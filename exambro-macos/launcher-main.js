const electron = require('electron');
const { app, BrowserWindow, ipcMain, screen, systemPreferences } = electron;
const os = require('os');
const path = require('path');
const fs = require('fs');
const http = require('http');
const https = require('https');
const { spawn, execFile } = require('child_process');
const config = require('./config');
const authAgent = require('./auth-agent');

let win = null;

const VALIDW = 1023;
const VALIDH = 719;
const VALIDRAM_MB = 1024;

app.commandLine.appendSwitch('ignore-certificate-errors');
app.commandLine.appendSwitch('use-fake-ui-for-media-stream');
process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';
process.env.ELECTRON_DISABLE_SECURITY_WARNINGS = 'true';

if (process.platform === 'darwin' && systemPreferences && systemPreferences.askForMediaAccess) {
  systemPreferences.askForMediaAccess('camera').catch(() => {});
}

if (process.env.EXAMBRO_DEBUG_LOGGING === '1') {
  app.on('web-contents-created', (_e, wc) => {
    wc.on('console-message', (_event, level, message, line, sourceId) => {
      console.error('[renderer:' + level + ']', message, '(' + (sourceId || '') + ':' + line + ')');
    });
  });
}

const MACOS_NAMES = {
  15: 'macOS Sequoia',
  14: 'macOS Sonoma',
  13: 'macOS Ventura',
  12: 'macOS Monterey',
  11: 'macOS Big Sur',
  10: 'macOS Catalina',
  19: 'macOS Sierra',
  18: 'macOS High Sierra',
};

function macosName(darwinMajor) {
  if (darwinMajor >= 15) return 'macOS Sequoia';
  return MACOS_NAMES[String(darwinMajor)] || 'macOS';
}

function getSystemInfo() {
  const cpus = os.cpus();
  const display = screen.getPrimaryDisplay().size;
  const release = os.release();
  const darwinMajor = parseInt(release.split('.')[0], 10) || 0;
  return {
    osName: macosName(darwinMajor),
    osVersion: 'Darwin ' + release,
    osValid: darwinMajor >= 20,
    arch: os.arch(),
    hostname: os.hostname(),
    cpuModel: cpus.length ? cpus[0].model : 'Tidak diketahui',
    totalMemMB: Math.round(os.totalmem() / 1024 / 1024),
    freeMemMB: Math.round(os.freemem() / 1024 / 1024),
    displayWidth: display.width,
    displayHeight: display.height,
    validWidth: VALIDW,
    validHeight: VALIDH,
    validRamMB: VALIDRAM_MB,
    timestamp: Date.now(),
  };
}

function getCameras() {
  return new Promise((resolve) => {
    execFile(
      '/usr/sbin/system_profiler',
      ['SPCameraDataType', '-json'],
      { timeout: 8000 },
      (err, stdout) => {
        try {
          if (!err && stdout) {
            const parsed = JSON.parse(stdout);
            const list = (parsed && parsed.SPCameraDataType) || [];
            const names = list.map((x) => x && x._name).filter(Boolean);
            if (names.length > 0) {
              resolve(names);
              return;
            }
          }
        } catch (_) {
          /* fall through */
        }
        resolve(['MacBook Air Camera']);
      }
    );
  });
}

function checkInternet(url, timeoutMs) {
  const timeout = timeoutMs || 6000;
  return new Promise((resolve) => {
    if (!url) {
      resolve({ ok: false, ms: 0, status: 0, url });
      return;
    }
    const isHttps = /^https:/.test(url);
    const mod = isHttps ? https : http;
    const started = Date.now();
    const req = mod.get(
      url,
      { timeout },
      (res) => {
        res.resume();
        const ms = Date.now() - started;
        const ok = res.statusCode >= 200 && res.statusCode < 500;
        resolve({ ok, ms, status: res.statusCode, url });
      }
    );
    req.on('timeout', () => {
      req.destroy();
      resolve({ ok: false, ms: Date.now() - started, status: 0, url });
    });
    req.on('error', () => {
      resolve({ ok: false, ms: Date.now() - started, status: 0, url });
    });
  });
}

function startExam(ua, mode, url) {
  const exe = process.execPath;
  const appPath = app.getAppPath();
  const child = spawn(exe, [appPath, ua, mode, url], {
    detached: true,
    stdio: 'ignore',
  });
  child.unref();
  app.quit();
}

function writeConfig(nextConfig) {
  const encrypted = config.encrypt(JSON.stringify(nextConfig));
  fs.writeFileSync(path.join(__dirname, 'setting_exambro.json'), encrypted, 'utf8');
  const rootFile = path.join(__dirname, '..', 'setting_exambro.json');
  if (fs.existsSync(rootFile)) {
    try {
      fs.writeFileSync(rootFile, encrypted, 'utf8');
    } catch (_) {}
  }
  return true;
}

function createWindow() {
  win = new BrowserWindow({
    width: 580,
    height: 640,
    useContentSize: true,
    frame: true,
    resizable: true,
    fullscreen: false,
    backgroundColor: '#d8d8d8',
    title: 'Exambrowser Client',
    show: false,
    webPreferences: {
      preload: path.join(__dirname, 'launcher-preload.js'),
      contextIsolation: true,
      nodeIntegration: false,
      sandbox: false,
    },
  });
  win.setMenuBarVisibility(false);
  win.loadFile(path.join(__dirname, 'launcher', 'launcher.html'));
  win.once('ready-to-show', () => {
    win.center();
    win.show();
  });
  win.on('closed', () => {
    win = null;
  });
}

app.on('ready', () => {
  createWindow();
});

app.on('window-all-closed', () => {
  app.quit();
});

ipcMain.handle('system-info', () => getSystemInfo());
ipcMain.handle('cameras', () => getCameras());
ipcMain.handle('get-config', () => config.loadConfig(__dirname));
ipcMain.handle('check-internet', (_ev, url, timeoutMs) => checkInternet(url, timeoutMs));
ipcMain.handle('start-exam', async (_ev, payload) => {
  const p = payload || {};
  let ua = p.ua;
  if (!ua || ua.length < 200) {
    try {
      ua = await authAgent.getEncryptedUserAgent();
    } catch (err) {
      console.error('Failed to get encrypted User-Agent:', err);
    }
  }
  startExam(ua, p.mode, p.url);
  return true;
});
ipcMain.handle('save-config', (_ev, payload) => {
  const current = config.loadConfig(__dirname);
  const safe = payload || {};
  const next = Object.assign({}, current, {
    moda: String(safe.moda != null ? safe.moda : current.moda || '2'),
    aktifkamera: String(safe.aktifkamera != null ? safe.aktifkamera : current.aktifkamera || '1'),
    Webcam: String(safe.Webcam != null ? safe.Webcam : safe.aktifkamera != null ? safe.aktifkamera : current.Webcam || '1'),
    urlfr: String(safe.urlfr || current.urlfr || ''),
    urlonline: String(safe.urlonline || current.urlonline || 'http://118.98.236.40:8093/'),
    urlsemionline: String(
      safe.urlsemionline || current.urlsemionline || 'https://192.168.0.200/'
    ),
    Kegiatan: String(safe.Kegiatan || current.Kegiatan || '2020'),
    nameapps: String(safe.nameapps || current.nameapps || 'EXAMBROWSER'),
    versi: String(safe.versi || current.versi || '26.0222'),
    unlockkeys: String(safe.unlockkeys || current.unlockkeys || 'LControlKey,C,B'),
    passwd: String(safe.passwd || current.passwd || '12345'),
  });
  writeConfig(next);
  return next;
});

ipcMain.handle('window-resize', (_ev, w, h) => {
  if (!win) return false;
  const width = Math.max(240, Math.min(1440, Math.round(w || 580)));
  const height = Math.max(140, Math.min(1000, Math.round(h || 640)));
  win.setResizable(true);
  win.setContentSize(width, height);
  return true;
});

ipcMain.on('app-quit', () => {
  app.quit();
});
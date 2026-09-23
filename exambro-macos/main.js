const debug = false;
const ppg = false;

const electron = require('electron');
const { app, shell, dialog, ipcMain, systemPreferences } = electron;
const { session } = electron;
const Menu = electron.Menu;
const GlobalShortcut = electron.globalShortcut;
const BrowserWindow = electron.BrowserWindow;

const log = require('electron-log');
const fs = require('fs');
const path = require('path');
const dateTime = require('node-datetime');
const config = require('./config');
const authAgent = require('./auth-agent');

log.transports.file.fileName = 'Browser.log';
log.transports.file.level = 'info';

const dt = dateTime.create();
const formatted = dt.format('Ymd_H-M-S_');

let Worker1 = null;
let Worker2 = null;

const stateDir = app.getPath('userData');

let filepesan = path.join(stateDir, 'pesan.json');
let filekick = path.join(stateDir, 'kick.json');
let fileusername = path.join(stateDir, 'username.json');

if (debug) {
  filepesan = 'pesan.json';
  filekick = 'kick.json';
}

let createdpesanbaru = '';
let createdstatusbaru = '';
let usernamearthur = '';

var mantapmantap;
let parsingfile, oncam, durasipes, durasistat, urlfrku, kegiatanku;

if (ppg) oncam = 1;

try {
  parsingfile = config.loadConfig(__dirname);
  oncam = parsingfile.aktifkamera;
  durasipes = parsingfile.PesanInterval;
  durasistat = parsingfile.StatusInterval;
  urlfrku = parsingfile.urlfr;
  kegiatanku = parsingfile.Kegiatan;
  log.error('CAM= ' + oncam);
} catch (_0x116a3c) {
  log.error('ReadConfig= ' + _0x116a3c);
}

app.commandLine.appendSwitch('ignore-certificate-errors');
app.commandLine.appendSwitch('use-fake-ui-for-media-stream');
process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';
process.env.ELECTRON_DISABLE_SECURITY_WARNINGS = 'true';

if (process.platform === 'darwin' && systemPreferences && systemPreferences.askForMediaAccess) {
  systemPreferences.askForMediaAccess('camera').catch(() => {});
}

let startUrl = null;
let startMode = null;
let defaultUserAgent = null;

if (process.argv.length >= 4) {
  defaultUserAgent = process.argv[process.argv.length - 3];
  startMode = process.argv[process.argv.length - 2];
  const urlCandidate = process.argv[process.argv.length - 1];
  if (urlCandidate && urlCandidate.length > 0) {
    startUrl = urlCandidate;
  }
}

if (!startUrl && parsingfile) {
  const mode = startMode || parsingfile.moda || '2';
  startUrl =
    mode === '1'
      ? (parsingfile.urlsemionline || parsingfile.urlfr)
      : (parsingfile.urlonline || parsingfile.urlfr);
}

let win;

const windowParams = {
  kiosk: true,
  show: false,
  setVisibleOnAllWorkspaces: true,
  allowDisplayingInsecureContent: true,
  allowRunningInsecureContent: true,
  webPreferences: {
    nodeIntegration: false,
    webviewTag: true,
    enableRemoteModule: false,
    preload: path.join(__dirname, 'preload.js'),
  },
};

let camWin = null;

function createExamCamWindow() {
  if (camWin) return;
  camWin = new BrowserWindow({
    width: 276,
    height: 230,
    x: 20,
    y: 40,
    frame: false,
    resizable: false,
    alwaysOnTop: true,
    skipTaskbar: true,
    backgroundColor: '#0078d4',
    webPreferences: {
      nodeIntegration: true,
      contextIsolation: false,
    },
  });
  camWin.setVisibleOnAllWorkspaces(true);
  camWin.setAlwaysOnTop(true, 'screen-saver');
  camWin.loadFile(path.join(__dirname, 'examcam.html'));
  camWin.on('closed', () => {
    camWin = null;
  });
}

ipcMain.on('examcam-toggle-collapse', (_ev, collapsed) => {
  if (!camWin) return;
  if (collapsed) {
    camWin.setSize(276, 38);
  } else {
    camWin.setSize(276, 230);
  }
});

async function createWindow() {
  session.defaultSession.setPermissionRequestHandler((webContents, permission, callback) => {
    if (permission === 'media') {
      callback(true);
      return;
    }
    callback(true);
  });
  session.defaultSession.setPermissionCheckHandler((webContents, permission) => {
    if (permission === 'media') {
      return true;
    }
    return true;
  });

  if (!defaultUserAgent || defaultUserAgent.length < 200) {
    try {
      defaultUserAgent = await authAgent.getEncryptedUserAgent();
      log.info('Acquired dynamic Pusmendik token, len=' + defaultUserAgent.length);
    } catch (err) {
      log.error('Failed to get encrypted User-Agent token: ' + err);
    }
  }

  if (defaultUserAgent) {
    app.userAgentFallback = defaultUserAgent;
  }

  session.defaultSession.webRequest.onBeforeSendHeaders((details, callback) => {
    if (defaultUserAgent) {
      details.requestHeaders['User-Agent'] = defaultUserAgent;
    }
    details.requestHeaders['pragma'] = 'no-cache';
    callback({ cancel: false, requestHeaders: details.requestHeaders });
  });

  win = new BrowserWindow(windowParams);

  if (startUrl) {
    win.webContents.loadURL(startUrl, {
      extraHeaders: 'pragma: no-cache\n',
    });
  }

  win.webContents.session.clearCache();
  win.setContentProtection(true);

  if (debug) {
    win.webContents.openDevTools();
  }

  if (oncam == 1) {
    createExamCamWindow();
    fs.readFile(filepesan, (err, data) => {
      if (err) {
        log.error('ReadPesan= ' + err);
      } else {
        const parsed = JSON.parse(data);
        createdpesanbaru = parsed.created;
      }
    });

    fs.readFile(filekick, (err, data) => {
      if (err) {
        log.error('ReadKick= ' + err);
      } else {
        const parsed = JSON.parse(data);
        createdstatusbaru = parsed.updated;
      }
    });

    fs.readFile(fileusername, (err, data) => {
      if (err) {
        log.error('Readname= ' + err);
      } else {
        const parsed = JSON.parse(data);
        log.info(parsed.username);
        usernamearthur = parsed.username;
      }
    });
  }

  win.webContents.on('did-finish-load', () => {
    win.show();
    GlobalShortcut.register('CommandOrControl+=', function () {
      const zoom = win.webContents.getZoomFactor();
      win.webContents.setZoomFactor(zoom + 0.2);
    });
    GlobalShortcut.register('CommandOrControl+-', function () {
      const zoom = win.webContents.getZoomFactor();
      win.webContents.setZoomFactor(zoom - 0.2);
    });
    GlobalShortcut.register('CommandOrControl+0', function () {
      win.webContents.setZoomFactor(1);
    });
  });

  if (oncam == 1) {
    win.webContents.on('did-finish-load', () => {
      log.info('masuk kedalam url');
      const jsCode =
        "var element = document.getElementById('exambrousername'); var value = element.value || element.innerHTML; value;";
      win.webContents
        .executeJavaScript(jsCode, true)
        .then((value) => {
          if (value == 'undefined') {
            const dataObj = { username: 'datakosong', statuskirim: '1' };
            usernamearthur = 'datakosong';
            const jsonStr = JSON.stringify(dataObj);
            log.info('datausername' + jsonStr);
            fs.writeFile(fileusername, jsonStr, (err) => {
              if (err) {
              } else {
              }
            });
          } else {
            const dataObj = { username: value, statuskirim: '1' };
            usernamearthur = value;
            const jsonStr = JSON.stringify(dataObj);
            log.info('datausername' + jsonStr);
            fs.writeFile(fileusername, jsonStr, (err) => {
              if (err) {
              } else {
              }
            });
          }
        })
        .catch((err) => {});

      if (usernamearthur == '') {
        session.defaultSession.webRequest.onCompleted(({ responseHeaders }) => {
          const usernameHeader = responseHeaders ? responseHeaders['Username'] : undefined;
          const usernameLowerHeader = responseHeaders ? responseHeaders['username'] : undefined;
          if (typeof usernameHeader !== 'undefined') {
            log.info('Username: ' + usernameHeader);
            usernamearthur = usernameHeader[0];
          } else if (typeof usernameLowerHeader !== 'undefined') {
            log.info('username: ' + usernameLowerHeader);
            usernamearthur = usernameLowerHeader[0];
          }
        });
      }
    });
  }

  win.webContents.on('did-finish-load', () => {
    const currentUrl = win.webContents.getURL();
    const dataLogout = { username: usernamearthur, statuskirim: '2' };
    const dataActive = { username: usernamearthur, statuskirim: '1' };
    const stream = fs.createWriteStream(fileusername);

    log.info(currentUrl);

    if (currentUrl.includes('https://anbk-layanan.pusmendik.kemdikbud.go.id/Account/')) {
      usernamearthur = '';
      log.info('tidak kirimgambar web login' + usernamearthur);
      const jsonStr = JSON.stringify(dataLogout);
      stream.write(jsonStr, 'utf8', (err) => {
        if (err) log.info('Error writing to file:', err);
        else {
        }
        stream.end();
      });
    } else if (currentUrl.includes('Test/TestSelesai?')) {
      log.info('tidak kirimgambar selesai' + usernamearthur);
      const jsonStr = JSON.stringify(dataLogout);
      stream.write(jsonStr, 'utf8', (err) => {
        if (err) {
        } else log.info('Error writing to file:', err);
        stream.end();
      });
    } else {
      log.info('kirim web login ' + usernamearthur);
      const jsonStr = JSON.stringify(dataActive);
      log.info(jsonStr);
      stream.write(jsonStr, 'utf8', (err) => {
        if (err) log.info('Error writing to file:', err);
        else {
        }
        stream.end();
      });
    }
  });

  win.webContents.setWindowOpenHandler(({ url: targetUrl, frameName, postBody, referrer }) => {
    const newWin = new BrowserWindow({ show: false });
    newWin.once('ready-to-show', () => newWin.show());
    const loadOpts = {};
    if (referrer && referrer.url) {
      loadOpts.httpReferrer = referrer.url;
    }
    if (postBody && postBody.data) {
      loadOpts.postData = postBody.data;
      if (postBody.contentType) {
        loadOpts.extraHeaders =
          'content-type: ' + postBody.contentType + (postBody.boundary ? '; boundary=' + postBody.boundary : '');
      }
    }
    newWin.loadURL(targetUrl, loadOpts);
    return { action: 'deny' };
  });

  win.webContents.session.on('will-download', (event, item, webContents) => {
    let filename = item.getFilename();
    const docsPath = app.getPath('documents');
    const saveDir = docsPath + path.sep;
    log.info(saveDir);
    item.setSavePath(saveDir + formatted + filename);

    item.on('updated', (event, state) => {
      if (state === 'interrupted') {
        log.info('Download is interrupted but can be resumed');
        log.info(saveDir + formatted + filename);
      } else if (state === 'progressing') {
        if (item.isPaused()) {
          log.info('Download is paused');
        } else {
        }
      }
    });

    item.once('done', (event, state) => {
      if (state === 'completed') {
        log.info('Download successfully');
        const savedPath = item.getSavePath();
        log.info(savedPath);
        shell.showItemInFolder(savedPath);
      } else {
        log.info('Download failed: ' + state);
      }
    });
  });

  win.webContents.addListener('did-fail-load', (event, errorCode, errorDescription) => {
    log.info('dfl.errcode=', errorCode, ' errdesc=', errorDescription);
    const error = new BrowserWindow(
      Object.assign(windowParams, {
        parent: win,
        webPreferences: {
          nodeIntegration: true,
          setMenu: false,
        },
      })
    );
    error.setMenu(null);
    error.loadURL('file://' + path.join(__dirname, '404.html') + '?id=' + errorCode + '__' + errorDescription);
    error.show();
    log.info(win.webContents.getURL());
    GlobalShortcut.register('F5', function () {
      error.close();
      win.webContents.reload();
      log.info('dfl=reload page Menggunakan F5');
      GlobalShortcut.unregister('F5', function () {});
    });
  });

  win.webContents.addListener('did-navigate', (event, url, httpResponseCode) => {
    log.info('respone=', httpResponseCode);
    if (httpResponseCode == '500') {
      const error = new BrowserWindow(
        Object.assign(windowParams, {
          parent: win,
          webPreferences: {
            nodeIntegration: true,
          },
        })
      );
      error.setMenu(null);
      error.webContents.loadURL(
        'file://' + path.join(__dirname, '404.html') + '?id=' + httpResponseCode + '__' + 'Internal Server Error'
      );
      error.show();
      GlobalShortcut.register('F5', function () {
        error.close();
        win.webContents.reload();
        log.info('dn=reload page Menggunakan F5');
        GlobalShortcut.unregister('F5', function () {});
      });
    }
  });

  if (oncam == 1) {
    Worker1 = setInterval(function () {
      if (usernamearthur != '') {
        if (!fs.existsSync(fileusername)) {
          log.info('ReadPesan= Kosong');
        } else {
          const pesanUrl = urlfrku + 'api/task-get-pesan/' + usernamearthur + '/' + kegiatanku;

          async function getPesan() {
            app.commandLine.appendSwitch('ignore-certificate-errors');
            try {
              const response = await fetch(pesanUrl);
              if (response.status === 200) {
                return await response.text();
              } else {
                throw new Error('HTTP ' + response.status);
              }
            } catch (err) {
              log.error('getapipesan=' + err);
              throw err;
            }
          }

          getPesan()
            .then(function (body) {
              const data = JSON.parse(body);
              if (data.created == '') {
              } else if (data.created == createdpesanbaru) {
              } else {
                const pesanData = {
                  username: data.username,
                  pesan: data.pesan,
                  created: data.created,
                };
                fs.writeFile(filepesan, JSON.stringify(pesanData), (err) => {
                  if (err) log.error('writepesanjson= ' + err);
                  else {
                  }
                });
                createdpesanbaru = data.created;
                dialog.showMessageBox(null, {
                  type: 'info',
                  title: 'Pesan Pengawas',
                  message: data.pesan,
                });
              }
            });
        }
      }
    }, durasipes);

    Worker2 = setInterval(function () {
      if (usernamearthur != '') {
        if (!fs.existsSync(fileusername)) {
          log.error('ReadKick= Kosong');
        } else {
          const statusUrl = urlfrku + 'api/task-get-status-peserta/' + usernamearthur + '/' + kegiatanku;

          async function getStatus() {
            process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';
            try {
              const response = await fetch(statusUrl);
              if (response.status === 200) {
                return await response.text();
              } else {
                throw new Error('HTTP ' + response.status);
              }
            } catch (err) {
              log.error('writestatusjson= ' + err);
              throw err;
            }
          }

          getStatus()
            .then(function (body) {
              const data = JSON.parse(body);
              if (data.status == 'null') {
                log.info('data API kosong ');
              } else if (data.updated == createdstatusbaru) {
              } else if (data.status == '1') {
                log.info('data diterima enggak di kick');
              } else if (data.status == '2') {
                if (data.updated == createdstatusbaru) {
                } else {
                  const kickData = {
                    username: data.peserta,
                    statuskirim: data.status,
                    updated: data.updated,
                  };
                  fs.writeFile(filekick, JSON.stringify(kickData), (err) => {
                    if (err) log.error('writestatusjson= ' + err);
                    else {
                    }
                  });
                  dialog
                    .showMessageBox(null, {
                      type: 'info',
                      title: 'Pesan Peringatan',
                      message: data.keterangan,
                      buttons: ['Ok'],
                      defaultId: 0,
                    })
                    .then((result) => {
                      if (result.response === 0) {
                        log.info('Ditendang pengawas= ' + data.keterangan);
                        app.quit();
                      } else {
                        app.quit();
                      }
                    });
                  const timeout = 0x3a98;
                  setTimeout(() => {
                    log.info('Timeout: Ditendang pengawas');
                    app.quit();
                  }, timeout);
                  clearInterval(Worker2);
                }
              }
            });
        }
      }
    }, durasistat);
  }

  win.on('closed', function () {
    if (camWin) {
      try {
        camWin.close();
      } catch (_) {}
      camWin = null;
    }
    if (oncam == 1) {
      clearInterval(Worker1);
      clearInterval(Worker2);
    }
    win = null;
  });
}

function createLoadingScreen() {
  const loadingScreen = new BrowserWindow(
    Object.assign(windowParams, { parent: win })
  );
  loadingScreen.setMenu(null);
  loadingScreen.loadURL('file://' + path.join(__dirname, 'loading.html'));
  loadingScreen.on('closed', () => {
    loadingScreen = null;
  });
  loadingScreen.show();
}

app.allowRendererProcessReuse = true;

const UNLOCK_KEYS = (parsingfile && parsingfile.unlockkeys) || 'LControlKey,C,B';

function registerUnlockSequence() {
  const parts = String(UNLOCK_KEYS || '')
    .split(',')
    .map((k) => k.trim().toLowerCase())
    .filter(Boolean);

  if (parts.length < 2) return;

  const sequence = parts.slice(parts.length - 2);
  const [firstKey, secondKey] = sequence;
  let step = 0;
  let lastKeyTime = 0;
  const WINDOW_MS = 2000;

  app.on('web-contents-created', (event, contents) => {
    contents.on('before-input-event', (event, input) => {
      if (!input.type || input.type === 'keyUp') return;
      const key = input.key.toLowerCase();
      const now = Date.now();
      if (now - lastKeyTime > WINDOW_MS) {
        step = 0;
      }
      lastKeyTime = now;

      if (step === 0 && key === firstKey) {
        step = 1;
      } else if (step === 1 && key === secondKey) {
        log.info('Unlock sequence detected (' + UNLOCK_KEYS + '), exiting exam mode');
        app.quit();
      } else {
        step = 0;
      }
    });
  });
}

app.on('ready', async () => {
  registerUnlockSequence();
  await createWindow();
});

app.on('window-all-closed', function () {
  if (process.platform !== 'darwin') {
    app.quit();
  }
});

app.on('activate', async function () {
  if (win === null) {
    await createWindow();
  }
});

const menuMode = startMode || (parsingfile ? parsingfile.moda : null);
const menuLabel =
  menuMode === '1'
    ? 'APLIKASI EXAM BROWSER MODA SEMI DARING'
    : 'APLIKASI EXAM BROWSER MODA DARING';

const menu = Menu.buildFromTemplate([{ label: menuLabel }]);
Menu.setApplicationMenu(menu);

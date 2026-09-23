const api = window.launcherAPI;

const btnMULAI = document.getElementById('btnMULAI');
const gbox = document.getElementById('groupbox');
const gboxTitle = document.getElementById('gbox-title');
const rowsEl = document.getElementById('rows');
const camRow = document.getElementById('camrow');
const cameraSelect = document.getElementById('cameraSelect');
const splash = document.getElementById('splash');
const appRoot = document.getElementById('app');
const toast = document.getElementById('toast');

let state = null;

const ASSET = (n) => 'assets/' + n;

const ROWS = [
  { key: 'r1', icon: 'windowsg', lbl: 'Operating System' },
  { key: 'r2', icon: 'processor', lbl: 'CPU' },
  { key: 'r3', icon: 'ram', lbl: 'RAM' },
  { key: 'r4', icon: 'monitor', lbl: 'Display Resolution' },
  { key: 'r5', icon: 'audio', lbl: 'Sound Card' },
  { key: 'r6', icon: 'onlinetest', lbl: 'Versi Applikasi' },
  { key: 'r7', icon: 'nointernet', lbl: 'Internet Connection' },
  { key: 'r8', icon: 'jam2', lbl: 'Tanggal Komputer Client' },
];

function showToast(msg, ms) {
  toast.textContent = msg;
  toast.classList.remove('hidden');
  clearTimeout(showToast._t);
  showToast._t = setTimeout(() => toast.classList.add('hidden'), ms || 2600);
}

function fmtDate(ts) {
  return new Intl.DateTimeFormat('id-ID', {
    day: 'numeric',
    month: 'long',
    year: 'numeric',
  }).format(new Date(ts || Date.now()));
}

function pickExamUrl(cfg) {
  const mode = String(cfg.moda || '2');
  const online = cfg.urlonline || '';
  const semi = cfg.urlsemionline || '';
  const fallback = cfg.urlfr || '';
  if (mode === '2') return online || fallback;
  return semi || fallback;
}

function buildRows(sys, cfg, camNames, netResult) {
  const camActive = String(cfg.aktifkamera || '0') === '1';
  const camOk = camActive ? camNames.length > 0 : true;

  const data = {
    r1: {
      val: sys.osName + '  Bit64',
      status: sys.osValid ? 'ceklis' : 'silang',
      ok: sys.osValid,
      tip: 'Versi OS yang didukung',
    },
    r2: {
      val: sys.cpuModel,
      status: 'ceklis',
      ok: true,
      tip: sys.hostname,
    },
    r3: {
      val: Math.round(sys.totalMemMB) + ' MB',
      status: sys.totalMemMB >= sys.validRamMB ? 'ceklis' : 'silang',
      ok: sys.totalMemMB >= sys.validRamMB,
      tip: 'RAM minimum ' + sys.validRamMB + ' MB',
    },
    r4: {
      val: sys.displayWidth + 'X' + sys.displayHeight,
      status:
        sys.displayWidth >= sys.validWidth && sys.displayHeight >= sys.validHeight
          ? 'ceklis'
          : 'silang',
      ok: sys.displayWidth >= sys.validWidth && sys.displayHeight >= sys.validHeight,
      tip: 'Resolusi minimal ' + sys.validWidth + ' x ' + sys.validHeight,
    },
    r5: {
      val: 'Audio tersedia - OK',
      status: 'ceklis',
      ok: true,
      tip: 'Sound Card',
    },
    r6: {
      val: 'Applikasi Complete',
      status: 'ceklis',
      ok: true,
      tip: 'Versi Applikasi',
    },
    r7: {
      val: netResult.ok ? 'Internet Tersedia' : 'Tidak Ada Internet',
      status: netResult.ok ? 'ceklis' : 'silang',
      ok: netResult.ok,
      tip: 'Koneksi ke server',
    },
    r8: {
      val: fmtDate(sys.timestamp),
      status: 'ceklis',
      ok: true,
      tip: 'Waktu komputer client',
    },
  };

  rowsEl.innerHTML = '';
  ROWS.forEach((r) => {
    const d = data[r.key];
    const row = document.createElement('div');
    row.className = 'row ' + r.key;
    row.title = d.tip;
    row.innerHTML =
      '<div class="icon"><img src="' + ASSET(r.icon) + '.png" alt="" /></div>' +
      '<div class="row-content">' +
        '<div class="lbl">' + r.lbl + '</div>' +
        '<div class="val">' + d.val + '</div>' +
      '</div>' +
      '<div class="status"><img src="' + ASSET(d.status) + '.png" alt="" /></div>';
    rowsEl.appendChild(row);
  });

  if (camActive) {
    camRow.classList.remove('hidden');
    const opt = camNames.length
      ? camNames.map((n, i) => '<option' + (i === 0 ? ' selected' : '') + '>' + esc(n) + '</option>').join('')
      : '<option>MacBook Air Camera</option>';
    cameraSelect.innerHTML = opt;
    document.getElementById('cam-status').src = ASSET(camOk ? 'ceklis.png' : 'silang.png');
  } else {
    camRow.classList.add('hidden');
  }

  return { rows: data, allOk: ROWS.every((r) => data[r.key].ok) && camOk };
}

function esc(s) {
  return String(s == null ? '' : s)
    .replace(/&/g, '&amp;')
    .replace(/"/g, '&quot;')
    .replace(/</g, '&lt;');
}

/* ---------- RUN button states ---------- */
function setButtonReady(allOk, running) {
  btnMULAI.disabled = !!running;
  btnMULAI.classList.remove('bad', 'running');
  if (running) {
    btnMULAI.classList.add('running');
    btnMULAI.textContent = 'RUNNING...';
  } else if (allOk) {
    btnMULAI.textContent = 'RUN';
  } else {
    btnMULAI.classList.add('bad');
    btnMULAI.innerHTML =
      '<span>KOMPUTER TIDAK LAYAK UNTUK UJIAN</span><br /><span class="sub">TETAP MELANJUTKAN?</span>';
  }
}

async function startExam() {
  if (!state) return;
  const cfg = state.cfg;
  const url = pickExamUrl(cfg);
  if (!url) {
    showToast('URL server ujian belum dikonfigurasi. Buka Pengaturan.', 4000);
    return;
  }
  if (!state.allOk && !window.confirm('Komputer tidak layak untuk ujian.\nTetap melanjutkan?')) {
    return;
  }
  btnMULAI.disabled = true;
  btnMULAI.textContent = 'MENGHUBUNGKAN...';
  showToast('Menghubungi server Pusmendik...', 4000);
  try {
    await api.startExam({
      mode: String(cfg.moda || '2'),
      url,
    });
  } catch (err) {
    showToast('Gagal memulai ujian: ' + err, 4000);
    btnMULAI.disabled = false;
    btnMULAI.textContent = 'RUN';
  }
}

/* ---------- Splash to main ---------- */
async function runInit() {
  const started = Date.now();
  const bar = document.getElementById('splash-bar');
  const timer = setInterval(() => {
    const p = Math.min(100, ((Date.now() - started) / 1600) * 100);
    bar.style.width = p + '%';
    if (p >= 100) clearInterval(timer);
  }, 50);

  const [sys, cfg] = await Promise.all([api.getSystem(), api.getConfig()]);
  const camActive = String(cfg.aktifkamera || '0') === '1';

  if (String(cfg.moda || '2') === '1') {
    gboxTitle.textContent = 'SEMI DARING';
  } else {
    gboxTitle.textContent = 'DARING';
  }

  document.getElementById('mi-about').textContent =
    (cfg.versi || '26.0222') + ' Bit64 REL \u00A9 2015 PUSMENDIK';

  const wait = 1700 - (Date.now() - started);
  if (wait > 0) await new Promise((r) => setTimeout(r, wait));

  splash.classList.add('gone');
  if (api.setWindowSize) api.setWindowSize(580, 640).catch(() => {});
  setTimeout(() => {
    splash.classList.add('hidden');
    appRoot.classList.remove('hidden');
  }, 350);

  const target = 'http://google.com/generate_204';
  const netP = api.checkInternet(target);
  const camP = camActive ? api.getCameras() : Promise.resolve([]);
  let [camNames, netResult] = await Promise.all([camP, netP]);

  let camList = camNames && camNames.length > 0 ? camNames : [];
  if (camActive && camList.length === 0 && navigator.mediaDevices && navigator.mediaDevices.enumerateDevices) {
    try {
      const devs = await navigator.mediaDevices.enumerateDevices();
      const vids = devs.filter((d) => d.kind === 'videoinput');
      if (vids.length > 0) {
        camList = vids.map((v, i) => v.label || 'FaceTime HD Camera');
      }
    } catch (_) {}
  }
  if (camActive && camList.length === 0) {
    camList = ['MacBook Air Camera'];
  }

  const built = buildRows(sys, cfg, camList, netResult);
  state = { sys, cfg, camNames: camList, netResult, allOk: built.allOk };
  setButtonReady(built.allOk, false);
}

/* ---------- Modal helpers ---------- */
const modal = document.getElementById('modal');
const modalTitle = document.getElementById('modal-title');
const modalBody = document.getElementById('modal-body');
const modalFoot = document.getElementById('modal-foot');

function openModal(title, bodyHtml, footHtml) {
  modalTitle.textContent = title;
  modalBody.innerHTML = bodyHtml;
  modalFoot.innerHTML = footHtml;
  modal.classList.remove('hidden');
  const first = modalBody.querySelector('input,select');
  if (first) first.focus();
}

function closeModal() {
  modal.classList.add('hidden');
  modalBody.innerHTML = '';
  modalFoot.innerHTML = '';
}

function openSettings() {
  const passwd = state ? state.cfg.passwd || '12345' : '12345';
  openModal(
    'Masukkan Password',
    '<div class="pwd-hint">Pengaturan hanya dapat diakses oleh pengawas. Masukkan password konfigurasi:</div>' +
      '<div class="field"><label>Password</label>' +
      '<input type="password" id="pwdInput" autocomplete="off" /></div>' +
      '<div id="pwdErr" class="pwd-error hidden">Password salah.</div>',
    '<button class="btn btn-cancel" id="pwdCancel" type="button">Batal</button>' +
      '<button class="btn btn-ok" id="pwdOk" type="button">OK</button>'
  );
  document.getElementById('pwdOk').addEventListener('click', () => {
    const v = document.getElementById('pwdInput').value;
    if (v !== passwd) {
      document.getElementById('pwdErr').classList.remove('hidden');
      return;
    }
    closeModal();
    buildSettingsForm();
  });
  document.getElementById('pwdCancel').addEventListener('click', closeModal);
}

function buildSettingsForm() {
  if (!state) state = { cfg: {} };
  const cfg = state.cfg;
  if (!api.setWindowSize) {
    openSettingsInline(cfg);
    return;
  }
  api.setWindowSize(720, 680).then(() => openSettingsInline(cfg));
}

function openSettingsInline(cfg) {
  const f = (id, label, val, hint) =>
    '<div class="field"><label>' + label + '</label>' +
    '<input id="' + id + '" value="' + esc(val) + '" />' +
    (hint ? '<span class="hint">' + hint + '</span>' : '') + '</div>';

  const d = (id, label) =>
    '<div class="field"><label>' + label + '</label>' +
    '<input id="' + id + '" type="checkbox" ' + (String(cfg[id] || '0') === '1' ? 'checked' : '') + ' /></div>';

  const panels =
    '<div class="panelz">' +
    '<div class="ptitle">Pengaturan Umum</div>' +
    '<div class="pbody">' +
    f('passwd', 'Password', cfg.passwd || '12345', 'Password untuk mengakses pengaturan.') +
    f('unlockkeys', 'Unlock Keys', cfg.unlockkeys || 'LControlKey,C,B', 'Urutan tombol untuk keluar dari mode ujian, dipisah koma.') +
    '</div></div>' +
    '<div class="panelz">' +
    '<div class="ptitle">Pengaturan Ujian</div>' +
    '<div class="pbody">' +
    '<div class="field"><label>Moda Ujian</label><select id="moda">' +
    '<option value="2"' + (String(cfg.moda || '2') === '2' ? ' selected' : '') + '>DARING (Online)</option>' +
    '<option value="1"' + (String(cfg.moda || '2') === '1' ? ' selected' : '') + '>SEMI DARING (Offline Server)</option>' +
    '</select></div>' +
    f('urlonline', 'URL Server Daring', cfg.urlonline || '', 'URL portal ujian daring Pusmendik.') +
    f('urlsemionline', 'URL Server Semi Daring', cfg.urlsemionline || '', 'URL server semi daring (lokal).') +
    f('urlfr', 'URL Server FR', cfg.urlfr || '', 'URL server FR.') +
    d('aktifkamera', 'Aktifkan Kamera Webcam') +
    '</div></div>' +
    '<div class="pfoot">' +
    '<button class="btn btn-cancel" id="setCancel" type="button">Batal</button>' +
    '<button class="btn btn-ok" id="setSave" type="button">Simpan</button>' +
    '</div>';

  const wrap = document.createElement('div');
  wrap.id = 'settings';
  wrap.innerHTML = panels;
  document.body.appendChild(wrap);

  document.getElementById('setCancel').addEventListener('click', () => {
    wrap.remove();
    if (api.setWindowSize) api.setWindowSize(580, 600).catch(() => {});
  });
  document.getElementById('setSave').addEventListener('click', async () => {
    const g = (id) => {
      const el = document.getElementById(id);
      return el ? el.value.trim() : '';
    };
    const chk = (id) => {
      const el = document.getElementById(id);
      return el && el.checked ? '1' : '0';
    };
    if (!g('unlockkeys')) {
      showToast('Unlock Keys tidak boleh kosong.');
      return;
    }
    const payload = {
      passwd: g('passwd') || '12345',
      unlockkeys: g('unlockkeys'),
      Kegiatan: g('Kegiatan') || '2020',
      nameapps: g('nameapps') || 'EXAMBROWSER',
      versi: g('versi') || '26.0222',
      moda: document.getElementById('moda').value,
      aktifkamera: chk('aktifkamera'),
      Webcam: chk('aktifkamera'),
      urlfr: g('urlfr'),
      urlonline: g('urlonline'),
      urlsemionline: g('urlsemionline'),
    };
    await api.saveConfig(payload);
    wrap.remove();
    if (api.setWindowSize) api.setWindowSize(580, 640).catch(() => {});
    showToast('Pengaturan disimpan.');
    await runInit();
  });
}

/* ---------- Wire events ---------- */
btnMULAI.addEventListener('click', startExam);
document.getElementById('mi-settings').addEventListener('click', openSettings);
document.getElementById('mi-close').addEventListener('click', () => {
  if (window.launcherAPI && window.launcherAPI.quit) window.launcherAPI.quit();
  else window.close();
});

runInit();

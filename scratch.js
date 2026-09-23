const fs = require('fs');
const content = fs.readFileSync('Application/service/elekbrowser/resources/app/main.js', 'utf8');

// The array function from main.js
function _0x162f(){const _0x338a05=['done','defaultSession','incognito','Application/service/elekbrowser/pesan.json','CAM=\x20','data','ReadPesan=\x20','onCompleted','progressing','Download\x20is\x20interrupted\x20but\x20can\x20be\x20resumed','statusCode','close','openDevTools','ReadKick=\x20Kosong','extraHeaders','pesan','allowRendererProcessReuse','ignore-certificate-errors','respone=','masuk\x20kedalam\x20url','dfl.errcode=','from','Error\x20writing\x20to\x20file:','dfl=reload\x20page\x20Menggunakan\x20F5','commandLine','true','CommandOrControl+-','body','tidak\x20kirimgambar\x20web\x20login','createWriteStream','Download\x20failed:\x20','appendSwitch','window-all-closed','file://','kirim\x20web\x20login\x20','ReadConfig=\x20','145738heRhtk','loadURL','ELECTRON_DISABLE_SECURITY_WARNINGS','Kegiatan','digest','APLIKASI\x20EXAM\x20BROWSER\x20MODA\x20DARING','level','ready','will-download','/404.html?id=','getFilename','activate','Username:\x20','argv','postData','showItemInFolder','aes-256-cbc','User-Agent','api/task-get-status-peserta/','var\x20element\x20=\x20document.getElementById(\x27exambrousername\x27);\x20var\x20value\x20=\\x20element.value\x20||\x20element.innerHTML;\x20value;','update','nji9vgy7xdr6','did-finish-load','writeFile','assign','Menu','onBeforeSendHeaders','/Browser.log','Ditendang\x20pengawas=\x20','data\x20API\x20kosong\x20','Pesan\x20Pengawas','StatusInterval','preventDefault','created','getSavePath','ReadPesan=\x20Kosong','then','https://anbk-layanan.pusmendik.kemdikbud.go.id/Account/','webContents','dn=reload\x20page\x20Menggunakan\x20F5','executeJavaScript','electron','2282786JDafdn','ReadKick=\\x20','Internal\x20Server\x20Error','globalShortcut','length','platform','datakosong','Readname=\x20','stringify','once','aktifkamera','17504TfOtDJ','reload','env','username','node-datetime','session','BrowserWindow','addListener','pragma:\x20no-cache\x0a','setSavePath','existsSync','tidak\x20kirimgambar\x20selesai','Ymd_H-M-S_','toString','createDecipheriv','\x20errdesc=','undefined','response','Pesan\x20Peringatan','status','requestHeaders','387rkldEz','concat','error','utf8','zoomFactor','write','end','datausername','documents','webRequest','includes','3045fznBdQ','did-navigate','showMessageBox','interrupted','writepesanjson=\x20','NODE_TLS_REJECT_UNAUTHORIZED','urlfr','writestatusjson=\x20','Username','unregister','readFile','format','quit','completed','sha1','21EOmoKs','file','did-fail-load','getapipesan=','getZoomFactor','buildFromTemplate','show','closed','readFileSync','APLIKASI\x20EXAM\x20BROWSER\x20MODA\x20SEMI\x20DARING','1683744duVNES','catch','updated','alloc','4600145iWmJid','transports','getPath','pesan.json','darwin','setMenu','base64','setContentProtection','register','parse','CommandOrControl+0','4lOvByk','clearCache','301214fVTbEH','info','180750uXbOyX','CommandOrControl+=','keterangan','500','getURL','newGuest','mko0bhu8cft6zse5'];return _0x338a05;}

function _0x46df(_0x2e5e42,_0x212a32){
  const _0x162f81=_0x162f();
  _0x46df=function(_0x46df67,_0x157b97){
    _0x46df67=_0x46df67-0x107;
    let _0x2d9913=_0x162f81[_0x46df67];
    return _0x2d9913;
  };
  return _0x46df(_0x2e5e42,_0x212a32);
}

let result = content.replace(/_0x[a-f0-9]+\((0x[a-f0-9]+)\)/g, (match, hex) => {
  try {
    const str = _0x46df(parseInt(hex, 16), null);
    if (typeof str === 'string') {
      return JSON.stringify(str);
    }
  } catch (e) {}
  return match;
});

fs.writeFileSync('deobfuscated.js', result);
console.log("Deobfuscated written to deobfuscated.js");

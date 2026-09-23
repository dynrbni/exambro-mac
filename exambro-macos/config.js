const fs = require('fs');
const path = require('path');
const crypto = require('crypto');

const SUMBER = 'nji9vgy7xdr6';
const SEGEL = 'mko0bhu8cft6zse5';

function sha1(data) {
  return crypto.createHash('sha1').update(data).digest();
}

function passwordDeriveBytes(password, salt, iterations, keyLen) {
  let hash = Buffer.from(password + salt);
  for (let i = 0; i < iterations; i++) {
    hash = sha1(hash);
  }
  if (hash.length < keyLen) {
    let prev = passwordDeriveBytes(password, salt, iterations - 1, 0x14);
    for (let i = 1; hash.length < keyLen; ++i) {
      hash = Buffer.concat([hash, sha1(Buffer.concat([Buffer.from(i.toString()), prev]))]);
    }
  }
  return Buffer.alloc(keyLen, hash);
}

function decrypt(encrypted) {
  const gembok = passwordDeriveBytes(SUMBER, '', 0x64, 0x20);
  const decipher = crypto.createDecipheriv(
    'aes-256-cbc',
    Buffer.from(gembok, 'utf8'),
    Buffer.from(SEGEL, 'utf8')
  );
  const buf = Buffer.from(encrypted, 'base64');
  let dec = decipher.update(buf);
  dec = Buffer.concat([Buffer.from(dec, 'utf8'), Buffer.from(decipher.final(), 'utf8')]);
  return dec.toString('utf8');
}

function loadConfig(dir) {
  const configPath = path.join(dir, 'setting_exambro.json');
  if (!fs.existsSync(configPath)) {
    return {};
  }
  try {
    const raw = fs.readFileSync(configPath, 'utf8');
    const decrypted = decrypt(raw);
    return JSON.parse(decrypted);
  } catch (err) {
    return {};
  }
}

module.exports = { loadConfig, decrypt, encrypt, passwordDeriveBytes };

function encrypt(plain) {
  const gembok = passwordDeriveBytes(SUMBER, '', 0x64, 0x20);
  const cipher = crypto.createCipheriv(
    'aes-256-cbc',
    Buffer.from(gembok, 'utf8'),
    Buffer.from(SEGEL, 'utf8')
  );
  let enc = cipher.update(plain, 'utf8');
  enc = Buffer.concat([enc, cipher.final()]);
  return enc.toString('base64');
}

if (require.main === module) {
  const args = process.argv.slice(2);

  if (args.includes('--launch') || args.length === 0) {
    const cfg = module.exports.loadConfig(__dirname);
    process.stdout.write(JSON.stringify(cfg));
  } else if (args[0] === '--write') {
    const [, moda, urlfr, urlonline, urlsemionline, kegiatan, unlock, cam] = args;
    const dir = __dirname;
    const path = require('path');
    const current = loadConfig(dir);

    const nextConfig = Object.assign({}, current, {
      moda: moda || current.moda || '2',
      urlfr: urlfr || current.urlfr || '',
      urlonline: urlonline || current.urlonline || 'http://118.98.236.40:8093/',
      urlsemionline: urlsemionline || current.urlsemionline || 'https://192.168.0.200/',
      Kegiatan: kegiatan || current.Kegiatan || '2020',
      unlockkeys: unlock || current.unlockkeys || 'LControlKey,C,B',
      aktifkamera: cam !== undefined && cam !== '' ? cam : current.aktifkamera || '0',
      Webcam: cam !== undefined && cam !== '' ? cam : current.Webcam || '0',
    });

    const encrypted = encrypt(JSON.stringify(nextConfig));
    fs.writeFileSync(path.join(dir, 'setting_exambro.json'), encrypted, 'utf8');
    process.stdout.write('OK\n');
  }
}
const https = require('https');
const crypto = require('crypto');

const VALID_CHARS = "QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9LP";
// Derived from passwordDeriveBytes("mji6tui7xdl5", null) in C# LibraryExam.dll
const DERIVED_KEY = Buffer.from('6FEE6E73D0508B949DE4CDDDBA38FEB46028D1017ECE494D50347C129C2C0E86', 'hex');
const IV = Buffer.from('mko0bhu8cft6zse5', 'utf8');

// Custom Base32 encoding exactly matching LibraryExam.encryption.Base32Encryption.ByteArrayToBase36String
function byteArrayToBase36String(bytes) {
  let result = '';
  let num3 = 5;
  let num4 = 0;
  while (num4 < bytes.length) {
    let b;
    if (num3 > 8) {
      b = (bytes[num4++] >> (num3 - 5)) & 0x1F;
    } else if (num3 === 8) {
      b = (bytes[num4++] >> 3) & 0x1F;
    } else {
      b = (((bytes[num4] << (8 - num3)) & 0xFF) >> 3) & 0x1F;
      num3 += 5;
      result += VALID_CHARS[b];
      continue;
    }
    if (num4 !== bytes.length) {
      const shift1 = ((bytes[num4] << (16 - num3)) & 0xFF) >> 3;
      b = (shift1 | b) & 0x1F;
    }
    num3 -= 3;
    result += VALID_CHARS[b];
  }
  return result;
}

function encryptToken(plainText) {
  const cipher = crypto.createCipheriv('aes-256-cbc', DERIVED_KEY, IV);
  const encrypted = Buffer.concat([cipher.update(plainText, 'utf8'), cipher.final()]);
  return byteArrayToBase36String(encrypted);
}

function fetchUserAgentJwt(timeoutMs = 7000) {
  return new Promise((resolve, reject) => {
    const options = {
      hostname: 'anbk-webapi.pusmendik.kemendikdasmen.go.id',
      path: '/auth/api/v1/user-agent/generate',
      method: 'GET',
      headers: {
        'Authorization': 'cmFkeWEgdGVrbm9sb2dpIGRpZ2l0YWw='
      },
      timeout: timeoutMs,
    };
    const req = https.request(options, (res) => {
      let data = '';
      res.on('data', chunk => data += chunk);
      res.on('end', () => {
        try {
          const parsed = JSON.parse(data);
          if (parsed && parsed.payload && parsed.payload.userAgent) {
            resolve(parsed.payload.userAgent);
          } else {
            reject(new Error('Invalid response from user-agent API: ' + data));
          }
        } catch (e) {
          reject(e);
        }
      });
    });
    req.on('timeout', () => {
      req.destroy();
      reject(new Error('Timeout connecting to user-agent API'));
    });
    req.on('error', reject);
    req.end();
  });
}

let cachedEncryptedUa = null;
let lastFetchTime = 0;
const CACHE_TTL_MS = 3 * 60 * 60 * 1000; // 3 hours (JWT is valid for 5 hours)

async function getEncryptedUserAgent() {
  const now = Date.now();
  if (cachedEncryptedUa && (now - lastFetchTime < CACHE_TTL_MS)) {
    return cachedEncryptedUa;
  }

  // Attempt up to 3 retries
  let lastError = null;
  for (let attempt = 1; attempt <= 3; attempt++) {
    try {
      const jwt = await fetchUserAgentJwt(5000);
      const encrypted = encryptToken(jwt);
      cachedEncryptedUa = encrypted;
      lastFetchTime = Date.now();
      return encrypted;
    } catch (err) {
      lastError = err;
      await new Promise(r => setTimeout(r, 600));
    }
  }

  if (cachedEncryptedUa) {
    return cachedEncryptedUa;
  }
  throw new Error('Failed to fetch and encrypt User-Agent token: ' + (lastError ? lastError.message : 'Unknown error'));
}

module.exports = {
  byteArrayToBase36String,
  encryptToken,
  fetchUserAgentJwt,
  getEncryptedUserAgent,
};

const crypto = require('crypto');

const VALID_CHARS = "QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9LP";
const DERIVED_KEY = Buffer.from('6FEE6E73D0508B949DE4CDDDBA38FEB46028D1017ECE494D50347C129C2C0E86', 'hex');
const IV = Buffer.from('mko0bhu8cft6zse5', 'utf8');

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

const sampleJwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE3OTAxNzc4NDQsImV4cCI6MTc5MDE5NTg0NCwiaWF0IjoxNzkwMTc3ODQ0LCJpc3MiOiJSYWR5YWxhYnMgVGVjaG5vbG9neSIsImF1ZCI6IlJhZHlhbGFicyBUZWNobm9sb2d5In0.IRkOyQWO0l8Dzi2ICQgetEeRUynUJLA4TyP9q8ErMwY";
const expected = "WJHDM2JCBYRDR3A6WUCWQ9SDRN4FZ6UKUWGF3JHPQUXW5UAZRMZSKQ4R2ZKDPSY733TYLJUXZYM3NRM53USUG3EHMLHN9RFP27G498CVPAWVST9DTBWCE55DTQ3PSTCVJQW6T49JRL3234MC6FGLALQQY7MKMSL25XDAGMK3PHU8X8WDBBZ85D4RKA26CP9ZWN22REJU95SX24NZUYHVQQJ9XEVPLQPETXS7X2M2A5ZGU23GXMJ3485T5PQD5QT2Q76MREHF6DXEU4RK6RPPPY4VAW8KTFYFKBXYMATNVSLPGCJCGXRSQ5B8EU38V9XBLFD7RCM75LP3MBRXNQLC98QQK5VX4XAPK4BMTK8GGFBDP5RB9CRCKHES9XG8XLFA";

const actual = encryptToken(sampleJwt);
console.log("Matches C# encryption 100%?", actual === expected);
if (actual !== expected) {
    console.log("Actual:  ", actual);
    console.log("Expected:", expected);
}

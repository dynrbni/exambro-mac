const https = require('https');
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

function fetchUserAgentJwt() {
    return new Promise((resolve, reject) => {
        const options = {
            hostname: 'anbk-webapi.pusmendik.kemendikdasmen.go.id',
            path: '/auth/api/v1/user-agent/generate',
            method: 'GET',
            headers: {
                'Authorization': 'cmFkeWEgdGVrbm9sb2dpIGRpZ2l0YWw='
            }
        };
        const req = https.request(options, (res) => {
            let data = '';
            res.on('data', chunk => data += chunk);
            res.on('end', () => {
                try {
                    const parsed = JSON.parse(data);
                    resolve(parsed.payload.userAgent);
                } catch (e) {
                    reject(e);
                }
            });
        });
        req.on('error', reject);
        req.end();
    });
}

async function run() {
    console.log("Fetching JWT from Pusmendik API...");
    const jwt = await fetchUserAgentJwt();
    console.log("Got JWT (length " + jwt.length + "): " + jwt.substring(0, 40) + "...");

    const encryptedUa = encryptToken(jwt);
    console.log("Encrypted UA (length " + encryptedUa.length + "): " + encryptedUa.substring(0, 40) + "...");

    console.log("\nTesting request to https://anbk-siswa.pusmendik.kemendikdasmen.go.id/ with Encrypted UA...");
    const testReq = https.request({
        hostname: 'anbk-siswa.pusmendik.kemendikdasmen.go.id',
        path: '/',
        method: 'GET',
        headers: {
            'User-Agent': encryptedUa,
            'pragma': 'no-cache'
        }
    }, (res) => {
        console.log("Response Status Code:", res.statusCode);
        console.log("Response Headers:", res.headers);
        let body = '';
        res.on('data', chunk => body += chunk);
        res.on('end', () => {
            console.log("\nResponse Body Length:", body.length);
            console.log("Is redirected to /Home/InvalidBrowser?", res.headers.location === '/Home/InvalidBrowser');
            if (res.headers.location) {
                console.log("Location:", res.headers.location);
            }
            if (body.includes("ERROR 402")) {
                console.log("Result: STILL 402 ERROR!");
            } else {
                console.log("Result: SUCCESS! NO 402 ERROR!");
                console.log("Page title:", body.match(/<title>([^<]+)<\/title>/)?.[1]);
            }
        });
    });
    testReq.end();
}

run().catch(console.error);

const { app } = require('electron');

const KIOSK_ARGS = process.argv.length >= 4;

if (KIOSK_ARGS) {
  require('./main.js');
} else {
  require('./launcher-main.js');
}
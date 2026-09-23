#!/usr/bin/env bash
set -uo pipefail

# ExamBrowser Setup untuk macOS
# Mengedit setting_exambro.json (terenkripsi AES-256-CBC)
# dan membangun ExamBrowser.app.

PROJECT="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DEV="$PROJECT/exambro-macos"
DIST="$PROJECT/Dist"

echo "=== ExamBrowser macOS Setup ==="

# 1. Tampilkan config saat ini
echo ""
echo "Config saat ini:"
node "$DEV/config.js" --launch | node -e "let d='';process.stdin.on('data',c=>d+=c).on('end',()=>{const j=JSON.parse(d);for(const k of ['moda','urlfr','urlonline','urlsemionline','Kegiatan','passwd','unlockkeys','aktifkamera'])console.log('  '+k+': '+j[k])})"

# 2. Input nilai
read -r -p "Mode (2=daring, 1=semidaring) [default: 2]: " MODA
MODA="${MODA:-2}"
read -r -p "Urlfr (server exam, contoh https://smart.pusmendik.kemdikbud.go.id/): " URLFR
read -r -p "URL online [default: http://118.98.236.40:8093/]: " URLON
URLON="${URLON:-http://118.98.236.40:8093/}"
read -r -p "URL semionline [default: https://192.168.0.200/]: " URLSEMI
URLSEMI="${URLSEMI:-https://192.168.0.200/}"
read -r -p "Kegiatan [default: 2020]: " KEGIATAN
KEGIATAN="${KEGIATAN:-2020}"
read -r -p "Unlock keys [default: LControlKey,C,B]: " UNLOCK
UNLOCK="${UNLOCK:-LControlKey,C,B}"
read -r -p "Aktifkan kamera (0=tidak, 1=ya) [default: 0]: " CAM
CAM="${CAM:-0}"

# 3. Tulis config baru terenkripsi
node "$DEV/config.js" --write "$MODA" "$URLFR" "$URLON" "$URLSEMI" "$KEGIATAN" "$UNLOCK" "$CAM"

echo ""
echo "Config berhasil diupdate."

# 4. Build/salurkan ke .app
if [ -d "$DIST/ExamBrowser.app" ]; then
  cp "$DEV/setting_exambro.json" "$DIST/ExamBrowser.app/Contents/Resources/app/setting_exambro.json"
  echo "Config disalin ke ExamBrowser.app."
fi

echo ""
echo "Selesai. Jalankan ujian dengan: ./launch.sh  (window validasi komputer)"
echo "  atau langsung mode ujian: ./launch.sh --kiosk [url-exam]"
echo "  atau edit config cepat: node exambro-macos/config.js --write ..."
#!/usr/bin/env bash
set -uo pipefail

# ExamBrowser Launcher untuk macOS
# Secara default membuka window launcher (splash + validasi komputer).
# Untuk langsung masuk mode ujian (kiosk) tanpa launcher:
#   ./launch.sh --kiosk [url-exam]
#
# Config (url, moda, dsb) diatur lewat window Pengaturan di dalam launcher,
# atau via CLI: node exambro-macos/config.js --write <moda> <urlfr> ...

DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
APP="$DIR/Dist/ExamBrowser.app"

if [ ! -d "$APP" ]; then
  echo "ERROR: $APP tidak ditemukan. Jalankan dulu ./build.sh untuk build." >&2
  exit 1
fi

BIN="$APP/Contents/MacOS/ExamBrowser"

CONFIG_DIR="$DIR/exambro-macos"

# Baca config terenkripsi untuk laporan (opsional)
CFG_JSON="$(node "$CONFIG_DIR/config.js" --launch 2>/dev/null || echo '{}')"

if [ "${1:-}" = "--kiosk" ]; then
  MODE="$(node -e "let d='';process.stdin.on('data',c=>d+=c).on('end',()=>{try{const j=JSON.parse(d);process.stdout.write(String(j.moda||'2'))}catch(e){process.stdout.write('2')}})" <<< "$CFG_JSON")"

  URL="${2:-}"
  if [ -z "$URL" ]; then
    URL="$(node -e "let d='';process.stdin.on('data',c=>d+=c).on('end',()=>{try{const j=JSON.parse(d);process.stdout.write(j.urlfr||'')}catch(e){process.stdout.write('')}})" <<< "$CFG_JSON")"
  fi

  UA="Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36"

  echo "Mode Ujian : $MODE"
  echo "URL Exam   : $URL"
  exec "$BIN" "$UA" "$MODE" "$URL"
fi

echo "Membuka launcher ExamBrowser..."
open "$APP"
echo "Jika ingin langsung mode ujian: ./launch.sh --kiosk [url-exam]"
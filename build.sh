#!/usr/bin/env bash
set -euo pipefail

# Membangun ulang ExamBrowser.app dari source di exambro-macos/
# Termasuk menyalin node_modules runtime (electron-log, node-datetime).

PROJECT="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DEV="$PROJECT/exambro-macos"
DIST="$PROJECT/Dist"
APP="$DIST/ExamBrowser.app"
ELAPP="$DEV/node_modules/electron/dist/Electron.app"

if [ ! -d "$ELAPP" ]; then
  echo "ERROR: Electron belum terinstall. Jalankan: cd exambro-macos && npm install" >&2
  exit 1
fi

echo "==> Membersihkan dist lama"
rm -rf "$DIST"
mkdir -p "$APP/Contents/MacOS"
mkdir -p "$APP/Contents/Resources"

echo "==> Menyalin Electron runtime"
cp -R "$ELAPP/Contents/Frameworks" "$APP/Contents/"
cp -R "$ELAPP/Contents/Resources/"* "$APP/Contents/Resources/"
cp "$ELAPP/Contents/PkgInfo" "$APP/Contents/"
cp "$ELAPP/Contents/MacOS/Electron" "$APP/Contents/MacOS/ExamBrowser"
chmod +x "$APP/Contents/MacOS/ExamBrowser"

echo "==> Menyalin source app"
mkdir -p "$APP/Contents/Resources/app"
cp -R "$DEV/"[!.n]* "$APP/Contents/Resources/app/"
rm -rf "$APP/Contents/Resources/app/node_modules"

echo "==> Menyalin runtime deps"
mkdir -p "$APP/Contents/Resources/app/node_modules/electron-log"
mkdir -p "$APP/Contents/Resources/app/node_modules/node-datetime"
cp -R "$DEV/node_modules/electron-log/." "$APP/Contents/Resources/app/node_modules/electron-log/"
cp -R "$DEV/node_modules/node-datetime/." "$APP/Contents/Resources/app/node_modules/node-datetime/"

echo "==> Menulis Info.plist"
cat > "$APP/Contents/Info.plist" << 'PLIST'
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
	<key>CFBundleDisplayName</key>
	<string>ExamBrowser</string>
	<key>CFBundleExecutable</key>
	<string>ExamBrowser</string>
	<key>CFBundleIdentifier</key>
	<string>id.go.kemdikbud.exambrowser</string>
	<key>CFBundleInfoDictionaryVersion</key>
	<string>6.0</string>
	<key>CFBundleName</key>
	<string>ExamBrowser</string>
	<key>CFBundlePackageType</key>
	<string>APPL</string>
	<key>CFBundleShortVersionString</key>
	<string>26.0222</string>
	<key>CFBundleVersion</key>
	<string>26.0222</string>
	<key>LSMinimumSystemVersion</key>
	<string>10.13</string>
	<key>NSHighResolutionCapable</key>
	<true/>
	<key>NSMicrophoneUsageDescription</key>
	<string>ExamBrowser membutuhkan akses kamera untuk pengawasan ujian.</string>
	<key>NSCameraUsageDescription</key>
	<string>ExamBrowser membutuhkan akses kamera untuk pengawasan ujian.</string>
	<key>NSPrincipalClass</key>
	<string>NSApplication</string>
</dict>
</plist>
PLIST
plutil -lint "$APP/Contents/Info.plist" >/dev/null

echo ""
echo "Build selesai: $APP"
echo "Jalankan: ./launch.sh [url-exam]"
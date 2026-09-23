# ExamBrowser untuk macOS

Portasi **ExamBrowser** (Pusmenjar Kemdikbud - ujian online) agar bisa berjalan
native di macOS. Logic backend & naming tetap **identik** dengan versi Windows
(.NET), hanya eksekusinya diganti dari `ExamBrowser.exe`/`runningexam.exe`
(.NET) menjadi aplikasi **Electron** native.

## Struktur

```
exambro-mac/
├── launch.sh            ← Jalankan ujian (ganti .NET launcher)
├── setup.sh             ← Edit konfigurasi server (moda, URL, kegiatan)
├── build.sh             ← Build ulang ExamBrowser.app dari source
├── exambro-macos/       ← Source Electron (main.js, config.js, assets)
│   ├── launcher.js      ← Entry: pilih mode launcher / kiosk dari argv
│   ├── launcher-main.js ← Proses utama launcher (validasi, spawn kiosk)
│   ├── launcher/        ← UI launcher (splash + validasi komputer + pengaturan)
│   ├── main.js          ← Port deobfuscated dari elekbrowser main.js (kiosk)
│   ├── config.js        ← Decrypt/encrypt setting_exambro.json (AES-256-CBC)
│   └── setting_exambro.json ← Config terenkripsi (algoritma sama dgn asli)
└── Dist/
    └── ExamBrowser.app  ← Aplikasi macOS final
```

## Persyaratan

- macOS 10.13+ (arm64 / Intel)
- Node.js 18+ (hanya dibutuhkan untuk setup/build)

## Setup pertama

```bash
./setup.sh
```

Ubah nilai: `moda` (2=daring, 1=semidaring), `urlfr` (server exam),
`Kegiatan`, `unlockkeys`, `aktifkamera`. Setup akan meng-encrypt ulang config
dengan algoritma yang sama dengan versi asli dan menyalinnya ke
`ExamBrowser.app`.

## Menjalankan ujian

```bash
# Membuka launcher: splash + validasi komputer + tombol MULAI:
./launch.sh

# Langsung masuk mode kiosk tanpa launcher (untuk pengetesan):
./launch.sh --kiosk https://smart.pusmendik.kemdikbud.go.id/Account/
```

Launcher menampilkan hasil validasi komputer (OS, prosesor, RAM, monitor,
audio, jaringan, waktu, kamera) dengan ikon hijau/merah — sama seperti
`runningexam.exe`. Tombol **MULAI** kemudian membuka browser kiosk (proses
terpisah, backend `main.js` identik tanpa perubahan) lalu menutup launcher.
Pengaturan (moda, URL, unlockkeys, kamera, password) bisa diubah dari tombol
**Pengaturan** (password default `12345`).

### Keluar dari mode kiosk

Tekan kombinasi **Ctrl + C** lalu **Ctrl + B** (sesuai `unlockkeys` di config,
default `LControlKey,C,B`) dalam rentang 2 detik untuk keluar dari aplikasi.

## Fitur yang dipertahankan (identik dgn Windows)

- Browser kiosk fullscreen + content protection
- Decrypt config `setting_exambro.json` (AES-256-CBC, key `nji9vgy7xdr6`,
  IV `mko0bhu8cft6zse5`, passwordDeriveBytes sha1)
- Extract username dari elemen `#exambrousername` + header respons
- Polling **Pesan Pengawas** `api/task-get-pesan/{username}/{kegiatan}`
- Polling **Status/Kick** `api/task-get-status-peserta/{username}/{kegiatan}`
  (+ dialog peringatan + auto-quit 15 detik)
- Download file ke folder Documents dengan prefix timestamp
- Halaman error 404/500 dengan tombol F5 refresh
- Zoom `Cmd+=`, `Cmd+-`, `Cmd+0`
- Popup/new-window diarahkan ke jendela baru

## Perbedaan teknis dgn Windows (tidak mengubah logic)

| Windows (.NET)            | macOS (Electron)                                       |
|---------------------------|--------------------------------------------------------|
| ExamBrowser.exe           | launch.sh → ExamBrowser.app (mode kiosk)               |
| runningexam.exe           | launcher: launcher.js + launcher-main.js + launcher/  |
| elekbrowser.exe           | electron (native macOS) + main.js                      |
| path separator `\`        | `path.sep` & `path.join`                               |
| log file di app dir       | `~/Library/Logs/exambrowser-macos/Browser.log`         |
| state file (username.json)| `~/Library/Application Support/exambrowser-macos/`     |
| `request` (deprecated)    | fetch bawaan Node                                       |

## Troubleshooting

- **Kamera/Webcam**: saat `aktifkamera=1` di config, macOS akan meminta izin
  kamera (Settings → Privacy & Security → Camera). Izin penuh untuk mengaktifkan.
- **Sertifikat self-signed**: app sudah pakai `ignore-certificate-errors` +
  `NODE_TLS_REJECT_UNAUTHORIZED=0` (sama seperti versi asli).
- **Build ulang setelah ubah source**: jalankan `./build.sh`.
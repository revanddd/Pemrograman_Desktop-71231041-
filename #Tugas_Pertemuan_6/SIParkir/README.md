# SIParkir - Sistem Informasi Parkir
## Tugas Pengamatan 2 - Pertemuan VI

---

## Cara Membuka & Menjalankan Proyek

1. Buka **Visual Studio** (2017 / 2019 / 2022)
2. Klik **File > Open > Project/Solution**
3. Pilih file `SIParkir.vbproj` di dalam folder `SIParkir/`
4. Klik **Build > Build Solution** (atau tekan `Ctrl+Shift+B`)
5. Klik **Debug > Start Debugging** (atau tekan `F5`)

---

## Akun Login Default

| Username | Password   |
|----------|------------|
| admin    | admin123   |
| petugas  | parkir123  |

---

## Daftar Form

| Form             | Nama File          | Fungsi                                          |
|------------------|--------------------|-------------------------------------------------|
| Login            | frmLogin.vb        | Autentikasi pengguna sebelum masuk sistem       |
| Form Utama       | frmUtama.vb        | Kelola parkir masuk & keluar, menu navigasi     |
| Ubah Profil      | frmUbahProfil.vb   | Mengganti password pengguna yang sedang login   |
| Langganan        | frmLangganan.vb    | CRUD data pelanggan parkir berlangganan         |
| Laporan          | frmLaporan.vb      | Menampilkan laporan pendapatan per periode      |

---

## Alur Program

```
[frmLogin]
    |-- Login sukses --> [frmUtama]
                              |-- Menu Sistem > Atur Profil --> [frmUbahProfil]
                              |-- Menu Sistem > Logout --> [frmLogin]
                              |-- Menu Admin > Langganan --> [frmLangganan]
                              |-- Menu Admin > Laporan --> [frmLaporan]
```

---

## Shortcut Keyboard di Form Utama

| Tombol | Fungsi              |
|--------|---------------------|
| F1     | Pilih jenis Motor   |
| F2     | Pilih jenis Mobil   |
| F3     | Pilih Taksi/Umum    |
| F4     | Pilih Sepeda        |
| F5     | Pilih Bis/Truk      |
| Enter  | Masuk / Keluar kendaraan |

---

## Catatan

- Koneksi ke database MySQL **belum diimplementasikan** (sesuai instruksi Tugas 2).
  Data disimpan sementara di memori (variabel/DataGridView).
- Koneksi database akan ditambahkan setelah TTS sesuai arahan dosen.
- Placeholder laporan di frmLaporan akan diisi dengan data dari database nantinya.

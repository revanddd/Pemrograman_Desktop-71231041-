Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmUtama
    ' ============================================================
    ' Form Utama / Kelola Parkir - SI Parkir
    ' Tugas Pengamatan 2 - Pertemuan VI
    ' ============================================================

    ' Variabel untuk menyimpan jenis kendaraan yang dipilih
    Private strJenisKendaraan As String = "Motor"

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan username yang sedang login
        lblInfoUser.Text = "Login sebagai: " & Module1.strUsername

        ' Set default pilihan jenis kendaraan
        cmbJenis.SelectedIndex = 0

        ' Inisialisasi kolom DataGridView
        dgvParkir.Columns.Clear()
        dgvParkir.Columns.Add("NoPlat", "No. Plat")
        dgvParkir.Columns.Add("Jenis", "Jenis")
        dgvParkir.Columns.Add("WaktuMasuk", "Waktu Masuk")
        dgvParkir.Columns.Add("Harga", "Tarif")
        dgvParkir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        ' Update jumlah kendaraan
        UpdateInfoKendaraan()
    End Sub

    Private Sub UpdateInfoKendaraan()
        Dim jumlah As Integer = dgvParkir.Rows.Count
        lblInfoKendaraan.Text = String.Format("0 Motor, 0 Mobil, 0 Taksi, 0 Spd, 0 Bis/Truk  |  Total: {0} kendaraan", jumlah)
    End Sub

    ' ---- MENU SISTEM ----
    Private Sub mnuAturProfil_Click(sender As Object, e As EventArgs) Handles mnuAturProfil.Click
        Dim frmP As New frmUbahProfil()
        frmP.ShowDialog()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        If MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Module1.strUsername = ""
            Me.Hide()
            Dim frmL As New frmLogin()
            frmL.Show()
        End If
    End Sub

    ' ---- MENU ADMIN ----
    Private Sub mnuLangganan_Click(sender As Object, e As EventArgs) Handles mnuLangganan.Click
        Dim frmLng As New frmLangganan()
        frmLng.ShowDialog()
    End Sub

    Private Sub mnuLaporan_Click(sender As Object, e As EventArgs) Handles mnuLaporan.Click
        Dim frmRpt As New frmLaporan()
        frmRpt.ShowDialog()
    End Sub

    ' ---- MENU BANTUAN ----
    Private Sub mnuBantuan_Click(sender As Object, e As EventArgs) Handles mnuBantuan.Click
        MessageBox.Show("Shortcut Keyboard:" & vbCrLf &
                        "F1 = Pilih Motor" & vbCrLf &
                        "F2 = Pilih Mobil" & vbCrLf &
                        "F3 = Pilih Taksi/Umum" & vbCrLf &
                        "F4 = Pilih Sepeda" & vbCrLf &
                        "F5 = Pilih Bis/Truk" & vbCrLf &
                        "Enter = Masuk / Keluar Kendaraan",
                        "Bantuan - SIParkir", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuTentang_Click(sender As Object, e As EventArgs) Handles mnuTentang.Click
        MessageBox.Show("SIParkir v1.0" & vbCrLf &
                        "Sistem Informasi Parkir" & vbCrLf & vbCrLf &
                        "Tugas Pengamatan 2 - Pertemuan VI" & vbCrLf &
                        "Mata Kuliah: Pemrograman Desktop",
                        "Tentang SIParkir", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ---- TOMBOL MASUK ----
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txtNomorPlat.Text.Trim() = "" Then
            MessageBox.Show("Masukkan nomor plat kendaraan terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomorPlat.Focus()
            Return
        End If

        Dim noPlat As String = txtNomorPlat.Text.Trim().ToUpper()
        Dim jenis As String = cmbJenis.SelectedItem.ToString()
        Dim waktuMasuk As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim tarif As Integer = GetTarif(jenis)

        ' Simpan ke list global
        Dim dp As New Module1.DataParkir()
        dp.NoPlat = noPlat
        dp.Jenis = jenis
        dp.WaktuMasuk = waktuMasuk
        dp.Harga = tarif
        dp.WaktuKeluar = ""
        Module1.listParkir.Add(dp)

        ' Tampilkan di label besar
        lblNomorPlat.Text = noPlat
        lblBiayaParkir.Text = "Rp " & tarif.ToString("N0")

        ' Tambahkan ke DataGridView
        dgvParkir.Rows.Add(noPlat, jenis, waktuMasuk, "Rp " & tarif.ToString("N0"))

        ' Reset input
        txtNomorPlat.Clear()
        txtNomorPlat.Focus()
        UpdateInfoKendaraan()

        MessageBox.Show(String.Format("Kendaraan {0} ({1}) berhasil masuk.{2}Tarif: Rp {3}",
                        noPlat, jenis, vbCrLf, tarif.ToString("N0")),
                        "Kendaraan Masuk", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ---- TOMBOL KELUAR ----
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If dgvParkir.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih kendaraan dari daftar yang akan keluar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim noPlat As String = dgvParkir.SelectedRows(0).Cells("NoPlat").Value.ToString()
        Dim harga As String = dgvParkir.SelectedRows(0).Cells("Harga").Value.ToString()

        If MessageBox.Show(String.Format("Kendaraan {0} akan keluar.{1}Total biaya: {2}{1}Konfirmasi?",
                           noPlat, vbCrLf, harga),
                           "Kendaraan Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Pindahkan dari listParkir ke listTransaksi (sebagai transaksi selesai)
            For i As Integer = 0 To Module1.listParkir.Count - 1
                If Module1.listParkir(i).NoPlat = noPlat Then
                    Dim selesai As Module1.DataParkir = Module1.listParkir(i)
                    selesai.WaktuKeluar = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Module1.listTransaksi.Add(selesai)
                    Module1.listParkir.RemoveAt(i)
                    Exit For
                End If
            Next

            dgvParkir.Rows.Remove(dgvParkir.SelectedRows(0))
            lblNomorPlat.Text = "-"
            lblBiayaParkir.Text = "Rp 0"
            UpdateInfoKendaraan()
        End If
    End Sub

    ' ---- SHORTCUT KEYBOARD ----
    Private Sub frmUtama_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1 : cmbJenis.SelectedIndex = 0 ' Motor
            Case Keys.F2 : cmbJenis.SelectedIndex = 1 ' Mobil
            Case Keys.F3 : cmbJenis.SelectedIndex = 2 ' Taksi/Umum
            Case Keys.F4 : cmbJenis.SelectedIndex = 3 ' Sepeda
            Case Keys.F5 : cmbJenis.SelectedIndex = 4 ' Bis/Truk
        End Select
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged
        If cmbJenis.SelectedItem IsNot Nothing Then
            strJenisKendaraan = cmbJenis.SelectedItem.ToString()
        End If
    End Sub

    Private Function GetTarif(jenis As String) As Integer
        Select Case jenis
            Case "Motor" : Return 2000
            Case "Mobil" : Return 5000
            Case "Taksi/Umum" : Return 3000
            Case "Sepeda" : Return 1000
            Case "Bis/Truk" : Return 10000
            Case Else : Return 2000
        End Select
    End Function

    Private Sub frmUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class

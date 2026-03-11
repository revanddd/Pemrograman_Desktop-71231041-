Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmLaporan
    ' ============================================================
    ' Form Laporan Pendapatan Parkir - SI Parkir
    ' Tugas Pengamatan 2 - Pertemuan VI
    ' ============================================================

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Dim bulan As String = cmbBulan.SelectedItem.ToString()
        Dim tahun As String = txtTahun.Text.Trim()

        If tahun = "" Then
            MessageBox.Show("Masukkan tahun laporan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTahun.Focus()
            Return
        End If

        ' Gabungkan: kendaraan yang sudah keluar (listTransaksi) + yang masih parkir (listParkir)
        Dim semuaData As New List(Of Module1.DataParkir)
        semuaData.AddRange(Module1.listTransaksi)
        semuaData.AddRange(Module1.listParkir)

        ' Filter berdasarkan bulan & tahun dari waktu masuk
        Dim filtered As New List(Of Module1.DataParkir)
        For Each dp As Module1.DataParkir In semuaData
            Try
                Dim tgl As DateTime = DateTime.ParseExact(dp.WaktuMasuk, "dd/MM/yyyy HH:mm:ss", Nothing)
                Dim namaBulan As String = tgl.ToString("MMMM", New System.Globalization.CultureInfo("id-ID"))
                ' Fallback ke nama bulan Indonesia manual jika CultureInfo gagal
                Dim bln As String = GetNamaBulan(tgl.Month)
                If bln = bulan AndAlso tgl.Year.ToString() = tahun Then
                    filtered.Add(dp)
                End If
            Catch
            End Try
        Next

        ' Tulis laporan
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("===== LAPORAN PENDAPATAN PARKIR =====")
        sb.AppendLine("Periode  : " & bulan & " " & tahun)
        sb.AppendLine("Dicetak  : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
        sb.AppendLine("Operator : " & Module1.strUsername)
        sb.AppendLine("=====================================")
        sb.AppendLine()

        If filtered.Count = 0 Then
            sb.AppendLine("Tidak ada data parkir untuk periode ini.")
        Else
            sb.AppendLine(String.Format("{0,-4} {1,-12} {2,-12} {3,-22} {4,-22} {5}", "No", "No. Plat", "Jenis", "Waktu Masuk", "Waktu Keluar", "Tarif"))
            sb.AppendLine(New String("-", 80))

            Dim total As Integer = 0
            Dim no As Integer = 1
            For Each dp As Module1.DataParkir In filtered
                Dim keluar As String = If(dp.WaktuKeluar = "", "(masih parkir)", dp.WaktuKeluar)
                sb.AppendLine(String.Format("{0,-4} {1,-12} {2,-12} {3,-22} {4,-22} Rp {5}", no, dp.NoPlat, dp.Jenis, dp.WaktuMasuk, keluar, dp.Harga.ToString("N0")))
                total += dp.Harga
                no += 1
            Next

            sb.AppendLine(New String("-", 80))
            sb.AppendLine("TOTAL PENDAPATAN      : Rp " & total.ToString("N0"))
            sb.AppendLine("Total Kendaraan Masuk : " & filtered.Count)
        End If

        txtLaporan.Text = sb.ToString()
    End Sub

    Private Function GetNamaBulan(bulan As Integer) As String
        Dim nama() As String = {"Januari", "Februari", "Maret", "April", "Mei", "Juni",
                                "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        Return nama(bulan - 1)
    End Function

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox bulan
        cmbBulan.Items.AddRange(New Object() {
            "Januari", "Februari", "Maret", "April", "Mei", "Juni",
            "Juli", "Agustus", "September", "Oktober", "November", "Desember"
        })
        cmbBulan.SelectedIndex = DateTime.Now.Month - 1
        txtTahun.Text = DateTime.Now.Year.ToString()
    End Sub
End Class

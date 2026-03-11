Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmLangganan
    ' ============================================================
    ' Form Atur Parkir Langganan - SI Parkir
    ' Tugas Pengamatan 2 - Pertemuan VI
    ' ============================================================

    Private isEditMode As Boolean = False
    Private selectedRowIndex As Integer = -1

    Private Sub frmLangganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup DataGridView kolom
        dgvLangganan.Columns.Clear()
        dgvLangganan.Columns.Add("ID", "ID")
        dgvLangganan.Columns.Add("Nama", "Nama Pelanggan")
        dgvLangganan.Columns.Add("NoPlat", "No. Plat")
        dgvLangganan.Columns.Add("Jenis", "Jenis")
        dgvLangganan.Columns.Add("Biaya", "Tarif (Rp)")
        dgvLangganan.Columns.Add("Expired", "Berlaku Hingga")
        dgvLangganan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill

        ' Load data dari list global
        RefreshGrid()
        SetInputEnabled(False)
    End Sub

    Private Sub RefreshGrid()
        dgvLangganan.Rows.Clear()
        For Each dl As Module1.DataLangganan In Module1.listLangganan
            dgvLangganan.Rows.Add(dl.ID, dl.Nama, dl.NoPlat, dl.Jenis, dl.Biaya, dl.Expired)
        Next
    End Sub

    Private Sub SetInputEnabled(enabled As Boolean)
        txtNama.Enabled = enabled
        txtNoPlat.Enabled = enabled
        cmbJenis.Enabled = enabled
        txtTarif.Enabled = enabled
        dtpBerlakuHingga.Enabled = enabled
    End Sub

    Private Sub ClearInput()
        txtNama.Clear()
        txtNoPlat.Clear()
        cmbJenis.SelectedIndex = 0
        txtTarif.Clear()
        dtpBerlakuHingga.Value = DateTime.Now.AddMonths(1)
        lblIDPelanggan.Text = "ID: -"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        isEditMode = False
        ClearInput()
        SetInputEnabled(True)
        txtNama.Focus()
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvLangganan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan yang akan diedit!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        isEditMode = True
        selectedRowIndex = dgvLangganan.SelectedRows(0).Index

        ' Isi form dengan data yang dipilih
        txtNama.Text = dgvLangganan.SelectedRows(0).Cells("Nama").Value.ToString()
        txtNoPlat.Text = dgvLangganan.SelectedRows(0).Cells("NoPlat").Value.ToString()
        cmbJenis.SelectedItem = dgvLangganan.SelectedRows(0).Cells("Jenis").Value.ToString()
        txtTarif.Text = dgvLangganan.SelectedRows(0).Cells("Biaya").Value.ToString()
        dtpBerlakuHingga.Value = DateTime.Parse(dgvLangganan.SelectedRows(0).Cells("Expired").Value.ToString())
        lblIDPelanggan.Text = "ID: " & dgvLangganan.SelectedRows(0).Cells("ID").Value.ToString()

        SetInputEnabled(True)
        btnTambah.Enabled = False
        btnHapus.Enabled = False
        txtNama.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvLangganan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nama As String = dgvLangganan.SelectedRows(0).Cells("Nama").Value.ToString()
        Dim id As Integer = Integer.Parse(dgvLangganan.SelectedRows(0).Cells("ID").Value.ToString())

        If MessageBox.Show(String.Format("Hapus data pelanggan '{0}'?", nama),
                           "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Hapus dari list global
            For i As Integer = 0 To Module1.listLangganan.Count - 1
                If Module1.listLangganan(i).ID = id Then
                    Module1.listLangganan.RemoveAt(i)
                    Exit For
                End If
            Next
            RefreshGrid()
            ClearInput()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" OrElse txtNoPlat.Text.Trim() = "" OrElse txtTarif.Text.Trim() = "" Then
            MessageBox.Show("Nama, Nomor Plat, dan Tarif wajib diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If isEditMode Then
            ' Update di list global
            Dim id As Integer = Integer.Parse(dgvLangganan.Rows(selectedRowIndex).Cells("ID").Value.ToString())
            For i As Integer = 0 To Module1.listLangganan.Count - 1
                If Module1.listLangganan(i).ID = id Then
                    Dim dl As Module1.DataLangganan = Module1.listLangganan(i)
                    dl.Nama = txtNama.Text.Trim()
                    dl.NoPlat = txtNoPlat.Text.Trim().ToUpper()
                    dl.Jenis = cmbJenis.SelectedItem.ToString()
                    dl.Biaya = txtTarif.Text.Trim()
                    dl.Expired = dtpBerlakuHingga.Value.ToString("dd/MM/yyyy")
                    Module1.listLangganan(i) = dl
                    Exit For
                End If
            Next
            MessageBox.Show("Data pelanggan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Tambah ke list global
            Dim dl As New Module1.DataLangganan()
            dl.ID = If(Module1.listLangganan.Count = 0, 1, Module1.listLangganan(Module1.listLangganan.Count - 1).ID + 1)
            dl.Nama = txtNama.Text.Trim()
            dl.NoPlat = txtNoPlat.Text.Trim().ToUpper()
            dl.Jenis = cmbJenis.SelectedItem.ToString()
            dl.Biaya = txtTarif.Text.Trim()
            dl.Expired = dtpBerlakuHingga.Value.ToString("dd/MM/yyyy")
            Module1.listLangganan.Add(dl)
            MessageBox.Show("Data pelanggan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        RefreshGrid()
        ClearInput()
        SetInputEnabled(False)
        btnTambah.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class

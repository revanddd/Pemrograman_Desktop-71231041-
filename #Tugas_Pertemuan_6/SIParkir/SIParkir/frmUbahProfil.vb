Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmUbahProfil
    ' ============================================================
    ' Form Ubah Profil - SI Parkir
    ' Tugas Pengamatan 2 - Pertemuan VI
    ' ============================================================

    Private Sub frmUbahProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = Module1.strUsername
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim passwordBaru As String = txtPasswordBaru.Text
        Dim passwordUlang As String = txtKetikLagi.Text

        If passwordBaru = "" OrElse passwordUlang = "" Then
            MessageBox.Show("Password baru dan konfirmasi tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If passwordBaru <> passwordUlang Then
            MessageBox.Show("Password baru dan konfirmasi tidak cocok!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPasswordBaru.Clear()
            txtKetikLagi.Clear()
            txtPasswordBaru.Focus()
            Return
        End If

        If passwordBaru.Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Update password di dictionary (simulasi database)
        Module1.dictUsers(Module1.strUsername) = passwordBaru

        MessageBox.Show("Password berhasil diubah!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class

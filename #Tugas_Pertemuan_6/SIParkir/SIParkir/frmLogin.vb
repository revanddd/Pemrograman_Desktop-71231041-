Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class frmLogin
    ' ============================================================
    ' Form Login - SI Parkir
    ' Tugas Pengamatan 2 - Pertemuan VI
    ' ============================================================

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validasi input kosong
        If username = "" OrElse password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek kredensial dari dictionary (simulasi database)
        If Module1.dictUsers.ContainsKey(username) AndAlso Module1.dictUsers(username) = password Then
            Module1.strUsername = username
            Me.Hide()
            Dim frmU As New frmUtama()
            frmU.Show()
        Else
            MessageBox.Show("Username atau Password salah! Silakan coba lagi.", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        ' Tekan Enter di field password = klik tombol Login
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.InitUsers()
        txtUsername.Focus()
    End Sub
End Class

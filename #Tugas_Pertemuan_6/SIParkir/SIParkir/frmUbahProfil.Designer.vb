<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUbahProfil
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPasswordBaru = New System.Windows.Forms.Label()
        Me.lblKetikLagi = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPasswordBaru = New System.Windows.Forms.TextBox()
        Me.txtKetikLagi = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(200, 220, 245)
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(380, 45)
        Me.lblTitle.Text = "SIParkir - Ubah Profil"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnlMain.Controls.Add(Me.lblTitle)

        ' lblUsername
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 10)
        Me.lblUsername.Location = New System.Drawing.Point(20, 65)
        Me.lblUsername.Text = "Username"
        Me.pnlMain.Controls.Add(Me.lblUsername)

        ' txtUsername (read-only)
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 10)
        Me.txtUsername.Location = New System.Drawing.Point(140, 62)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(210, 23)
        Me.pnlMain.Controls.Add(Me.txtUsername)

        ' lblPasswordBaru
        Me.lblPasswordBaru.AutoSize = True
        Me.lblPasswordBaru.Font = New System.Drawing.Font("Arial", 10)
        Me.lblPasswordBaru.Location = New System.Drawing.Point(20, 105)
        Me.lblPasswordBaru.Text = "Password Baru"
        Me.pnlMain.Controls.Add(Me.lblPasswordBaru)

        ' txtPasswordBaru
        Me.txtPasswordBaru.Font = New System.Drawing.Font("Arial", 10)
        Me.txtPasswordBaru.Location = New System.Drawing.Point(140, 102)
        Me.txtPasswordBaru.Name = "txtPasswordBaru"
        Me.txtPasswordBaru.PasswordChar = "*"c
        Me.txtPasswordBaru.Size = New System.Drawing.Size(210, 23)
        Me.pnlMain.Controls.Add(Me.txtPasswordBaru)

        ' lblKetikLagi
        Me.lblKetikLagi.AutoSize = True
        Me.lblKetikLagi.Font = New System.Drawing.Font("Arial", 10)
        Me.lblKetikLagi.Location = New System.Drawing.Point(20, 145)
        Me.lblKetikLagi.Text = "Ketik lagi"
        Me.pnlMain.Controls.Add(Me.lblKetikLagi)

        ' txtKetikLagi
        Me.txtKetikLagi.Font = New System.Drawing.Font("Arial", 10)
        Me.txtKetikLagi.Location = New System.Drawing.Point(140, 142)
        Me.txtKetikLagi.Name = "txtKetikLagi"
        Me.txtKetikLagi.PasswordChar = "*"c
        Me.txtKetikLagi.Size = New System.Drawing.Size(210, 23)
        Me.pnlMain.Controls.Add(Me.txtKetikLagi)

        ' btnSimpan
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(46, 117, 182)
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(140, 185)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(90, 30)
        Me.btnSimpan.Text = "Simpan"
        Me.pnlMain.Controls.Add(Me.btnSimpan)

        ' btnTutup
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(240, 185)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(90, 30)
        Me.btnTutup.Text = "Tutup"
        Me.pnlMain.Controls.Add(Me.btnTutup)

        ' pnlMain
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Location = New System.Drawing.Point(30, 30)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(380, 235)

        ' frmUbahProfil
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(235, 243, 251)
        Me.ClientSize = New System.Drawing.Size(440, 295)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUbahProfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SIParkir - Ubah Profil"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPasswordBaru As System.Windows.Forms.Label
    Friend WithEvents lblKetikLagi As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordBaru As System.Windows.Forms.TextBox
    Friend WithEvents txtKetikLagi As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
End Class

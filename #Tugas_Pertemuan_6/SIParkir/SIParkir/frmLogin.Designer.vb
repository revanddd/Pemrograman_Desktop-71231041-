<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SIParkir - Login"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(200, 220, 245)

        ' lblUsername
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 10)
        Me.lblUsername.Location = New System.Drawing.Point(40, 80)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Text = "Username"

        ' txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 10)
        Me.txtUsername.Location = New System.Drawing.Point(140, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(180, 23)
        Me.txtUsername.TabIndex = 1

        ' lblPassword
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 10)
        Me.lblPassword.Location = New System.Drawing.Point(40, 120)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "Password"

        ' txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 10)
        Me.txtPassword.Location = New System.Drawing.Point(140, 117)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = "*"c
        Me.txtPassword.Size = New System.Drawing.Size(180, 23)
        Me.txtPassword.TabIndex = 2

        ' btnLogin
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(46, 117, 182)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(140, 160)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 30)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"

        ' btnKeluar
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(192, 0, 0)
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(235, 160)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(85, 30)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"

        ' pnlMain
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Controls.Add(Me.lblTitle)
        Me.pnlMain.Controls.Add(Me.lblUsername)
        Me.pnlMain.Controls.Add(Me.txtUsername)
        Me.pnlMain.Controls.Add(Me.lblPassword)
        Me.pnlMain.Controls.Add(Me.txtPassword)
        Me.pnlMain.Controls.Add(Me.btnLogin)
        Me.pnlMain.Controls.Add(Me.btnKeluar)
        Me.pnlMain.Location = New System.Drawing.Point(50, 40)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(360, 210)

        ' frmLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(235, 243, 251)
        Me.ClientSize = New System.Drawing.Size(460, 290)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir - Login"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
End Class

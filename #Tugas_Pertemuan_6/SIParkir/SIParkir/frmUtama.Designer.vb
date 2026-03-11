<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.mnuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuSistem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAturProfil = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLangganan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBantuanMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBantuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTentang = New System.Windows.Forms.ToolStripMenuItem()

        Me.lblNomorPlat = New System.Windows.Forms.Label()
        Me.lblNomorPlatCaption = New System.Windows.Forms.Label()
        Me.txtNomorPlat = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.lblBiayaCaption = New System.Windows.Forms.Label()
        Me.lblBiayaParkir = New System.Windows.Forms.Label()
        Me.lblInfoCaption = New System.Windows.Forms.Label()
        Me.lblInfoKendaraan = New System.Windows.Forms.Label()
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.lblDaftarParkir = New System.Windows.Forms.Label()
        Me.dgvParkir = New System.Windows.Forms.DataGridView()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlBottom = New System.Windows.Forms.Panel()

        Me.mnuBar.SuspendLayout()
        CType(Me.dgvParkir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()

        ' MenuStrip
        Me.mnuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSistem, Me.mnuAdmin, Me.mnuBantuanMenu})
        Me.mnuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuBar.Name = "mnuBar"
        Me.mnuBar.Size = New System.Drawing.Size(900, 24)

        ' Menu Sistem
        Me.mnuSistem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAturProfil, Me.ToolStripSeparator1, Me.mnuLogout})
        Me.mnuSistem.Name = "mnuSistem"
        Me.mnuSistem.Text = "Sistem"

        Me.mnuAturProfil.Name = "mnuAturProfil"
        Me.mnuAturProfil.Text = "Atur Profil"

        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"

        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Text = "Logout"

        ' Menu Admin
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLangganan, Me.mnuLaporan})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Text = "Admin"

        Me.mnuLangganan.Name = "mnuLangganan"
        Me.mnuLangganan.Text = "Langganan"

        Me.mnuLaporan.Name = "mnuLaporan"
        Me.mnuLaporan.Text = "Laporan"

        ' Menu Bantuan
        Me.mnuBantuanMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBantuan, Me.mnuTentang})
        Me.mnuBantuanMenu.Name = "mnuBantuanMenu"
        Me.mnuBantuanMenu.Text = "Bantuan"

        Me.mnuBantuan.Name = "mnuBantuan"
        Me.mnuBantuan.Text = "Bantuan"

        Me.mnuTentang.Name = "mnuTentang"
        Me.mnuTentang.Text = "Tentang"

        ' pnlLeft (input area)
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Location = New System.Drawing.Point(0, 24)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(420, 500)
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblNomorPlat (besar)
        Me.lblNomorPlat.AutoSize = False
        Me.lblNomorPlat.Font = New System.Drawing.Font("Arial", 36, System.Drawing.FontStyle.Bold)
        Me.lblNomorPlat.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblNomorPlat.Location = New System.Drawing.Point(10, 10)
        Me.lblNomorPlat.Name = "lblNomorPlat"
        Me.lblNomorPlat.Size = New System.Drawing.Size(400, 80)
        Me.lblNomorPlat.Text = "-"
        Me.lblNomorPlat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNomorPlat.BackColor = System.Drawing.Color.FromArgb(235, 243, 251)
        Me.pnlLeft.Controls.Add(Me.lblNomorPlat)

        ' lblNomorPlatCaption
        Me.lblNomorPlatCaption.AutoSize = True
        Me.lblNomorPlatCaption.Font = New System.Drawing.Font("Arial", 10)
        Me.lblNomorPlatCaption.Location = New System.Drawing.Point(10, 105)
        Me.lblNomorPlatCaption.Text = "Nomor Plat"
        Me.pnlLeft.Controls.Add(Me.lblNomorPlatCaption)

        ' txtNomorPlat
        Me.txtNomorPlat.Font = New System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
        Me.txtNomorPlat.Location = New System.Drawing.Point(110, 100)
        Me.txtNomorPlat.Name = "txtNomorPlat"
        Me.txtNomorPlat.Size = New System.Drawing.Size(280, 26)
        Me.txtNomorPlat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pnlLeft.Controls.Add(Me.txtNomorPlat)

        ' lblJenis
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Arial", 10)
        Me.lblJenis.Location = New System.Drawing.Point(10, 145)
        Me.lblJenis.Text = "Jenis"
        Me.pnlLeft.Controls.Add(Me.lblJenis)

        ' cmbJenis
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi/Umum", "Sepeda", "Bis/Truk"})
        Me.cmbJenis.Location = New System.Drawing.Point(110, 142)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(160, 24)
        Me.cmbJenis.SelectedIndex = 0
        Me.pnlLeft.Controls.Add(Me.cmbJenis)

        ' btnMasuk
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(46, 117, 182)
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(110, 185)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(90, 32)
        Me.btnMasuk.Text = "Masuk"
        Me.pnlLeft.Controls.Add(Me.btnMasuk)

        ' btnKeluar
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(192, 0, 0)
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(215, 185)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(90, 32)
        Me.btnKeluar.Text = "Keluar"
        Me.pnlLeft.Controls.Add(Me.btnKeluar)

        ' lblBiayaCaption
        Me.lblBiayaCaption.AutoSize = True
        Me.lblBiayaCaption.Font = New System.Drawing.Font("Arial", 10)
        Me.lblBiayaCaption.Location = New System.Drawing.Point(10, 240)
        Me.lblBiayaCaption.Text = "Biaya Parkir"
        Me.pnlLeft.Controls.Add(Me.lblBiayaCaption)

        ' lblBiayaParkir
        Me.lblBiayaParkir.AutoSize = False
        Me.lblBiayaParkir.Font = New System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold)
        Me.lblBiayaParkir.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblBiayaParkir.BackColor = System.Drawing.Color.FromArgb(235, 243, 251)
        Me.lblBiayaParkir.Location = New System.Drawing.Point(110, 230)
        Me.lblBiayaParkir.Name = "lblBiayaParkir"
        Me.lblBiayaParkir.Size = New System.Drawing.Size(295, 60)
        Me.lblBiayaParkir.Text = "Rp 0"
        Me.lblBiayaParkir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pnlLeft.Controls.Add(Me.lblBiayaParkir)

        ' lblInfoCaption
        Me.lblInfoCaption.AutoSize = True
        Me.lblInfoCaption.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblInfoCaption.ForeColor = System.Drawing.Color.Gray
        Me.lblInfoCaption.Location = New System.Drawing.Point(10, 310)
        Me.lblInfoCaption.Text = "Informasi"
        Me.pnlLeft.Controls.Add(Me.lblInfoCaption)

        ' lblInfoKendaraan
        Me.lblInfoKendaraan.AutoSize = False
        Me.lblInfoKendaraan.Font = New System.Drawing.Font("Arial", 8)
        Me.lblInfoKendaraan.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoKendaraan.Location = New System.Drawing.Point(10, 330)
        Me.lblInfoKendaraan.Name = "lblInfoKendaraan"
        Me.lblInfoKendaraan.Size = New System.Drawing.Size(400, 20)
        Me.lblInfoKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Spd, 0 Bis/Truk"
        Me.pnlLeft.Controls.Add(Me.lblInfoKendaraan)

        ' Shortcut label
        Dim lblShortcut As New System.Windows.Forms.Label()
        lblShortcut.AutoSize = False
        lblShortcut.Font = New System.Drawing.Font("Arial", 8)
        lblShortcut.ForeColor = System.Drawing.Color.Gray
        lblShortcut.Location = New System.Drawing.Point(10, 355)
        lblShortcut.Size = New System.Drawing.Size(400, 50)
        lblShortcut.Text = "F1=Motor  F2=Mobil  F3=Taksi  F4=Sepeda  F5=Bis/Truk" & vbCrLf & "Enter = Masuk / Keluar Kendaraan"
        Me.pnlLeft.Controls.Add(lblShortcut)

        ' pnlRight (daftar kendaraan)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Location = New System.Drawing.Point(422, 24)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(460, 500)
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblDaftarParkir
        Me.lblDaftarParkir.AutoSize = True
        Me.lblDaftarParkir.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.lblDaftarParkir.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblDaftarParkir.Location = New System.Drawing.Point(5, 5)
        Me.lblDaftarParkir.Text = "Kendaraan sedang parkir:"
        Me.pnlRight.Controls.Add(Me.lblDaftarParkir)

        ' dgvParkir
        Me.dgvParkir.AllowUserToAddRows = False
        Me.dgvParkir.AllowUserToDeleteRows = False
        Me.dgvParkir.BackgroundColor = System.Drawing.Color.White
        Me.dgvParkir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvParkir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParkir.Location = New System.Drawing.Point(5, 28)
        Me.dgvParkir.Name = "dgvParkir"
        Me.dgvParkir.ReadOnly = True
        Me.dgvParkir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParkir.Size = New System.Drawing.Size(448, 460)
        Me.dgvParkir.MultiSelect = False
        Me.pnlRight.Controls.Add(Me.dgvParkir)

        ' pnlBottom (status bar)
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.pnlBottom.Location = New System.Drawing.Point(0, 524)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(900, 26)

        ' lblInfoUser
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Font = New System.Drawing.Font("Arial", 9)
        Me.lblInfoUser.ForeColor = System.Drawing.Color.White
        Me.lblInfoUser.Location = New System.Drawing.Point(5, 5)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Text = "Login sebagai: -"
        Me.pnlBottom.Controls.Add(Me.lblInfoUser)

        ' frmUtama
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(235, 243, 251)
        Me.ClientSize = New System.Drawing.Size(884, 550)
        Me.Controls.Add(Me.mnuBar)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlBottom)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuBar
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir - Form Utama"

        Me.mnuBar.ResumeLayout(False)
        Me.mnuBar.PerformLayout()
        CType(Me.dgvParkir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSistem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAturProfil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLangganan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBantuanMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBantuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTentang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNomorPlat As System.Windows.Forms.Label
    Friend WithEvents lblNomorPlatCaption As System.Windows.Forms.Label
    Friend WithEvents txtNomorPlat As System.Windows.Forms.TextBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents btnMasuk As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents lblBiayaCaption As System.Windows.Forms.Label
    Friend WithEvents lblBiayaParkir As System.Windows.Forms.Label
    Friend WithEvents lblInfoCaption As System.Windows.Forms.Label
    Friend WithEvents lblInfoKendaraan As System.Windows.Forms.Label
    Friend WithEvents lblInfoUser As System.Windows.Forms.Label
    Friend WithEvents lblDaftarParkir As System.Windows.Forms.Label
    Friend WithEvents dgvParkir As System.Windows.Forms.DataGridView
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
End Class

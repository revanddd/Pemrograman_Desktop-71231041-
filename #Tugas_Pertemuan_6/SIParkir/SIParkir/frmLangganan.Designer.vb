<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLangganan
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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblTarif = New System.Windows.Forms.Label()
        Me.lblBerlaku = New System.Windows.Forms.Label()
        Me.lblIDPelanggan = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.dtpBerlakuHingga = New System.Windows.Forms.DateTimePicker()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.dgvLangganan = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLangganan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(200, 220, 245)
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(700, 40)
        Me.lblTitle.Text = "SIParkir - Langganan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Form controls - input area
        Dim lbls() As String = {"Nama Pelanggan", "Nomor Plat", "Jenis", "Tarif Langganan", "Berlaku hingga"}
        Dim yPos() As Integer = {55, 90, 125, 160, 195}

        Me.lblNama.AutoSize = True : Me.lblNama.Font = New System.Drawing.Font("Arial", 9) : Me.lblNama.Location = New System.Drawing.Point(10, yPos(0)) : Me.lblNama.Text = "Nama Pelanggan"
        Me.lblNoPlat.AutoSize = True : Me.lblNoPlat.Font = New System.Drawing.Font("Arial", 9) : Me.lblNoPlat.Location = New System.Drawing.Point(10, yPos(1)) : Me.lblNoPlat.Text = "Nomor Plat"
        Me.lblJenis.AutoSize = True : Me.lblJenis.Font = New System.Drawing.Font("Arial", 9) : Me.lblJenis.Location = New System.Drawing.Point(10, yPos(2)) : Me.lblJenis.Text = "Jenis"
        Me.lblTarif.AutoSize = True : Me.lblTarif.Font = New System.Drawing.Font("Arial", 9) : Me.lblTarif.Location = New System.Drawing.Point(10, yPos(3)) : Me.lblTarif.Text = "Tarif Langganan"
        Me.lblBerlaku.AutoSize = True : Me.lblBerlaku.Font = New System.Drawing.Font("Arial", 9) : Me.lblBerlaku.Location = New System.Drawing.Point(10, yPos(4)) : Me.lblBerlaku.Text = "Berlaku hingga"

        Me.lblIDPelanggan.AutoSize = True : Me.lblIDPelanggan.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Italic) : Me.lblIDPelanggan.ForeColor = System.Drawing.Color.Gray : Me.lblIDPelanggan.Location = New System.Drawing.Point(450, 55) : Me.lblIDPelanggan.Text = "ID: -"

        Me.txtNama.Font = New System.Drawing.Font("Arial", 9) : Me.txtNama.Location = New System.Drawing.Point(140, yPos(0) - 2) : Me.txtNama.Size = New System.Drawing.Size(200, 21) : Me.txtNama.Enabled = False
        Me.txtNoPlat.Font = New System.Drawing.Font("Arial", 9) : Me.txtNoPlat.Location = New System.Drawing.Point(140, yPos(1) - 2) : Me.txtNoPlat.Size = New System.Drawing.Size(120, 21) : Me.txtNoPlat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper : Me.txtNoPlat.Enabled = False

        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.Font = New System.Drawing.Font("Arial", 9)
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi/Umum", "Sepeda", "Bis/Truk"})
        Me.cmbJenis.Location = New System.Drawing.Point(280, yPos(1) - 2)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(120, 21)
        Me.cmbJenis.SelectedIndex = 0
        Me.cmbJenis.Enabled = False

        Me.txtTarif.Font = New System.Drawing.Font("Arial", 9) : Me.txtTarif.Location = New System.Drawing.Point(140, yPos(3) - 2) : Me.txtTarif.Size = New System.Drawing.Size(120, 21) : Me.txtTarif.Enabled = False
        Me.dtpBerlakuHingga.Font = New System.Drawing.Font("Arial", 9) : Me.dtpBerlakuHingga.Location = New System.Drawing.Point(140, yPos(4) - 2) : Me.dtpBerlakuHingga.Size = New System.Drawing.Size(200, 21) : Me.dtpBerlakuHingga.Enabled = False : Me.dtpBerlakuHingga.Format = System.Windows.Forms.DateTimePickerFormat.Short

        ' Buttons
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(46, 117, 182) : Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnTambah.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.btnTambah.ForeColor = System.Drawing.Color.White : Me.btnTambah.Location = New System.Drawing.Point(140, 230) : Me.btnTambah.Size = New System.Drawing.Size(70, 27) : Me.btnTambah.Text = "Tambah"
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 153, 0) : Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnEdit.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.btnEdit.ForeColor = System.Drawing.Color.White : Me.btnEdit.Location = New System.Drawing.Point(218, 230) : Me.btnEdit.Size = New System.Drawing.Size(60, 27) : Me.btnEdit.Text = "Edit"
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(192, 0, 0) : Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnHapus.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.btnHapus.ForeColor = System.Drawing.Color.White : Me.btnHapus.Location = New System.Drawing.Point(286, 230) : Me.btnHapus.Size = New System.Drawing.Size(60, 27) : Me.btnHapus.Text = "Hapus"
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 128, 0) : Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnSimpan.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.btnSimpan.ForeColor = System.Drawing.Color.White : Me.btnSimpan.Location = New System.Drawing.Point(354, 230) : Me.btnSimpan.Size = New System.Drawing.Size(65, 27) : Me.btnSimpan.Text = "Simpan"

        ' lblDaftar
        Me.lblDaftar.AutoSize = True : Me.lblDaftar.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.lblDaftar.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100) : Me.lblDaftar.Location = New System.Drawing.Point(10, 272) : Me.lblDaftar.Text = "Kendaraan terdaftar langganan:"

        ' dgvLangganan
        Me.dgvLangganan.AllowUserToAddRows = False : Me.dgvLangganan.AllowUserToDeleteRows = False : Me.dgvLangganan.BackgroundColor = System.Drawing.Color.White : Me.dgvLangganan.Location = New System.Drawing.Point(10, 292) : Me.dgvLangganan.Name = "dgvLangganan" : Me.dgvLangganan.ReadOnly = True : Me.dgvLangganan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect : Me.dgvLangganan.Size = New System.Drawing.Size(680, 200) : Me.dgvLangganan.MultiSelect = False

        ' btnTutup
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(100, 100, 100) : Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnTutup.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold) : Me.btnTutup.ForeColor = System.Drawing.Color.White : Me.btnTutup.Location = New System.Drawing.Point(600, 500) : Me.btnTutup.Size = New System.Drawing.Size(90, 28) : Me.btnTutup.Text = "Tutup"

        ' frmLangganan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 540)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblNama) : Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNoPlat) : Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.lblJenis) : Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.lblTarif) : Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.lblBerlaku) : Me.Controls.Add(Me.dtpBerlakuHingga)
        Me.Controls.Add(Me.lblIDPelanggan)
        Me.Controls.Add(Me.btnTambah) : Me.Controls.Add(Me.btnEdit) : Me.Controls.Add(Me.btnHapus) : Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblDaftar) : Me.Controls.Add(Me.dgvLangganan)
        Me.Controls.Add(Me.btnTutup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLangganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SIParkir - Langganan"
        CType(Me.dgvLangganan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblNoPlat As System.Windows.Forms.Label
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents lblTarif As System.Windows.Forms.Label
    Friend WithEvents lblBerlaku As System.Windows.Forms.Label
    Friend WithEvents lblIDPelanggan As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPlat As System.Windows.Forms.TextBox
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents txtTarif As System.Windows.Forms.TextBox
    Friend WithEvents dtpBerlakuHingga As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblDaftar As System.Windows.Forms.Label
    Friend WithEvents dgvLangganan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class

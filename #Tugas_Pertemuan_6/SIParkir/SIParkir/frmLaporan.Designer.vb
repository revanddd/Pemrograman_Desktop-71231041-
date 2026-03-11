<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLaporan
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
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.txtLaporan = New System.Windows.Forms.TextBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(200, 220, 245)
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(600, 38)
        Me.lblTitle.Text = "SIParkir - Laporan Pendapatan Parkir"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblPeriode
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Font = New System.Drawing.Font("Arial", 10)
        Me.lblPeriode.Location = New System.Drawing.Point(10, 55)
        Me.lblPeriode.Text = "Periode"

        ' cmbBulan
        Me.cmbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBulan.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbBulan.Location = New System.Drawing.Point(80, 52)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(130, 24)

        ' txtTahun
        Me.txtTahun.Font = New System.Drawing.Font("Arial", 10)
        Me.txtTahun.Location = New System.Drawing.Point(220, 52)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(70, 23)
        Me.txtTahun.MaxLength = 4

        ' btnTampilkan
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(46, 117, 182)
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(302, 50)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(100, 28)
        Me.btnTampilkan.Text = "Tampilkan!"

        ' lblLaporan
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblLaporan.Location = New System.Drawing.Point(10, 90)
        Me.lblLaporan.Text = "Laporan:"

        ' txtLaporan (placeholder)
        Me.txtLaporan.BackColor = System.Drawing.Color.FromArgb(248, 248, 248)
        Me.txtLaporan.Font = New System.Drawing.Font("Courier New", 9)
        Me.txtLaporan.Location = New System.Drawing.Point(10, 110)
        Me.txtLaporan.Multiline = True
        Me.txtLaporan.Name = "txtLaporan"
        Me.txtLaporan.ReadOnly = True
        Me.txtLaporan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLaporan.Size = New System.Drawing.Size(575, 340)
        Me.txtLaporan.WordWrap = False

        ' btnTutup
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(495, 460)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(90, 28)
        Me.btnTutup.Text = "Tutup"

        ' frmLaporan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPeriode)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.txtLaporan)
        Me.Controls.Add(Me.btnTutup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SIParkir - Laporan Pendapatan Parkir"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPeriode As System.Windows.Forms.Label
    Friend WithEvents cmbBulan As System.Windows.Forms.ComboBox
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents lblLaporan As System.Windows.Forms.Label
    Friend WithEvents txtLaporan As System.Windows.Forms.TextBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class

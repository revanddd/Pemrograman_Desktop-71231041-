<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        SplitContainer1 = New SplitContainer()
        tvDrive = New TreeView()
        ImageList1 = New ImageList(components)
        SplitContainer2 = New SplitContainer()
        LvMP3 = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        SplitContainer3 = New SplitContainer()
        lblYear = New Label()
        lblAlbum = New Label()
        lblArtist = New Label()
        lblTitle = New Label()
        lblTrack = New Label()
        lblMp3Editor = New Label()
        GroupBox1 = New GroupBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        lblDuration = New Label()
        lblPlaying = New Label()
        btnStop = New Button()
        btnPlay = New Button()
        lblTextDuration = New Label()
        lblTextPlaying = New Label()
        txtTrack = New TextBox()
        txtTitle = New TextBox()
        txtArtist = New TextBox()
        txtAlbum = New TextBox()
        txtYear = New TextBox()
        btnEdit = New Button()
        Timer1 = New Timer(components)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(875, 512)
        SplitContainer1.SplitterDistance = 236
        SplitContainer1.TabIndex = 0
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(236, 512)
        tvDrive.TabIndex = 0
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp")
        ImageList1.Images.SetKeyName(1, "folder.bmp")
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(LvMP3)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(SplitContainer3)
        SplitContainer2.Size = New Size(635, 512)
        SplitContainer2.SplitterDistance = 271
        SplitContainer2.TabIndex = 0
        ' 
        ' LvMP3
        ' 
        LvMP3.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        LvMP3.Dock = DockStyle.Fill
        LvMP3.GridLines = True
        LvMP3.Location = New Point(0, 0)
        LvMP3.Name = "LvMP3"
        LvMP3.Size = New Size(635, 271)
        LvMP3.SmallImageList = ImageList1
        LvMP3.TabIndex = 0
        LvMP3.UseCompatibleStateImageBehavior = False
        LvMP3.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        chName.Width = 200
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 100
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        chFileSize.Width = 100
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Last Modified"
        chLastModified.Width = 100
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        chLastAccessed.Width = 100
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        chCreatedDate.Width = 100
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        chAttributes.Width = 100
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(btnEdit)
        SplitContainer3.Panel1.Controls.Add(txtYear)
        SplitContainer3.Panel1.Controls.Add(txtAlbum)
        SplitContainer3.Panel1.Controls.Add(txtArtist)
        SplitContainer3.Panel1.Controls.Add(txtTitle)
        SplitContainer3.Panel1.Controls.Add(txtTrack)
        SplitContainer3.Panel1.Controls.Add(lblYear)
        SplitContainer3.Panel1.Controls.Add(lblAlbum)
        SplitContainer3.Panel1.Controls.Add(lblArtist)
        SplitContainer3.Panel1.Controls.Add(lblTitle)
        SplitContainer3.Panel1.Controls.Add(lblTrack)
        SplitContainer3.Panel1.Controls.Add(lblMp3Editor)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(GroupBox1)
        SplitContainer3.Size = New Size(635, 237)
        SplitContainer3.SplitterDistance = 393
        SplitContainer3.TabIndex = 0
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(26, 188)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 12
        lblYear.Text = "Year:"
        ' 
        ' lblAlbum
        ' 
        lblAlbum.AutoSize = True
        lblAlbum.Location = New Point(26, 155)
        lblAlbum.Name = "lblAlbum"
        lblAlbum.Size = New Size(46, 15)
        lblAlbum.TabIndex = 11
        lblAlbum.Text = "Album:"
        ' 
        ' lblArtist
        ' 
        lblArtist.AutoSize = True
        lblArtist.Location = New Point(26, 122)
        lblArtist.Name = "lblArtist"
        lblArtist.Size = New Size(38, 15)
        lblArtist.TabIndex = 10
        lblArtist.Text = "Artist:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(26, 89)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(32, 15)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Title:"
        ' 
        ' lblTrack
        ' 
        lblTrack.AutoSize = True
        lblTrack.Location = New Point(26, 56)
        lblTrack.Name = "lblTrack"
        lblTrack.Size = New Size(37, 15)
        lblTrack.TabIndex = 8
        lblTrack.Text = "Track:"
        ' 
        ' lblMp3Editor
        ' 
        lblMp3Editor.AutoSize = True
        lblMp3Editor.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblMp3Editor.Location = New Point(16, 12)
        lblMp3Editor.Name = "lblMp3Editor"
        lblMp3Editor.Size = New Size(157, 28)
        lblMp3Editor.TabIndex = 7
        lblMp3Editor.Text = "MP3 ID3 Editor"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(AxWindowsMediaPlayer1)
        GroupBox1.Controls.Add(lblDuration)
        GroupBox1.Controls.Add(lblPlaying)
        GroupBox1.Controls.Add(btnStop)
        GroupBox1.Controls.Add(btnPlay)
        GroupBox1.Controls.Add(lblTextDuration)
        GroupBox1.Controls.Add(lblTextPlaying)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(232, 231)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Preview"
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(20, 149)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(107, 55)
        AxWindowsMediaPlayer1.TabIndex = 6
        ' 
        ' lblDuration
        ' 
        lblDuration.AutoSize = True
        lblDuration.Location = New Point(93, 59)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(34, 15)
        lblDuration.TabIndex = 5
        lblDuration.Text = "00:00"
        ' 
        ' lblPlaying
        ' 
        lblPlaying.AutoSize = True
        lblPlaying.Location = New Point(93, 34)
        lblPlaying.Name = "lblPlaying"
        lblPlaying.Size = New Size(34, 15)
        lblPlaying.TabIndex = 4
        lblPlaying.Text = "00:00"
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(119, 93)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(75, 23)
        btnStop.TabIndex = 3
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' btnPlay
        ' 
        btnPlay.Location = New Point(20, 93)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(75, 23)
        btnPlay.TabIndex = 2
        btnPlay.Text = "Play"
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' lblTextDuration
        ' 
        lblTextDuration.AutoSize = True
        lblTextDuration.Location = New Point(20, 59)
        lblTextDuration.Name = "lblTextDuration"
        lblTextDuration.Size = New Size(56, 15)
        lblTextDuration.TabIndex = 1
        lblTextDuration.Text = "Duration:"
        ' 
        ' lblTextPlaying
        ' 
        lblTextPlaying.AutoSize = True
        lblTextPlaying.Location = New Point(20, 34)
        lblTextPlaying.Name = "lblTextPlaying"
        lblTextPlaying.Size = New Size(49, 15)
        lblTextPlaying.TabIndex = 0
        lblTextPlaying.Text = "Playing:"
        ' 
        ' txtTrack
        ' 
        txtTrack.Location = New Point(81, 54)
        txtTrack.Name = "txtTrack"
        txtTrack.Size = New Size(92, 23)
        txtTrack.TabIndex = 13
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(81, 83)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(265, 23)
        txtTitle.TabIndex = 14
        ' 
        ' txtArtist
        ' 
        txtArtist.Location = New Point(81, 119)
        txtArtist.Name = "txtArtist"
        txtArtist.Size = New Size(265, 23)
        txtArtist.TabIndex = 15
        ' 
        ' txtAlbum
        ' 
        txtAlbum.Location = New Point(81, 152)
        txtAlbum.Name = "txtAlbum"
        txtAlbum.Size = New Size(195, 23)
        txtAlbum.TabIndex = 16
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(81, 185)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(70, 23)
        txtYear.TabIndex = 17
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(292, 188)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(875, 512)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MP3TagEditor"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel1.PerformLayout()
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents LvMP3 As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPlaying As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblTextDuration As Label
    Friend WithEvents lblTextPlaying As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTrack As Label
    Friend WithEvents lblMp3Editor As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents Timer1 As Timer

End Class

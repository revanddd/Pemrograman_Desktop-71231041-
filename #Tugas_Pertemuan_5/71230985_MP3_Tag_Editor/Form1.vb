Imports System.IO
Imports ID3.ID3Info
Public Class Form1
    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop
        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function

    Private Sub GetDrives()
        tvDrive.Nodes.Clear()

        For Each Drive In DriveInfo.GetDrives
            If (Drive.IsReady) Then
                Dim dName As String = Drive.VolumeLabel
                If String.IsNullOrEmpty(dName) Then
                    dName = Drive.Name
                End If
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 0
                    .SelectedImageIndex = 0
                    .Text = dName
                    .Nodes.Add("")
                    .Tag = Drive.Name
                End With
                Call tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)
        Try
            For Each nFolder In di.GetDirectories()
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 1
                    .SelectedImageIndex = 1
                    .Tag = nFolder.FullName
                    .Text = nFolder.Name.ToString()
                    .Nodes.Add("")
                End With
                di = New DirectoryInfo(tNode.Tag)
                If (di.Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        LvMP3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        LvMP3.Items.Clear()
        LvMP3.BeginUpdate()
        For Each nFile As String In Directory.GetFiles(PathName)
            Dim sExtension As String = Path.GetExtension(nFile)
            sExtension = sExtension.ToLower
            Dim f As FileInfo = New FileInfo(nFile)
            Dim att As String = f.Attributes.ToString
            Dim size As String = f.Length.ToString
            Dim dibuat As String = f.CreationTime.ToString
            Dim akses As String = f.LastAccessTime.ToString
            Dim modi As String = f.LastWriteTime.ToString
            If (Trim(sExtension) = ".mp3" = True) Then
                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo
                If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If
                With LItem
                    .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(size))
                    .SubItems.Add(modi)
                    .SubItems.Add(akses)
                    .SubItems.Add(dibuat)
                    .SubItems.Add(att)
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With
                LvMP3.Items.Add(LItem)
            End If
        Next
        LvMP3.EndUpdate()
        For Each x As ColumnHeader In LvMP3.Columns
            x.Width = -2
        Next
    End Sub

    Private Sub tvDrive_BeforeExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDrives()
        LvMP3.Columns(0).Width = -2
    End Sub

    Private Sub lvMp3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvMP3.SelectedIndexChanged
        AxWindowsMediaPlayer1.settings.autoStart = False
        If LvMP3.SelectedItems.Count = 1 Then
            AxWindowsMediaPlayer1.URL = LvMP3.SelectedItems(0).Tag
            lblDuration.Text = AxWindowsMediaPlayer1.currentMedia.durationString
            btnPlay.Text = "Play"
            btnPlay.Enabled = True
            Dim file As ID3.ID3Info = New ID3.ID3Info(LvMP3.SelectedItems(0).Tag, True)
            txtTrack.Text = file.ID3v1Info.TrackNumber
            txtTitle.Text = file.ID3v1Info.Title
            txtArtist.Text = file.ID3v1Info.Artist
            txtAlbum.Text = file.ID3v1Info.Album
            txtYear.Text = file.ID3v1Info.Year
            file = Nothing
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblPlaying.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
        lblDuration.Text = AxWindowsMediaPlayer1.currentMedia.durationString
    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click

        If AxWindowsMediaPlayer1.URL <> "" Then
            If btnPlay.Text = "Play" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Timer1.Enabled = True
                btnPlay.Text = "Pause"
            ElseIf btnPlay.Text = "Pause" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                Timer1.Enabled = False
                btnPlay.Text = "Play"
            ElseIf btnPlay.Text = "Play" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Timer1.Enabled = True
                btnPlay.Text = "Pause"
            End If
            btnStop.Enabled = True
        End If
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Timer1.Enabled = False
            btnPlay.Text = "Play"
            lblPlaying.Text = "00:00"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            txtTrack.ReadOnly = False
            txtTitle.ReadOnly = False
            txtArtist.ReadOnly = False
            txtAlbum.ReadOnly = False
            txtYear.ReadOnly = False
            btnEdit.Text = "Save"
        Else
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Or
           AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or
           AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady Or
           AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                Timer1.Enabled = False
                btnPlay.Text = "Play"
                lblPlaying.Text = "00:00"
                AxWindowsMediaPlayer1.close()
                AxWindowsMediaPlayer1.URL = ""
            End If
            Try
                Dim file As ID3.ID3Info = New ID3.ID3Info(LvMP3.SelectedItems(0).Tag,
               True)
                file.ID3v1Info.TrackNumber = txtTrack.Text
                file.ID3v1Info.Title = txtTitle.Text
                file.ID3v1Info.Artist = txtArtist.Text
                file.ID3v1Info.Album = txtAlbum.Text
                file.ID3v1Info.Year = txtYear.Text
                file.Save()
            Catch ex As Exception
            Finally
                txtTrack.ReadOnly = True
                txtTitle.ReadOnly = True
                txtArtist.ReadOnly = True
                txtAlbum.ReadOnly = True
                txtYear.ReadOnly = True
            End Try
            btnEdit.Text = "Edit"
        End If
    End Sub

End Class

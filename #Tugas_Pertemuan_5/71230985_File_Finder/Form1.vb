Imports System.IO
Imports System.Net.WebRequestMethods
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
    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()
        For Each nFile As String In Directory.GetFiles(PathName,
       txtExtension.Text.Trim)
            Dim sExtension As String = Path.GetExtension(nFile)
            sExtension = sExtension.ToLower
            Dim f As FileInfo = New FileInfo(nFile)
            If (f.Attributes And FileAttributes.Hidden) = False Then
                Dim att As String = f.Attributes.ToString
                Dim size As String = f.Length.ToString
                Dim dibuat As String = f.CreationTime.ToString
                Dim akses As String = f.LastAccessTime.ToString
                Dim modi As String = f.LastWriteTime.ToString
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
                    .SubItems.Add(nFile)
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With
                lvFile.Items.Add(LItem)
            End If
        Next
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GetFiles2(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()
        Try
            With ToolStripProgressBar1
                .Maximum = My.Computer.FileSystem.GetFiles(PathName).Count
                .Minimum = 0
                .Step = 1
                .Value = 1
            End With
        Catch ua As UnauthorizedAccessException
        Catch ex As Exception
        End Try
        Try
            For Each nFile As String In Directory.GetFiles(PathName, txtExtension.Text, SearchOption.AllDirectories)
                If nFile.ToLower.Contains(cbFind.Text.ToLower) Then
                    ToolStripProgressBar1.PerformStep()
                    Dim sExtension As String = Path.GetExtension(nFile)
                    sExtension = sExtension.ToLower
                    Dim f As FileInfo = New FileInfo(nFile)
                    If (f.Attributes And FileAttributes.Hidden) = False Then
                        Dim att As String = f.Attributes.ToString
                        Dim size As String = f.Length.ToString
                        Dim dibuat As String = f.CreationTime.ToString
                        Dim akses As String = f.LastAccessTime.ToString
                        Dim modi As String = f.LastWriteTime.ToString
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
                            .SubItems.Add(nFile)
                            .ImageKey = sExtension
                            .Tag = Path.Combine(PathName, nFile)
                        End With
                        lvFile.Items.Add(LItem)
                    End If
                End If
            Next nFile
        Catch ua As UnauthorizedAccessException
            ToolStripProgressBar1.PerformStep()
        Catch ex As Exception
            ToolStripProgressBar1.PerformStep()
        End Try
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)
        Try
            For Each nFolder As DirectoryInfo In di.GetDirectories()
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

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
        For Each curDrive As DriveInfo In My.Computer.FileSystem.Drives
            If curDrive.DriveType = DriveType.Fixed Then
                Dim theFreeSpace As Long = curDrive.AvailableFreeSpace
                Label3.Text &= curDrive.VolumeLabel & " (" & curDrive.Name & ") Free " & FormatFileSize(theFreeSpace) & " - " & curDrive.DriveFormat & vbCrLf
            End If
        Next
    End Sub

    Private Sub tvDrive_BeforeExpand(sender As System.Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = e.Node.Tag
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        If ToolStripStatusLabel1.Text <> "Ready" And
       My.Computer.FileSystem.DirectoryExists(ToolStripStatusLabel1.Text) Then
            GetFiles2(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum
        Else
            MsgBox("Please select a drive/directory first from Tree View on the left side")
        End If
    End Sub

    Private Sub cbFind_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbFind.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub lvFile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvFile.DoubleClick
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenExecuteToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenAndSelectFileInFolderToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start("explorer.exe", "/select," & lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub CopyPathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyFullPathToClipboardToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(lvFile.SelectedItems(0).Tag)
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub CopyFolderPathToClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyFolderPathToClipboardToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(Path.GetDirectoryName(lvFile.SelectedItems(0).Tag))
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshFolderToolStripMenuItem.Click
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = "*.txt"
        sfd.FileName = "Export.txt"
        sfd.Filter = "Text File (*.txt) | *.txt"
        If sfd.ShowDialog = DialogResult.OK Then
            Using writer As New StreamWriter(sfd.FileName)
                writer.Write("Name,Extension,File Size,Last Modified,Last Accessed,File Created,Attributes,Full Path")
                writer.WriteLine()
                For Each item As ListViewItem In lvFile.Items
                    For index = 0 To item.SubItems.Count - 1
                        If index > 0 Then
                            writer.Write(",")
                        End If
                        writer.Write(item.SubItems(index).Text)
                    Next
                    writer.WriteLine()
                Next
            End Using
        End If
    End Sub

    Private Sub txtExtension_Leave(sender As System.Object, e As System.EventArgs) Handles txtExtension.Leave
        If ToolStripStatusLabel1.Text <> "Ready" Then
            GetFiles(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = 0
        End If
    End Sub

    Private Sub DeleteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFileToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Dim filePath As String = lvFile.SelectedItems(0).Tag

            If MsgBox("Yakin Hapus File?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteFile(filePath)
                    lvFile.Items.Remove(lvFile.SelectedItems(0))
                    MsgBox("File Berhasil Dihapus.")
                Catch ex As Exception
                    MsgBox("Error menghapus file.")
                End Try
            End If
        End If
    End Sub


    Private Sub RenameFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFileToolStripMenuItem.Click
        If lvFile.SelectedItems.Count = 1 Then
            Dim oldPath As String = lvFile.SelectedItems(0).Tag
            Dim folder As String = Path.GetDirectoryName(oldPath)
            Dim oldName As String = Path.GetFileName(oldPath)

            Dim newName As String = InputBox("Masukan nama file baru:", "Rename File", oldName)

            If newName <> "" Then
                Try
                    My.Computer.FileSystem.RenameFile(oldPath, newName)
                    lvFile.SelectedItems(0).SubItems(0).Text = Path.GetFileNameWithoutExtension(newName)
                    lvFile.SelectedItems(0).SubItems(1).Text = Path.GetExtension(newName)
                    lvFile.SelectedItems(0).Tag = Path.Combine(folder, newName)
                    MsgBox("Nama file berhasil diubah")
                Catch ex As Exception
                    MsgBox("Error penamaan file.")
                End Try
            End If
        End If
    End Sub


End Class
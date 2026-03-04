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
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        RefreshFolderToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenExecuteToolStripMenuItem = New ToolStripMenuItem()
        OpenAndSelectFileInFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyFullPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        lblFind = New Label()
        cbFind = New ComboBox()
        btnSearch = New Button()
        txtExtension = New TextBox()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        Panel2 = New Panel()
        Label3 = New Label()
        lblInfo = New Label()
        tvDrive = New TreeView()
        lvFile = New ListView()
        colName = New ColumnHeader()
        FileSize = New ColumnHeader()
        LastModified = New ColumnHeader()
        LastAccessed = New ColumnHeader()
        CreatedDate = New ColumnHeader()
        Attributes = New ColumnHeader()
        FullPath = New ColumnHeader()
        Extension = New ColumnHeader()
        DeleteFileToolStripMenuItem = New ToolStripMenuItem()
        RenameFileToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(283, 17)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(500, 16)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportToolStripMenuItem, RefreshFolderToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(209, 22)
        ExportToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshFolderToolStripMenuItem
        ' 
        RefreshFolderToolStripMenuItem.Name = "RefreshFolderToolStripMenuItem"
        RefreshFolderToolStripMenuItem.Size = New Size(209, 22)
        RefreshFolderToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(209, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(180, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp")
        ImageList1.Images.SetKeyName(1, "folder.bmp")
        ImageList1.Images.SetKeyName(2, "file.bmp")
        ImageList1.Images.SetKeyName(3, "exe.bmp")
        ImageList1.Images.SetKeyName(4, "image.ico")
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenExecuteToolStripMenuItem, OpenAndSelectFileInFolderToolStripMenuItem, CopyFullPathToClipboardToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem, DeleteFileToolStripMenuItem, RenameFileToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(235, 158)
        ' 
        ' OpenExecuteToolStripMenuItem
        ' 
        OpenExecuteToolStripMenuItem.Name = "OpenExecuteToolStripMenuItem"
        OpenExecuteToolStripMenuItem.Size = New Size(234, 22)
        OpenExecuteToolStripMenuItem.Text = "Open/Execute File"
        ' 
        ' OpenAndSelectFileInFolderToolStripMenuItem
        ' 
        OpenAndSelectFileInFolderToolStripMenuItem.Name = "OpenAndSelectFileInFolderToolStripMenuItem"
        OpenAndSelectFileInFolderToolStripMenuItem.Size = New Size(234, 22)
        OpenAndSelectFileInFolderToolStripMenuItem.Text = "Open and Select File in Folder"
        ' 
        ' CopyFullPathToClipboardToolStripMenuItem
        ' 
        CopyFullPathToClipboardToolStripMenuItem.Name = "CopyFullPathToClipboardToolStripMenuItem"
        CopyFullPathToClipboardToolStripMenuItem.Size = New Size(234, 22)
        CopyFullPathToClipboardToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(234, 22)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Copy Folder Path to Clipboard"
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(12, 8)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(33, 15)
        lblFind.TabIndex = 3
        lblFind.Text = "Find:"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(51, 5)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(602, 23)
        cbFind.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Dock = DockStyle.Right
        btnSearch.Location = New Point(726, 0)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(74, 34)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(659, 5)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(61, 23)
        txtExtension.TabIndex = 6
        txtExtension.Text = "*.*"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblFind)
        Panel1.Controls.Add(txtExtension)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(btnSearch)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 34)
        Panel1.TabIndex = 7
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 58)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel2)
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Size = New Size(800, 370)
        SplitContainer1.SplitterDistance = 245
        SplitContainer1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblInfo)
        Panel2.Location = New Point(0, 258)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(245, 112)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblInfo.Location = New Point(11, 8)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(121, 15)
        lblInfo.TabIndex = 0
        lblInfo.Text = "Free Fixed Disk Info:"
        ' 
        ' tvDrive
        ' 
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, -1)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(245, 264)
        tvDrive.TabIndex = 0
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {colName, FileSize, LastModified, LastAccessed, CreatedDate, Attributes, FullPath})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.Dock = DockStyle.Fill
        lvFile.GridLines = True
        lvFile.Location = New Point(0, 0)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(551, 370)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 0
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' colName
        ' 
        colName.Text = "Name"
        colName.Width = 200
        ' 
        ' FileSize
        ' 
        FileSize.Text = "File Size"
        FileSize.Width = 100
        ' 
        ' LastModified
        ' 
        LastModified.Text = "Last Modified"
        LastModified.Width = 100
        ' 
        ' LastAccessed
        ' 
        LastAccessed.Text = "Last Accessed"
        LastAccessed.Width = 100
        ' 
        ' CreatedDate
        ' 
        CreatedDate.Text = "Created Date"
        CreatedDate.Width = 100
        ' 
        ' Attributes
        ' 
        Attributes.Text = "Attributes"
        Attributes.Width = 100
        ' 
        ' FullPath
        ' 
        FullPath.Text = "Full Path"
        FullPath.Width = 100
        ' 
        ' Extension
        ' 
        Extension.Text = "Extension"
        ' 
        ' DeleteFileToolStripMenuItem
        ' 
        DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        DeleteFileToolStripMenuItem.Size = New Size(234, 22)
        DeleteFileToolStripMenuItem.Text = "Delete File"
        ' 
        ' RenameFileToolStripMenuItem
        ' 
        RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem"
        RenameFileToolStripMenuItem.Size = New Size(234, 22)
        RenameFileToolStripMenuItem.Text = "Rename File"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFinder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenExecuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAndSelectFileInFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFullPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFind As Label
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lvFile As ListView

    Friend WithEvents Extension As ColumnHeader
    Friend WithEvents FileSize As ColumnHeader
    Friend WithEvents LastModified As ColumnHeader
    Friend WithEvents LastAccessed As ColumnHeader
    Friend WithEvents CreatedDate As ColumnHeader
    Friend WithEvents Attributes As ColumnHeader
    Friend WithEvents FullPath As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameFileToolStripMenuItem As ToolStripMenuItem

End Class

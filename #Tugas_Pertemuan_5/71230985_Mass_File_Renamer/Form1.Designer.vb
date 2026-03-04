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
        txtPath = New TextBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lblPath = New Label()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cbCaseF = New ComboBox()
        txtRightCropNCharF = New TextBox()
        txtWithThisF = New TextBox()
        txtInsertAfterF = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertAfterF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        TabPage2 = New TabPage()
        cbCaseE = New ComboBox()
        rbReplaceWithE = New RadioButton()
        txtRightCropNCharE = New TextBox()
        rbReplaceThisE = New RadioButton()
        txtWithThisE = New TextBox()
        rbInsertBeforeE = New RadioButton()
        txtInsertAfterE = New TextBox()
        rbInsertAfterE = New RadioButton()
        txtLeftCropNCharE = New TextBox()
        rbLeftCropNCharE = New RadioButton()
        txtInsertBeforeE = New TextBox()
        rbRightCropNCharE = New RadioButton()
        txtReplaceThisE = New TextBox()
        lblCaseE = New Label()
        txtReplaceWithE = New TextBox()
        lblWithThisE = New Label()
        TabPage3 = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnUndo = New Button()
        btnRename = New Button()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(63, 23)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(531, 23)
        txtPath.TabIndex = 0
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(20, 26)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(34, 15)
        lblPath.TabIndex = 1
        lblPath.Text = "Path:"
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(602, 23)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(63, 23)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(671, 27)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(59, 15)
        lblExt.TabIndex = 3
        lblExt.Text = "File Mask:"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(731, 23)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(70, 23)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(20, 56)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(73, 15)
        lblOri.TabIndex = 5
        lblOri.Text = "Original File:"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(417, 56)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(72, 15)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File:"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.Location = New Point(20, 79)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(388, 264)
        lvOri.SmallImageList = ImageList1
        lvOri.TabIndex = 7
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(413, 79)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(388, 264)
        lvPreview.SmallImageList = ImageList1
        lvPreview.TabIndex = 8
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 349)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(707, 159)
        TabControl1.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cbCaseF)
        TabPage1.Controls.Add(txtRightCropNCharF)
        TabPage1.Controls.Add(txtWithThisF)
        TabPage1.Controls.Add(txtInsertAfterF)
        TabPage1.Controls.Add(txtLeftCropNCharF)
        TabPage1.Controls.Add(txtInsertBeforeF)
        TabPage1.Controls.Add(txtReplaceThisF)
        TabPage1.Controls.Add(txtReplaceWithF)
        TabPage1.Controls.Add(lblWithThisF)
        TabPage1.Controls.Add(lblCaseF)
        TabPage1.Controls.Add(rbRightCropNCharF)
        TabPage1.Controls.Add(rbLeftCropNCharF)
        TabPage1.Controls.Add(rbInsertAfterF)
        TabPage1.Controls.Add(rbInsertBeforeF)
        TabPage1.Controls.Add(rbReplaceThisF)
        TabPage1.Controls.Add(rbReplaceWithF)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(699, 131)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Filename"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPERCASE", "No Change"})
        cbCaseF.Location = New Point(494, 11)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(189, 23)
        cbCaseF.TabIndex = 15
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(501, 100)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(148, 23)
        txtRightCropNCharF.TabIndex = 14
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(461, 42)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(222, 23)
        txtWithThisF.TabIndex = 13
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(461, 71)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(222, 23)
        txtInsertAfterF.TabIndex = 12
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(126, 98)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(99, 23)
        txtLeftCropNCharF.TabIndex = 11
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(126, 69)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(239, 23)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(126, 40)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(265, 23)
        txtReplaceThisF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(126, 11)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(320, 23)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(400, 45)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(57, 15)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "With this:"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(453, 15)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(35, 15)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case:"
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(374, 101)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(121, 19)
        rbRightCropNCharF.TabIndex = 5
        rbRightCropNCharF.Text = "Right Crop n char:"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(10, 102)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(113, 19)
        rbLeftCropNCharF.TabIndex = 4
        rbLeftCropNCharF.Text = "Left Crop n char:"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(375, 72)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(86, 19)
        rbInsertAfterF.TabIndex = 3
        rbInsertAfterF.Text = "Insert After:"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(10, 74)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(94, 19)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.Text = "Insert Before:"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(11, 43)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(93, 19)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.Text = "Replace This:"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Checked = True
        rbReplaceWithF.Location = New Point(11, 13)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(97, 19)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With:"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(cbCaseE)
        TabPage2.Controls.Add(rbReplaceWithE)
        TabPage2.Controls.Add(txtRightCropNCharE)
        TabPage2.Controls.Add(rbReplaceThisE)
        TabPage2.Controls.Add(txtWithThisE)
        TabPage2.Controls.Add(rbInsertBeforeE)
        TabPage2.Controls.Add(txtInsertAfterE)
        TabPage2.Controls.Add(rbInsertAfterE)
        TabPage2.Controls.Add(txtLeftCropNCharE)
        TabPage2.Controls.Add(rbLeftCropNCharE)
        TabPage2.Controls.Add(txtInsertBeforeE)
        TabPage2.Controls.Add(rbRightCropNCharE)
        TabPage2.Controls.Add(txtReplaceThisE)
        TabPage2.Controls.Add(lblCaseE)
        TabPage2.Controls.Add(txtReplaceWithE)
        TabPage2.Controls.Add(lblWithThisE)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(699, 131)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Extension"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPERCASE", "No Change"})
        cbCaseE.Location = New Point(494, 11)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(189, 23)
        cbCaseE.TabIndex = 31
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Checked = True
        rbReplaceWithE.Location = New Point(11, 13)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(97, 19)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace With:"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(501, 100)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(148, 23)
        txtRightCropNCharE.TabIndex = 30
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(11, 43)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(93, 19)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.Text = "Replace This:"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(461, 42)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(222, 23)
        txtWithThisE.TabIndex = 29
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(10, 74)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(94, 19)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.Text = "Insert Before:"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(461, 71)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(222, 23)
        txtInsertAfterE.TabIndex = 28
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(375, 72)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(86, 19)
        rbInsertAfterE.TabIndex = 19
        rbInsertAfterE.Text = "Insert After:"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(126, 98)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(99, 23)
        txtLeftCropNCharE.TabIndex = 27
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(10, 102)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(113, 19)
        rbLeftCropNCharE.TabIndex = 20
        rbLeftCropNCharE.Text = "Left Crop n char:"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(126, 69)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(239, 23)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(374, 101)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(121, 19)
        rbRightCropNCharE.TabIndex = 21
        rbRightCropNCharE.Text = "Right Crop n char:"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(126, 40)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(265, 23)
        txtReplaceThisE.TabIndex = 25
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(453, 15)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(35, 15)
        lblCaseE.TabIndex = 22
        lblCaseE.Text = "Case:"
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(126, 11)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(320, 23)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(400, 45)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(57, 15)
        lblWithThisE.TabIndex = 23
        lblWithThisE.Text = "With this:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(gbWith)
        TabPage3.Controls.Add(gbPlace)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(699, 131)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Autonumber"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(187, 11)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(309, 111)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With:"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(128, 69)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(120, 23)
        nudIncrementBy.TabIndex = 3
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(128, 33)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(120, 23)
        nudStartWithNumber.TabIndex = 2
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(17, 73)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(80, 15)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(17, 36)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(105, 15)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start with number:"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(10, 11)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(165, 111)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(20, 69)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(108, 19)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(20, 36)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(108, 19)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "Before filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(725, 367)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(725, 430)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(75, 23)
        btnUndo.TabIndex = 11
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(725, 399)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(75, 23)
        btnRename.TabIndex = 12
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 513)
        Controls.Add(btnRename)
        Controls.Add(btnUndo)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(lblPath)
        Controls.Add(txtPath)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents ImageList1 As ImageList

End Class

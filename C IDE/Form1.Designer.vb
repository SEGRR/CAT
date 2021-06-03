<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolBar = New System.Windows.Forms.MenuStrip()
        Me.filesTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDirectory = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideherracyOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFIleTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunPreviewBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Herracy = New System.Windows.Forms.TreeView()
        Me.directoryOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDirectoryMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollapseOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideHerracy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.closeTabContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolBar.SuspendLayout()
        Me.directoryOptions.SuspendLayout()
        Me.tabOptions.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filesTool, Me.SaveTool, Me.NewFIleTool, Me.BuildTool, Me.RunTool, Me.RunPreviewBox})
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolBar.Size = New System.Drawing.Size(1047, 31)
        Me.ToolBar.TabIndex = 0
        Me.ToolBar.Text = "MenuStrip1"
        '
        'filesTool
        '
        Me.filesTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.filesTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.filesTool.CheckOnClick = True
        Me.filesTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectory, Me.OpenFile, Me.NewFile, Me.Save, Me.settings})
        Me.filesTool.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filesTool.Image = CType(resources.GetObject("filesTool.Image"), System.Drawing.Image)
        Me.filesTool.Name = "filesTool"
        Me.filesTool.Size = New System.Drawing.Size(34, 27)
        Me.filesTool.ToolTipText = "Files"
        '
        'OpenDirectory
        '
        Me.OpenDirectory.BackColor = System.Drawing.SystemColors.MenuBar
        Me.OpenDirectory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OpenDirectory.Image = CType(resources.GetObject("OpenDirectory.Image"), System.Drawing.Image)
        Me.OpenDirectory.Name = "OpenDirectory"
        Me.OpenDirectory.Size = New System.Drawing.Size(199, 26)
        Me.OpenDirectory.Text = "Open Directory"
        '
        'OpenFile
        '
        Me.OpenFile.BackColor = System.Drawing.SystemColors.MenuBar
        Me.OpenFile.CheckOnClick = True
        Me.OpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OpenFile.Image = CType(resources.GetObject("OpenFile.Image"), System.Drawing.Image)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Padding = New System.Windows.Forms.Padding(1)
        Me.OpenFile.Size = New System.Drawing.Size(201, 26)
        Me.OpenFile.Text = "Open FIles"
        '
        'NewFile
        '
        Me.NewFile.BackColor = System.Drawing.SystemColors.MenuBar
        Me.NewFile.ForeColor = System.Drawing.Color.Black
        Me.NewFile.Image = CType(resources.GetObject("NewFile.Image"), System.Drawing.Image)
        Me.NewFile.Name = "NewFile"
        Me.NewFile.Size = New System.Drawing.Size(199, 26)
        Me.NewFile.Text = "New File"
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Save.ForeColor = System.Drawing.Color.Black
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(199, 26)
        Me.Save.Text = "Save"
        '
        'settings
        '
        Me.settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hideherracyOption, Me.quit})
        Me.settings.Image = CType(resources.GetObject("settings.Image"), System.Drawing.Image)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(199, 26)
        Me.settings.Text = "Options "
        '
        'hideherracyOption
        '
        Me.hideherracyOption.Name = "hideherracyOption"
        Me.hideherracyOption.Size = New System.Drawing.Size(182, 26)
        Me.hideherracyOption.Text = "Hide Herracy"
        '
        'quit
        '
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(182, 26)
        Me.quit.Text = "Quit"
        '
        'SaveTool
        '
        Me.SaveTool.BackColor = System.Drawing.SystemColors.Menu
        Me.SaveTool.Image = CType(resources.GetObject("SaveTool.Image"), System.Drawing.Image)
        Me.SaveTool.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaveTool.Name = "SaveTool"
        Me.SaveTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTool.Size = New System.Drawing.Size(34, 27)
        Me.SaveTool.ToolTipText = "Save file (cltr+s)"
        '
        'NewFIleTool
        '
        Me.NewFIleTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.NewFIleTool.Image = CType(resources.GetObject("NewFIleTool.Image"), System.Drawing.Image)
        Me.NewFIleTool.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NewFIleTool.Name = "NewFIleTool"
        Me.NewFIleTool.Size = New System.Drawing.Size(34, 27)
        '
        'BuildTool
        '
        Me.BuildTool.AutoToolTip = True
        Me.BuildTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BuildTool.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.BuildTool.Image = CType(resources.GetObject("BuildTool.Image"), System.Drawing.Image)
        Me.BuildTool.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BuildTool.Name = "BuildTool"
        Me.BuildTool.Size = New System.Drawing.Size(34, 27)
        Me.BuildTool.ToolTipText = "Build your file (Shift + F6)"
        '
        'RunTool
        '
        Me.RunTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RunTool.Image = CType(resources.GetObject("RunTool.Image"), System.Drawing.Image)
        Me.RunTool.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.RunTool.Name = "RunTool"
        Me.RunTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.RunTool.Size = New System.Drawing.Size(34, 27)
        Me.RunTool.ToolTipText = "Build + Run " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Alt+F1)"
        '
        'RunPreviewBox
        '
        Me.RunPreviewBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RunPreviewBox.Margin = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.RunPreviewBox.Name = "RunPreviewBox"
        Me.RunPreviewBox.ReadOnly = True
        Me.RunPreviewBox.Size = New System.Drawing.Size(150, 27)
        '
        'Herracy
        '
        Me.Herracy.BackColor = System.Drawing.SystemColors.Window
        Me.Herracy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Herracy.ContextMenuStrip = Me.directoryOptions
        Me.Herracy.Dock = System.Windows.Forms.DockStyle.Left
        Me.Herracy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Herracy.HideSelection = False
        Me.Herracy.ImageIndex = 0
        Me.Herracy.ImageList = Me.ImageList1
        Me.Herracy.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.Herracy.ItemHeight = 30
        Me.Herracy.LineColor = System.Drawing.Color.Red
        Me.Herracy.Location = New System.Drawing.Point(0, 31)
        Me.Herracy.Name = "Herracy"
        Me.Herracy.SelectedImageKey = "c++.png"
        Me.Herracy.ShowLines = False
        Me.Herracy.Size = New System.Drawing.Size(175, 584)
        Me.Herracy.TabIndex = 2
        '
        'directoryOptions
        '
        Me.directoryOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.directoryOptions.DropShadowEnabled = False
        Me.directoryOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.directoryOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectoryMenuStrip, Me.ExpandOption, Me.CollapseOption, Me.HideHerracy})
        Me.directoryOptions.Name = "ContextMenuStrip1"
        Me.directoryOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.directoryOptions.Size = New System.Drawing.Size(178, 100)
        '
        'OpenDirectoryMenuStrip
        '
        Me.OpenDirectoryMenuStrip.Name = "OpenDirectoryMenuStrip"
        Me.OpenDirectoryMenuStrip.Size = New System.Drawing.Size(177, 24)
        Me.OpenDirectoryMenuStrip.Text = "open Directory"
        '
        'ExpandOption
        '
        Me.ExpandOption.Name = "ExpandOption"
        Me.ExpandOption.Size = New System.Drawing.Size(177, 24)
        Me.ExpandOption.Text = "Expand"
        '
        'CollapseOption
        '
        Me.CollapseOption.Name = "CollapseOption"
        Me.CollapseOption.Size = New System.Drawing.Size(177, 24)
        Me.CollapseOption.Text = "Collapse "
        '
        'HideHerracy
        '
        Me.HideHerracy.Name = "HideHerracy"
        Me.HideHerracy.Size = New System.Drawing.Size(177, 24)
        Me.HideHerracy.Text = "Hide "
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "c++.png")
        Me.ImageList1.Images.SetKeyName(1, "java.png")
        Me.ImageList1.Images.SetKeyName(2, "html.png")
        Me.ImageList1.Images.SetKeyName(3, "javascript.png")
        Me.ImageList1.Images.SetKeyName(4, "json.png")
        Me.ImageList1.Images.SetKeyName(5, "txt.png")
        Me.ImageList1.Images.SetKeyName(6, "python.png")
        Me.ImageList1.Images.SetKeyName(7, "directory.png")
        Me.ImageList1.Images.SetKeyName(8, "c.png")
        Me.ImageList1.Images.SetKeyName(9, "exe.png")
        Me.ImageList1.Images.SetKeyName(10, "unknown.png")
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.tabOptions
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(175, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(872, 584)
        Me.TabControl1.TabIndex = 3
        '
        'tabOptions
        '
        Me.tabOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tabOptions.DropShadowEnabled = False
        Me.tabOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tabOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closeTabContextMenuItem})
        Me.tabOptions.Name = "ContextMenuStrip1"
        Me.tabOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tabOptions.ShowImageMargin = False
        Me.tabOptions.Size = New System.Drawing.Size(107, 28)
        '
        'closeTabContextMenuItem
        '
        Me.closeTabContextMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.closeTabContextMenuItem.Name = "closeTabContextMenuItem"
        Me.closeTabContextMenuItem.ShortcutKeyDisplayString = ""
        Me.closeTabContextMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.closeTabContextMenuItem.ShowShortcutKeys = False
        Me.closeTabContextMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.closeTabContextMenuItem.Text = "Close tab"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Title = "Open Files"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Title = "Save File"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "TIp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1047, 615)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Herracy)
        Me.Controls.Add(Me.ToolBar)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ToolBar
        Me.Name = "Form1"
        Me.Text = "CAT"
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.directoryOptions.ResumeLayout(False)
        Me.tabOptions.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolBar As MenuStrip
    Friend WithEvents filesTool As ToolStripMenuItem
    Friend WithEvents OpenFile As ToolStripMenuItem
    Friend WithEvents NewFile As ToolStripMenuItem
    Friend WithEvents Save As ToolStripMenuItem
    Friend WithEvents SaveTool As ToolStripMenuItem
    Friend WithEvents Herracy As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents NewFIleTool As ToolStripMenuItem
    Friend WithEvents RunPreviewBox As ToolStripTextBox
    Friend WithEvents RunTool As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenDirectory As ToolStripMenuItem
    Friend WithEvents BuildTool As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents closeTabContextMenuItem As ToolStripMenuItem
    Public WithEvents tabOptions As ContextMenuStrip
    Public WithEvents directoryOptions As ContextMenuStrip
    Friend WithEvents ExpandOption As ToolStripMenuItem
    Friend WithEvents CollapseOption As ToolStripMenuItem
    Friend WithEvents OpenDirectoryMenuStrip As ToolStripMenuItem
    Friend WithEvents HideHerracy As ToolStripMenuItem
    Friend WithEvents settings As ToolStripMenuItem
    Friend WithEvents hideherracyOption As ToolStripMenuItem
    Friend WithEvents quit As ToolStripMenuItem
End Class

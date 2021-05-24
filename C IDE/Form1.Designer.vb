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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFIleTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunPreviewBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Herracy = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolBar.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.filesTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectory, Me.OpenFile, Me.NewFile, Me.ToolStripSeparator1, Me.Save, Me.Settings})
        Me.filesTool.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filesTool.Image = CType(resources.GetObject("filesTool.Image"), System.Drawing.Image)
        Me.filesTool.Name = "filesTool"
        Me.filesTool.Size = New System.Drawing.Size(34, 27)
        Me.filesTool.ToolTipText = "Files"
        '
        'OpenDirectory
        '
        Me.OpenDirectory.Image = CType(resources.GetObject("OpenDirectory.Image"), System.Drawing.Image)
        Me.OpenDirectory.Name = "OpenDirectory"
        Me.OpenDirectory.Size = New System.Drawing.Size(199, 26)
        Me.OpenDirectory.Text = "Open Directory"
        '
        'OpenFile
        '
        Me.OpenFile.CheckOnClick = True
        Me.OpenFile.Image = CType(resources.GetObject("OpenFile.Image"), System.Drawing.Image)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Padding = New System.Windows.Forms.Padding(1)
        Me.OpenFile.Size = New System.Drawing.Size(201, 26)
        Me.OpenFile.Text = "Open FIles"
        '
        'NewFile
        '
        Me.NewFile.Image = CType(resources.GetObject("NewFile.Image"), System.Drawing.Image)
        Me.NewFile.Name = "NewFile"
        Me.NewFile.Size = New System.Drawing.Size(199, 26)
        Me.NewFile.Text = "New File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'Save
        '
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(199, 26)
        Me.Save.Text = "Save"
        '
        'Settings
        '
        Me.Settings.Image = CType(resources.GetObject("Settings.Image"), System.Drawing.Image)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(199, 26)
        Me.Settings.Text = "Settings"
        '
        'SaveTool
        '
        Me.SaveTool.BackColor = System.Drawing.SystemColors.MenuBar
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
        Me.BuildTool.BackColor = System.Drawing.Color.White
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
        Me.RunTool.Size = New System.Drawing.Size(34, 27)
        '
        'RunPreviewBox
        '
        Me.RunPreviewBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RunPreviewBox.Margin = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.RunPreviewBox.Name = "RunPreviewBox"
        Me.RunPreviewBox.ReadOnly = True
        Me.RunPreviewBox.Size = New System.Drawing.Size(150, 27)
        '
        'Herracy
        '
        Me.Herracy.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Herracy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Herracy.CheckBoxes = True
        Me.Herracy.Dock = System.Windows.Forms.DockStyle.Left
        Me.Herracy.LineColor = System.Drawing.Color.SandyBrown
        Me.Herracy.Location = New System.Drawing.Point(0, 31)
        Me.Herracy.Name = "Herracy"
        Me.Herracy.Size = New System.Drawing.Size(151, 584)
        Me.Herracy.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(151, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(896, 584)
        Me.TabControl1.TabIndex = 3
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolBar As MenuStrip
    Friend WithEvents filesTool As ToolStripMenuItem
    Friend WithEvents OpenFile As ToolStripMenuItem
    Friend WithEvents NewFile As ToolStripMenuItem
    Friend WithEvents Save As ToolStripMenuItem
    Friend WithEvents Settings As ToolStripMenuItem
    Friend WithEvents SaveTool As ToolStripMenuItem
    Friend WithEvents Herracy As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewFIleTool As ToolStripMenuItem
    Friend WithEvents RunPreviewBox As ToolStripTextBox
    Friend WithEvents RunTool As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenDirectory As ToolStripMenuItem
    Friend WithEvents BuildTool As ToolStripMenuItem
End Class

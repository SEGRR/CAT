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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolBar = New System.Windows.Forms.MenuStrip()
        Me.filesTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.Herracy = New System.Windows.Forms.ListBox()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.BackColor = System.Drawing.SystemColors.Highlight
        Me.ToolBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filesTool, Me.SaveTool})
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(1047, 28)
        Me.ToolBar.TabIndex = 0
        Me.ToolBar.Text = "MenuStrip1"
        '
        'filesTool
        '
        Me.filesTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.filesTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.filesTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFile, Me.NewFile, Me.Save, Me.Settings})
        Me.filesTool.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filesTool.Image = CType(resources.GetObject("filesTool.Image"), System.Drawing.Image)
        Me.filesTool.Name = "filesTool"
        Me.filesTool.Size = New System.Drawing.Size(74, 24)
        Me.filesTool.Text = "Files"
        '
        'OpenFile
        '
        Me.OpenFile.CheckOnClick = True
        Me.OpenFile.Image = CType(resources.GetObject("OpenFile.Image"), System.Drawing.Image)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Padding = New System.Windows.Forms.Padding(1)
        Me.OpenFile.Size = New System.Drawing.Size(167, 26)
        Me.OpenFile.Text = "Open FIles"
        '
        'NewFile
        '
        Me.NewFile.Image = CType(resources.GetObject("NewFile.Image"), System.Drawing.Image)
        Me.NewFile.Name = "NewFile"
        Me.NewFile.Size = New System.Drawing.Size(165, 26)
        Me.NewFile.Text = "New File"
        '
        'Save
        '
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(165, 26)
        Me.Save.Text = "Save"
        '
        'Settings
        '
        Me.Settings.Image = CType(resources.GetObject("Settings.Image"), System.Drawing.Image)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(165, 26)
        Me.Settings.Text = "Settings"
        '
        'SaveTool
        '
        Me.SaveTool.BackColor = System.Drawing.SystemColors.MenuBar
        Me.SaveTool.Image = CType(resources.GetObject("SaveTool.Image"), System.Drawing.Image)
        Me.SaveTool.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaveTool.Name = "SaveTool"
        Me.SaveTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTool.Size = New System.Drawing.Size(34, 24)
        Me.SaveTool.ToolTipText = "Save file (cltr+s)"
        '
        'Herracy
        '
        Me.Herracy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Herracy.BackColor = System.Drawing.SystemColors.Menu
        Me.Herracy.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Herracy.FormattingEnabled = True
        Me.Herracy.ItemHeight = 23
        Me.Herracy.Items.AddRange(New Object() {"hello.c", "arrays.c", "Gproject.c"})
        Me.Herracy.Location = New System.Drawing.Point(0, 51)
        Me.Herracy.Name = "Herracy"
        Me.Herracy.ScrollAlwaysVisible = True
        Me.Herracy.Size = New System.Drawing.Size(192, 556)
        Me.Herracy.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1047, 615)
        Me.Controls.Add(Me.Herracy)
        Me.Controls.Add(Me.ToolBar)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MainMenuStrip = Me.ToolBar
        Me.Name = "Form1"
        Me.Text = "C-AT"
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
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
    Friend WithEvents Herracy As ListBox
End Class

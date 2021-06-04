Imports System.IO

Public Class Form1

    Dim OpenTabs As List(Of TabWizard) = New List(Of TabWizard)
    Dim OpenDirectories As List(Of FileHandler) = New List(Of FileHandler)
    Dim OpenFIles As List(Of FileInfo) = New List(Of FileInfo)

    Private Sub newFile_creator(sender As Object, e As EventArgs) Handles NewFIleTool.Click, OpenFile.Click

        OpenFileDialog.Title = " New File "

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filename = OpenFileDialog.FileName
            ' MsgBox(filename)
            Dim fileinfo = New FileInfo(filename)
            Dim newtab As TabWizard = New TabWizard(fileinfo.Name, fileinfo)
            TabControl1.TabPages.Add(newtab.tab_page)

            TabControl1.SelectedTab = newtab.tab_page

            RunPreviewBox.Text = fileinfo.FullName

            TabControl1.SelectedTab.ContextMenuStrip = tabOptions

            TabControl1.SelectedTab.ImageIndex = getImageIndex(fileinfo.Extension)

            newtab.CreateAndLoadTextBox()

            OpenTabs.Add(newtab)
        End If


    End Sub

    Function Findfileinfo(ByVal findThisFile As String) As FileInfo

        Dim a As TabWizard

        If OpenTabs.Count() = 0 Then
            ErrorProvider1.SetError(TabControl1, "No file Selected ")
            Return Nothing
        End If

        For Each a In OpenTabs

            If (a.filename.Equals(findThisFile)) Then
                Return a.fileinfo
            End If
        Next
        Return Nothing
    End Function


    Private Sub SaveTool_Clicked(sender As Object, e As EventArgs) Handles SaveTool.Click

        Dim selectedTab = TabControl1.SelectedTab.Text

        For Each tabs As TabWizard In OpenTabs
            If tabs.filename.Equals(selectedTab) Then
                tabs.SaveFile()
                Exit For
            End If
        Next

        MessageBox.Show("File Saved Succcessfuly")


    End Sub


    Private Sub RunProgram(sender As Object, e As EventArgs) Handles RunTool.Click

        If OpenTabs.Count = 0 Or RunPreviewBox.Text Is Nothing Then
            MessageBox.Show("No Files are selected to Run , Open a file First by double Clicking File name in the Herracy ", "No file Found ", MessageBoxButtons.OK)
        Else
            Dim fileName As String = TabControl1.SelectedTab.Text
            Dim fileInformation As FileInfo = Findfileinfo(fileName)
            If fileInformation Is Nothing Then
                fileInformation = New FileInfo(RunPreviewBox.Text)
            End If
            Dim filePath As String = fileInformation.FullName
            Dim filenameWithoutExtention = fileInformation.Name.Replace(".cpp", "")

            Dim command = commandbuilder(fileInformation, fileInformation.Extension)
            RunPreviewBox.Text = fileInformation.FullName

            Shell(command, AppWinStyle.NormalFocus)

        End If


    End Sub

    Private Function commandbuilder(ByVal fileinfo As FileInfo, ByVal ext As String) As String

        Dim fileNameWithoutExtention = fileinfo.Name.Replace(fileinfo.Extension, "")

        Select Case ext
            Case ".cpp"
                Return "PowerShell  cd '" + fileinfo.DirectoryName + "' ; g++ " + fileinfo.Name + " -o " + fileNameWithoutExtention + " ; " + "start " + fileNameWithoutExtention + ".exe"
            Case ".java"
                Return "PowerShell -NoExit cd '" + fileinfo.DirectoryName + "' ; javac " + fileinfo.Name + "; java " + fileNameWithoutExtention
            Case ".html"
                Return "PowerShell cd '" + fileinfo.DirectoryName + "' ; start " + fileinfo.Name
            Case ".c"
                Return "PowerShell cd '" + fileinfo.DirectoryName + "' ; gcc " + fileinfo.Name + " -o " + fileNameWithoutExtention + " ; " + " start " + fileNameWithoutExtention + ".exe"
            Case Else
                Return "PowerShell -NoExit  echo 'Cant Run this type of file '"
        End Select

    End Function







    Private Sub ss(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        If OpenTabs.Count = 0 Then
            e.Cancel = False
        Else

            Dim unsavedTabs As List(Of TabWizard) = New List(Of TabWizard)
            Dim tabs As TabWizard
            Dim anyUnsavedFile As Boolean = False
            For Each tabs In OpenTabs

                If Not tabs.IsSaved Then
                    unsavedTabs.Add(tabs)
                    anyUnsavedFile = True
                End If
            Next

            ' Dim FileNames As String = ""
            ' For Each tabs In unsavedTabs
            ' FileNames.Append(tabs.filename).Append(" ,")
            ' Next
            If anyUnsavedFile Then
                Dim result = MessageBox.Show("Do you want save Them ", "Some Files  are not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    For Each tabs In unsavedTabs
                        tabs.SaveFileWithoutMessage()
                    Next
                    e.Cancel = False
                ElseIf result = DialogResult.Cancel Then
                    e.Cancel = True
                ElseIf result = DialogResult.No Then
                    e.Cancel = False
                End If
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Open_Directory_click(sender As Object, e As EventArgs) Handles OpenDirectory.Click, OpenDirectoryMenuStrip.Click


        FolderBrowserDialog1.Description = "open A directory"
        FolderBrowserDialog1.ShowNewFolderButton = True
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then



            'ReDim OpenDirectories(OpenDirectories.Length + 1)

            Dim directoryPath = FolderBrowserDialog1.SelectedPath

            Dim NewDirectory As FileHandler = New FileHandler(directoryPath)

            NewDirectory.CreateTreeView(Herracy)
            ' Controls.Add(Herracy)
            Herracy.SelectedNode = Herracy.Nodes(0)
            OpenDirectories.Add(NewDirectory)
        End If
    End Sub

    Private Sub get_file_to_tabs(sender As Object, e As EventArgs) Handles Herracy.NodeMouseDoubleClick

        Dim selectedFile = Herracy.SelectedNode.Text
        Dim Directory As FileHandler
        Dim fileinfo As FileInfo

        For Each Directory In OpenDirectories

            fileinfo = Directory.findFile(selectedFile)

            If fileinfo IsNot Nothing Then
                Exit For
            End If


        Next


        Dim NewTab As TabWizard

        NewTab = New TabWizard(selectedFile, fileinfo)

        TabControl1.TabPages.Add(NewTab.tab_page)

        TabControl1.SelectedTab = NewTab.tab_page

        RunPreviewBox.Text = fileinfo.FullName

        TabControl1.SelectedTab.ContextMenuStrip = tabOptions

        TabControl1.SelectedTab.ImageIndex = Herracy.SelectedNode.ImageIndex

        NewTab.CreateAndLoadTextBox()

        OpenTabs.Add(NewTab)




    End Sub

    Private Function getImageIndex(ext As String) As Integer
        Dim imageindex As Integer
        Select Case ext
            Case ".cpp"
                imageindex = 0
            Case ".java"
                imageindex = 1
            Case ".html"
                imageindex = 2
            Case ".js"
                imageindex = 3
            Case ".json"
                imageindex = 4
            Case ".txt"
                imageindex = 5
            Case ".py"
                imageindex = 6
            Case ".c"
                imageindex = 7
            Case ".exe"
                imageindex = 8
            Case Else
                imageindex = 9
        End Select
        Return imageindex
    End Function

    Private Sub CloseTab(sender As System.Object, e As System.EventArgs) Handles closeTabContextMenuItem.Click


        Dim file As String = TabControl1.SelectedTab.Text
        Dim tab As TabWizard

        For Each tab In OpenTabs
            If tab.filename.Equals(file) Then
                tab.SaveFile()
                OpenTabs.Remove(tab)
                TabControl1.TabPages.Remove(tab.tab_page)
                Exit For
            End If


        Next




    End Sub


    Private Sub collapseTreenode(sender As Object, e As EventArgs) Handles CollapseOption.Click

        Herracy.CollapseAll()

    End Sub

    Private Sub exapandTreenode(sender As Object, e As EventArgs) Handles ExpandOption.Click

        Herracy.ExpandAll()

    End Sub




    Private Function getDirectoryInfo(ByVal directoryName As String) As Integer

        For Each directory As FileHandler In OpenDirectories

            If directory.Directory_name.Equals(directoryName) Then

                Return OpenDirectories.IndexOf(directory)


            End If

        Next

        Return Nothing

    End Function

    Private Sub tabselect(sender As Object, e As EventArgs) Handles TabControl1.Selected
        If OpenTabs.Count <> 0 Then
            RunPreviewBox.Text = TabControl1.SelectedTab.Text
        Else
            RunPreviewBox.Text = ""
        End If
    End Sub

    Private Sub herracy_hide(sender As Object, e As EventArgs) Handles HideHerracy.CheckedChanged, hideherracyOption.CheckedChanged

        If HideHerracy.Checked = True Or hideherracyOption.Checked = True Then
            Herracy.Hide()
            hideherracyOption.Text = "Unhide Herracy"
            ' hideherracyOption.Checked = True
            ' HideHerracy.Checked = True
        ElseIf HideHerracy.Checked = False Or hideherracyOption.Checked = False Then
            Herracy.Show()
            hideherracyOption.Text = "Hide Herracy "
            'hideherracyOption.Checked = False
            ' HideHerracy.Checked = False
        End If

    End Sub

    Private Sub hideHerracy_click(sender As Object, e As EventArgs) Handles HideHerracy.Click
        If HideHerracy.Checked = False Then
            HideHerracy.Checked = True
            hideherracyOption.Checked = True
        Else
            HideHerracy.Checked = False
            hideherracyOption.Checked = False
        End If
    End Sub

    Private Sub hideHerracyoption_click(sender As Object, e As EventArgs) Handles hideherracyOption.Click
        If hideherracyOption.Checked = False Then
            hideherracyOption.Checked = True
            HideHerracy.Checked = True
        Else
            hideherracyOption.Checked = False
            HideHerracy.Checked = False
        End If
    End Sub


    Private Sub quit_cat(sender As Object, e As EventArgs) Handles quit.Click

        Me.Close()

    End Sub



End Class




Class TabWizard  ' this clsss will handle file opning in  tabs in tab Control and RichTextBoxes

    Public tab_page As TabPage     'create new tab page to add into herracy
    Public filename As String       'name of file opned in tabpage
    Public textbox As RichTextBox     ' this richtextbox will go in tab_page as new control and for file editing
    Public fileinfo As IO.FileInfo   ' information of opened file 
    Public pageIndex As Integer        ' after adding page to Tab Control, its index will be saved here 
    Public IsSaved As Boolean      ' to check eather file is saved or not
    'pblic IsAllocated As Boolean

    Sub New(ByVal fname As String, ByVal FileInformation As IO.FileInfo)

        filename = fname
        tab_page = New TabPage()          'it will genrate a new tab_page that can be then added into herracy 
        'set tab properties 
        tab_page.Text = filename              'set its title as file name
        tab_page.Name = "tab_page"

        ' tab_page.Padding.Left = 5

        IsSaved = False                       'at beginning file is not saved
        fileinfo = FileInformation
        'IsAllocated = True
    End Sub

    Sub CreateAndLoadTextBox()       ' this sub will allocate a richtextbox and load the file into it
        textbox = New RichTextBox()
        tab_page.Controls.Add(textbox)
        textbox.Dock = DockStyle.Fill
        Try
            textbox.LoadFile(fileinfo.FullName, RichTextBoxStreamType.PlainText)
        Catch e As Exception
            MessageBox.Show(" Error : File Not found ")

        End Try

    End Sub

    Sub SaveFile()
        Try
            textbox.SaveFile(fileinfo.FullName, RichTextBoxStreamType.PlainText)
        Catch s As Exception
            MessageBox.Show("Error : couldn't save file")
        End Try
        IsSaved = True

    End Sub

    Sub SaveFileWithoutMessage()
        Try
            textbox.SaveFile(fileinfo.FullName, RichTextBoxStreamType.PlainText)
        Catch s As Exception
            MessageBox.Show("Error : couldn't save file")
        End Try
        IsSaved = True
    End Sub



End Class

Class FileHandler

    Public Directory_name As String
    Public openDirectory As IO.DirectoryInfo
    Public subdirectory As IO.DirectoryInfo()
    Public directoryFiles As IO.FileInfo()
    Public Sub New(ByVal fullPath As String)
        openDirectory = New DirectoryInfo(fullPath)
        Directory_name = openDirectory.Name
        subdirectory = openDirectory.GetDirectories()
        directoryFiles = openDirectory.GetFiles()

    End Sub
    Public Sub CreateTreeView(ByRef localTree As TreeView)

        localTree.Dock = DockStyle.Left
        Dim nodecount = localTree.GetNodeCount(False)
        localTree.CollapseAll()
        Dim file As FileInfo
        Dim obj As Form1 = New Form1()
        localTree.Nodes.Add(Directory_name)
        localTree.Nodes(nodecount).ImageIndex = 7
        localTree.Nodes(nodecount).SelectedImageIndex = 7
        ' localTree.Nodes(nodecount).ContextMenuStrip = obj.directoryOptions

        '   localTree.Nodes(nodecount).Nodes.Add(file.Name)
        For Each file In directoryFiles

            Dim ext = file.Extension
            Dim treenode = New TreeNode()
            Dim imageindex As Integer
            treenode.Text = file.Name
            Select Case ext
                Case ".cpp"
                    imageindex = 0
                Case ".java"
                    imageindex = 1
                Case ".html"
                    imageindex = 2
                Case ".js"
                    imageindex = 3
                Case ".json"
                    imageindex = 4
                Case ".txt"
                    imageindex = 5
                Case ".py"
                    imageindex = 6
                Case ".c"
                    imageindex = 7
                Case ".exe"
                    imageindex = 8
                Case Else
                    imageindex = 9
            End Select

            localTree.Nodes(nodecount).Nodes.Add(file.Name, file.Name, imageindex, imageindex)

        Next

    End Sub

    Public Sub updateTreeView(ByRef herracy As TreeView, filename As String)

        Dim directoryIndex = herracy.Nodes.IndexOfKey(Me.Directory_name)
        herracy.Nodes(directoryIndex).Nodes.Add(filename)
    End Sub

    Public Sub updateDirectory(ByRef herracy As TreeView, ByVal newName As String, ByVal newPath As String)


        Me.openDirectory.Refresh()
        herracy.SelectedNode.Text = newName

    End Sub
    Public Function findFile(ByVal fileName As String) As FileInfo

        Dim file As FileInfo

        For Each file In directoryFiles
            If file.Name.Equals(fileName) Then
                Return file
            End If
        Next

        Return Nothing
    End Function



End Class


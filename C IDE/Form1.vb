
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports Microsoft.PowerShell

Public Class Form1

    Dim OpenTabs As List(Of TabWizard) = New List(Of TabWizard)
    Dim OpenDirectories As List(Of FileHandler) = New List(Of FileHandler)


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



    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolBar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolBar.ItemClicked

    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs)

    End Sub

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

    Private Sub CompileProgram(sender As Object, e As EventArgs) Handles BuildTool.Click
        If OpenTabs.Count = 0 Then
            MessageBox.Show("No Files are selected to Build , Open a file First by double Clicking File name in the Herracy ", "No file Found ", MessageBoxButtons.OK)
        Else
            Dim fileName As String = TabControl1.SelectedTab.Text
            Try
                Dim fileInformation As FileInfo = Findfileinfo(fileName)
                Dim filePath As String = fileInformation.FullName
                Dim command = "PowerShell -NoExit g++ -o" + filePath
                RunPreviewBox.Text = fileName
                Shell(command, AppWinStyle.NormalFocus)

            Catch returnedNull As Exception

            End Try

        End If

    End Sub
    Private Sub RunProgram(sender As Object, e As EventArgs) Handles RunTool.Click

        If OpenTabs.Count = 0 Then
            MessageBox.Show("No Files are selected to Run , Open a file First by double Clicking File name in the Herracy ", "No file Found ", MessageBoxButtons.OK)
        Else
            Dim fileName As String = TabControl1.SelectedTab.Text
            Dim fileInformation As FileInfo = Findfileinfo(fileName)
            Dim filePath As String = fileInformation.DirectoryName
            Dim filenameWithoutExtention = fileInformation.Name.Replace(".cpp", "")

            Dim command = "PowerShell -NoExit cd " + fileInformation.DirectoryName + " ; g++ " + fileName + " -o " + filenameWithoutExtention + " ; " + fileInformation.DirectoryName + "\" + filenameWithoutExtention
            RunPreviewBox.Text = fileName
            Shell(command, AppWinStyle.NormalFocus)

        End If


    End Sub
    Private Sub openFile_clicked(sender As Object, e As EventArgs) Handles OpenFile.Click


        OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory()
        OpenFileDialog.Multiselect = True
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim selectedFiles As String() = OpenFileDialog.FileNames

            For Each file As String In selectedFiles

            Next


        End If
    End Sub

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
    Private Sub Open_Directory_click(sender As Object, e As EventArgs) Handles OpenDirectory.Click


        FolderBrowserDialog1.Description = "open A directory"
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()

        'ReDim OpenDirectories(OpenDirectories.Length + 1)

        Dim directoryPath = FolderBrowserDialog1.SelectedPath

        Dim NewDirectory As FileHandler = New FileHandler(directoryPath)

        NewDirectory.CreateTreeView(Herracy)
        ' Controls.Add(Herracy)

        OpenDirectories.Add(NewDirectory)

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
        TabControl1.SelectedTab.ImageIndex = Herracy.SelectedNode.ImageIndex
        NewTab.CreateAndLoadTextBox()
        OpenTabs.Add(NewTab)




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
            MessageBox.Show(" Error : File not found ")

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

        localTree.Nodes.Add(Directory_name)
        localTree.Nodes(nodecount).ImageIndex = 7                   '   localTree.Nodes(nodecount).Nodes.Add(file.Name)
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

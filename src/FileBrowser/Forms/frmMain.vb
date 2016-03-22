Imports System.IO
Imports System.Threading

Public Class frmMain

    Private curdir As String = ""
    Private imgLst As New ImageList
    Dim tokenSource2 As New CancellationTokenSource()
    Dim ct As CancellationToken = tokenSource2.Token
    Private history As New List(Of String)
    Private tempfile As String = ""
    Private searchhistory As New List(Of String)
    Private fileclipboard As New List(Of String)

#Region "MenuStrip"

#Region "File"

    Private Sub OpenSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSelectedToolStripMenuItem.Click
        Open()
    End Sub

    Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFolderToolStripMenuItem.Click
        CreateNewFolder()
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        CreateNewFile()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Edit"

    Private Sub MoveHereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveHereToolStripMenuItem.Click
        MoveHere()
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        DeselectAll()
    End Sub

    Private Sub ClearCopyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCopyListToolStripMenuItem.Click
        fileclipboard.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Rename()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

#End Region

#Region "Navigation"

    Private Sub GoToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToToolStripMenuItem.Click
        Dim newb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "Go to...", "Enter a location to navigate to")
        If newb.DialogResult = Windows.Forms.DialogResult.OK Then
            Navigate(newb.Response)
        End If
    End Sub

    Private Sub OpenParentInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenParentInNewWindowToolStripMenuItem.Click
        Dim newb As New frmMain
        If curdir = "" Then
            newb.Navigate("")
        Else
            newb.Navigate(Path.GetDirectoryName(curdir))
        End If
        newb.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        DisplayDrives()
    End Sub

    Private Sub GoUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoUpToolStripMenuItem.Click
        GoUp()
    End Sub

#End Region

#Region "View"

#Region "Style"

    Private Sub ExtraLargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraLargeIconsToolStripMenuItem.Click
        SetViewStyle(ConfigManager.FileViewStyle.ExtraLargeIcons)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeIconsToolStripMenuItem.Click
        SetViewStyle(ConfigManager.FileViewStyle.LargeIcons)
    End Sub

    Private Sub MediumIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumIconsToolStripMenuItem.Click
        SetViewStyle(ConfigManager.FileViewStyle.MediumIcons)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallIconsToolStripMenuItem.Click
        SetViewStyle(ConfigManager.FileViewStyle.SmallIcons)
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        SetViewStyle(ConfigManager.FileViewStyle.List)
    End Sub

#End Region

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        If Not pnl_navigation.Visible Then
            DisplayNavigationPane(True)
        End If
        combo_search.Focus()
    End Sub

    Private Sub SidebarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SidebarToolStripMenuItem.Click
        If SplitContainer1.Panel1Collapsed Then
            DisplaySideBar(True)
        Else
            DisplaySideBar(False)
        End If
    End Sub

    Private Sub NavigationPaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigationPaneToolStripMenuItem.Click
        If pnl_navigation.Visible Then
            DisplayNavigationPane(False)
        Else
            DisplayNavigationPane(True, True)
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        LoadDirectory(curdir)
    End Sub

#End Region

#Region "Window"

    Private Sub TopmostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopmostToolStripMenuItem.Click
        If Me.TopMost Then
            SetTopmost(False)
        Else
            SetTopmost(True)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newb As New frmMain
        newb.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        Dim bb As New Aire.API.MessageBox("Are you sure you want to close all windows?", "Confirm Close All", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
        If bb.DialogResult = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

#End Region

#Region "Tools"

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        Dim newb As New dlgBookmarks
        newb.ShowDialog()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        Dim newb As New dlgHistory
        newb.ShowDialog()
    End Sub

    Private Sub AddCurrentDirectoryToBookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCurrentDirectoryToBookmarksToolStripMenuItem.Click
        If curdir <> "" Then
            ConfigManager.AddBookmark(curdir)
            Dim bb As New Aire.API.MessageBox("Added '" & curdir & "' as a bookmark!", "New Bookmark", Aire.API.MessageBox.MessageBoxButtons.OkOnly, Aire.API.MessageBox.MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region "About"

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim newb As New dlgOptions
        newb.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim newb As New dlgAbout
        newb.ShowDialog()
    End Sub

#End Region

#End Region

#Region "Context Menu Strip"

    Private Sub MoveHereToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveHereToolStripMenuItem1.Click
        MoveHere()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            DisplayPropertiesDialog(ListView1.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        SelectAll()
    End Sub

    Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem1.Click
        Rename()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Delete()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        Paste()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        Copy()
    End Sub

    Private Sub OpenInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNewWindowToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim newb As New frmMain
            newb.Navigate(ListView1.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open()
    End Sub

#Region "New"

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        CreateNewFolder()
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        CreateNewFile()
    End Sub

#End Region

#End Region

#Region "Methods"

#Region "Search"

    Private Sub CancelSearch()
        tokenSource2.Cancel()
        pnl_cancelsearch.Hide()
    End Sub

    Private Sub Search(ByVal txt As String, ByVal dir As String)
        CancelSearch()
        tokenSource2 = New CancellationTokenSource()
        ct = tokenSource2.Token
        pnl_cancelsearch.Show()
        Dim t As Task = Task.Factory.StartNew(Sub()
                                                  If ct.IsCancellationRequested Then
                                                      Exit Sub
                                                  End If
                                                  ListView1.Clear()
                                                  Dim iscasesensitive As Boolean = ConfigManager.SearchIsCaseSensitive
                                                  If Not searchhistory.Contains(txt) Then
                                                      searchhistory.Add(txt)
                                                      combo_search.Items.Add(txt)
                                                  End If
                                                  If ct.IsCancellationRequested Then
                                                      Exit Sub
                                                  End If
                                                  If dir = "" Then
                                                      For Each item As String In Directory.GetLogicalDrives
                                                          If ct.IsCancellationRequested Then
                                                              Exit Sub
                                                          End If
                                                          SearchRec(txt, item, iscasesensitive)
                                                      Next
                                                  Else
                                                      SearchRec(txt, dir)
                                                  End If
                                                  pnl_cancelsearch.Hide()
                                              End Sub)
    End Sub

    Private Sub SearchRec(ByVal txt As String, ByVal rootdir As String, Optional ByVal casesensitive As Boolean = True)
        For Each item As String In Directory.GetFiles(rootdir)
            If ct.IsCancellationRequested Then
                Exit Sub
            End If
            If casesensitive Then
                If item.Contains(txt) Then
                    ListView1.BeginInvoke(Sub()
                                              AddItem(item)
                                          End Sub)
                End If
            Else
                If item.ToLower.Contains(txt.ToLower) Then
                    ListView1.BeginInvoke(Sub()
                                              AddItem(item)
                                          End Sub)
                End If
            End If
        Next
        For Each item As String In Directory.GetDirectories(rootdir)
            If ct.IsCancellationRequested Then
                Exit Sub
            End If
            SearchRec(txt, item)
        Next
    End Sub

#End Region

#Region "Create"

    Private Sub CreateNewFolder()
        If curdir <> "" Then
            Dim bb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "New Folder", "Enter new folder name")
            If bb.DialogResult = Windows.Forms.DialogResult.OK AndAlso Not bb.Response = "" Then
                If Not Directory.Exists(curdir & "/" & bb.Response) Then
                    Directory.CreateDirectory(curdir & "/" & bb.Response)
                    AddItem(curdir & "/" & bb.Response)
                Else
                    Dim t As New Aire.API.MessageBox("The specified directory already exists!", "Could not create directory", Aire.API.MessageBox.MessageBoxButtons.OkOnly, Aire.API.MessageBox.MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub CreateNewFile()
        If curdir <> "" Then
            Dim bb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "New File", "Enter new file name")
            If bb.DialogResult = Windows.Forms.DialogResult.OK AndAlso Not bb.Response = "" Then
                If Not File.Exists(curdir & "/" & bb.Response) Then
                    File.Create(curdir & "/" & bb.Response)
                    AddItem(curdir & "/" & bb.Response)
                Else
                    Dim t As New Aire.API.MessageBox("The specified file already exists!", "Could not create file", Aire.API.MessageBox.MessageBoxButtons.OkOnly, Aire.API.MessageBox.MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Edit Methods"

    Private Sub Open()
        If ListView1.SelectedItems.Count > 0 Then
            If Directory.Exists(ListView1.SelectedItems(0).Tag) Then
                LoadDirectory(ListView1.SelectedItems(0).Tag)
            Else
                For Each item As ListViewItem In ListView1.SelectedItems
                    If File.Exists(item.Tag) Then
                        FileLauncher.LaunchFile(item.Tag)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Rename()
        If ListView1.SelectedItems.Count > 0 Then
            Dim t As ListViewItem = ListView1.SelectedItems(0)
            Dim bb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "Rename", "", t.Text)
            If bb.DialogResult = Windows.Forms.DialogResult.OK AndAlso bb.Response <> t.Text Then
                If Directory.Exists(t.Tag) Then
                    t.Text = bb.Response
                    My.Computer.FileSystem.RenameDirectory(t.Tag, bb.Response)
                    t.Tag = Path.GetDirectoryName(t.Tag) & "/" & bb.Response
                    t.ToolTipText = t.Tag
                ElseIf File.Exists(t.Tag) Then
                    t.Text = bb.Response
                    My.Computer.FileSystem.RenameFile(t.Tag, bb.Response)
                    t.Tag = Path.GetDirectoryName(t.Tag) & "/" & bb.Response
                    t.ToolTipText = t.Tag
                End If
            End If
        End If
    End Sub

    Private Sub Copy()
        If ListView1.SelectedItems.Count > 0 Then
            fileclipboard.Clear()
            For Each item As ListViewItem In ListView1.SelectedItems
                fileclipboard.Add(item.Tag)
            Next
        End If
    End Sub

    Private Sub MoveHere()
        If fileclipboard.Count > 0 AndAlso curdir <> "" Then
            For Each item As String In fileclipboard
                If File.Exists(item) Then
                    Dim bb As String = curdir & "/" & Path.GetFileName(item)
                    If File.Exists(bb) Then
                        Dim msg As New Aire.API.MessageBox("The directory you are attempting to move the file '" & Path.GetFileName(item) & "' to already contains a file with that name. Do you want to replace it?", "File Already Exists", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
                        If msg.DialogResult = Windows.Forms.DialogResult.Yes Then
                            File.Delete(bb)
                            File.Move(item, bb)
                        End If
                    Else
                        File.Move(item, bb)
                    End If
                ElseIf Directory.Exists(item) Then
                    Dim bb As String = curdir & "/" & Path.GetFileName(item)
                    If Directory.Exists(bb) Then
                        Dim msg As New Aire.API.MessageBox("The directory you are attempting to move the directory '" & Path.GetFileName(item) & "' to already contains a directory with that name. Do you want to replace it?", "Directory Already Exists", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
                        If msg.DialogResult = Windows.Forms.DialogResult.Yes Then
                            Directory.Delete(bb, True)
                            Directory.Move(item, bb)
                        End If
                    Else
                        Directory.Move(item, bb)
                    End If
                End If
            Next
            LoadDirectory(curdir)
        End If
    End Sub

    Private Sub Paste()
        If fileclipboard.Count > 0 AndAlso curdir <> "" Then
            For Each item As String In fileclipboard
                If File.Exists(item) Then
                    Dim bb As String = curdir & "/" & Path.GetFileName(item)
                    If File.Exists(bb) Then
                        Dim i As Integer = 1
                        While File.Exists(curdir & "/" & Path.GetFileNameWithoutExtension(item) & " (" & i & ")" & Path.GetExtension(item))
                            i += 1
                        End While
                        bb = curdir & "/" & Path.GetFileNameWithoutExtension(item) & " (" & i & ")" & Path.GetExtension(item)
                    End If
                    File.Copy(item, bb)
                ElseIf Directory.Exists(item) Then
                    Dim bb As String = curdir & "/" & Path.GetFileName(item)
                    If Directory.Exists(bb) Then
                        Dim i As Integer = 1
                        While Directory.Exists(bb & " (" & i & ")")
                            i += 1
                        End While
                        bb = bb & " (" & i & ")"
                    End If
                    My.Computer.FileSystem.CopyDirectory(item, bb)
                End If

            Next
            LoadDirectory(curdir)
        End If
    End Sub

    Private Sub SelectAll()
        For Each item As ListViewItem In ListView1.Items
            item.Selected = True
        Next
    End Sub

    Private Sub DeselectAll()
        For Each item As ListViewItem In ListView1.Items
            item.Selected = False
        Next
    End Sub

    Private Sub Delete()
        If ListView1.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                If File.Exists(item.Tag) Then
                    File.Delete(item.Tag)
                ElseIf Directory.Exists(item.Tag) Then
                    Directory.Delete(item.Tag, True)
                End If
            Next
            LoadDirectory(curdir)
        End If
    End Sub

#End Region

#Region "Navigation"

    Private Sub DisplayDrives()
        ListView1.Clear()
        For Each item As String In Directory.GetLogicalDrives
            Dim newb As New ListViewItem
            newb.Text = item
            newb.ToolTipText = item
            newb.Tag = item
            newb.ImageIndex = 25 'Helper.ConvertPathToIndex(item, True)
            combo_navigation.Text = ""
            ListView1.Items.Add(newb)
        Next
    End Sub

    Public Sub Navigate(ByVal path As String)
        If path = "" Then
            LoadDirectory("")
        ElseIf System.IO.File.Exists(path) Then
            LoadDirectory(System.IO.Path.GetDirectoryName(path))
        ElseIf System.IO.Directory.Exists(path) Then
            LoadDirectory(path)
        End If
    End Sub

    Private Sub GoUp()
        Dim bb As String = Path.GetDirectoryName(curdir)
        If bb = "" Then
            DisplayDrives()
        Else
            LoadDirectory(bb)
        End If
    End Sub

    Private Sub LoadDirectory(ByVal dir As String)
        'Dim t As Task = Task.Factory.StartNew(Sub()
        If Directory.Exists(dir) Then
            curdir = dir
            combo_navigation.Text = dir
            If Not history.Contains(dir) Then
                combo_navigation.Items.Add(dir)
                history.Add(dir)
                ConfigManager.AddToHistory(dir)
            End If
            ListView1.Clear()
            For Each item As String In Directory.GetDirectories(dir)
                AddItem(item)
            Next
            For Each item As String In Directory.GetFiles(dir)
                AddItem(item)
            Next
        ElseIf dir = "" Then
            DisplayDrives()
        End If
        'End Sub)
    End Sub

#End Region

    Private Sub DisplayNavigationPane(ByVal val As Boolean, Optional ByVal focusonnav As Boolean = False)
        pnl_navigation.Visible = val
        NavigationToolStripMenuItem.Checked = val
        If focusonnav Then
            combo_navigation.Focus()
        End If
    End Sub

    Private Sub DisplaySideBar(ByVal val As Boolean)
        SplitContainer1.Panel1Collapsed = Not val
        SidebarToolStripMenuItem.Checked = val
    End Sub

    Private Sub UncheckAllViewStyleMenuItems()
        ExtraLargeIconsToolStripMenuItem.Checked = False
        LargeIconsToolStripMenuItem.Checked = False
        MediumIconsToolStripMenuItem.Checked = False
        SmallIconsToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
    End Sub

    Private Sub LoadImagesWithSize(sz As Size)
        imgLst.ColorDepth = ColorDepth.Depth32Bit
        imgLst.ImageSize = sz
        imgLst.Images.Clear()
        For n As Int32 = 0 To ImageList_Master.Images.Count - 1
            imgLst.Images.Add(ImageList_Master.Images(n))
        Next
        ListView1.LargeImageList = imgLst
    End Sub

    Private Sub DisplayPropertiesDialog(ByVal path As String)
        Dim newb As New dlgProperties(path)
        newb.ShowDialog()
    End Sub

    Private Sub SetTopmost(ByVal val As Boolean)
        Me.TopMost = val
        TopmostToolStripMenuItem.Checked = val
    End Sub

    Private Sub SetViewStyle(ByVal view As ConfigManager.FileViewStyle)
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.EnsureVisible(ListView1.SelectedItems(0).Index)
        End If
        UncheckAllViewStyleMenuItems()
        Select Case view
            Case ConfigManager.FileViewStyle.ExtraLargeIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                LoadImagesWithSize(New Size(128, 128))
                ExtraLargeIconsToolStripMenuItem.Checked = True
            Case ConfigManager.FileViewStyle.LargeIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                LoadImagesWithSize(New Size(96, 96))
                LargeIconsToolStripMenuItem.Checked = True
            Case ConfigManager.FileViewStyle.MediumIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                LoadImagesWithSize(New Size(64, 64))
                MediumIconsToolStripMenuItem.Checked = True
            Case ConfigManager.FileViewStyle.SmallIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                LoadImagesWithSize(New Size(32, 32))
                SmallIconsToolStripMenuItem.Checked = True
            Case ConfigManager.FileViewStyle.List
                ListView1.View = Windows.Forms.View.Details
                ListToolStripMenuItem.Checked = True
        End Select
    End Sub

    Private Sub LoadUI()
        SetViewStyle(ConfigManager.ViewStyle)
        SetTopmost(ConfigManager.Topmost)
        DisplaySideBar(ConfigManager.Sidebar)
        DisplayNavigationPane(ConfigManager.NavigationPane)
        DisplayDrives()
    End Sub

    Private Sub AddItem(ByVal file As String)
        Dim newb As New ListViewItem
        newb.Text = Path.GetFileName(file)
        newb.ToolTipText = file
        newb.Tag = file
        newb.ImageIndex = Helper.ConvertPathToIndex(file)
        ListView1.Items.Add(newb)
    End Sub

#End Region

#Region "Navigation Bar"

#Region "combo_navigation"

    Private Sub combo_navigation_KeyDown(sender As Object, e As KeyEventArgs) Handles combo_navigation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Navigate(combo_navigation.Text)
        End If
    End Sub

    Private Sub combo_navigation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_navigation.SelectedIndexChanged
        Navigate(combo_navigation.SelectedItem)
    End Sub

#End Region

#Region "combo_search"

    Private Sub combo_search_KeyDown(sender As Object, e As KeyEventArgs) Handles combo_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search(combo_search.Text, curdir)
        End If
    End Sub

    Private Sub combo_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_search.SelectedIndexChanged
        Search(combo_search.SelectedItem, curdir)
    End Sub

#End Region

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        GoUp()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        DisplayDrives()
    End Sub

#End Region

#Region "pnl_cancelsearch"

    Private Sub btnCancelSearch_Click(sender As Object, e As EventArgs) Handles btnCancelSearch.Click
        CancelSearch()
    End Sub

#End Region

#Region "ListView1"

    Private Sub ListView_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView1.ItemDrag
        Dim myItem As ListViewItem
        Dim myItems As New List(Of ListViewItem)
        Dim i As Integer = 0
        For Each myItem In sender.SelectedItems
            myItems.Add(myItem)
        Next
        sender.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem()", myItems), DragDropEffects.Move)
    End Sub

    Private Sub ListView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListView_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        Dim myItem As ListViewItem
        Dim myItems As List(Of ListViewItem) = e.Data.GetData("System.Windows.Forms.ListViewItem()")
        Dim i As Integer = 0
        For Each myItem In myItems
            Dim t As ListViewItem = myItem.Clone()
            If Not Path.GetDirectoryName(t.Tag) = curdir Then
                If Directory.Exists(t.Tag) Then
                    Dim b As String = Path.GetFileName(t.Tag)
                    Dim orig As String = t.Tag
                    t.Tag = curdir & "/" & b
                    t.ToolTipText = curdir & "/" & vbAbort
                    Directory.Move(orig, t.Tag)
                    sender.Items.Add(t)
                ElseIf File.Exists(t.Tag) Then
                    Dim b As String = Path.GetFileName(t.Tag)
                    Dim orig As String = t.Tag
                    t.Tag = curdir & "/" & b
                    t.ToolTipText = curdir & "/" & vbAbort
                    File.Move(orig, t.Tag)
                    sender.Items.Add(t)
                End If
            End If
        Next
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If ListView1.SelectedItems.Count > 0 Then
            Select Case e.KeyCode
                Case Keys.Back, Keys.Delete
                    Delete()
                Case Keys.Enter
                    Open()
                Case Keys.Escape
                    GoUp()
                    ListView1.Focus()
            End Select
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Open()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            tokenSource2.Cancel()
            Dim bb As New FileProperties(ListView1.SelectedItems(0).Tag)
            If bb.GetIfFileExists Then
                lblProperties.Text = "Name: " & Path.GetFileName(bb.GetFullPath) & " | Size: " & bb.GetFileSize()
            Else
                lblProperties.Text = "Name: " & Path.GetFileName(bb.GetFullPath) & " | Size: "
                Dim t As Task = Task.Factory.StartNew(Sub()
                                                          lblProperties.Text &= bb.GetFolderSize(ListView1)
                                                      End Sub)
            End If
        Else
            lblProperties.Text = ""
        End If
    End Sub

#End Region

#Region "lblProperties"

    Private Sub lblProperties_Click(sender As Object, e As EventArgs) Handles lblProperties.Click
        If ListView1.SelectedItems.Count > 0 AndAlso lblProperties.Text <> "" Then
            DisplayPropertiesDialog(ListView1.SelectedItems(0).Tag)
        End If
    End Sub

#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LoadUI()
        history = ConfigManager.ReadHistory
    End Sub

#End Region
    
End Class
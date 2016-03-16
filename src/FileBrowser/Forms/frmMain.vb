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

    End Sub

    Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFolderToolStripMenuItem.Click

    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Edit"

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click

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
        newb.Navigate(Path.GetDirectoryName(curdir))
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
            DisplayNavigationPane(True)
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

#Region "Methods"

    Private Sub Copy()
        If ListView1.SelectedItems.Count > 0 Then
            fileclipboard.Clear()
            For Each item As ListViewItem In ListView1.SelectedItems
                fileclipboard.Add(item.Tag)
            Next
        End If
    End Sub

    Private Sub Paste()
        If fileclipboard.Count > 0 AndAlso curdir <> "" Then
            For Each item As String In fileclipboard
                File.Copy(item, curdir & Path.GetFileName(item))
            Next
            LoadDirectory(curdir)
        End If
    End Sub

    Private Sub SelectAll()
        For Each item As ListViewItem In ListView1.Items
            item.Selected = True
        Next
    End Sub

    Private Sub Delete()
        If ListView1.SelectedItems.Count > 0 Then
            For Each item As String In ListView1.SelectedItems
                File.Delete(item)
            Next
            LoadDirectory(curdir)
        End If
    End Sub

    Private Sub DisplayNavigationPane(ByVal val As Boolean)
        pnl_navigation.Visible = val
        NavigationToolStripMenuItem.Checked = val
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

    Private Sub Search(ByVal txt As String, ByVal dir As String)
        ListView1.Clear()
        If Not searchhistory.Contains(txt) Then
            searchhistory.Add(txt)
            combo_search.Items.Add(txt)
        End If
        If dir = "" Then
            For Each item As String In Directory.GetLogicalDrives
                SearchRec(txt, item)
            Next
        Else
            SearchRec(txt, dir)
        End If
    End Sub

    Private Sub SearchRec(ByVal txt As String, ByVal rootdir As String)
        For Each item As String In Directory.GetFiles(rootdir)
            If item.Contains(txt) Then
                AddItem(item)
            End If
        Next
        For Each item As String In Directory.GetDirectories(rootdir)
            SearchRec(txt, item)
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

    Private Sub LoadDirectory(ByVal dir As String)
        'Dim t As Task = Task.Factory.StartNew(Sub()
        If Directory.Exists(dir) Then
            curdir = dir
            combo_navigation.Text = dir
            If Not history.Contains(dir) Then
                combo_navigation.Items.Add(dir)
                history.Add(dir)
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

    Private Sub AddItem(ByVal file As String)
        Dim newb As New ListViewItem
        newb.Text = Path.GetFileName(file)
        newb.ToolTipText = Path.GetDirectoryName(file)
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

#Region "ListView1"

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown

    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            If Directory.Exists(ListView1.SelectedItems(0).Tag) Then
                LoadDirectory(ListView1.SelectedItems(0).Tag)
            End If
        End If
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
        'System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LoadUI()
    End Sub

#End Region
    
End Class
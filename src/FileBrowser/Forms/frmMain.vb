Imports System.IO
Imports System.Threading

Public Class frmMain

    Private curdir As String = ""
    Private imgLst As New ImageList
    Dim tokenSource2 As New CancellationTokenSource()
    Dim ct As CancellationToken = tokenSource2.Token

#Region "MenuStrip"

#Region "File"



#End Region

#Region "Edit"



#End Region

#Region "Navigation"



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

    End Sub

    Private Sub NavigationPaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigationPaneToolStripMenuItem.Click

    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click

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



#End Region

#Region "About"



#End Region

#End Region

#Region "Methods"

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

    Private Sub Search(ByVal txt As String)

    End Sub

    Private Sub Navigate(ByVal path As String)

    End Sub

    Private Sub GoBack()

    End Sub

    Private Sub GoForward()

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
        SplitContainer1.Panel1Collapsed = Not ConfigManager.Sidebar
        pnl_navigation.Visible = ConfigManager.NavigationPane
        DisplayDrives()
    End Sub

    Private Sub LoadDirectory(ByVal dir As String)
        'Dim t As Task = Task.Factory.StartNew(Sub()
        If Directory.Exists(dir) Then
            curdir = dir
            combo_navigation.Text = dir
            ListView1.Clear()
            For Each item As String In Directory.GetDirectories(dir)
                AddItem(item)
            Next
            For Each item As String In Directory.GetFiles(dir)
                AddItem(item)
            Next
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

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        GoUp()
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
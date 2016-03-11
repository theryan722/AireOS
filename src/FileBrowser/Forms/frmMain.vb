Imports System.IO

Public Class frmMain

    Private curdir As String = ""

#Region "MenuStrip"

#Region "File"



#End Region

#Region "Edit"



#End Region

#Region "Navigation"



#End Region

#Region "View"



#End Region

#Region "Window"



#End Region

#Region "Tools"



#End Region

#Region "About"



#End Region

#End Region

#Region "Methods"

    Private Sub DisplayDrives()
        ListView1.Clear()
        For Each item As String In Directory.GetLogicalDrives

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
        Select Case view
            Case ConfigManager.FileViewStyle.ExtraLargeIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                ImageList1.ImageSize = New Size(128, 128)
            Case ConfigManager.FileViewStyle.LargeIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                ImageList1.ImageSize = New Size(96, 96)
            Case ConfigManager.FileViewStyle.MediumIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                ImageList1.ImageSize = New Size(64, 64)
            Case ConfigManager.FileViewStyle.SmallIcons
                ListView1.View = Windows.Forms.View.LargeIcon
                ImageList1.ImageSize = New Size(32, 32)
            Case ConfigManager.FileViewStyle.List
                ListView1.View = Windows.Forms.View.Details
        End Select
    End Sub

    Private Sub LoadUI()
        SetViewStyle(ConfigManager.ViewStyle)
        SetTopmost(ConfigManager.Topmost)
        SplitContainer1.Panel1Collapsed = Not ConfigManager.Sidebar
        pnl_navigation.Visible = ConfigManager.NavigationPane
    End Sub

    Private Sub LoadDirectory(ByVal dir As String)
        If Directory.Exists(dir) Then
            ListView1.Clear()
            For Each item As String In Directory.GetDirectories(dir)
                AddItem(item)
            Next
            For Each item As String In Directory.GetFiles(dir)
                AddItem(item)
            Next
        End If
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
            Dim bb As New FileProperties(ListView1.SelectedItems(0).Tag)
            lblProperties.Text = "Name: " & Path.GetFileName(bb.GetFullPath) & " Size: " & bb.GetFileSize()
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
        LoadUI()
    End Sub

#End Region
    
End Class
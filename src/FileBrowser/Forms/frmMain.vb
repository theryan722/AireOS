Imports System.IO

Public Class frmMain

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

#Region "About"



#End Region

#End Region

#Region "Methods"

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

    End Sub

    Private Sub AddItem(ByVal file As String)
        Dim newb As New ListViewItem
        newb.Text = Path.GetFileName(file)
        newb.ToolTipText = Path.GetDirectoryName(file)
        newb.Tag = file
        newb.ImageIndex = FileIcon.ConvertPathToIndex(file)
        ListView1.Items.Add(newb)
    End Sub

#End Region

#Region "ListView1"



#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class

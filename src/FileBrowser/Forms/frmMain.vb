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

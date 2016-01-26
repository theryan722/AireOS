Imports System.Windows.Forms
Imports System.IO

Public Class dlgFolder

    Public Property SelectedFolder As String

#Region "Methods"

    Private Sub LoadFolders_MyComputer()
        Dim drives As String() = Environment.GetLogicalDrives()
        Dim myPC As TreeNode = TreeView1.Nodes.Add("MYPC", "My Computer")
        For Each drive As String In drives
            Dim tmp As TreeNode = myPC.Nodes.Add(drive, drive)
            Try
                If Directory.GetDirectories(drive).Length <> 0 Then
                    tmp.Nodes.Add("[EMPTY]", "")
                End If
            Catch
                Exit Try
            End Try
        Next
    End Sub

#End Region

#Region "dlgFolder"

    Private Sub dlgFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "UI"

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "TreeView1"

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand

    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick

    End Sub

#End Region

    
End Class
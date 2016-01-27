Imports System.Windows.Forms
Imports System.IO

Public Class FolderDialog

    Public Property SelectedFolder As String

#Region "Methods"

    Private Sub SetSelectedFolderFromSelectedNode(Optional ByVal close As Boolean = False)
        If TreeView1.SelectedNode IsNot Nothing AndAlso TreeView1.SelectedNode.Text <> "My Computer" Then
            SelectedFolder = TreeView1.SelectedNode.Text
            If close Then
                btnOK.PerformClick()
            End If
        End If
    End Sub

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
        LoadFolders_MyComputer()
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

    Public Sub New(Optional ByVal title As String = "Browse For File", Optional ByVal text As String = "")
        InitializeComponent()
        Me.Text = title
        If text <> "" Then
            TextBox1.Text = text
            TextBox1.Show()
        End If
        Me.ShowDialog()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        SetSelectedFolderFromSelectedNode()
    End Sub

    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        Dim tmp As TreeNode()
        Dim newNode As TreeNode
        tmp = e.Node.Nodes.Find("[EMPTY]", False)
        If tmp.Length > 0 Then
            e.Node.Nodes.Clear()
        End If
        If Directory.Exists(e.Node.Text) Then
            For Each dir As String In Directory.GetDirectories(e.Node.Text)
                tmp = e.Node.Nodes.Find(dir, False)
                If tmp.Length = 0 Then
                    newNode = e.Node.Nodes.Add(dir, dir)
                    newNode.Tag = dir
                    newNode.ImageIndex = 0
                    Try
                        If Directory.GetDirectories(dir).Length <> 0 Then
                            newNode.Nodes.Add("[EMPTY]", "")
                        End If
                    Catch
                        Exit Try
                    End Try
                    newNode = Nothing
                End If
            Next
        End If
    End Sub

    Private Sub TreeView1_KeyDown(sender As Object, e As KeyEventArgs) Handles TreeView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SetSelectedFolderFromSelectedNode(True)
        End If
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        SetSelectedFolderFromSelectedNode(True)
    End Sub

#End Region

End Class
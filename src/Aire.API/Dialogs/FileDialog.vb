Public Class FileDialog

    Public Enum Mode
        Open
        Save
    End Enum

    Public Property SelectedFile As String
    Private extlist As New List(Of String)

#Region "Methods"

    Private Sub ClearExtensions()
        combo_fileextensions.Items.Clear()
        extlist.Clear()
    End Sub

    Private Sub ParseExtensions(ByVal extl As List(Of String))
        ClearExtensions()
        If extl IsNot Nothing AndAlso extl.Count > 0 Then
            Dim arr() As String
            For Each item As String In extl
                arr = item.Split("|")
                combo_fileextensions.Items.Add(arr(0))
                extlist.Add(arr(1))
            Next
        Else
            extlist.Add("*.*")
            combo_fileextensions.Items.Add("All Files (*.*)")
        End If
    End Sub

#End Region

#Region "UI"

    Private Sub combo_fileextensions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_fileextensions.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOpenSave_Click(sender As Object, e As EventArgs) Handles btnOpenSave.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region "dlgFile"

    Public Sub New(Optional ByVal filemode As Mode = Mode.Open, Optional ByVal extensions As List(Of String) = Nothing, Optional ByVal title As String = "")
        InitializeComponent()
        If title = "" Then
            Me.Text = If(filemode = Mode.Open, "Open File", "Save File")
        Else
            Me.Text = title
        End If
        If filemode = Mode.Open Then
            btnOpenSave.Text = "Open"
        Else
            btnOpenSave.Text = "Save"
        End If
        ParseExtensions(extensions)
        Me.ShowDialog()
    End Sub

    Private Sub dlgFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

    
    
    
End Class
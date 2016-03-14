Public Class InputDialog

#Region "Properties"

    Public Property Response As String

#End Region

#Region "Methods"



#End Region

#Region "UI"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

    End Sub

#End Region

#Region "InputDialog"

    Public Sub New(Optional ByVal multiline As Boolean = False, Optional ByVal title As String = "", Optional ByVal message As String = "")

    End Sub

#End Region

End Class
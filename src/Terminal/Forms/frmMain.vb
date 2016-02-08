Public Class frmMain

#Region "Properties/Variables"

    Private TypedText As String = ""

#End Region

#Region "Methods"



#End Region

#Region "Menu Strip"

#Region "File"



#End Region

#Region "Edit"



#End Region

#Region "View"



#End Region

#Region "About"



#End Region

#End Region

#Region "Context Menu Strip"



#End Region

#Region "TextBox1"

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectionStart = Len(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                CommandManager.ExecuteCommand(TypedText)
                TypedText = ""
            ElseIf e.KeyChar = ChrW(Keys.Back) Then
                If TypedText.Length > 0 Then
                    TypedText = TypedText.Substring(0, TypedText.Length - 1)
                Else
                    e.Handled = True
                End If
            Else
                TypedText += e.KeyChar
            End If
            TextBox1.SelectionStart = Len(TextBox1.Text)
        Catch ex As Exception
            Aire.API.Sys.Logging.Log.Write("ERROR: " & ex.ToString)
        End Try
    End Sub

#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class

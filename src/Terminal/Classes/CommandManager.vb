Public Class CommandManager

    Public Shared Sub ExecuteCommand(ByVal cmd As String, ByVal cmdform As frmMain)
        Dim sText As String = ""
        Try
            Select Case cmd
                Case cmd.ToLower = "clear"
                    sText = ""
                    cmdform.TextBox1.Clear()
                Case Else
                    sText = "Unrecognized command. Enter HELP for help."
            End Select
        Catch ex As Exception
            sText = "There was an error attempting to perform the command or action."
        End Try
        cmdform.TextBox1.Text = cmdform.TextBox1.Text & vbNewLine & vbNewLine & sText & vbNewLine & vbNewLine & "Studio:>"
        cmdform.TextBox1.SelectionStart = Len(cmdform.TextBox1.Text)
    End Sub

End Class

Public Class CommandManager

    Public Shared Sub ExecuteCommand(ByVal cmd As String, ByVal cmdform As frmMain)
        Dim sText As String = ""
        Try
            Select Case cmd.ToLower
                Case "clear"
                    sText = ""
                    cmdform.TextBox1.Clear()
                Case "help"
                Case "about"
                Case "terminal -exit window"
                    sText = "Exiting Window"
                    cmdform.Close()
                Case "terminal -exit all"
                    sText = "Exiting Terminal"
                    Application.Exit()
                Case "terminal -menu show"
                Case "terminal -menu hide"
                Case "terminal -topmost true"
                Case "terminal -topmost false"
                Case "terminal -windowstate minimize"
                Case "terminal -windowstate maximize"
                Case "terminal -windowstate normal"
                Case cmd.ToLower.StartsWith("terminal -title")
                Case cmd.ToLower.StartsWith("start")
                Case cmd.ToLower.StartsWith("launch")
                Case cmd.ToLower.StartsWith("get")
                Case "aire -user logout"
                Case "aire -user lock"
                Case "aire -user switch"
                Case "aire -power shutdown"
                Case "aire -power restart"
                Case "aire -power sleep"
                Case "aire -power hibernate"
                Case "aire -version"
                Case cmd.ToLower.StartsWith("log -write")
                Case cmd.ToLower.StartsWith("aire -notification toast")
                Case cmd.ToLower.StartsWith("aire -notification msgbox")
                Case cmd.ToLower.StartsWith("aire -volume -set")
                Case "aire -volume get"

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

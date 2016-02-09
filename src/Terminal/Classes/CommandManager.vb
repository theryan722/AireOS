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
                    sText = "Terminal Menu Visible"
                    cmdform.MenuStrip1.Show()
                Case "terminal -menu hide"
                    sText = "Terminal Menu Hidden"
                    cmdform.MenuStrip1.Hide()
                Case "terminal -topmost true"
                    sText = "Terminal Topmost set to true"
                    cmdform.TopMost = True
                    cmdform.TopmostToolStripMenuItem.Checked = True
                Case "terminal -topmost false"
                    sText = "Terminal Topmost set to false"
                    cmdform.TopMost = False
                    cmdform.TopmostToolStripMenuItem.Checked = False
                Case "terminal -windowstate minimize"
                    sText = "Terminal WindowState Minimized"
                    cmdform.WindowState = FormWindowState.Minimized
                Case "terminal -windowstate maximize"
                    sText = "Terminal WindowState Maximized"
                    cmdform.WindowState = FormWindowState.Maximized
                Case "terminal -windowstate normal"
                    sText = "Terminal WindowState Normal"
                    cmdform.WindowState = FormWindowState.Normal
                Case cmd.ToLower.StartsWith("terminal -title")
                    sText = "Terminal Title Set To: " & cmd.Split(""""c)(1)
                    cmdform.Text = cmd.Split(""""c)(1)
                Case cmd.ToLower.StartsWith("process -start")
                    sText = "Starting Process: " & cmd.Split(""""c)(1)
                    Aire.API.Sys.Process.Start(cmd.Split(""""c)(1))
                Case cmd.ToLower.StartsWith("command -exec")
                    Dim p1 As String = cmd.Split({"(", ","}, StringSplitOptions.None)(1)
                    Dim p2 As String = cmd.Split({",", ")"}, StringSplitOptions.None)(2)
                    sText = "Executing Command: " & p1
                    sText = vbNewLine & "Command Output: " & vbNewLine & Aire.API.Sys.Process.ExecuteCommandWithOutput(p1, p2)
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
                    sText = "Volume: " & Aire.API.Audio.Volume.GetVolume
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

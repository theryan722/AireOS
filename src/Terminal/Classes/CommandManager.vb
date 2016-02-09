Public Class CommandManager

    Public Shared Sub ExecuteCommand(ByVal cmd As String, ByVal cmdform As frmMain)
        Dim sText As String = ""
        Try
            Select Case cmd.ToLower
                Case "clear"
                    sText = ""
                    cmdform.TextBox1.Clear()
                Case "help" 'todo
                Case "terminal -about"
                    sText = "Displaying about information"
                    cmdform.AboutToolStripMenuItem1.PerformClick()
                Case "terminal -about version"
                    sText = "Terminal Version: " & My.Application.Info.Version.ToString
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
                Case cmd.ToLower.StartsWith("launch") 'todo
                Case cmd.ToLower.StartsWith("get") 'todo
                Case "aire -user -get permissionlevel"
                    sText = "Permission Level: " & Aire.API.User.Current.Info.GetPermissionLevel
                Case "aire -user -get datastoragelocation"
                    sText = "Data Storage Location: " & Aire.API.User.Current.Info.GetDataStorageLocation
                Case "aire -user -get loglocation"
                    sText = "Log Location: " & Aire.API.User.Current.Info.GetLogLocation
                Case "aire -user -get passwordhint"
                    sText = "Password Hint: " & Aire.API.User.Current.Info.GetPasswordHint
                Case "aire -user logout"
                    sText = "Logging out User"
                    Aire.API.User.Current.Actions.LogoutUser()
                Case "aire -user lock"
                    sText = "Locking User"
                    Aire.API.User.Current.Actions.LockUser()
                Case "aire -user switch"
                    sText = "Switching User"
                    Aire.API.User.Current.Actions.SwitchUser()
                Case "aire -power shutdown"
                    sText = "Setting powerstate to shutdown"
                    Aire.API.Sys.Power.Actions.Shutdown()
                Case "aire -power restart"
                    sText = "Setting powerstate to restart"
                    Aire.API.Sys.Power.Actions.Restart()
                Case "aire -power sleep"
                    sText = "Setting powerstate to sleep"
                    Aire.API.Sys.Power.Actions.Sleep()
                Case "aire -power hibernate"
                    sText = "Setting powerstate to hibernate"
                    Aire.API.Sys.Power.Actions.Hibernate()
                Case "aire -version"
                    sText = "Aire OS Version: " & Aire.API.Sys.Info.OS.Version
                Case "aire -release"
                    sText = "Aire OS Release: " & Aire.API.Sys.Info.OS.Release
                Case cmd.ToLower.StartsWith("aire -notification toast")
                    sText = "Displaying Toast: " & cmd.Split(""""c)(1)
                    Dim bb As New Aire.API.Toast(cmd.Split(""""c)(1), 2500, "Terminal")
                Case cmd.ToLower.StartsWith("aire -notification msgbox")
                    sText = "Displaying Message Box: " & cmd.Split(""""c)(1)
                    Dim bb As New Aire.API.MessageBox(cmd.Split(""""c)(1), "Terminal")
                Case cmd.ToLower.StartsWith("aire -volume set")
                    Dim bb As Integer = CInt(cmd.Split(""""c)(1))
                    Aire.API.Audio.Volume.SetVolume(bb)
                    sText = "Set Volume To: " & bb & "%"
                Case "aire -volume get"
                    sText = "Volume: " & Aire.API.Audio.Volume.GetVolume
                Case cmd.ToLower.StartsWith("log -write")
                    sText = "Writing to Log: " & cmd.Split(""""c)(1)
                    Aire.API.Sys.Logging.Log.Write(cmd.Split(""""c)(1), Aire.API.Sys.Logging.Log.LogSource.General)
                Case cmd.ToLower.StartsWith("echo")
                    sText = cmd.Split(""""c)(1)
                Case cmd.ToLower.StartsWith("file -create")
                    sText = "Creating File: " & cmd.Split(""""c)(1)
                    System.IO.File.Create(cmd.Split(""""c)(1))
                Case cmd.ToLower.StartsWith("file -delete")
                    sText = "Deleting File: " & cmd.Split(""""c)(1)
                    System.IO.File.Delete(cmd.Split(""""c)(1))
                Case cmd.ToLower.StartsWith("directory -create")
                    sText = "Creating Directory: " & cmd.Split(""""c)(1)
                    System.IO.Directory.CreateDirectory(cmd.Split(""""c)(1))
                Case cmd.ToLower.StartsWith("directory -delete")
                    sText = "Deleting Directory: " & cmd.Split(""""c)(1)
                    System.IO.Directory.Delete(cmd.Split(""""c)(1))
                Case cmd.ToLower.StartsWith("directory -delete recursive")
                    sText = "Deleting Directory Recursively: " & cmd.Split(""""c)(1)
                    System.IO.Directory.Delete(cmd.Split(""""c)(1), True)
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

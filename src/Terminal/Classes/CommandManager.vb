Public Class CommandManager

    Public Shared Sub ExecuteCommand(ByVal cmd As String, ByVal cmdform As frmMain)
        Dim sText As String = ""
        Try
            Select Case cmd.ToLower
                Case "clear"
                    sText = ""
                    cmdform.TextBox1.Clear()
                Case "help"
                    sText = "Basic Command List" & vbNewLine & _
"-------------------" & vbNewLine & _
"clear -- Clears the terminal" & vbNewLine & _
"help -- Displays help" & vbNewLine & _
"terminal -about -- Displays Information about Terminal" & vbNewLine & _
"terminal -about version -- Displays the terminal version" & vbNewLine & _
"terminal -exit window -- Closes the current terminal window" & vbNewLine & _
"terminal -exit all -- Exits the terminal application" & vbNewLine & _
"terminal -menu show -- Displays the terminal menu" & vbNewLine & _
"terminal -menu hide -- Hides the terminal menu" & vbNewLine & _
"terminal -topmost true -- Makes the terminal display above all other windows" & vbNewLine & _
"terminal -topmost false -- Makes the terminal display like a normal form" & vbNewLine & _
"terminal -windowstate minimize -- Minimizes the terminal" & vbNewLine & _
"terminal -windowstate maximize -- Maximizes the terminal" & vbNewLine & _
"terminal -windowstate normal -- Displays the terminal as normal" & vbNewLine & _
"terminal -title ""TITLEHERE"" -- Sets the terminal title" & vbNewLine & _
"terminal -fullscreen true -- Displays the terminal in fullscreen" & vbNewLine & _
"terminal -fullscreen false -- Returns the terminal to normal" & vbNewLine & _
"process -start ""PROCESSHERE"" -- Starts a process" & vbNewLine & _
"command -exec (PROCESS,ARGUMENTS) -- Executes a command, displays any output" & vbNewLine & _
"aire -user -get permissionlevel -- Displays the current user's permission level" & vbNewLine & _
"aire -user -get datastoragelocation -- Displays the current user's data storage location" & vbNewLine & _
"aire -user -get loglocation -- Displays the current user's log location" & vbNewLine & _
"aire -user -get passwordhint -- Displays the current user's password hint" & vbNewLine & _
"aire -user logout -- Logs out the current user" & vbNewLine & _
"aire -user lock -- Locks the current user" & vbNewLine & _
"aire -user switch -- Switches the user" & vbNewLine & _
"aire -power shutdown -- Shuts down the computer" & vbNewLine & _
"aire -power restart -- Restarts the computer" & vbNewLine & _
"aire -power sleep -- Puts the computer to sleep" & vbNewLine & _
"aire -power hibernate -- Puts the computer in hibernation" & vbNewLine & _
"aire -version -- Displays the OS version" & vbNewLine & _
"aire -release -- Displays the OS release" & vbNewLine & _
"aire -notification toast ""TEXTHERE"" -- Displays a toast notification" & vbNewLine & _
"aire -notification msgbox ""TEXTHERE"" -- Displays a messagebox notification" & vbNewLine & _
"aire -volume set VOLUME -- Sets the volume" & vbNewLine & _
"aire -volume get -- Displays the volume" & vbNewLine & _
"log -write ""TEXTHERE"" -- Writes to the system log" & vbNewLine & _
"echo ""TEXTHERE"" -- Displays the specified text" & vbNewLine & _
"file -create ""PATHHERE"" -- Creates a file" & vbNewLine & _
"file -delete ""PATHHERE"" -- Deletes a file" & vbNewLine & _
"directory -create ""PATHHERE"" -- Creates a directory" & vbNewLine & _
"directory -delete ""PATHHERE"" -- Deletes a directory" & vbNewLine & _
"directory -delete recursive ""PATHHERE"" -- Recursively deletes a directory (all sub folders and files)"
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
                Case "terminal -fullscreen true"
                    sText = "Terminal Fullscreen set to true"
                    cmdform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    cmdform.WindowState = FormWindowState.Maximized
                    cmdform.FullScreenToolStripMenuItem.Checked = True
                Case "terminal -fullscreen false"
                    sText = "Terminal Fullscreen set to false"
                    cmdform.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    cmdform.WindowState = FormWindowState.Normal
                    cmdform.FullScreenToolStripMenuItem.Checked = False
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
                    'Case cmd.ToLower.StartsWith("launch") 'todo
                    'Case cmd.ToLower.StartsWith("get") 'todo
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
        If sText <> "" Then
            cmdform.TextBox1.Text = cmdform.TextBox1.Text & vbNewLine & sText & vbNewLine & "Terminal@" & Aire.API.User.Current.Info.GetUsername & ":>"
        Else
            cmdform.TextBox1.Text = cmdform.TextBox1.Text & "Terminal@" & Aire.API.User.Current.Info.GetUsername & ":>"
        End If
        cmdform.TextBox1.SelectionStart = Len(cmdform.TextBox1.Text)
    End Sub

End Class

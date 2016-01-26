Public Class Process

    Public Shared Sub Start(ByVal proc As String)
        System.Diagnostics.Process.Start(proc)
    End Sub

    Public Shared Sub ExecuteCommand(ByVal file As String, ByVal arguments As String)
            Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
            proc.StartInfo.FileName = file
            proc.StartInfo.Arguments = arguments
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.StartInfo.CreateNoWindow = True
            proc.Start()
    End Sub

    Public Shared Function ExecuteCommandWithOutput(ByVal file As String, ByVal arguments As String) As String
        Dim ret As String = ""
        Dim proc As New System.Diagnostics.Process()
        proc.StartInfo.FileName = file
        proc.StartInfo.Arguments = arguments
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.Start()
        ret = proc.StandardOutput.ReadToEnd()
        proc.WaitForExit()

    End Function

    Public Shared Sub ExecuteScript(ByVal script As String)
        Dim proc As New System.Diagnostics.Process()
        proc.StartInfo.FileName = "/bin/bash"
        proc.StartInfo.Arguments = script
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.Start()
    End Sub

    Public Shared Function ExecuteScriptWithOutput(ByVal script As String)
        Dim ret As String = ""
        Dim proc As New System.Diagnostics.Process()
        proc.StartInfo.FileName = "/bin/bash"
        proc.StartInfo.Arguments = script
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.Start()
        ret = proc.StandardOutput.ReadToEnd()
        proc.WaitForExit()
        Return ret
    End Function

End Class
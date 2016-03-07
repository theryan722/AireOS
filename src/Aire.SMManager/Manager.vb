Public Class Manager

#Region "Public"

    Public Shared Sub UpdateFile(ByVal file As String, ByVal txt As String)

    End Sub

    Public Shared Function ReadFile(ByVal file As String) As String

    End Function

#End Region

#Region "Helper"

    Private Shared Sub ExecuteScript(ByVal script As String)
        Try
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo.FileName = "/usr/bin/python"
            proc.StartInfo.Arguments = script
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.Start()
        Catch
        End Try
    End Sub

    Private Shared Function ExecuteScriptWithOutput(ByVal script As String) As String
        Try
            Dim ret As String = ""
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo.FileName = "/usr/bin/python"
            proc.StartInfo.Arguments = script
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.Start()
            ret = proc.StandardOutput.ReadToEnd()
            proc.WaitForExit()
            proc.Close()
            Return ret
        Catch
            Return Nothing
        End Try
    End Function

#End Region

End Class
Namespace Sys

    Public Class Process

        Public Shared Sub Start(ByVal proc As String)
            System.Diagnostics.Process.Start(proc)
        End Sub

#Region "ExecuteCommand"

        Public Shared Sub ExecuteCommand(ByVal file As String, ByVal arguments As String)
            Try
                Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
                proc.StartInfo.FileName = file
                proc.StartInfo.Arguments = arguments
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True
                proc.StartInfo.CreateNoWindow = True
                proc.Start()
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Function ExecuteCommandWithOutput(ByVal file As String, ByVal arguments As String) As String
            Try
                Dim ret As String = ""
                Dim proc As New System.Diagnostics.Process()
                proc.StartInfo.FileName = file
                proc.StartInfo.Arguments = arguments
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True
                proc.Start()
                ret = proc.StandardOutput.ReadToEnd()
                proc.WaitForExit()
                Return ret
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
                Return Nothing
            End Try
        End Function

#End Region

#Region "ExecuteScript"

        Public Shared Sub ExecuteScript(ByVal script As String)
            Try
                Dim proc As New System.Diagnostics.Process()
                proc.StartInfo.FileName = "/bin/bash"
                proc.StartInfo.Arguments = script
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True
                proc.Start()
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Function ExecuteScriptWithOutput(ByVal script As String)
            Try
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
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
Namespace Sys

    Public Class Process
        ''' <summary>
        ''' Starts a process
        ''' </summary>
        ''' <param name="proc">The process to start</param>
        ''' <remarks></remarks>
        Public Shared Sub Start(ByVal proc As String)
            System.Diagnostics.Process.Start(proc)
        End Sub

#Region "ExecuteCommand"

        ''' <summary>
        ''' Executes a command
        ''' </summary>
        ''' <param name="file">The command to execute</param>
        ''' <param name="arguments">The arguments for the command</param>
        ''' <remarks></remarks>
        Public Shared Sub ExecuteCommand(ByVal file As String, Optional ByVal arguments As String = "")
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

        ''' <summary>
        ''' Executes a command and captures the output
        ''' </summary>
        ''' <param name="file">The command to execute</param>
        ''' <param name="arguments">The arguments for the command</param>
        ''' <returns>String, the output of the command</returns>
        ''' <remarks></remarks>
        Public Shared Function ExecuteCommandWithOutput(ByVal file As String, Optional ByVal arguments As String = "") As String
            Try
                Dim ret As String = ""
                Dim proc As New System.Diagnostics.Process()
                proc.StartInfo.FileName = file
                proc.StartInfo.Arguments = arguments
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True
                proc.Start()
                ret = proc.StandardOutput.ReadToEnd()
                'proc.BeginOutputReadLine()
                proc.WaitForExit()
                proc.Close()
                Return ret
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
                Return Nothing
            End Try
        End Function

#End Region

#Region "ExecuteScript"

        ''' <summary>
        ''' Executes a bash script
        ''' </summary>
        ''' <param name="script">The location of the script</param>
        ''' <remarks></remarks>
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

        ''' <summary>
        ''' Executes a bash script and captures the output
        ''' </summary>
        ''' <param name="script">The location of the script</param>
        ''' <returns>String, the output of the script</returns>
        ''' <remarks></remarks>
        Public Shared Function ExecuteScriptWithOutput(ByVal script As String) As String
            Try
                Dim ret As String = ""
                Dim proc As New System.Diagnostics.Process()
                proc.StartInfo.FileName = "/bin/bash"
                proc.StartInfo.Arguments = script
                proc.StartInfo.UseShellExecute = False
                proc.StartInfo.RedirectStandardOutput = True
                proc.Start()

                ret = proc.StandardOutput.ReadToEnd()
                'proc.BeginOutputReadLine()
                proc.WaitForExit()
                proc.Close()
                Return ret
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
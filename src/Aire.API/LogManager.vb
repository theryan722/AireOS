Namespace Sys

    Namespace Logging

        Public Class Log
            Private Shared syslogloc As String = Aire.API.Compatibility.FixPath(AppDomain.CurrentDomain.BaseDirectory & "/SysData/syslog.txt")

#Region "Enums"

            Enum LogSource
                General
                MessageBox
                System
                Toast
            End Enum

#End Region

#Region "Private Methods"

            Private Shared Sub WriteToLog(ByVal logloc As String, ByVal txt As String)
                Try
                    Dim objWriter As New System.IO.StreamWriter(logloc, True)
                    objWriter.WriteLine(DateTime.Now.ToString() & " | " & txt)
                    objWriter.Close()
                Catch
                End Try
            End Sub

#End Region

#Region "Public Methods"

            ''' <summary>
            ''' Writes text to a specified log
            ''' </summary>
            ''' <param name="message">The message to log</param>
            ''' <param name="source">The source of the message, also determines which log will be written to</param>
            ''' <remarks></remarks>
            Public Shared Sub Write(ByVal message As String, Optional source As LogSource = LogSource.System)
                Select Case source
                    Case LogSource.General, LogSource.MessageBox, LogSource.Toast
                        WriteToLog(User.Current.Info.GetLogLocation, message)
                        'Case LogSource.MessageBox
                        '    If User.Current.Info.GetUsername <> "" Then
                        '        If User.Current.Settings.LogNotificationText Then
                        '            WriteToLog(User.Current.Info.GetLogLocation, message)
                        '        End If
                        '    End If
                    Case LogSource.System
                        WriteToLog(syslogloc, message)
                        'Case LogSource.Toast
                        '    If User.Current.Settings.LogNotificationText Then
                        '        WriteToLog(User.Current.Info.GetLogLocation, message)
                        '    End If
                End Select
            End Sub

#End Region

        End Class

    End Namespace

End Namespace
Namespace Sys

    Namespace Network

        Public Class Info

            Public Shared Function GetIfWireless() As Boolean
                Try
                    Dim res As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getnetworktype.sh")
                    Return res = "WIRELESS"
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return "ERROR"
                End Try
            End Function

            Public Shared Function GetIfNetworkConnection() As Boolean
                Try
                    Return Sys.Info.Network.IsAvailable()
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            Public Shared Function GetWirelessStrengthDBM() As Integer
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("iwconfig", "eth1")
                    Return CInt(res.Substring(res.IndexOf("level=") + 6, 4).Trim(" "))
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            Public Shared Function GetWirelessStrengthInBars() As Integer
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("iwconfig", "eth1")
                    Dim dbm As Integer = CInt(res.Substring(res.IndexOf("level=") + 6, 4).Trim(" "))
                    If dbm > -50 Then
                        Return 4
                    ElseIf dbm > -60 Then
                        Return 3
                    ElseIf dbm > -70 Then
                        Return 2
                    Else
                        Return 1
                    End If
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

        End Class

    End Namespace

End Namespace
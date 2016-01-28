Namespace Sys

    Namespace Network

        Public Class Info

            Public Shared Function GetIfWireless() As Boolean
                Dim res As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getnetworktype.sh")
                Return res = "WIRELESS"
            End Function

            Public Shared Function GetIfNetworkConnection() As Boolean
                Return Sys.Info.Network.IsAvailable()
            End Function

            Public Shared Function GetWirelessStrengthDBM() As Integer
                Dim res As String = Sys.Process.ExecuteCommandWithOutput("iwconfig", "eth1")
                Return res.Substring(res.IndexOf("level=") + 6, 4).Trim(" ")
            End Function

        End Class

    End Namespace

End Namespace
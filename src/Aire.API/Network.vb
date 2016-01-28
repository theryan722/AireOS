Namespace Sys

    Namespace Network

        Public Class Info

            Public Shared Function GetIfWireless() As Boolean
                Dim res As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getnetworktype.sh")
                Return res = "WIRELESS"
            End Function

        End Class

    End Namespace

End Namespace
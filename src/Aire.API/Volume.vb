Namespace Audio

    Public Class Volume

        Public Shared Sub Increase(ByVal amount As Integer)
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 +" & Math.Min(amount, 100) & "%")
        End Sub

        Public Shared Sub Decrease(ByVal amount As Integer)
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 -" & Math.Min(amount, 100) & "%")
        End Sub

        Public Shared Sub Mute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 1")
        End Sub

        Public Shared Sub Unmute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 0")
        End Sub

        Public Shared Sub ToggleMute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 toggle")
        End Sub

        Public Shared Function GetVolume() As Integer
            Dim temp As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getvolume.sh")
            If temp.Contains("%") Then
                temp.Replace("%", "")
            End If
            Return temp
        End Function

    End Class

End Namespace
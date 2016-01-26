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

        End Sub

        Public Shared Sub ToggleMute()

        End Sub

        Public Shared Function GetVolume() As Integer

        End Function

    End Class

End Namespace
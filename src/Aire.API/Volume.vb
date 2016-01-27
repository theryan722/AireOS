Namespace Audio

    Public Class Volume

#Region "Variables"

        Private Shared muted As Boolean = False
        Private Shared volstat As dlgVolumeStatus

#End Region

        Public Shared Sub Increase(ByVal amount As Integer)
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 +" & Math.Min(amount, 100) & "%")
            Sys.Events.Raise_VolumeChanged(GetVolume())
        End Sub

        Public Shared Sub Decrease(ByVal amount As Integer)
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 -" & Math.Min(amount, 100) & "%")
            Sys.Events.Raise_VolumeChanged(GetVolume())
        End Sub

        Public Shared Sub Mute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 1")
            Sys.Events.Raise_VolumeChanged(GetVolume())
            muted = True
        End Sub

        Public Shared Sub Unmute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 0")
            Sys.Events.Raise_VolumeChanged(GetVolume())
            muted = False
        End Sub

        Public Shared Sub ToggleMute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 toggle")
            Sys.Events.Raise_VolumeChanged(GetVolume())
            muted = If(muted, False, True)
        End Sub

        Public Shared Function GetVolume() As Integer
            Dim temp As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getvolume.sh")
            Dim ret As String = temp.Replace("%", "")
            Return Math.Min(CInt(ret), 100)
        End Function

        Public Shared Function GetIfMuted() As Boolean
            Return muted
        End Function

        Public Shared Sub DisplayVolumeStatus()
            If dlgVolumeStatus.Showing Then
                volstat.UpdateVolume(GetVolume())
            Else
                volstat = New dlgVolumeStatus
                volstat.Show()
            End If
        End Sub

    End Class

End Namespace
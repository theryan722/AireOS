Namespace Audio

    Public Class Volume

#Region "Volume Status"

#Region "Private"

        Private Shared volstatdisp As Boolean = False
        Private Shared volstat As dlgVolumeStatus

        Private Shared Sub VolStatusClosed()
            volstatdisp = False
            RemoveHandler volstat.StatClosed, AddressOf VolStatusClosed
        End Sub

#End Region

        Public Shared Sub DisplayVolumeStatus()
            If Not volstatdisp Then
                volstat = New dlgVolumeStatus(GetVolume())
                volstatdisp = True
                volstat.Show()
                AddHandler volstat.StatClosed, AddressOf VolStatusClosed
            End If
        End Sub

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
        End Sub

        Public Shared Sub Unmute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 0")
            Sys.Events.Raise_VolumeChanged(GetVolume())
        End Sub

        Public Shared Sub ToggleMute()
            Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 toggle")
            Sys.Events.Raise_VolumeChanged(GetVolume())
        End Sub

        Public Shared Function GetVolume() As Integer
            Dim temp As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getvolume.sh")
            Dim ret As String = temp.Replace("%", "")
            Return CInt(ret)
        End Function

    End Class

End Namespace
Namespace Audio

    Public Class Volume

#Region "Variables"

        Private Shared muted As Boolean = False
        Private Shared volstat As dlgVolumeStatus
        Private Shared volcont As dlgVolumeControl

#End Region

        Public Shared Sub Increase(ByVal amount As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 +" & Math.Min(amount, 100) & "%")
                Sys.Events.Raise_VolumeChanged(GetVolume())
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Sub Decrease(ByVal amount As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 -" & Math.Min(amount, 100) & "%")
                Sys.Events.Raise_VolumeChanged(GetVolume())
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Sub Mute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 1")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = True
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Sub Unmute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 0")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = False
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Sub ToggleMute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 toggle")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = If(muted, False, True)
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Function GetVolume() As Integer
            Try
                Dim temp As String = Sys.Process.ExecuteScriptWithOutput(Aire.DataManager.DataPaths.GetSysDataLocation & "/Scripts/getvolume.sh")
                Dim ret As String = temp.Replace("%", "")
                Return Math.Min(CInt(ret), 100)
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
                Return 0
            End Try
        End Function

        Public Shared Sub SetVolume(ByVal vol As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 " & Math.Min(vol, 100) & "%")
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        Public Shared Function GetIfMuted() As Boolean
                Return muted
        End Function

        Public Shared Sub DisplayVolumeControl()
            If Not dlgVolumeControl.Showing Then
                volcont = New dlgVolumeControl
                volcont.Show()
            End If
        End Sub

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
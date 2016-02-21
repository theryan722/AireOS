Namespace Audio

    Public Class Volume

#Region "Variables"

        Private Shared muted As Boolean = False
        Private Shared volstat As dlgVolumeStatus
        Private Shared volcont As dlgVolumeControl

#End Region

        ''' <summary>
        ''' Increases the volume
        ''' </summary>
        ''' <param name="amount">The amount to increase the volume by</param>
        ''' <remarks></remarks>
        Public Shared Sub Increase(ByVal amount As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 +" & Math.Min(amount, 100) & "%")
                Sys.Events.Raise_VolumeChanged(GetVolume())
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Decreases the volume
        ''' </summary>
        ''' <param name="amount">The amount to decrease the volume by</param>
        ''' <remarks></remarks>
        Public Shared Sub Decrease(ByVal amount As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 -" & Math.Min(amount, 100) & "%")
                Sys.Events.Raise_VolumeChanged(GetVolume())
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Mutes the volume
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub Mute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 1")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = True
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Unmutes the volume
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub Unmute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 0")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = False
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Toggles whether the volume is muted or not
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub ToggleMute()
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-mute 0 toggle")
                Sys.Events.Raise_VolumeChanged(GetVolume())
                muted = If(muted, False, True)
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Gets the volume
        ''' </summary>
        ''' <returns>Integer, the volume</returns>
        ''' <remarks></remarks>
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

        ''' <summary>
        ''' Sets the volume
        ''' </summary>
        ''' <param name="vol">The level to set the volume to</param>
        ''' <remarks></remarks>
        Public Shared Sub SetVolume(ByVal vol As Integer)
            Try
                Sys.Process.ExecuteCommand("pactl", "-- set-sink-volume 0 " & Math.Min(vol, 100) & "%")
            Catch ex As Exception
                Sys.Logging.Log.Write("ERROR: " & ex.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' Get whether the volume is muted or not
        ''' </summary>
        ''' <returns>True, if the volume is muted, otherwise false</returns>
        ''' <remarks></remarks>
        Public Shared Function GetIfMuted() As Boolean
                Return muted
        End Function

        ''' <summary>
        ''' Displays the system volume control
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub DisplayVolumeControl()
            If Not dlgVolumeControl.Showing Then
                volcont = New dlgVolumeControl
                volcont.Show()
            End If
        End Sub

        ''' <summary>
        ''' Displays the system volume status control
        ''' </summary>
        ''' <remarks></remarks>
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
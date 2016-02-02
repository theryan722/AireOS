Namespace Sys

    Public Class Events

#Region "Enums"

        Public Enum PowerState
            Shutdown
            Restart
            Hibernate
            Sleep
        End Enum

#End Region

#Region "Events"

        Public Shared Event SystemPowerStateChanged(ByVal change As PowerState)
        Public Shared Event VolumeChanged(ByVal volume As Integer)
        Public Shared Event BatteryPercentChanged(ByVal percent As Integer)
        Public Shared Event WindowClosed(ByVal window As String)

#End Region

#Region "Raise Event Methods"

        Public Shared Sub Raise_WindowClosed(ByVal window As String)
            RaiseEvent WindowClosed(window)
        End Sub

        Public Shared Sub Raise_SystemPowerStateChanged(ByVal change As PowerState)
            RaiseEvent SystemPowerStateChanged(change)
            Select Case change
                Case PowerState.Hibernate
                    Aire.API.Sys.Logging.Log.Write("System is hibernating.")
                Case PowerState.Restart
                    Aire.API.Sys.Logging.Log.Write("System is restarting.")
                Case PowerState.Shutdown
                    Aire.API.Sys.Logging.Log.Write("System is shutting down.")
                Case PowerState.Sleep
                    Aire.API.Sys.Logging.Log.Write("System is sleeping.")
            End Select
        End Sub

        Public Shared Sub Raise_VolumeChanged(ByVal volume As Integer)
            RaiseEvent VolumeChanged(volume)
            Audio.Volume.DisplayVolumeStatus()
        End Sub

        Public Shared Sub Raise_BatteryPercentChanged(ByVal percent As Integer)
            RaiseEvent BatteryPercentChanged(percent)
        End Sub

#End Region

    End Class

End Namespace
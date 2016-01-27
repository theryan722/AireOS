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

#End Region

#Region "Raise Event Methods"

        Public Shared Sub Raise_SystemPowerStateChange(ByVal change As PowerState)
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
        End Sub

#End Region

    End Class

End Namespace
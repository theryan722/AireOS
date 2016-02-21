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

        ''' <summary>
        ''' Raised when the system power state is changed, i.e. sleep, shutdown, restart, etc.
        ''' </summary>
        ''' <param name="change">The type of power state change</param>
        ''' <remarks></remarks>
        Public Shared Event SystemPowerStateChanged(ByVal change As PowerState)

        ''' <summary>
        ''' Raised when the volume is changed
        ''' </summary>
        ''' <param name="volume">The volume</param>
        ''' <remarks></remarks>
        Public Shared Event VolumeChanged(ByVal volume As Integer)

        ''' <summary>
        ''' Raised when the battery percentage is changed
        ''' </summary>
        ''' <param name="percent">The battery percentage</param>
        ''' <remarks></remarks>
        Public Shared Event BatteryPercentChanged(ByVal percent As Integer)

#End Region

#Region "Raise Event Methods"

        ''' <summary>
        ''' Raises the SystemPowerStateChanged event
        ''' </summary>
        ''' <param name="change">The powerstate change</param>
        ''' <remarks></remarks>
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

        ''' <summary>
        ''' Raises the VolumeChanged event
        ''' </summary>
        ''' <param name="volume">The volume</param>
        ''' <remarks></remarks>
        Public Shared Sub Raise_VolumeChanged(ByVal volume As Integer)
            RaiseEvent VolumeChanged(volume)
            Audio.Volume.DisplayVolumeStatus()
        End Sub

        ''' <summary>
        ''' Raises the BatteryPercentChanged event
        ''' </summary>
        ''' <param name="percent">The battery level</param>
        ''' <remarks></remarks>
        Public Shared Sub Raise_BatteryPercentChanged(ByVal percent As Integer)
            RaiseEvent BatteryPercentChanged(percent)
        End Sub

#End Region

    End Class

End Namespace
Namespace Sys

    Public Class Power

        Public Shared Sub ShowPowerDialog()
            Dim newb As New dlgPower
            newb.ShowDialog()
        End Sub

        Public Shared Sub Shutdown()
            Sys.Events.Raise_SystemPowerStateChange(Events.PowerState.Shutdown)
        End Sub

        Public Shared Sub Restart()
            Sys.Events.Raise_SystemPowerStateChange(Events.PowerState.Restart)
        End Sub

        Public Shared Sub Hibernate()
            Sys.Events.Raise_SystemPowerStateChange(Events.PowerState.Hibernate)
        End Sub

        Public Shared Sub Sleep()
            Sys.Events.Raise_SystemPowerStateChange(Events.PowerState.Sleep)
        End Sub

    End Class

End Namespace

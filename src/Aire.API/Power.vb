Namespace System

    Public Class Power

        Public Shared Sub Shutdown()
            System.Events.Raise_SystemPowerStateChange(Events.PowerState.Shutdown)
        End Sub

        Public Shared Sub Restart()
            System.Events.Raise_SystemPowerStateChange(Events.PowerState.Restart)
        End Sub

        Public Shared Sub Hibernate()
            System.Events.Raise_SystemPowerStateChange(Events.PowerState.Hibernate)
        End Sub

        Public Shared Sub Sleep()
            System.Events.Raise_SystemPowerStateChange(Events.PowerState.Sleep)
        End Sub

    End Class

End Namespace

Namespace System
    Public Class Power

        Public Shared Sub Shutdown()
            System.Events.Raise_SystemPowerStateChange(PowerState.Shutdown)
        End Sub

        Public Shared Sub Restart()
            System.Events.Raise_SystemPowerStateChange(PowerState.Restart)
        End Sub

        Public Shared Sub Hibernate()
            System.Events.Raise_SystemPowerStateChange(PowerState.Hibernate)
        End Sub

        Public Shared Sub Sleep()

        End Sub

    End Class
End Namespace

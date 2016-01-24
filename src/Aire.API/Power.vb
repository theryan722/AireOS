Namespace System
    Public Class Power

        Public Shared Sub Shutdown()
            System.Events.Raise_SystemPowerStateChange(PowerState.Shutdown)
        End Sub

        Public Shared Sub Restart()

        End Sub

        Public Shared Sub Hibernate()

        End Sub

        Public Shared Sub Sleep()

        End Sub

    End Class
End Namespace

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

        Public Shared Event SystemPowerStateChange(ByVal change As PowerState)

#End Region

#Region "Raise Event Methods"

        Public Shared Sub Raise_SystemPowerStateChange(ByVal change As PowerState)
            RaiseEvent SystemPowerStateChange(change)
        End Sub

#End Region

    End Class

End Namespace
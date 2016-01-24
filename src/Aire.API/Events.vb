Namespace System

    Public Enum PowerState
        Shutdown
        Restart
        Hibernate
        Sleep
    End Enum

    Public Class Events
        Public Shared Event SystemPowerStateChange(ByVal change As PowerState)
    End Class

End Namespace
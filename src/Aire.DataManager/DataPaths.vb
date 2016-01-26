Public Class DataPaths

    Public Shared Function GetOSLocation() As String

    End Function

    Public Shared Function GetSysDataLocation() As String
        Return AppDomain.CurrentDomain.BaseDirectory & "/SysData"
    End Function

End Class

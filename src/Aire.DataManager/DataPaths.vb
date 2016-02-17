Public Class DataPaths

    Public Shared Function GetOSLocation() As String
        Return AppDomain.CurrentDomain.BaseDirectory.TrimEnd("/")
    End Function

    Public Shared Function GetSysDataLocation() As String
        Return AppDomain.CurrentDomain.BaseDirectory & "SysData"
    End Function

    Public Shared Function GetSystemApplicationList() As String
        Return AppDomain.CurrentDomain.BaseDirectory & "SysData/sysapplist.txt"
    End Function

End Class

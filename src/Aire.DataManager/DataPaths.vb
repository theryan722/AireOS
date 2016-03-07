Public Class DataPaths

    ''' <summary>
    ''' Gets the location of the operating system
    ''' </summary>
    ''' <returns>String, the root path of the OS</returns>
    ''' <remarks></remarks>
    Public Shared Function GetOSLocation() As String
        Return AppDomain.CurrentDomain.BaseDirectory.TrimEnd("/")
    End Function

    ''' <summary>
    ''' Gets the system data location
    ''' </summary>
    ''' <returns>String, the path of the system data folder</returns>
    ''' <remarks></remarks>
    Public Shared Function GetSysDataLocation() As String
        Return AppDomain.CurrentDomain.BaseDirectory & "SysData"
    End Function

    ''' <summary>
    ''' Gets the system application list location
    ''' </summary>
    ''' <returns>String, the location of the system application list</returns>
    ''' <remarks></remarks>
    Public Shared Function GetSystemApplicationList() As String
        Return AppDomain.CurrentDomain.BaseDirectory & "SysData/sysapplist.txt"
    End Function

    ''' <summary>
    ''' Returns the highest visible directory for the user
    ''' </summary>
    ''' <returns>String, the rooth path</returns>
    ''' <remarks></remarks>
    Public Shared Function GetRootPath() As String
        'Todo
    End Function

End Class

Public Class Compatibility

    Public Shared Function FixPath(ByVal path As String) As String
        Return path.Replace("\", "/").Replace("//", "/")
    End Function

End Class

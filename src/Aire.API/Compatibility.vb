Public Class Compatibility

    Public Shared Function FixPath(ByVal path As String) As String
        Return path.Replace("\", "/")
    End Function

End Class

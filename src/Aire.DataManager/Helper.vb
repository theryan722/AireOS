Friend Class Helper

    ''' <summary>
    ''' Fixes the slashes in a path
    ''' </summary>
    ''' <param name="path">The path to fix</param>
    ''' <returns>String, the fixed path</returns>
    ''' <remarks></remarks>
    Public Shared Function FixPath(ByVal path As String) As String
        Return path.Replace("\", "/")
    End Function

End Class

Imports System.IO

Namespace Sys.IO

    Public Class File

        ''' <summary>
        ''' Writes text to a file
        ''' </summary>
        ''' <param name="file">The file to write to</param>
        ''' <param name="text">The text to write</param>
        ''' <param name="append">Whether or not to append text to the file</param>
        ''' <remarks></remarks>
        Public Shared Sub WriteText(ByVal file As String, ByVal text As String, Optional ByVal append As Boolean = False)
            Using writer As StreamWriter = New StreamWriter(file, append)
                writer.Write(text)
            End Using
        End Sub

    End Class

End Namespace

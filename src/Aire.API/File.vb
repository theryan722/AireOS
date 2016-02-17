Imports System.IO

Namespace Sys.IO

    Public Class File

        Public Shared Sub WriteText(ByVal file As String, ByVal text As String, Optional ByVal append As Boolean = False)
            Using writer As StreamWriter = New StreamWriter(file, append)
                writer.Write(text)
            End Using
        End Sub

    End Class

End Namespace

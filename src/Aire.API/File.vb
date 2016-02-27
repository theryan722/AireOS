Imports System.IO
Imports System.Text

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

        ''' <summary>
        ''' Reads text from a file
        ''' </summary>
        ''' <param name="sfile">The file to open and read</param>
        ''' <returns>String, the text of the file</returns>
        ''' <remarks>Allows multiple processes to read from the file asynchronously</remarks>
        Public Shared Function ReadTextNoLock(ByVal sfile As String) As String
            Using stream As FileStream = System.IO.File.Open(sfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim strb As New StringBuilder()
                Dim b As Byte() = New Byte(stream.Length) {}
                Dim temp As New UTF8Encoding(True)
                While stream.Read(b, 0, b.Length) > 0
                    strb.Append(temp.GetString(b))
                End While
                Return strb.ToString
            End Using
        End Function

    End Class

End Namespace

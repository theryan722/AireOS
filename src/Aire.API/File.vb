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
        ''' Writes text to a file
        ''' </summary>
        ''' <param name="file">The file to write to</param>
        ''' <param name="text">The text to write to the file</param>
        ''' <remarks>Does not place a lock on the file</remarks>
        Public Shared Sub SWrite(ByVal file As String, ByVal text As String)
            Aire.SMManager.Manager.UpdateFile(file, text)
        End Sub

        ''' <summary>
        ''' Reads text from a file
        ''' </summary>
        ''' <param name="file">The file to read from</param>
        ''' <returns>String, the text of the file</returns>
        ''' <remarks>Does not place a lock on the file</remarks>
        Public Shared Function SRead(ByVal file As String) As String
            Return Aire.SMManager.Manager.ReadFile(file)
        End Function

    End Class

End Namespace

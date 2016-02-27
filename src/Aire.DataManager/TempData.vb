Imports System.IO
Imports System.Text

Public Class TempData

    ''' <summary>
    ''' Gets the currently logged in user
    ''' </summary>
    ''' <value>The currently logged in user</value>
    ''' <returns>String, the username of the currently logged in user</returns>
    ''' <remarks></remarks>
    Public Shared Property LoggedInUser As String
        Get
            Return ReadTextNoLock(DataPaths.GetSysDataLocation & "/Temp/currentuser.txt")
        End Get
        Set(value As String)
            My.Computer.FileSystem.WriteAllText(DataPaths.GetSysDataLocation & "/Temp/currentuser.txt", value, False)
        End Set
    End Property

    ''' <summary>
    ''' Reads text from a file
    ''' </summary>
    ''' <param name="sfile">The file to open and read</param>
    ''' <returns>String, the text of the file</returns>
    ''' <remarks>Allows multiple processes to read from the file asynchronously</remarks>
    Private Shared Function ReadTextNoLock(ByVal sfile As String) As String
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

Imports System.IO

Public Class Manager

#Region "Public"

    Public Shared Sub UpdateFile(ByVal file As String, ByVal txt As String)
        Dim outStream = New FileStream(file, FileMode.Open, FileAccess.Write, FileShare.ReadWrite)
        Dim arr() As Byte = System.Text.Encoding.ASCII.GetBytes(txt)
        outStream.SetLength(0)
        outStream.Write(System.Text.Encoding.ASCII.GetBytes(txt), 0, arr.Count)
        outStream.Close()
    End Sub

    Public Shared Function ReadFile(ByVal file As String) As String
        Dim inStream = New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        Dim bytes() As Byte = New Byte((inStream.Length) - 1) {}
        Dim numBytesToRead As Integer = CType(inStream.Length, Integer)
        Dim numBytesRead As Integer = 0
        While (numBytesToRead > 0)
            Dim n As Integer = inStream.Read(bytes, numBytesRead, _
                numBytesToRead)
            If (n = 0) Then
                Exit While
            End If
            numBytesRead = (numBytesRead + n)
            numBytesToRead = (numBytesToRead - n)
        End While
        numBytesToRead = bytes.Length
        inStream.Close()
        Return System.Text.ASCIIEncoding.ASCII.GetString(bytes)
    End Function

#End Region

End Class
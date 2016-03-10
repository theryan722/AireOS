Public Class FileIcon

    Public Shared Function ConvertPathToIndex(ByVal ext As String, Optional isdirectory As Boolean = False) As Integer
        If System.IO.Directory.Exists(ext) Then
            Return 1
        End If
        Select Case System.IO.Path.GetExtension(ext)
            Case ".7z"
                Return 2
            Case ".cab"
                Return 3
            Case ".css"
                Return 4
            Case ".dll"
                Return 5
            Case ".doc"
                Return 6
            Case ".docx"
                Return 7
            Case ".exe"
                Return 8
            Case ".gif"
                Return 9
            Case ".html"
                Return 9
            Case ".jpg"
                Return 10
            Case ".mp3"
                Return 11
            Case ".mp4"
                Return 12
            Case ".pdf"
                Return 13
            Case ".png"
                Return 14
            Case ".rar"
                Return 15
            Case ".rtf"
                Return 16
            Case ".txt"
                Return 17
            Case ".wav"
                Return 18
            Case ".webm"
                Return 19
            Case ".xls"
                Return 20
            Case ".xlsx"
                Return 21
            Case ".xml"
                Return 22
            Case ".zip"
                Return 23
            Case Else
                Return 0
        End Select
    End Function

End Class

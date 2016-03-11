Public Class Helper

    Public Shared Function ConvertPathToIndex(ByVal ext As String, Optional isdrive As Boolean = False) As Integer
        If System.IO.Directory.Exists(ext) Then
            Return 1
        End If
        If isdrive Then
            Return 25
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
                Return 10
            Case ".jpg"
                Return 11
            Case ".mp3"
                Return 12
            Case ".mp4"
                Return 13
            Case ".pdf"
                Return 14
            Case ".png"
                Return 15
            Case ".rar"
                Return 16
            Case ".rtf"
                Return 17
            Case ".txt"
                Return 18
            Case ".wav"
                Return 19
            Case ".webm"
                Return 20
            Case ".xls"
                Return 21
            Case ".xlsx"
                Return 22
            Case ".xml"
                Return 23
            Case ".zip"
                Return 24
            Case Else
                Return 0
        End Select
    End Function

End Class

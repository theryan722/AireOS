Imports System.IO

Public Class FileProperties

    Private fpath As String

#Region "Methods"

    Public Function GetIfFileExists() As Boolean
        Return File.Exists(fpath)
    End Function

    Public Function GetFileSize() As String
        Return New FileInfo(fpath).Length
    End Function

    Public Function GetFullPath() As String
        Return fpath
    End Function

    Public Function GetFileCreationDate() As Date
        Return File.GetCreationTime(fpath)
    End Function

    Public Function GetFileModifiedDate() As Date
        Return File.GetLastWriteTime(fpath)
    End Function

    Public Function GetAccessedDate() As Date
        Return File.GetLastAccessTime(fpath)
    End Function

    Public Function GetIfReadOnly() As Boolean
        Return New FileInfo(fpath).IsReadOnly
    End Function

    Public Function GetFileSize() As String
        Dim DoubleBytes As Double
        If fpath.Length = 0 Then Return ""
        '---
        Dim TheSize As ULong = My.Computer.FileSystem.GetFileInfo(fpath).Length
        Dim SizeType As String = ""
        '---
        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

#End Region

    Public Sub New(ByVal path As String)
        fpath = path
    End Sub

End Class

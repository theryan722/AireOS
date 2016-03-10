Imports System.IO

Public Class FileProperties

    Private fpath As String

#Region "Methods"

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

    End Function

    Public Function GetIfHidden() As Boolean

    End Function

#End Region

    Public Sub New(ByVal path As String)
        fpath = path
    End Sub

End Class

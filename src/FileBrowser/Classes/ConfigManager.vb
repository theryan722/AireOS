Public Class ConfigManager

    Private Shared histloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/history.txt"
    Private Shared bookmarkloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/bookmarks.txt"

#Region "Enums"

    Public Enum FileViewStyle
        ExtraLargeIcons
        LargeIcons
        MediumIcons
        SmallIcons
        List
    End Enum

#End Region

#Region "Helper"

    Public Shared Function ReadFile(ByVal f As String) As List(Of String)
        Dim TextLine As New List(Of String)
        Dim bb As String = Aire.API.Sys.IO.File.SRead(f)
        For Each item As String In bb.Split(Environment.NewLine)
            TextLine.Add(item)
        Next
        Return TextLine
    End Function

#End Region

#Region "Properties"

    Public Shared Property ViewStyle As FileViewStyle

    Public Shared Property Topmost As Boolean

    Public Shared Property Sidebar As Boolean

    Public Shared Property NavigationPane As Boolean

    Public Shared Property SearchIsCaseSensitive As Boolean

#End Region

#Region "Methods"

    Public Shared Function ReadHistory() As List(Of String)
        Return ReadFile(histloc)
    End Function

#End Region

End Class

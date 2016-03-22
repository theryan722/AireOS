Public Class ConfigManager

    Private Shared histloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/history.txt"
    Private Shared bookmarkloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/bookmarks.txt"
    Private Shared setloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/config.txt"

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
        Get
            For Each item As String In ReadFile(setloc)
                If item.StartsWith("VS:") Then
                    Dim bb As String = item.Split(":")(1)
                    Select Case bb
                        Case "ExtraLargeIcons"
                            Return FileViewStyle.ExtraLargeIcons
                        Case "LargeIcons"
                            Return FileViewStyle.LargeIcons
                        Case "MediumIcons"
                            Return FileViewStyle.MediumIcons
                        Case "SmallIcons"
                            Return FileViewStyle.SmallIcons
                        Case "List"
                            Return FileViewStyle.List
                    End Select
                End If
            Next
            Return False
        End Get
        Set(value As FileViewStyle)
            Dim ss() As String
            ss = IO.File.ReadAllLines(setloc)
            ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("VS:"))))) = "VS:" & value.ToString
            IO.File.WriteAllLines(setloc, ss)
        End Set
    End Property

    Public Shared Property Topmost As Boolean
        Get
            For Each item As String In ReadFile(setloc)
                If item.StartsWith("TM:") Then
                    Return If(item.Split(":")(1) = "True", True, False)
                End If
            Next
            Return False
        End Get
        Set(value As Boolean)
            Dim ss() As String
            ss = IO.File.ReadAllLines(setloc)
            ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("TM:"))))) = "TM:" & value.ToString
            IO.File.WriteAllLines(setloc, ss)
        End Set
    End Property

    Public Shared Property Sidebar As Boolean
        Get
            For Each item As String In ReadFile(setloc)
                If item.StartsWith("SB:") Then
                    Return If(item.Split(":")(1) = "True", True, False)
                End If
            Next
            Return False
        End Get
        Set(value As Boolean)
            Dim ss() As String
            ss = IO.File.ReadAllLines(setloc)
            ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("SB:"))))) = "SB:" & value.ToString
            IO.File.WriteAllLines(setloc, ss)
        End Set
    End Property

    Public Shared Property NavigationPane As Boolean
        Get
            For Each item As String In ReadFile(setloc)
                If item.StartsWith("NP:") Then
                    Return If(item.Split(":")(1) = "True", True, False)
                End If
            Next
            Return False
        End Get
        Set(value As Boolean)
            Dim ss() As String
            ss = IO.File.ReadAllLines(setloc)
            ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("NP:"))))) = "NP:" & value.ToString
            IO.File.WriteAllLines(setloc, ss)
        End Set
    End Property

    Public Shared Property SearchIsCaseSensitive As Boolean
        Get
            For Each item As String In ReadFile(setloc)
                If item.StartsWith("CS:") Then
                    Return If(item.Split(":")(1) = "True", True, False)
                End If
            Next
            Return False
        End Get
        Set(value As Boolean)
            Dim ss() As String
            ss = IO.File.ReadAllLines(setloc)
            ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("CS:"))))) = "CS:" & value.ToString
            IO.File.WriteAllLines(setloc, ss)
        End Set
    End Property

#End Region

#Region "Methods"

#Region "History"

    Public Shared Function ReadHistory() As List(Of String)
        Return ReadFile(histloc)
    End Function

    Public Shared Sub AddToHistory(ByVal s As String)
        Dim objWriter As New System.IO.StreamWriter(histloc, True)
        objWriter.WriteLine(s)
        objWriter.Close()
    End Sub

    Public Shared Sub ClearHistory()
        Dim stream As New IO.StreamWriter(histloc, False)
        stream.Write("")
        stream.Close()
    End Sub

#End Region

#Region "Bookmarks"

    Public Shared Function ReadBookmarks() As List(Of String)
        Return ReadFile(bookmarkloc)
    End Function

    Public Shared Sub AddBookmark(ByVal s As String)
        Dim objWriter As New System.IO.StreamWriter(bookmarkloc, True)
        objWriter.WriteLine(s)
        objWriter.Close()
    End Sub

    Public Shared Sub ClearBookmarks()
        Dim stream As New IO.StreamWriter(bookmarkloc, False)
        stream.Write("")
        stream.Close()
    End Sub

    Public Shared Sub RemoveBookmark(ByVal s As String)
        Dim sb As New System.Text.StringBuilder
        For Each line As String In IO.File.ReadLines(bookmarkloc)
            If Not line = s Then
                sb.AppendLine(line)
            End If
        Next
        My.Computer.FileSystem.WriteAllText(bookmarkloc, sb.ToString, False)
    End Sub

#End Region

#End Region

End Class
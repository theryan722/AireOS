Public Class DataManager

    Private Shared loc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser"
    Private Shared setloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/config.txt"
    Private Shared histloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/history.txt"
    Private Shared bookmarkloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/FileBrowser/bookmarks.txt"

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

    Public Shared Sub CheckAndRepairData()
        CheckAndRepairConfig()
    End Sub

    Public Shared Sub CheckAndRepairConfig()
        Dim oconf As String = "VS:LargeIcons" & vbNewLine & "TM:False" & vbNewLine & "SB:False" & vbNewLine & "NP:False" & vbNewLine & "CS:False"
        If ReadFile(setloc).Count < 5 Then
            Aire.API.Sys.IO.File.SWrite(setloc, oconf)
            'System.IO.File.WriteAllText(loc & "/config.txt", oconf)
        End If
    End Sub

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

End Class
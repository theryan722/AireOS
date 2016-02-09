Imports System.IO

Public Class ConfigManager

    Private Shared setloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/Terminal/config.txt"

#Region "Helper"

    Public Shared Function ReadConfig() As List(Of String)
        Dim TextLine As New List(Of String)
        Dim objReader As New System.IO.StreamReader(setloc)
        Do While objReader.Peek() <> -1
            TextLine.Add(objReader.ReadLine())
        Loop
        Return TextLine
    End Function

#End Region

#Region "Get"

    Public Shared Function GetBackColor() As Color
        For Each item As String In ReadConfig()
            If item.StartsWith("BC:") Then
                Return Color.FromArgb(item.Split(":")(1))
            End If
        Next
    End Function

    Public Shared Function GetForeColor() As Color
        For Each item As String In ReadConfig()
            If item.StartsWith("FC:") Then
                Return Color.FromArgb(item.Split(":")(1))
            End If
        Next
    End Function

    Public Shared Function GetIfTopmost() As Boolean
        For Each item As String In ReadConfig()
            If item.StartsWith("TM:") Then
                Return If(item.Split(":")(1) = "True", True, False)
            End If
        Next
    End Function

    Public Shared Function GetIfFullscreen() As Boolean
        For Each item As String In ReadConfig()
            If item.StartsWith("FS:") Then
                Return If(item.Split(":")(1) = "True", True, False)
            End If
        Next
    End Function

    Public Shared Function GetIfAllowExternal() As Boolean
        For Each item As String In ReadConfig()
            If item.StartsWith("AE:") Then
                Return If(item.Split(":")(1) = "True", True, False)
            End If
        Next
    End Function

    Public Shared Function GetIfDisplayMenu() As Boolean
        For Each item As String In ReadConfig()
            If item.StartsWith("DM:") Then
                Return If(item.Split(":")(1) = "True", True, False)
            End If
        Next
    End Function

#End Region

#Region "Set"

    Public Shared Sub SetBackColor(ByVal clr As Color)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("BC:"))))) = "BC:" & clr.ToArgb.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

    Public Shared Sub SetForeColor(ByVal clr As Color)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("FC:"))))) = "FC:" & clr.ToArgb.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

    Public Shared Sub SetIfTopmost(ByVal topmost As Boolean)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("TM:"))))) = "TM:" & topmost.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

    Public Shared Sub SetIfFullscreen(ByVal fullscreen As Boolean)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("FS:"))))) = "FS:" & fullscreen.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

    Public Shared Sub SetIfAllowExternal(ByVal allow As Boolean)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("AE:"))))) = "AE:" & allow.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

    Public Shared Sub SetIfDisplayMenu(ByVal display As Boolean)
        Dim ss() As String
        ss = File.ReadAllLines(setloc)
        ss(Array.IndexOf(ss, Array.Find(ss, Function(x) (x.StartsWith("DM:"))))) = "DM:" & display.ToString
        File.WriteAllLines(setloc, ss)
    End Sub

#End Region

End Class

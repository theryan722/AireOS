Public Class ConfigManager

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

#Region "Properties"

    Public Shared Property ViewStyle As FileViewStyle
        Get
            For Each item As String In DataManager.ReadFile(setloc)
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
            For Each item As String In DataManager.ReadFile(setloc)
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
            For Each item As String In DataManager.ReadFile(setloc)
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
            For Each item As String In DataManager.ReadFile(setloc)
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
            For Each item As String In DataManager.ReadFile(setloc)
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

End Class
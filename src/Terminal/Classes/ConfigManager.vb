Public Class SettingsReader

    Private Shared setloc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/Terminal/config.txt"

#Region "Helper"

    Private Shared Function ReadConfig() As List(Of String)
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
        
    End Function

    Public Shared Function GetForeColor() As Color

    End Function

    Public Shared Function GetIfTopmost() As Boolean

    End Function

    Public Shared Function GetIfFullscreen() As Boolean

    End Function

    Public Shared Function GetIfAllowExternal() As Boolean

    End Function

#End Region

#Region "Set"

    Public Shared Sub SetBackColor(ByVal clr As Color)

    End Sub

    Public Shared Sub SetForeColor(ByVal clr As Color)

    End Sub

    Public Shared Sub SetIfTopmost(ByVal topmost As Boolean)

    End Sub

    Public Shared Sub SetIfFullscreen(ByVal fullscreen As Boolean)

    End Sub

    Public Shared Sub SetIfAllowExternal(ByVal allow As Boolean)

    End Sub

#End Region

End Class

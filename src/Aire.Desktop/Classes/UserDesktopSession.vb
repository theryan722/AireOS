Public Class UserDesktopSession

#Region "Properties"

    Public Property User As String
    Public Property Desktop As frmDesktop

#End Region

#Region "Public"

    Public Sub LoadSession()
        DisplayDesktop()
    End Sub

    Public Sub HideSession()
        Desktop.Hide()
        Desktop.StopUpdating()
        For Each item As DesktopWindows In Desktop.Windows
            item.HideAll()
        Next
    End Sub

    Public Sub CloseSession()
        Manager.DesktopSessions.Remove(Me)
        Desktop.Close()
    End Sub

    Public Sub LoadSettings()
        Desktop.SetDesktopBackground(Aire.API.User.Current.Settings.DesktopBackgroundImage, Aire.API.User.Current.Settings.DesktopBackgroundImageLayout)
        Desktop.SetAppBarColor(Aire.API.User.Current.Settings.AppBarColor)
        Desktop.SetLaunchBarColor(Aire.API.User.Current.Settings.LaunchBarColor)
    End Sub

#End Region

#Region "Private"

    Private Sub DisplayDesktop()
        Desktop.Show()
    End Sub

#End Region

End Class
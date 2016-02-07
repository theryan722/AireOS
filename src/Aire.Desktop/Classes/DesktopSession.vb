﻿Public Class DesktopSession

#Region "Properties"

    Public Property User As String
    Public Property Desktop As frmDesktop
    Public Property LaunchBar As bar_launchbar

#End Region

#Region "Public"

    Public Sub LoadSession()
        DisplayDesktop()
        DisplayLaunchBar()
    End Sub

    Public Sub HideSession()
        Desktop.Hide()
        LaunchBar.Hide()
        LaunchBar.StopUpdating()
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
        LaunchBar.SetBackColor(Aire.API.User.Current.Settings.LaunchBarColor)
    End Sub

#End Region

#Region "Private"

    Private Sub DisplayDesktop()
        Desktop.Show()
    End Sub

    Private Sub DisplayLaunchBar()
        Dim b As Point = Desktop.PointToScreen(Desktop.pnl_launchbar.Location)
        LaunchBar.Size = Desktop.pnl_launchbar.Size
        LaunchBar.Location = b
        LaunchBar.Show()
        LaunchBar.Height += Desktop.pnl_appbar_bottom.Height
        LaunchBar.Width = Desktop.pnl_launchbar.Width
    End Sub

#End Region

End Class
﻿Public Class DesktopSession

#Region "Properties"

    Public Property User As String
    Public Property Desktop As frmDesktop
    Public Property LaunchBar As bar_launchbar

#End Region

#Region "Public"

    Public Sub LoadSession()
        DisplayDesktop()
    End Sub

    Public Sub DisplayBars()
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

#End Region

#Region "Private"

    Private Sub DisplayDesktop()
        Desktop.Show()
    End Sub

    Private Sub DisplayLaunchBar()
        LaunchBar.Show()
        Dim b As Point = Desktop.PointToScreen(Desktop.pnl_launchbar_loc.Location)
        LaunchBar.Size = Desktop.pnl_launchbar_loc.Size
        LaunchBar.Location = b
        Dim c As Point = Desktop.PointToScreen(Desktop.pnl_launchbar_loc.Location)
        Dim newb As New bar_launchbar(Desktop)
        newb.Show()
        newb.Size = Desktop.pnl_launchbar_loc.Size
        newb.Location = c
        LaunchBar.Close()
        LaunchBar = newb

    End Sub

#End Region

End Class
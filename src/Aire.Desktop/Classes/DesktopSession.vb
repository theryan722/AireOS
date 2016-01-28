Public Class DesktopSession

#Region "Properties"

    Public Property User As String
    Public Property Desktop As frmDesktop
    Public Property LaunchBar As bar_launchbar
    Public Property AppBarTop As bar_appbar
    Public Property AppBarBottom As bar_appbar

#End Region

#Region "Public"

    Public Sub LoadSession()
        DisplayDesktop()
        DisplayLaunchBar()
        DisplayAppBarTop()
        DisplayAppBarBottom()
    End Sub

    Public Sub HideSession()
        Desktop.Hide()
        LaunchBar.Hide()
        AppBarTop.Hide()
        AppBarBottom.Hide()
        For Each item As DesktopWindows In Desktop.Windows
            item.HideAll()
        Next
    End Sub

    Public Sub CloseSession()

    End Sub

#End Region

#Region "Private"

    Private Sub DisplayDesktop()
        Desktop.Show()
    End Sub

    Private Sub DisplayLaunchBar()
        Dim b As Point = Desktop.PointToScreen(Desktop.pnl_launchbar_loc.Location)
        LaunchBar.Show()
        LaunchBar.Size = Desktop.pnl_launchbar_loc.Size
        LaunchBar.Location = b
        LaunchBar.Parent = Desktop
    End Sub

    Private Sub DisplayAppBarTop()
        Dim b As Point = Desktop.PointToScreen(Desktop.pnl_appbar_top_loc.Location)
        AppBarTop.Show()
        AppBarTop.Size = Desktop.pnl_appbar_top_loc.Size
        AppBarTop.Location = b
        AppBarTop.Parent = Desktop
    End Sub

    Private Sub DisplayAppBarBottom()
        Dim b As Point = Desktop.PointToScreen(Desktop.pnl_appbar_bottom_loc.Location)
        AppBarBottom.Show()
        AppBarBottom.Size = Desktop.pnl_appbar_bottom_loc.Size
        AppBarBottom.Location = b
        AppBarBottom.Parent = Desktop
    End Sub

#End Region

End Class

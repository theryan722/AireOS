Public Class frmLauncher

#Region "Variables/Properties"

    Private bar As bar_launchbar
    Private desktop As frmDesktop
    Public Shared Property Showing As Boolean = False
#End Region

#Region "UI"

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Aire.API.User.Current.Actions.ShowLogoutDialog()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not frmSearch.Showing Then
            Dim newb As New frmSearch
            newb.Show()
            newb.Location = PointToScreen(bar.btnLauncher.Location)
        End If
    End Sub

    Private Sub btnFileExplorer_Click(sender As Object, e As EventArgs) Handles btnFileExplorer.Click

    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Aire.API.Sys.Power.Actions.ShowPowerDialog()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadUI()
        btnProfile.BackgroundImage = Aire.API.User.Current.Settings.ProfilePicture
    End Sub

#End Region

#Region "frmLauncher"

    Public Sub New(ByVal frm As bar_launchbar, ByVal frm2 As frmDesktop)
        InitializeComponent()
        bar = frm
        desktop = frm2
    End Sub

    Private Sub frmLauncher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmLauncher.Showing = False
    End Sub

    Private Sub frmLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLauncher.Showing = True
        LoadUI()
    End Sub

    Private Sub frmLauncher_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

#End Region

End Class
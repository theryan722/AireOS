Public Class frmLauncher

#Region "Variables/Properties"

    Private desktop As frmDesktop
    Public Shared Property Showing As Boolean = False

#End Region

#Region "UI"

#Region "btnProfile"

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Aire.API.User.Current.Actions.ShowLogoutDialog()
    End Sub

    Private Sub btnProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnProfile.MouseEnter
        btnProfile.BackColor = Aire.SysColors.Colors.GradientActiveCaption
    End Sub

    Private Sub btnProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnProfile.MouseLeave
        btnProfile.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "btnOptions"

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

    End Sub

    Private Sub btnOptions_MouseEnter(sender As Object, e As EventArgs) Handles btnOptions.MouseEnter
        btnOptions.BackColor = Aire.SysColors.Colors.GradientActiveCaption
    End Sub

    Private Sub btnOptions_MouseLeave(sender As Object, e As EventArgs) Handles btnOptions.MouseLeave
        btnOptions.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "btnSearch"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not frmSearch.Showing Then
            Dim newb As New frmSearch
            newb.Show()
            newb.Location = PointToScreen(desktop.btnLauncher.Location)
        End If
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.BackColor = Aire.SysColors.Colors.GradientActiveCaption
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "btnFileBrowser"

    Private Sub btnFileBrowser_Click(sender As Object, e As EventArgs) Handles btnFileBrowser.Click

    End Sub

    Private Sub btnFileBrowser_MouseEnter(sender As Object, e As EventArgs) Handles btnFileBrowser.MouseEnter
        btnFileBrowser.BackColor = Aire.SysColors.Colors.GradientActiveCaption
    End Sub

    Private Sub btnFileBrowser_MouseLeave(sender As Object, e As EventArgs) Handles btnFileBrowser.MouseLeave
        btnFileBrowser.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "btnPower"

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Aire.API.Sys.Power.Actions.ShowPowerDialog()
    End Sub

    Private Sub btnPower_MouseEnter(sender As Object, e As EventArgs) Handles btnPower.MouseEnter
        btnPower.BackColor = Aire.SysColors.Colors.GradientActiveCaption
    End Sub

    Private Sub btnPower_MouseLeave(sender As Object, e As EventArgs) Handles btnPower.MouseLeave
        btnPower.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter AndAlso txtSearch.Text <> "" Then
            If Not frmSearch.Showing Then
                Dim newb As New frmSearch(txtSearch.Text)
                newb.Show()
                newb.Location = PointToScreen(desktop.btnLauncher.Location)
            End If
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub LoadApplications()
        'Load System Applications
        If My.Computer.FileSystem.ReadAllText(Aire.DataManager.DataPaths.GetSystemApplicationList) <> "" Then
            Dim objReader As New System.IO.StreamReader(Aire.DataManager.DataPaths.GetSystemApplicationList)
            Do While objReader.Peek() <> -1
                Dim arr() As String = objReader.ReadLine().Split("|")
                Dim newb As New LauncherItem(arr(1), arr(0))
                newb.LauncherForm = Me
                newb.Dock = DockStyle.Top
                pnl_applications.Controls.Add(newb)
            Loop
        End If
        'Load User Applications
        Dim bb As List(Of String) = Aire.API.User.Current.Info.GetAppList
        If bb.Count > 0 Then
            For Each item As String In bb
                Dim arr() As String = item.Split("|")
                Dim newb As New LauncherItem(arr(1), arr(0))
                newb.LauncherForm = Me
                newb.Dock = DockStyle.Top
                pnl_applications.Controls.Add(newb)
            Next
        End If
    End Sub

    Private Sub LoadUI()
        FixBackColor()
        btnProfile.BackgroundImage = Image.FromFile(Aire.API.User.Current.Settings.ProfilePicture)
        lblUsername.Text = Aire.API.User.Current.Info.GetUsername
        LoadApplications()
    End Sub

    Private Sub FixBackColor()
        pnl_right.BackColor = Aire.SysColors.Colors.ActiveCaption
        pnl_bottom.BackColor = Aire.SysColors.Colors.ActiveCaption
        pnl_user.BackColor = Aire.SysColors.Colors.ActiveCaption
        pnl_right_title.BackColor = Aire.SysColors.Colors.ActiveCaption
        pnl_pinned.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "frmLauncher"

    Public Sub New(ByVal frm As frmDesktop)
        InitializeComponent()
        desktop = frm
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
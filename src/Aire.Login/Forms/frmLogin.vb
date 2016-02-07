Public Class frmLogin
    Private okaytoclose As Boolean = False
    Public Property LBForm As frmLoginBackground

#Region "UI"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If VerifyFields() AndAlso VerifyPassword(txt_username.Text, txt_password.Text) Then
            Aire.API.User.Users.Actions.LoginUser(txt_username.Text, txt_password.Text)
            Aire.Desktop.Manager.LoadDesktopSession(txt_username.Text, txt_password.Text)
            okaytoclose = True
            Me.Close()
            LBForm.Close()
        Else
            Dim bb As New Aire.API.MessageBox("Invalid username or password, or the fields were not properly filled out.", "Error", API.MessageBox.MessageBoxButtons.OkOnly, API.MessageBox.MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_otherusers_Click(sender As Object, e As EventArgs) Handles btnOtherUsers.Click
        If lb_users.Visible Then
            lb_users.Hide()
        Else
            lb_users.Show()
        End If
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Aire.API.Sys.Power.Actions.ShowPowerDialog()
    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        If Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            Dim bb As New Aire.API.MessageBox(Aire.API.User.Users.Info.GetPasswordHintForUser(txt_username.Text), "Password Hint", API.MessageBox.MessageBoxButtons.OkOnly, API.MessageBox.MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub HandleShutdownEvents(ByVal powertype As Aire.API.Sys.Events.PowerState)
        If powertype = API.Sys.Events.PowerState.Shutdown Then
            okaytoclose = True
        ElseIf powertype = API.Sys.Events.PowerState.Restart Then
            okaytoclose = True
        End If
    End Sub

#End Region

#Region "lb_users"

    Private Sub lb_users_LostFocus(sender As Object, e As EventArgs) Handles lb_users.LostFocus
        lb_users.Hide()
    End Sub

    Private Sub lb_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_users.SelectedIndexChanged
        If lb_users.SelectedIndex <> -1 Then
            txt_username.Text = lb_users.SelectedItem
            txt_password.Clear()
            lb_users.Hide()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If txt_username.Text = "" Or Not Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            ret = False
        End If
        Return ret
    End Function

    Private Function VerifyPassword(ByVal user As String, ByVal pass As String) As Boolean
        Return Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass)
    End Function

    Private Sub InitializeUI()
        lb_users.Items.Clear()
        For Each item As String In Aire.API.User.Users.Info.GetAllUsers
            lb_users.Items.Add(item)
        Next
        If lb_users.Items.Count > 0 Then
            btnOtherUsers.Visible = True
        End If
    End Sub

#End Region

#Region "frmLogin"

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not okaytoclose Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me, frmLoginBackground)
        AddHandler Aire.API.Sys.Events.SystemPowerStateChanged, AddressOf HandleShutdownEvents
        InitializeUI()
    End Sub

#End Region

End Class

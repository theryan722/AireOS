Public Class frmLogin
    Private okaytoclose As Boolean = False

#Region "UI"

    Private Sub lb_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_users.SelectedIndexChanged
        If lb_users.SelectedIndex <> -1 Then
            txt_username.Text = lb_users.SelectedItem
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
        Aire.API.Sys.Power.ShowPowerDialog()
    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        If Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            Dim bb As New Aire.API.MessageBox(Aire.API.User.Users.Info.GetPasswordHintForUser(txt_username.Text), "Password Hint", API.MessageBox.MessageBoxButtons.OkOnly, API.MessageBox.MessageBoxIcon.Information)
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



#End Region

#Region "Methods"

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If txt_username.Text = "" Or Not Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            ret = False
        End If
        Return ret
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If VerifyFields() Then

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
        AddHandler Aire.API.Sys.Events.SystemPowerStateChange, AddressOf HandleShutdownEvents
        InitializeUI()
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Aire.API.User.Users.Actions.CreateUser(TextBox1.Text, "fdsfds", Aire.API.Cryptography.Passwords.GenerateSalt(), "", False, "fddsfdsfdsfdsf", 0)
    End Sub

End Class

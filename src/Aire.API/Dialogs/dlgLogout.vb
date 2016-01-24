Friend Class dlgLogout

#Region "UI"

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Aire.API.User.Current.Actions.Logout()
        Me.Close()
    End Sub

    Private Sub btnSwitchUser_Click(sender As Object, e As EventArgs) Handles btnSwitchUser.Click
        Aire.API.User.Current.Actions.SwitchUser()
        Me.Close()
    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click

    End Sub

#End Region

#Region "dlgLogout"

    Private Sub dlgLogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me)
    End Sub

#End Region
    

End Class
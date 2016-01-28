Friend Class dlgPower

#Region "UI"

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Aire.API.Sys.Power.Actions.Shutdown()
        Me.Close()
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        Aire.API.Sys.Power.Actions.Sleep()
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Aire.API.Sys.Power.Actions.Restart()
        Me.Close()
    End Sub

    Private Sub btnHibernate_Click(sender As Object, e As EventArgs) Handles btnHibernate.Click
        Aire.API.Sys.Power.Actions.Hibernate()
        Me.Close()
    End Sub

#End Region

#Region "dlgPower"

    Private Sub dlgPower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me)
    End Sub

#End Region

End Class
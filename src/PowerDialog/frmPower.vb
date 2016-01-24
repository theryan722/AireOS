Public Class frmPower

#Region "UI"

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Aire.API.System.Power.Shutdown()
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        Aire.API.System.Power.Sleep()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Aire.API.System.Power.Restart()
    End Sub

    Private Sub btnHibernate_Click(sender As Object, e As EventArgs) Handles btnHibernate.Click
        Aire.API.System.Power.Hibernate()
    End Sub

#End Region

#Region "frmPower"

    Private Sub frmPower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me)
    End Sub

#End Region

End Class

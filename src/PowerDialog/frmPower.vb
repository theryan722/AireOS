Public Class frmPower

#Region "UI"

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Aire.API.Sys.Power.Shutdown()
        Me.Close()
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        Aire.API.Sys.Power.Sleep()
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Aire.API.Sys.Power.Restart()
        Me.Close()
    End Sub

    Private Sub btnHibernate_Click(sender As Object, e As EventArgs) Handles btnHibernate.Click
        Aire.API.Sys.Power.Hibernate()
        Me.Close()
    End Sub

#End Region

#Region "frmPower"

    Private Sub frmPower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me)
    End Sub

#End Region

End Class

Public Class frmPower

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Aire.API.System.Power.Shutdown()
    End Sub

    Private Sub btnSleep_Click(sender As Object, e As EventArgs) Handles btnSleep.Click
        Aire.API.System.Power.Sleep()
    End Sub

End Class

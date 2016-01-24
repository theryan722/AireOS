Public Class frmPower

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Aire.API.System.Power.Shutdown()
    End Sub

End Class

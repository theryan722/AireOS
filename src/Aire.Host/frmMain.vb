Public Class frmMain

    Private Sub HandlePowerStateChange(ByVal change As Aire.API.Sys.Events.PowerState)
        Select Case change
            Case API.Sys.Events.PowerState.Restart, API.Sys.Events.PowerState.Shutdown
                Me.Close()
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Visible = False
        Me.WindowState = FormWindowState.Minimized
        AddHandler Aire.API.Sys.Events.SystemPowerStateChanged, AddressOf HandlePowerStateChange
        Dim newb As New Aire.Login.frmLoginBackground
        newb.Show()
        newb.Focus()
    End Sub
End Class

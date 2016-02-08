Public Class frmMain

    Private Sub HandlePowerStateChange(ByVal change As Aire.API.Sys.Events.PowerState)
        Select Case change
            Case API.Sys.Events.PowerState.Restart, API.Sys.Events.PowerState.Shutdown
                Me.Close()
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Aire.API.Sys.Events.SystemPowerStateChanged, AddressOf HandlePowerStateChange
        Dim newb As New Aire.Login.frmLoginBackground
        newb.Show()
        newb.Focus()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Visible = False
    End Sub

End Class
Public Class frmLogin
    Private okaytoclose As Boolean = False

#Region "UI"

    Private Sub btn_otherusers_Click(sender As Object, e As EventArgs) Handles btnOtherUsers.Click
        If lb_users.Visible Then
            lb_users.Hide()
        Else
            lb_users.Show()
        End If
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Dim newb As New PowerDialog.frmPower
        newb.ShowDialog()
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub HandleShutdownEvents(ByVal powertype As Aire.API.System.Events.PowerState)
        If powertype = API.System.Events.PowerState.Shutdown Then
            okaytoclose = True
        ElseIf powertype = API.System.Events.PowerState.Restart Then
            okaytoclose = True
        End If
    End Sub

#End Region

#Region "lb_users"



#End Region

#Region "Methods"



    Private Sub InitializeUI()
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
        AddHandler Aire.API.System.Events.SystemPowerStateChange, AddressOf HandleShutdownEvents
        InitializeUI()
    End Sub

#End Region

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txt_username.Text <> "" AndAlso txt_password.Text <> "" Then

        End If
    End Sub
End Class

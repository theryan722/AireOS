Public Class frmLoginBackground

    Private Sub frmLoginBackground_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Aire.SysColors.Colors.ActiveCaption
        frmLogin.Show()
        frmLogin.LBForm = Me
    End Sub

End Class
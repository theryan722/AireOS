Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Visible = False
        Me.WindowState = FormWindowState.Minimized
        Dim newb As New Aire.Login.frmLoginBackground
        newb.Show()
        newb.Focus()
    End Sub
End Class

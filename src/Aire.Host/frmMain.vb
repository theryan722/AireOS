Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim newb As New Aire.Login.frmLoginBackground
        newb.Show()
    End Sub
End Class

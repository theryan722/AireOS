Public Class frmBack

    Private Sub frmBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Aire.SysColors.Colors.ActiveCaption
        frmMain.ShowDialog()
    End Sub
End Class
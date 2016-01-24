Public Class Manager

    Public Shared Sub DisplayInitialLogin()
        Dim newb As New frmLoginBackground
        Dim newl As New frmLogin
        newb.Show()
        newl.ShowDialog(newb)
    End Sub

End Class

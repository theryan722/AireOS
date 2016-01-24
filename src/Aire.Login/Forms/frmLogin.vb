Public Class frmLogin
    Private okaytoclose As Boolean = False
#Region "UI"



#End Region

#Region "Methods"



#End Region

#Region "frmLogin"

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not okaytoclose Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aire.API.FormPosition.CenterForm(Me, frmLoginBackground)
    End Sub

#End Region

End Class

Public Class frmShowDesktop

#Region "Variables"

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    Private desk As frmDesktop

#End Region

#Region "frmShowDesktop"

    Public Sub New(ByVal desktop As frmDesktop)
        InitializeComponent()
        desk = desktop
    End Sub

    Private Sub frmShowDesktop_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick

    End Sub

    Private Sub frmShowDesktop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmShowDesktop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmShowDesktop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

#End Region

End Class
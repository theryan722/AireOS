﻿Public Class UserPermissionDialog

#Region "Properties/Variables"

    Private permlevel As Integer
    Private allowothers As Boolean
    Public Property PermissionGranted As PermissionCertificate

#End Region

#Region "UI"

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ShowOtherUsers()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub ShowOtherUsers(Optional ByVal button As Boolean = False)
        If button Then
            btnUsers.Show()
        End If
        lb_users.Show()
    End Sub

    Private Sub HideOtherUsers(Optional ByVal button As Boolean = False)
        If button Then
            btnUsers.Hide()
        End If
        lb_users.Hide()
    End Sub

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If txt_username.Text = "" Or Not Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            ret = False
        End If
        Return ret
    End Function

    Private Function VerifyPassword(ByVal user As String, ByVal pass As String) As Boolean
        Return Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass)
    End Function

#End Region

#Region "UserPermissionDialog"

    Public Sub New(ByVal requiredpermissionlevel As Integer, Optional ByVal defaultuser As String = "", Optional ByVal allowotherusers As Boolean = True, Optional ByVal displayotherusers As Boolean = True, Optional ByVal title As String = "User Permission", Optional ByVal message As String = "")
        InitializeComponent()
        permlevel = requiredpermissionlevel
        txt_username.Text = defaultuser
        If displayotherusers Then
            ShowOtherUsers(True)
        End If
        allowothers = allowotherusers
        Me.Text = title
        If message = "" Then
            Me.Height -= 40
        Else
            txt_msg.Text = message
            txt_msg.Show()
        End If
        Me.ShowDialog()
    End Sub

#End Region

End Class
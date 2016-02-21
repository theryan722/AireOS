Public Class UserPermissionDialog

#Region "Properties/Variables"

    Private ouser As String
    Private permlevel As Integer
    Private allowothers As Boolean
    Public Property PermissionGranted As PermissionCertificate

#End Region

#Region "UI"

    Private Sub lb_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_users.SelectedIndexChanged
        If lb_users.SelectedIndex <> -1 Then
            txt_username.Text = lb_users.SelectedItem
            txt_password.Clear()
            lb_users.Hide()
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ShowOtherUsers()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
            CreateCertificate(False, txt_username.Text, Aire.API.User.Users.Info.GetPermissionLevelForUser(txt_username.Text))
        Else
            CreateCertificate(False)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If VerifyFields() Then
            If VerifyUser(txt_username.Text, txt_password.Text) Then
                CreateCertificate(txt_username.Text, Aire.API.User.Users.Info.GetPermissionLevelForUser(txt_username.Text), True)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Dim bb As New Aire.API.MessageBox("Username or password was incorrect.", "Error", MessageBox.MessageBoxButtons.OkOnly, MessageBox.MessageBoxIcon.Warning)
            End If
        Else
            Dim bb As New Aire.API.MessageBox("Username or password was incorrect, or the user does not have the required permissions.", "Error", MessageBox.MessageBoxButtons.OkOnly, MessageBox.MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub CreateCertificate(ByVal granted As Boolean)
        Dim newcert As New PermissionCertificate(granted)
        PermissionGranted = newcert
    End Sub

    Private Sub CreateCertificate(ByVal granted As Boolean, ByVal user As String, ByVal perm As Integer)
        Dim newcert As New PermissionCertificate(granted, user, perm)
        PermissionGranted = newcert
    End Sub

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

    Private Function VerifyUser(ByVal user As String, ByVal pass As String) As Boolean
        If VerifyPassword(user, pass) Then
            If Aire.API.User.Users.Info.GetPermissionLevelForUser(user) >= permlevel Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Function VerifyFields() As Boolean
        Dim ret As Boolean = True
        If allowothers Then
            If txt_username.Text = "" Or Not Aire.API.User.Users.Info.GetIfUserExists(txt_username.Text) Then
                ret = False
            End If
        Else
            If txt_username.Text <> ouser Then
                ret = False
            End If
        End If
        Return ret
    End Function

    Private Function VerifyPassword(ByVal user As String, ByVal pass As String) As Boolean
        Return Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass)
    End Function

#End Region

#Region "UserPermissionDialog"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="requiredpermissionlevel">The permission level required to grant permission</param>
    ''' <param name="defaultuser">The user displayed in the dialog</param>
    ''' <param name="allowotherusers">Whether or not other users besides the default user can grant permission</param>
    ''' <param name="displayotherusers">Whether or not to display other users</param>
    ''' <param name="title">The title of the dialog</param>
    ''' <param name="message">The message to display</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal requiredpermissionlevel As Integer, Optional ByVal defaultuser As String = "", Optional ByVal allowotherusers As Boolean = True, Optional ByVal displayotherusers As Boolean = True, Optional ByVal title As String = "User Permission", Optional ByVal message As String = "")
        InitializeComponent()
        permlevel = requiredpermissionlevel
        ouser = defaultuser
        txt_username.Text = defaultuser
        If allowotherusers AndAlso displayotherusers Then
            For Each item As String In Aire.API.User.Users.Info.GetAllUsers
                lb_users.Items.Add(item)
            Next
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
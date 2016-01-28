Public Class UserPermissionDialog

#Region "Properties/Variables"

    Private permlevel As Integer
    Private allowothers As Boolean
    Public Property PermissionGranted As PermissionCertificate

#End Region

#Region "UI"



#End Region

#Region "Methods"

    Private Sub ShowOtherUsers(Optional ByVal button As Boolean = False)

    End Sub

    Private Sub HideOtherUsers(Optional ByVal button As Boolean = False)

    End Sub

    Private Function VerifyFields() As Boolean
        
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
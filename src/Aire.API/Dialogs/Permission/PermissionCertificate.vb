Public Class PermissionCertificate

    Public Property Granted As Boolean
    Public Property GrantedBy As String
    Public Property GrantedByPermissionLevel As Integer

    Public Sub New(ByVal grantby As String, ByVal grant As Boolean, ByVal grantbypermlevel As Integer)
        Granted = grant
        GrantedBy = grantby
        GrantedByPermissionLevel = grantbypermlevel
    End Sub

End Class

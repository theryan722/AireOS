Public Class PermissionCertificate

    Public Property Granted As Boolean
    Public Property GrantedBy As String
    Public Property GrantedByPermissionLevel As Integer

    Public Sub New(ByVal grant As Boolean)
        Granted = grant
    End Sub

    Public Sub New(ByVal grant As Boolean, ByVal grantby As String, ByVal grantbypermlevel As Integer)
        Granted = grant
        GrantedBy = grantby
        GrantedByPermissionLevel = grantbypermlevel
    End Sub

End Class

Public Class PermissionCertificate

    Public Property Granted As Boolean
    Public Property GrantedBy As String
    Public Property GrantedByPermissionLevel As Integer

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="grant">Whether permission was granted or not</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal grant As Boolean)
        Granted = grant
    End Sub

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="grant">Whether permission was granted or not</param>
    ''' <param name="grantby">The user that granted permission</param>
    ''' <param name="grantbypermlevel">The permission level of the user that granted permission</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal grant As Boolean, ByVal grantby As String, ByVal grantbypermlevel As Integer)
        Granted = grant
        GrantedBy = grantby
        GrantedByPermissionLevel = grantbypermlevel
    End Sub

End Class

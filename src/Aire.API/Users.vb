Namespace User

    'The currently logged in user
    Namespace Current

        Public Class Info

            Public Shared Function GetUsername() As String

            End Function

            Public Shared Function GetPermissionLevel() As Integer

            End Function

            Public Shared Function GetDataStorageLocation() As String

            End Function

            Public Shared Function GetIfHidden() As Boolean

            End Function

        End Class

        Public Class Actions

            Public Shared Sub ChangePermissionLevel(ByVal pass As String, ByVal newlevel As Integer)

            End Sub

            Public Shared Sub ChangeUsername(ByVal newusername As String)

            End Sub

            Public Shared Sub ChangePassword(ByVal curpass As String, ByVal newpass As String)

            End Sub

            Public Shared Function MatchPassword(ByVal pass As String) As Boolean

            End Function

            Public Shared Sub Logout()

            End Sub

            Public Shared Sub SwitchUser()

            End Sub

        End Class

    End Namespace

    'Methods for all users
    Namespace Users

        Public Class Info

            Public Shared Function CheckIfUserExists(ByVal username As String) As Boolean

            End Function

            Public Shared Function GetPermissionLevelForUser(ByVal username As String) As Integer

            End Function

            Public Shared Function CheckIfUserIsHidden(ByVal username As String) As Boolean

            End Function

            Public Shared Function IsALoggedInUser() As Boolean

            End Function

        End Class

    End Namespace

End Namespace
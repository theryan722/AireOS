Namespace User

    Namespace Current

        Public Class Info

            Public Shared Function GetUsername() As String

            End Function

            Public Shared Function MatchPassword(ByVal pass As String) As Boolean

            End Function

            Public Shared Function GetPermissionLevel() As Integer

            End Function

            Public Shared Function GetDataStorageLocation() As String

            End Function

        End Class

    End Namespace

    Namespace Users

        Public Class Info

            Public Shared Function CheckIfUserExists(ByVal username As String) As Boolean

            End Function

            Public Shared Function GetPermissionLevelForUser(ByVal username As String) As Integer

            End Function

        End Class

    End Namespace

End Namespace

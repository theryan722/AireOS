Namespace User

    'The currently logged in user
    Namespace Current

        Public Class Info

            Public Shared Function GetUsername() As String
                Return Aire.DataManager.TempData.LoggedInUser
            End Function

            Public Shared Function GetPermissionLevel() As Integer
                Return Aire.DataManager.Databases.UserData.GetPermissionLevel(GetUsername)
            End Function

            Public Shared Function GetDataStorageLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername)
            End Function

            Public Shared Function GetLogLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername) & "/Data/log.txt"
            End Function

            Public Shared Function GetSalt() As String
                Return Aire.DataManager.Databases.UserData.GetSalt(GetUsername)
            End Function

        End Class

        'The user settings for the currently logged in user
        Public Class Settings

            Public Shared Property DesktopBackgroundImage() As System.Drawing.Image
                Get

                End Get
                Set(value As System.Drawing.Image)

                End Set
            End Property

            Public Shared Property LogNotificationText() As Boolean
                Get

                End Get
                Set(value As Boolean)

                End Set
            End Property

            Public Shared Property IsHidden() As Boolean
                Get

                End Get
                Set(value As Boolean)

                End Set
            End Property

            Public Shared Property ProfilePicture() As System.Drawing.Image
                Get

                End Get
                Set(value As System.Drawing.Image)

                End Set
            End Property

            Public Shared Property ConfirmShutdown() As Boolean
                Get

                End Get
                Set(value As Boolean)

                End Set
            End Property

            Public Shared Property PasswordHint() As String
                Get

                End Get
                Set(value As String)

                End Set
            End Property

        End Class

        Public Class Actions

            Public Shared Sub ShowLogoutDialog()
                Dim newb As New dlgLogout
                newb.ShowDialog()
            End Sub

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

            Public Shared Sub Lock()

            End Sub

        End Class

    End Namespace

    'Methods for all users
    Namespace Users

        Public Class Info

            Public Shared Function CheckIfUserExists(ByVal username As String) As Boolean

            End Function

            Public Shared Function GetPasswordHintForUser(ByVal username As String) As String

            End Function

            Public Shared Function MatchPasswordForUser(ByVal username As String, ByVal password As String) As Boolean

            End Function

            Public Shared Function GetSaltForUser(ByVal username As String) As String

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
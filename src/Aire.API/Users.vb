Imports System.Windows.Forms
Imports System.Drawing

Namespace User

    'The currently logged in user
    Namespace Current

        Public Class Info

            Public Shared Function GetUsername() As String
                Return Aire.DataManager.TempData.LoggedInUser
            End Function

            Public Shared Function GetPermissionLevel() As Integer
                Return CInt(Aire.DataManager.Databases.UserData.GetPermissionLevel(GetUsername))
            End Function

            Public Shared Function GetDataStorageLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername)
            End Function

            Public Shared Function GetLogLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername) & "/Data/log.txt"
            End Function

            Public Shared Function GetIfHidden() As Boolean
                Return If(Aire.DataManager.Databases.UserData.GetHidden(GetUsername) = "YES", True, False)
            End Function

            Public Shared Function GetPasswordHint() As String
                Return Aire.DataManager.Databases.UserData.GetPasswordHint(GetUsername)
            End Function

            Public Shared Function GetAppList() As List(Of String)
                Dim TextLine As New List(Of String)
                Dim objReader As New System.IO.StreamReader(Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername) & "/Data/applist.txt")
                Do While objReader.Peek() <> -1
                    TextLine.Add(objReader.ReadLine())
                Loop
                Return TextLine
            End Function

        End Class

        'The user settings for the currently logged in user
        Public Class Settings

            Public Shared Property DesktopBackgroundImage() As String
                Get
                    Return User.Current.Info.GetDataStorageLocation & "/Data/bg.jpg"
                End Get
                Set(value As String)
                    System.IO.File.Copy(value, User.Current.Info.GetDataStorageLocation & "/Data/bg.jpg", True)
                End Set
            End Property

            Public Shared Property LaunchBarColor() As Color
                Get
                    Return Color.FromArgb(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/launchbarcolor.txt"))
                End Get
                Set(value As Color)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/launchbarcolor.txt", value.ToArgb.ToString)
                End Set
            End Property

            Public Shared Property AppBarColor() As Color
                Get

                End Get
                Set(value As Color)

                End Set
            End Property

            Public Shared Property DesktopBackgroundImageLayout() As ImageLayout
                Get

                End Get
                Set(value As ImageLayout)

                End Set
            End Property

            Public Shared Property LogNotificationText() As Boolean
                Get

                End Get
                Set(value As Boolean)

                End Set
            End Property

            Public Shared Property ProfilePicture() As String
                Get
                    Return User.Current.Info.GetDataStorageLocation & "/profile.jpg"
                End Get
                Set(value As String)
                    System.IO.File.Copy(value, User.Current.Info.GetDataStorageLocation & "/profile.jpg", True)
                End Set
            End Property

            Public Shared Property ConfirmShutdown() As Boolean
                Get

                End Get
                Set(value As Boolean)

                End Set
            End Property

        End Class

        Public Class Actions

            Public Shared Sub ShowLogoutDialog()
                Dim newb As New dlgLogout
                newb.ShowDialog()
            End Sub

            Public Shared Sub SetPermissionLevel(ByVal pass As String, ByVal newlevel As Integer)
                If MatchPassword(pass) Then
                    Aire.DataManager.Databases.UserData.ModifyPermissionLevel(Current.Info.GetUsername, newlevel)
                End If
            End Sub

            Public Shared Sub SetPassword(ByVal curpass As String, ByVal newpass As String)
                If MatchPassword(curpass) Then
                    Aire.DataManager.Databases.UserData.ModifyPassword(Current.Info.GetUsername, newpass)
                End If
            End Sub

            Public Shared Sub SetIfHidden(ByVal hidden As Boolean)
                Aire.DataManager.Databases.UserData.ModifyHidden(Current.Info.GetUsername, hidden)
            End Sub

            Public Shared Sub SetPasswordHint(ByVal hint As String)
                Aire.DataManager.Databases.UserData.ModifyPasswordHint(Current.Info.GetUsername, hint)
            End Sub

            Public Shared Function MatchPassword(ByVal pass As String) As Boolean
                Return Cryptography.Passwords.CheckPassword(pass, Aire.DataManager.Databases.UserData.GetPassword(Current.Info.GetUsername))
            End Function

            Public Shared Sub LogoutUser()
                Users.Info.ActiveUsers.Remove(User.Current.Info.GetUsername)
                Users.Actions.SetCurrentUser("")
            End Sub

            Public Shared Sub SwitchUser()

            End Sub

            Public Shared Sub LockUser()

            End Sub

        End Class

    End Namespace

    'Methods for all users
    Namespace Users

        Public Class Info

            Friend Shared Property ActiveUsers() As New List(Of String)

            Public Shared Function GetActiveUsers() As List(Of String)
                Return ActiveUsers
            End Function

            Public Shared Function GetAllUsers() As List(Of String)
                Dim ret As New List(Of String)
                For Each item As String In Aire.DataManager.Databases.UserData.GetAllUsers()
                    If Not GetIfUserIsHidden(item) Then
                        ret.Add(item)
                    End If
                Next
                Return ret
            End Function

            Public Shared Function GetIfUserExists(ByVal username As String) As Boolean
                Return Aire.DataManager.Databases.UserData.GetIfUserExists(username)
            End Function

            Public Shared Function GetPasswordHintForUser(ByVal username As String) As String
                Return Aire.DataManager.Databases.UserData.GetPasswordHint(username)
            End Function

            Public Shared Function GetPermissionLevelForUser(ByVal username As String) As Integer
                Return CInt(Aire.DataManager.Databases.UserData.GetPermissionLevel(username))
            End Function

            Public Shared Function GetIfUserIsHidden(ByVal username As String) As Boolean
                Return If(Aire.DataManager.Databases.UserData.GetHidden(username) = "YES", True, False)
            End Function

            Public Shared Function IsALoggedInUser() As Boolean
                Return If(Aire.DataManager.TempData.LoggedInUser <> "", True, False)
            End Function

        End Class

        Public Class Actions

            Friend Shared Sub SetCurrentUser(ByVal username As String)
                Aire.DataManager.TempData.LoggedInUser = username
            End Sub

            Public Shared Sub LogoutUser(ByVal username As String)
                Users.Info.ActiveUsers.Remove(username)
            End Sub

            Public Shared Sub LoginUser(ByVal username As String, ByVal password As String)
                If MatchPasswordForUser(username, password) Then
                    SetCurrentUser(username)
                    If Not Info.GetActiveUsers.Contains(username) Then
                        Info.ActiveUsers.Add(username)
                    End If
                End If
            End Sub

            ' + Aire.DataManager.Databases.UserData.GetSalt(username)
            Public Shared Function MatchPasswordForUser(ByVal username As String, ByVal password As String) As Boolean
                Return Cryptography.Passwords.CheckPassword(password, Aire.DataManager.Databases.UserData.GetPassword(username))
            End Function

            Public Shared Sub CreateUser(ByVal username As String, ByVal password As String, ByVal salt As String, ByVal datastorageloc As String, ByVal hidden As Boolean, ByVal passwordhint As String, ByVal permissionlevel As Integer)
                Dim hid As String = If(hidden, "YES", "NO")
                Aire.DataManager.Databases.UserData.AddUser(username, Cryptography.Passwords.HashPassword(password, salt), datastorageloc, hid, passwordhint, CInt(permissionlevel))
                Aire.DataManager.Users.SetupUserDataStorage(datastorageloc)
            End Sub

            Public Shared Sub RemoveUser(ByVal username As String)
                Aire.DataManager.Databases.UserData.RemoveUser(username)
            End Sub

        End Class

    End Namespace

End Namespace
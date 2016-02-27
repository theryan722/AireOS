Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Namespace User

    'The currently logged in user
    Namespace Current

        Public Class Info

            ''' <summary>
            ''' Gets the current users username
            ''' </summary>
            ''' <returns>String, the username of the current user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetUsername() As String
                Return Aire.DataManager.TempData.LoggedInUser
            End Function

            ''' <summary>
            ''' Gets the permission level of the current user
            ''' </summary>
            ''' <returns>Integer, the permission level of the current user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetPermissionLevel() As Integer
                Return CInt(Aire.DataManager.Databases.UserData.GetPermissionLevel(GetUsername))
            End Function

            ''' <summary>
            ''' Gets the data storage location of the current user
            ''' </summary>
            ''' <returns>String, the data storage location for the current user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetDataStorageLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername)
            End Function

            ''' <summary>
            ''' Gets the log location of the current user
            ''' </summary>
            ''' <returns>String, the log location of the current user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetLogLocation() As String
                Return Aire.DataManager.Databases.UserData.GetDataStorageLoc(GetUsername) & "/Data/log.txt"
            End Function

            ''' <summary>
            ''' Gets whether or not the current user is hidden
            ''' </summary>
            ''' <returns>True, if the user is hidden, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfHidden() As Boolean
                Return If(Aire.DataManager.Databases.UserData.GetHidden(GetUsername) = "YES", True, False)
            End Function

            ''' <summary>
            ''' Gets the password hint for the current user
            ''' </summary>
            ''' <returns>String, the password hint for the current user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetPasswordHint() As String
                Return Aire.DataManager.Databases.UserData.GetPasswordHint(GetUsername)
            End Function

            ''' <summary>
            ''' Gets the user applist
            ''' </summary>
            ''' <returns>List of strings, the applist for the user</returns>
            ''' <remarks></remarks>
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

            ''' <summary>
            ''' The desktop background image of the current user
            ''' </summary>
            ''' <value>The file location of the background image</value>
            ''' <returns>String, the file location of the background image</returns>
            ''' <remarks></remarks>
            Public Shared Property DesktopBackgroundImage() As String
                Get
                    Return User.Current.Info.GetDataStorageLocation & "/Data/bg.jpg"
                End Get
                Set(value As String)
                    System.IO.File.Copy(value, User.Current.Info.GetDataStorageLocation & "/Data/bg.jpg", True)
                End Set
            End Property

            ''' <summary>
            ''' The color of the LaunchBar of the current user
            ''' </summary>
            ''' <value>The color of the LaunchBar</value>
            ''' <returns>Color, the color of the LaunchBar</returns>
            ''' <remarks></remarks>
            Public Shared Property LaunchBarColor() As Color
                Get
                    Return Color.FromArgb(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/launchbarcolor.txt"))
                End Get
                Set(value As Color)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/launchbarcolor.txt", value.ToArgb.ToString)
                End Set
            End Property

            ''' <summary>
            ''' The color of the AppBar of the current user
            ''' </summary>
            ''' <value>The color of the AppBar</value>
            ''' <returns>Color, the color of the AppBar</returns>
            ''' <remarks></remarks>
            Public Shared Property AppBarColor() As Color
                Get
                    Return Color.FromArgb(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/appbarcolor.txt"))
                End Get
                Set(value As Color)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/appbarcolor.txt", value.ToArgb.ToString)
                End Set
            End Property

            ''' <summary>
            ''' The image layout for the current user's desktop background
            ''' </summary>
            ''' <value>The image layout of the desktop background image</value>
            ''' <returns>ImageLayout, the layout of the desktop background image</returns>
            ''' <remarks></remarks>
            Public Shared Property DesktopBackgroundImageLayout() As ImageLayout
                Get
                    Return Aire.DataManager.Converter.ConvertStringToImageLayout(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/backgroundimagelayout.txt"))
                End Get
                Set(value As ImageLayout)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/backgroundimagelayout.txt", value.ToString)
                End Set
            End Property

            ''' <summary>
            ''' Whether or not notifications are logged for the current user
            ''' </summary>
            ''' <value>hether or not notifications are logged</value>
            ''' <returns>True, if notifications are logged, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Property LogNotificationText() As Boolean
                Get
                    Return Convert.ToBoolean(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/lognotificationtext.txt"))
                End Get
                Set(value As Boolean)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/lognotificationtext.txt", value.ToString)
                End Set
            End Property

            ''' <summary>
            ''' The profile picture of the current user
            ''' </summary>
            ''' <value>The file location of the profile picture</value>
            ''' <returns>String, the file location of the profile picture</returns>
            ''' <remarks></remarks>
            Public Shared Property ProfilePicture() As String
                Get
                    Return User.Current.Info.GetDataStorageLocation & "/Data/profile.jpg"
                End Get
                Set(value As String)
                    System.IO.File.Copy(value, User.Current.Info.GetDataStorageLocation & "/Data/profile.jpg", True)
                End Set
            End Property

            ''' <summary>
            ''' Whether or not a confirm dialog is displayed when shutting down for the current user
            ''' </summary>
            ''' <value>Whether or not a confirm dialog is displayed when shutting down</value>
            ''' <returns>True, if a dialog is displayed, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Property ConfirmShutdown() As Boolean
                Get
                    Return Convert.ToBoolean(System.IO.File.ReadAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/confirmshutdown.txt"))
                End Get
                Set(value As Boolean)
                    System.IO.File.WriteAllText(User.Current.Info.GetDataStorageLocation & "/Data/Config/confirmshutdown.txt", value.ToString)
                End Set
            End Property

        End Class

        Public Class Actions

            ''' <summary>
            ''' Displays the logout dialog for the current user
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub ShowLogoutDialog()
                Dim newb As New dlgLogout
                newb.ShowDialog()
            End Sub

            ''' <summary>
            ''' Sets the permission level for the current user
            ''' </summary>
            ''' <param name="pass">The user's password</param>
            ''' <param name="newlevel">The permission level to set</param>
            ''' <remarks></remarks>
            Public Shared Sub SetPermissionLevel(ByVal pass As String, ByVal newlevel As Integer)
                If MatchPassword(pass) Then
                    Aire.DataManager.Databases.UserData.ModifyPermissionLevel(Current.Info.GetUsername, newlevel)
                End If
            End Sub

            ''' <summary>
            ''' Sets the password for the current user
            ''' </summary>
            ''' <param name="curpass">The user's original password</param>
            ''' <param name="newpass">The new password to set</param>
            ''' <remarks></remarks>
            Public Shared Sub SetPassword(ByVal curpass As String, ByVal newpass As String)
                If MatchPassword(curpass) Then
                    Aire.DataManager.Databases.UserData.ModifyPassword(Current.Info.GetUsername, newpass)
                End If
            End Sub

            ''' <summary>
            ''' Sets whether the current user is hidden or not
            ''' </summary>
            ''' <param name="hidden">Whether or not the user is hidden</param>
            ''' <remarks></remarks>
            Public Shared Sub SetIfHidden(ByVal hidden As Boolean)
                Aire.DataManager.Databases.UserData.ModifyHidden(Current.Info.GetUsername, hidden)
            End Sub

            ''' <summary>
            ''' Sets the password hint for the current user
            ''' </summary>
            ''' <param name="hint">The password hint to set</param>
            ''' <remarks></remarks>
            Public Shared Sub SetPasswordHint(ByVal hint As String)
                Aire.DataManager.Databases.UserData.ModifyPasswordHint(Current.Info.GetUsername, hint)
            End Sub

            ''' <summary>
            ''' Checks whether or not a password matches the current user's password
            ''' </summary>
            ''' <param name="pass">The password to check</param>
            ''' <returns>True, if the passwords match, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function MatchPassword(ByVal pass As String) As Boolean
                Return Cryptography.Passwords.CheckPassword(pass, Aire.DataManager.Databases.UserData.GetPassword(Current.Info.GetUsername))
            End Function

            ''' <summary>
            ''' Logs out the current user
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub LogoutUser()
                Users.Info.ActiveUsers.Remove(User.Current.Info.GetUsername)
                Users.Actions.SetCurrentUser("")
            End Sub

            ''' <summary>
            ''' Switches the current user
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub SwitchUser()

            End Sub

            ''' <summary>
            ''' Locks the current user
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub LockUser()

            End Sub

        End Class

    End Namespace

    'Methods for all users
    Namespace Users

        Public Class Info

            Friend Shared Property ActiveUsers() As New List(Of String)

            ''' <summary>
            ''' Gets a list of all active users
            ''' </summary>
            ''' <returns>List of string, the usernames of all currently active users</returns>
            ''' <remarks></remarks>
            Public Shared Function GetActiveUsers() As List(Of String)
                Return ActiveUsers
            End Function

            ''' <summary>
            ''' Gets a list of all users
            ''' </summary>
            ''' <returns>List of string, the usernames of all users</returns>
            ''' <remarks></remarks>
            Public Shared Function GetAllUsers() As List(Of String)
                Dim ret As New List(Of String)
                For Each item As String In Aire.DataManager.Databases.UserData.GetAllUsers()
                    If Not GetIfUserIsHidden(item) Then
                        ret.Add(item)
                    End If
                Next
                Return ret
            End Function

            ''' <summary>
            ''' Determines whether a user exists
            ''' </summary>
            ''' <param name="username">The username to check</param>
            ''' <returns>True, if the user exists, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfUserExists(ByVal username As String) As Boolean
                Return Aire.DataManager.Databases.UserData.GetIfUserExists(username)
            End Function

            ''' <summary>
            ''' Gets the password hint of a user
            ''' </summary>
            ''' <param name="username">The user to get the password hint from</param>
            ''' <returns>String, the user's password hint</returns>
            ''' <remarks></remarks>
            Public Shared Function GetPasswordHintForUser(ByVal username As String) As String
                Return Aire.DataManager.Databases.UserData.GetPasswordHint(username)
            End Function

            ''' <summary>
            ''' Gets the permission level of a user
            ''' </summary>
            ''' <param name="username">The user to get the permission level from</param>
            ''' <returns>Integer, the permission level of the user</returns>
            ''' <remarks></remarks>
            Public Shared Function GetPermissionLevelForUser(ByVal username As String) As Integer
                Return CInt(Aire.DataManager.Databases.UserData.GetPermissionLevel(username))
            End Function

            ''' <summary>
            ''' Gets if a user is hidden
            ''' </summary>
            ''' <param name="username">The user to check if is hidden</param>
            ''' <returns>True, if the user is hidden, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfUserIsHidden(ByVal username As String) As Boolean
                Return If(Aire.DataManager.Databases.UserData.GetHidden(username) = "YES", True, False)
            End Function

            ''' <summary>
            ''' Checks if there is a currently logged in user
            ''' </summary>
            ''' <returns>True, if a user is currently logged in, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function IsALoggedInUser() As Boolean
                Return If(Aire.DataManager.TempData.LoggedInUser <> "", True, False)
            End Function

        End Class

        Public Class Actions

            Friend Shared Sub SetCurrentUser(ByVal username As String)
                Aire.DataManager.TempData.LoggedInUser = username
                My.Computer.FileSystem.WriteAllText(Aire.DataManager.DataPaths.GetSysDataLocation & "/Temp/currentuser.txt", username, False)
            End Sub

            ''' <summary>
            ''' Logs out a user
            ''' </summary>
            ''' <param name="username">The user to logout</param>
            ''' <remarks></remarks>
            Public Shared Sub LogoutUser(ByVal username As String)
                Users.Info.ActiveUsers.Remove(username)
            End Sub

            ''' <summary>
            ''' Logs in a user
            ''' </summary>
            ''' <param name="username">The user to login</param>
            ''' <param name="password">The password of the user</param>
            ''' <remarks></remarks>
            Public Shared Sub LoginUser(ByVal username As String, ByVal password As String)
                If MatchPasswordForUser(username, password) Then
                    SetCurrentUser(username)
                    If Not Info.GetActiveUsers.Contains(username) Then
                        Info.ActiveUsers.Add(username)
                    End If
                End If
            End Sub

            ''' <summary>
            ''' Compares a password to a user's password
            ''' </summary>
            ''' <param name="username">The user to compare passwords with</param>
            ''' <param name="password">The password to compare</param>
            ''' <returns>True, if the passwords match, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function MatchPasswordForUser(ByVal username As String, ByVal password As String) As Boolean
                Return Cryptography.Passwords.CheckPassword(password, Aire.DataManager.Databases.UserData.GetPassword(username))
            End Function

            ''' <summary>
            ''' Creates a new user
            ''' </summary>
            ''' <param name="username">The username of the user</param>
            ''' <param name="password">The password of the user</param>
            ''' <param name="datastorageloc">The data storage location of the user</param>
            ''' <param name="hidden">Whether the user is hidden or not</param>
            ''' <param name="passwordhint">The password hint of the user</param>
            ''' <param name="permissionlevel">The permission level of the user</param>
            ''' <remarks></remarks>
            Public Shared Sub CreateUser(ByVal username As String, ByVal password As String, ByVal datastorageloc As String, ByVal hidden As Boolean, ByVal passwordhint As String, ByVal permissionlevel As Integer)
                Dim hid As String = If(hidden, "YES", "NO")
                Aire.DataManager.Databases.UserData.AddUser(username, Cryptography.Passwords.HashPassword(password), datastorageloc, hid, passwordhint, CInt(permissionlevel))
                Aire.DataManager.Users.SetupUserDataStorage(datastorageloc)
            End Sub

            ''' <summary>
            ''' Removes a user
            ''' </summary>
            ''' <param name="username">The user to remove</param>
            ''' <remarks></remarks>
            Public Shared Sub RemoveUser(ByVal username As String)
                Aire.DataManager.Databases.UserData.RemoveUser(username)
            End Sub

        End Class

    End Namespace

End Namespace
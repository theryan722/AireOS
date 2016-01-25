Public Class DBTest
    Public Shared Sub CreateUser()
        Aire.DataManager.Databases.UserData.AddUser("Admin", "TestPassword", "TestSalt", "K:\HP", "YES", "This is my password hint", "0")
    End Sub
End Class

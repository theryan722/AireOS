Public Class Users

#Region "Helper"

    Private Shared Sub CreateDirectories(ByVal loc As String)
        System.IO.Directory.CreateDirectory(loc)
        System.IO.Directory.CreateDirectory(loc & "/Apps")
        System.IO.Directory.CreateDirectory(loc & "/Apps/Terminal")
        System.IO.Directory.CreateDirectory(loc & "/Data")
        System.IO.Directory.CreateDirectory(loc & "/Data/Config")
    End Sub

    Private Shared Sub CreateFiles(ByVal loc As String)
        System.IO.File.Create(loc & "/Data/log.txt")
        System.IO.File.Create(loc & "/Apps/Terminal/config.txt")
        System.IO.File.Create(loc & "/Apps/Terminal/external.txt")
        System.IO.File.Create(loc & "/Data/applist.txt")
        System.IO.File.Create(loc & "/Data/Config/launchbarcolor.txt")
        System.IO.File.Create(loc & "/Data/Config/appbarcolor.txt")
    End Sub

    Private Shared Sub CopyDefaultFiles(ByVal loc As String)
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defbg.jpg", loc & "/Data/bg.jpg")
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defprofile.jpg", loc & "/Data/profile.jpg")
    End Sub

    Private Shared Sub SetDefaultSettings(ByVal loc As String)
        'launchbarcolor
        'appbarcolor

    End Sub

#End Region

    Public Shared Sub SetupUserDataStorage(ByVal loc As String)
        CreateDirectories(loc)
        CreateFiles(loc)
        CopyDefaultFiles(loc)
        SetDefaultSettings(loc)
    End Sub

End Class

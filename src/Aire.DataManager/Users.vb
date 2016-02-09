Public Class Users

#Region "Helper"

    Private Shared Sub CreateDirectories(ByVal loc As String)
        System.IO.Directory.CreateDirectory(loc)
        System.IO.Directory.CreateDirectory(loc & "/Apps")
        System.IO.Directory.CreateDirectory(loc & "/Apps/Terminal")
    End Sub

    Private Shared Sub CreateFiles(ByVal loc As String)
        System.IO.File.Create(loc & "/log.txt")
        System.IO.File.Create(loc & "/Apps/Terminal/config.txt")
        System.IO.File.Create(loc & "/Apps/Terminal/external.txt")
        System.IO.File.Create(loc & "/applist.txt")
    End Sub

    Private Shared Sub CopyDefaultFiles(ByVal loc As String)
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defbg.jpg", loc & "/bg.jpg")
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defprofile.jpg", loc & "/profile.jpg")
    End Sub

#End Region

    Public Shared Sub SetupUserDataStorage(ByVal loc As String)
        CreateDirectories(loc)
        CreateFiles(loc)
        CopyDefaultFiles(loc)
    End Sub

End Class

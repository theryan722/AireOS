Public Class Users

    Public Shared Sub SetupUserDataStorage(ByVal loc As String)
        System.IO.Directory.CreateDirectory(loc)
        System.IO.Directory.CreateDirectory(loc & "/Apps")
        System.IO.Directory.CreateDirectory(loc & "/Apps/Terminal")
        System.IO.File.Create(loc & "/log.txt")
        System.IO.File.Create(loc & "/Apps/Terminal/config.txt")
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defbg.jpg", loc & "/bg.jpg")
    End Sub

End Class

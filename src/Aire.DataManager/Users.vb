Public Class Users

    Public Shared Sub SetupUserDataStorage(ByVal loc As String)
        System.IO.Directory.CreateDirectory(loc)
        System.IO.File.Create(loc & "/log.txt")
        System.IO.File.Copy(DataPaths.GetSysDataLocation & "/Default/defbg.jpg", loc & "/bg.jpg")
    End Sub

End Class

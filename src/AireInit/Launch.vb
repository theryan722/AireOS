Module Launch
    Private loginloc As String = Aire.API.Compatibility.FixPath(AppDomain.CurrentDomain.BaseDirectory & "/Aire.Login.exe")

    'Initializes Aire OS
    Sub Main()
        Console.Title = "Aire OS Initialization"
        Aire.API.Sys.Logging.Log.Write("System is initializing.")
        Process.Start(loginloc)
    End Sub

End Module

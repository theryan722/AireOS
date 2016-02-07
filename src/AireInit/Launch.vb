Module Launch
    Private hostloc As String = Aire.API.Compatibility.FixPath(AppDomain.CurrentDomain.BaseDirectory & "/Aire.Host.exe")

    'Initializes Aire OS
    Sub Main()
        Console.Title = "Aire OS Initialization"
        Aire.API.Sys.Logging.Log.Write("System is initializing.")
        InitializeAudio()
        Process.Start(hostloc)
    End Sub

    Private Sub InitializeAudio()
        Aire.API.Audio.Volume.Unmute()
    End Sub

End Module

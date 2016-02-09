Module Launch
    Private hostloc As String = Aire.API.Compatibility.FixPath(AppDomain.CurrentDomain.BaseDirectory & "/Aire.Host.exe")
    Private setuploc As String = Aire.API.Compatibility.FixPath(AppDomain.CurrentDomain.BaseDirectory & "/Aire.FirstTimeSetup.exe")
    'Initializes Aire OS
    Sub Main()
        Console.Title = "Aire OS Initialization"
        Aire.API.Sys.Logging.Log.Write("System is initializing.")
        InitializeAudio()
        If System.IO.File.Exists(setuploc) Then
            Process.Start(setuploc)
        Else
            Process.Start(hostloc)
        End If
    End Sub

    Private Sub InitializeAudio()
        Aire.API.Audio.Volume.Unmute()
    End Sub

End Module

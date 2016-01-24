Module Launch
    Private loginloc As String = AppDomain.CurrentDomain.BaseDirectory & "\Aire.Login.exe"

    'Initializes Aire OS
    Sub Main()
        Console.Title = "Aire OS Initialization"
        Process.Start(loginloc)
    End Sub

End Module

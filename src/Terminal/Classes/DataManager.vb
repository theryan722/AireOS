Public Class DataManager

    Private Shared loc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/Terminal"

    Public Shared Sub CheckAndRepairData()
        If Not System.IO.File.Exists(loc & "/config.txt") Then
            System.IO.File.Create(loc & "/config.txt")
        End If
        If Not System.IO.File.Exists(loc & "/external.txt") Then
            System.IO.File.Create(loc & "/external.txt")
        End If
        CheckAndRepairConfig()
    End Sub

    Public Shared Sub CheckAndRepairConfig()
        Dim oconf As String = "BC:-16777216" & vbNewLine & "FC:-1" & vbNewLine & "TM:False" & vbNewLine & "FS:False" & vbNewLine & "AE:False"
        If ConfigManager.ReadConfig.Count < 5 Then
            Dim objWriter As New System.IO.StreamWriter(loc & "/config.txt")
            objWriter.Write(oconf)
            objWriter.Close()
        End If
    End Sub

    Public Shared Sub ClearExternalCommands()

    End Sub

    Public Shared Sub AddToExternalCommands(ByVal cmd As String)

    End Sub

End Class

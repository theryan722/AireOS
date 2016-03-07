Public Class DataManager

    Private Shared loc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/Terminal"

    Public Shared Sub CheckAndRepairData()
        CheckAndRepairConfig()
    End Sub

    Public Shared Sub CheckAndRepairConfig()
        Dim oconf As String = "BC:-16777216" & vbNewLine & "FC:-1" & vbNewLine & "TM:False" & vbNewLine & "FS:False" & vbNewLine & "AE:False" & vbNewLine & "DM:False"
        If ConfigManager.ReadConfig().Count < 5 Then
            Aire.API.Sys.IO.File.SWrite(loc & "/config.txt", oconf)
            'System.IO.File.WriteAllText(loc & "/config.txt", oconf)
        End If
    End Sub

    Public Shared Sub ClearExternalCommands()
        Aire.API.Sys.IO.File.SWrite(loc & "/external.txt", "")
        'System.IO.File.WriteAllText(loc & "/external.txt", "")
    End Sub

    Public Shared Sub AddToExternalCommands(ByVal cmd As String)
        Dim objWriter As New System.IO.StreamWriter(loc & "/external.txt", True)
        objWriter.Write(vbNewLine & cmd)
        objWriter.Close()
    End Sub

End Class

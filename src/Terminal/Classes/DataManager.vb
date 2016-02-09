Public Class DataManager

    Private Shared loc As String = Aire.API.User.Current.Info.GetDataStorageLocation & "/Apps/Terminal"

    Public Shared Sub CheckAndRepairData()
        If Not System.IO.File.Exists(loc & "/config.txt") Then
            System.IO.File.Create(loc & "/config.txt")
        End If
        If Not System.IO.File.Exists(loc & "/external.txt") Then
            System.IO.File.Create(loc & "/external.txt")
        End If
    End Sub

    Public Shared Sub CheckAndRepairConfig()

    End Sub

End Class

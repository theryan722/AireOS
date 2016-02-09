Public Class Notifications

    Public Shared Sub Add(ByVal txt As String)
        Dim objWriter As New System.IO.StreamWriter(Aire.DataManager.DataPaths.GetSysDataLocation & "/notifications.txt", True)
        objWriter.Write(vbNewLine & txt)
        objWriter.Close()
    End Sub

End Class

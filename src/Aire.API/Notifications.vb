Public Class Notifications

    Public Shared Sub Add(ByVal txt As String, Optional ByVal displaytoast As Boolean = False)
        Dim objWriter As New System.IO.StreamWriter(Aire.DataManager.DataPaths.GetSysDataLocation & "/notifications.txt", True)
        objWriter.Write(vbNewLine & DateTime.Now.ToString & "|" & txt)
        objWriter.Close()
        If displaytoast Then
            Dim bb As New Toast(txt, 2500, "Notification")
        End If
    End Sub

End Class

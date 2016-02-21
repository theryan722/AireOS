Public Class Notifications

    ''' <summary>
    ''' Adds a new notification
    ''' </summary>
    ''' <param name="txt">The text to be added</param>
    ''' <param name="displaytoast">Whether or not to display a toast for the notification</param>
    ''' <remarks></remarks>
    Public Shared Sub Add(ByVal txt As String, Optional ByVal displaytoast As Boolean = False)
        Dim objWriter As New System.IO.StreamWriter(Aire.DataManager.DataPaths.GetSysDataLocation & "/notifications.txt", True)
        objWriter.Write(vbNewLine & DateTime.Now.ToString & "|" & txt)
        objWriter.Close()
        If displaytoast Then
            Dim bb As New Toast(txt, 2500, "Notification")
        End If
    End Sub

End Class

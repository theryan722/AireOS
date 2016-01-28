Public Class Manager

#Region "Properties/Variables"

    Public Shared Property DesktopSessions As List(Of DesktopSession)
    Public Shared Property ActiveSession As DesktopSession

#End Region

#Region "Methods"

    Public Shared Sub LoadMainDesktop(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then
            If Aire.API.User.Users.Info.GetActiveUsers().Contains(user) Then
                For Each item As DesktopSession In DesktopSessions
                    If item.User = user Then
                        ActiveSession = item
                        ActiveSession.LoadSession()
                    End If
                Next
            Else

            End If
            Dim newb As New frmDesktop
            newb.User = user
            newb.Windows.Add(New DesktopWindows(newb))
            newb.Show()
        End If
    End Sub

#End Region

End Class

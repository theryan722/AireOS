Public Class Manager

#Region "Properties/Variables"

    Public Shared Property DesktopSessions As List(Of DesktopSession)
    Public Shared Property ActiveSession As DesktopSession

#End Region

#Region "Methods"

    Public Shared Sub LoadDesktopSession(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then
            If Aire.API.User.Users.Info.GetActiveUsers().Contains(user) Then
                For Each item As DesktopSession In DesktopSessions
                    If item.User = user Then
                        ActiveSession = item
                        For Each ses As DesktopSession In DesktopSessions
                            ses.HideSession()
                        Next
                        ActiveSession.LoadSession()
                    End If
                Next
            Else
                Dim newses As New DesktopSession
                newses.User = user
                newses.Desktop = New frmDesktop(user)
                newses.AppBarTop = New bar_appbar(newses.Desktop, True)
                newses.AppBarBottom = New bar_appbar(newses.Desktop, False)
                newses.LaunchBar = New bar_launchbar(newses.Desktop)
                DesktopSessions.Add(newses)
                ActiveSession = newses
                ActiveSession.LoadSession()
            End If
        End If
    End Sub

#End Region

End Class

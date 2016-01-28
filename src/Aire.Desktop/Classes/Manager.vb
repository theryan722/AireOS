Public Class Manager

#Region "Properties/Variables"

    Public Shared Property DesktopSessions As New List(Of DesktopSession)
    Public Shared Property ActiveSession As DesktopSession

#End Region

#Region "Methods"

    Private Shared Sub CreateSession(ByVal user)
        For Each ses As DesktopSession In DesktopSessions
            ses.HideSession()
        Next
        Dim newses As New DesktopSession
        newses.User = user
        newses.Desktop = New frmDesktop(user, newses)
        newses.LaunchBar = New bar_launchbar(newses.Desktop)
        DesktopSessions.Add(newses)
        ActiveSession = newses
        ActiveSession.LoadSession()
    End Sub

    Public Shared Sub LoadDesktopSession(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then
            If Aire.API.User.Users.Info.GetActiveUsers().Contains(user) Then
                Dim found As Boolean = False
                For Each item As DesktopSession In DesktopSessions
                    If item.User = user Then
                        found = True
                        ActiveSession = item
                        For Each ses As DesktopSession In DesktopSessions
                            ses.HideSession()
                        Next
                        ActiveSession.LoadSession()
                    End If
                Next
                If Not found Then
                    CreateSession(user)
                End If
            Else
                CreateSession(user)
            End If
        End If
    End Sub

#End Region

End Class

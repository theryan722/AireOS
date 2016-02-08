Public Class Manager

#Region "Properties/Variables"

    Public Shared Property DesktopSessions As New List(Of UserDesktopSession)
    Public Shared Property ActiveSession As UserDesktopSession

#End Region

#Region "Methods"

    Private Shared Sub CreateSession(ByVal user)
        For Each ses As UserDesktopSession In DesktopSessions
            ses.HideSession()
        Next
        Dim newses As New UserDesktopSession
        newses.User = user
        newses.Desktop = New frmDesktop(user, newses)
        DesktopSessions.Add(newses)
        ActiveSession = newses
        ActiveSession.LoadSession()
    End Sub

    Public Shared Sub LoadDesktopSession(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then
            If Aire.API.User.Users.Info.GetActiveUsers().Contains(user) Then
                Dim found As Boolean = False
                For Each item As UserDesktopSession In DesktopSessions
                    If item.User = user Then
                        found = True
                        ActiveSession = item
                        For Each ses As UserDesktopSession In DesktopSessions
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

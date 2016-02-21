Public Class Manager

#Region "Properties/Variables"

    ''' <summary>
    ''' The list of desktop sessions currently running
    ''' </summary>
    ''' <value>The list of desktop sessions currently running</value>
    ''' <returns>List of UserDesktopSession, the list of desktop sessions currently running</returns>
    ''' <remarks></remarks>
    Public Shared Property DesktopSessions As New List(Of UserDesktopSession)

    ''' <summary>
    ''' The currently active user desktop session
    ''' </summary>
    ''' <value>The currently active user desktop session</value>
    ''' <returns>UserDesktopSession, the currently active user desktop session</returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Loads a desktop session for a user
    ''' </summary>
    ''' <param name="user">The user to load a desktop session for</param>
    ''' <param name="pass">The password of the user</param>
    ''' <remarks>If a desktop session does not exist for the user, a new one is created</remarks>
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

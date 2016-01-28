Public Class Manager

    Public Shared Sub LoadMainDesktop(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then

        End If
    End Sub

    Public Shared Sub AddDesktop()

    End Sub

    Public Shared Sub RemoveDesktop(ByVal desktop As frmDesktop)

    End Sub

    Public Shared Sub GoToDesktop(ByVal desktop As frmDesktop)

    End Sub

End Class

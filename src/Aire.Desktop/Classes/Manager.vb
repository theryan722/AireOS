Public Class Manager

#Region "Properties/Variables"



#End Region

#Region "Methods"

    Public Shared Sub LoadMainDesktop(ByVal user As String, ByVal pass As String)
        If Aire.API.User.Users.Actions.MatchPasswordForUser(user, pass) Then
            Dim newb As New frmDesktop
            newb.User = user
            newb.Windows.Add(New DesktopWindows(newb))
            newb.Show()
        End If
    End Sub

    Public Shared Sub AddDesktop()

    End Sub

    Public Shared Sub RemoveDesktop(ByVal desktop As frmDesktop)

    End Sub

    Public Shared Sub GoToDesktop(ByVal desktop As frmDesktop)

    End Sub

#End Region

End Class

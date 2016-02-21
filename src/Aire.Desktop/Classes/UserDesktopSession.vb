Public Class UserDesktopSession

#Region "Properties"

    ''' <summary>
    ''' The user the desktop session belongs to
    ''' </summary>
    ''' <value>The user the desktop session belongs to</value>
    ''' <returns>String, the user the desktop session belongs to</returns>
    ''' <remarks></remarks>
    Public Property User As String

    ''' <summary>
    ''' The desktop form of the desktop session
    ''' </summary>
    ''' <value>The desktop form of the desktop session</value>
    ''' <returns>frmDesktop, the desktop form of the desktop session</returns>
    ''' <remarks></remarks>
    Public Property Desktop As frmDesktop

#End Region

#Region "Public"

    ''' <summary>
    ''' Loads the desktop session
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadSession()
        DisplayDesktop()
        For Each item As String In Desktop.Windows
            Aire.API.Sys.Window.Actions.Show(item)
        Next
    End Sub

    ''' <summary>
    ''' Hides the desktop session
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HideSession()
        Desktop.Hide()
        Desktop.StopUpdating()
        For Each item As String In Desktop.Windows
            Aire.API.Sys.Window.Actions.Hide(item)
        Next
    End Sub

    ''' <summary>
    ''' Closes the desktop session
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseSession()
        Manager.DesktopSessions.Remove(Me)
        Desktop.Close()
    End Sub

    ''' <summary>
    ''' Loads and applies the user settings for the desktop session
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadSettings()
        Desktop.SetDesktopBackground(Aire.API.User.Current.Settings.DesktopBackgroundImage, Aire.API.User.Current.Settings.DesktopBackgroundImageLayout)
        Desktop.SetAppBarColor(Aire.API.User.Current.Settings.AppBarColor)
        Desktop.SetLaunchBarColor(Aire.API.User.Current.Settings.LaunchBarColor)
    End Sub

#End Region

#Region "Private"

    Private Sub DisplayDesktop()
        Desktop.Show()
    End Sub

#End Region

End Class
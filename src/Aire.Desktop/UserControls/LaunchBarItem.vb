Public Class LaunchBarItem

#Region "Properties"

    Public Property Window As String

    Public Shadows Property Text As String

#End Region

#Region "Methods"

    Public Sub RemoveIfWindowClosed()
        If Aire.API.Sys.Window.Info.GetIfClosed(Window) Then
            Me.Dispose()
        End If
    End Sub

#End Region

#Region "UI"

    Private Sub lblName_MouseClick(sender As Object, e As MouseEventArgs) Handles lblName.MouseClick
        Call LaunchBarItem_MouseClick(sender, e)
    End Sub

#End Region

#Region "Context Menu"

    Private Sub ContextMenu_Close()
        Aire.API.Sys.Window.Actions.Kill(Window)
    End Sub

    Private Sub ContextMenu_Maximize()
        Aire.API.Sys.Window.Actions.Maximize(Window)
    End Sub

    Private Sub ContextMenu_Activate()
        Aire.API.Sys.Window.Actions.Activate(Window)
    End Sub

    Private Sub ContextMenu_Normal()
        Aire.API.Sys.Window.Actions.Normal(Window)
    End Sub

    Private Sub ContextMenu_Minimize()
        Aire.API.Sys.Window.Actions.Minimize(Window)
    End Sub

#End Region

#Region "LaunchBarItem"

    Private Sub LaunchBarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaunchBarItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Select Case e.Clicks
            Case 1
                Aire.API.Sys.Window.Actions.Activate(Window)
            Case 2
                Aire.API.Sys.Window.Actions.Minimize(Window)
            Case 3
                Aire.API.Sys.Window.Actions.Kill(Window)
        End Select
    End Sub

#End Region

End Class

Public Class LaunchBarItem

#Region "Properties/Variables"

    Public Property Window As String

    Public Shadows Property Text As String

    Private menuItems() As MenuItem = New MenuItem() {New MenuItem("Activate"), New MenuItem("Close"), New MenuItem("Maximize"), New MenuItem("Normal"), New MenuItem("Minimize")}
    Private buttonMenu As New ContextMenu(menuItems)

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
        If e.Button = Windows.Forms.MouseButtons.Right Then
            buttonMenu.Show(Me, New System.Drawing.Point(20, 20))
        Else
            Call LaunchBarItem_MouseClick(sender, e)
        End If
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
        If e.Button = Windows.Forms.MouseButtons.Right Then
            buttonMenu.Show(Me, New System.Drawing.Point(20, 20))
        Else
            Select Case e.Clicks
                Case 1
                    Aire.API.Sys.Window.Actions.Activate(Window)
                Case 2
                    Aire.API.Sys.Window.Actions.Minimize(Window)
                Case 3
                    Aire.API.Sys.Window.Actions.Kill(Window)
                Case 4
                    buttonMenu.Show(Me, New System.Drawing.Point(20, 20))
            End Select
        End If
        
    End Sub

#End Region

End Class

Public Class LaunchBarItem

#Region "Properties/Variables"

    Private fname As String

    Private lbar As bar_launchbar

    Public Property Window As String

    Public Shadows Property Text As String
        Get
            Return fname
        End Get
        Set(value As String)
            fname = value
            If value.Length > 10 Then
                lblName.Text = value.Substring(0, 10) & "..."
            Else
                lblName.Text = value
            End If
        End Set
    End Property

    Private menuItems() As MenuItem = New MenuItem() {New MenuItem("Activate", New EventHandler(AddressOf ContextMenu_Activate)), New MenuItem("Close", New EventHandler(AddressOf ContextMenu_Close)), New MenuItem("Maximize", New EventHandler(AddressOf ContextMenu_Maximize)), New MenuItem("Normal", New EventHandler(AddressOf ContextMenu_Normal)), New MenuItem("Minimize", New EventHandler(AddressOf ContextMenu_Minimize))}
    Private buttonMenu As New ContextMenu(menuItems)

#End Region

#Region "Methods"

    Public Sub UpdateText()
        Text = Aire.API.Sys.Window.Info.GetName(Window)
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

    Public Sub New(ByVal win As String, ByVal launchbar As bar_launchbar)
        InitializeComponent()
        Window = win
        Text = Aire.API.Sys.Window.Info.GetName(win)
        lbar = launchbar
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

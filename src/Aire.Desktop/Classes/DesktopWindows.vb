Public Class DesktopWindows

    Public Property Windows As New List(Of String)
    Private desktop As frmDesktop

#Region "Methods"

    Public Sub CloseAll()
        For Each item As String In Windows
            Aire.API.Sys.Window.Actions.Kill(item)
        Next
    End Sub

    Public Sub ShowAll()
        For Each item As String In Windows
            Aire.API.Sys.Window.Actions.Normal(item)
        Next
    End Sub

    Public Sub HideAll()
        
    End Sub

    Public Sub MinimizeAll()
        For Each item As String In Windows
            Aire.API.Sys.Window.Actions.Minimize(item)
        Next
    End Sub

    Public Sub MaximizeAll()
        For Each item As String In Windows
            Aire.API.Sys.Window.Actions.Maximize(item)
        Next
    End Sub

#End Region

    Public Sub New(ByVal frm As frmDesktop)
        desktop = frm
    End Sub

End Class
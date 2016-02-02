Public Class DesktopWindows

    Public Property Windows As New List(Of String)
    Private desktop As frmDesktop

#Region "Methods"

    Public Sub CloseAll()

    End Sub

    Public Sub ShowAll()

    End Sub

    Public Sub HideAll()

    End Sub

    Public Sub MinimizeAll()

    End Sub

    Public Sub MaximizeAll()

    End Sub

#End Region

    Public Sub New(ByVal frm As frmDesktop)
        desktop = frm
    End Sub

End Class

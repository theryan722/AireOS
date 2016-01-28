Public Class frmDesktop

#Region "Properties"

    Public Property Windows As New List(Of DesktopWindows)
    Public Property User As String
    Public Property Session As DesktopSession

#End Region

#Region "Methods"



#End Region

#Region "UI"



#End Region

#Region "frmDesktop"

    Public Sub New(ByVal ouser As String, Optional ByVal ses As DesktopSession = Nothing)
        InitializeComponent()
        User = ouser
        Session = ses
    End Sub

#End Region

End Class
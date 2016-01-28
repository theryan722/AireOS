Public Class frmDesktop

#Region "Properties"

    Public Property Windows As List(Of DesktopWindows)
    Public Property User As String

#End Region

#Region "Methods"



#End Region

#Region "UI"



#End Region

#Region "frmDesktop"

    Public Sub New(ByVal ouser As String)
        InitializeComponent()
        User = ouser
    End Sub

#End Region

End Class
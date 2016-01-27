Public Class frmLauncher

#Region "Variables/Properties"

    Private bar As bar_launchbar
    Private desktop As frmDesktop
    Public Shared Property Showing As Boolean = False

#End Region

#Region "UI"



#End Region

#Region "Methods"



#End Region

#Region "bar_appbar"

    Public Sub New(ByVal frm As bar_launchbar, ByVal frm2 As frmDesktop)
        InitializeComponent()
        bar = frm
        desktop = frm2
    End Sub

#End Region

End Class
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

#Region "frmLauncher"

    Public Sub New(ByVal frm As bar_launchbar, ByVal frm2 As frmDesktop)
        InitializeComponent()
        bar = frm
        desktop = frm2
    End Sub

    Private Sub frmLauncher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmLauncher.Showing = False
    End Sub

    Private Sub frmLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLauncher.Showing = True
    End Sub

#End Region

End Class
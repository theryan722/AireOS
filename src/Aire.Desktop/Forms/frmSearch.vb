Public Class frmSearch

#Region "Properties/Variables"

    Public Shared Property Showing As Boolean = False

#End Region

#Region "UI"

#Region "Options Panel"

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        If pnl_options.Width = 16 Then
            pnl_options.Width = 80
            btnOptions.BackgroundImage = My.Resources._16_arrowleft
            btnOptions.Dock = DockStyle.Right
        Else
            pnl_options.Width = 16
            btnOptions.BackgroundImage = My.Resources._16_arrowright
            btnOptions.Dock = DockStyle.Left
        End If
    End Sub

#End Region

#End Region

#Region "Methods"

    Private Sub FixBackColor()
        pnl_options.BackColor = Aire.SysColors.Colors.ActiveCaption
        pnl_results.BackColor = Aire.SysColors.Colors.ActiveCaption
    End Sub

#End Region

#Region "frmSearch"

    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmSearch.Showing = False
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSearch.Showing = True
        FixBackColor()
    End Sub

    Private Sub frmSearch_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal searchterm As String)
        InitializeComponent()
        txtSearch.Text = searchterm
    End Sub

#End Region

End Class
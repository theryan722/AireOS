Public Class frmSearch

#Region "Properties/Variables"

    Public Shared Property Showing As Boolean = False

#End Region

#Region "UI"



#End Region

#Region "Methods"



#End Region

#Region "frmSearch"

    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmSearch.Showing = False
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSearch.Showing = True
    End Sub

    Private Sub frmSearch_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal searchterm As String)
        InitializeComponent()
    End Sub

#End Region

End Class
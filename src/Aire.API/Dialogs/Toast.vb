Imports System.Drawing

Public Class Toast

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Toast"

    Public Sub New(ByVal text As String, Optional ByVal duration As Integer = 2500, Optional ByVal title As String = "", Optional ByVal backcolor As System.Drawing.Color = Nothing)
        InitializeComponent()
        Dim bcolor As Color = If(backcolor = Nothing, SystemColors.ActiveCaption, backcolor)
        TextBox1.BackColor = bcolor
        pnl_top.BackColor = bcolor
        TextBox1.Text = text
        lblTitle.Text = title
        Sys.Logging.Log.Write("Toast - TITLE: " & title & " , TEXT: " & text, Sys.Logging.Log.LogSource.Toast)
    End Sub

#End Region


End Class
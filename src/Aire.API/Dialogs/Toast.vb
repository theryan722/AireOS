Imports System.Drawing
Imports System.Windows.Forms

Public Class Toast
    Private Shared openForms As New List(Of Toast)

#Region "UI"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Toast"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="text">The text to display</param>
    ''' <param name="duration">How long to display the toast, in milliseconds</param>
    ''' <param name="title">The title to display</param>
    ''' <param name="backcolor">The backcolor of the toast</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal text As String, Optional ByVal duration As Integer = 2500, Optional ByVal title As String = "", Optional ByVal backcolor As System.Drawing.Color = Nothing, Optional ByVal autoshow As Boolean = True)
        InitializeComponent()
        Dim bcolor As Color = If(backcolor = Nothing, SystemColors.ActiveBorder, backcolor)
        Me.TextBox1.BackColor = bcolor
        Me.pnl_top.BackColor = bcolor
        Me.TextBox1.Text = text
        Me.lblTitle.Text = title
        Me.lifeTimer.Interval = duration
        Sys.Logging.Log.Write("Toast - TITLE: " & title & " , TEXT: " & text, Sys.Logging.Log.LogSource.Toast)
        If autoshow Then
            Me.Show()
        End If
    End Sub

    Private Sub Toast_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        For Each openForm As Toast In Toast.openForms
            If openForm Is Me Then
                Exit For
            End If
            openForm.Top += Me.Height + 5
        Next
        Toast.openForms.Remove(Me)
    End Sub

    Private Sub Toast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 5)
        For Each openForm As Toast In Toast.openForms
            openForm.Top -= Me.Height + 5
        Next
        Toast.openForms.Add(Me)
        Me.lifeTimer.Start()
    End Sub

#End Region

    Private Sub lifeTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles lifeTimer.Tick
        Me.Close()
    End Sub

End Class
﻿Public Class LauncherItem

#Region "Properties/Variables"

    Private ftitle As String

    Public Property Title As String
        Get
            Return ftitle
        End Get
        Set(value As String)
            ftitle = value
            If value.Length > 20 Then
                lblTitle.Text = value.Substring(0, 20) & "..."
            Else
                lblTitle.Text = value
            End If
            ToolTip1.SetToolTip(lblTitle, value)
            ToolTip1.SetToolTip(Me, value)
        End Set
    End Property

    Public Property FileLocation As String

    Public Property LauncherForm As frmLauncher

#End Region

#Region "Methods"

    Private Sub LaunchFile()
        If System.IO.File.Exists(FileLocation) Then
            Aire.API.Sys.Process.Start(FileLocation)
            LauncherForm.Close()
        End If
    End Sub

    Private Sub SetBackColorDimGray()
        lblTitle.BackColor = Color.DimGray
        Me.BackColor = Color.DimGray
    End Sub

    Private Sub SetBackColorGray()
        lblTitle.BackColor = Color.Gray
        Me.BackColor = Color.Gray
    End Sub

#End Region

#Region "lblTitle"

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        LaunchFile()
    End Sub

    Private Sub lblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        SetBackColorGray()
    End Sub

    Private Sub lblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        SetBackColorDimGray()
    End Sub

#End Region

#Region "LauncherItem"

    Public Sub New(ByVal ntitle As String, ByVal floc As String)
        InitializeComponent()
        Title = ntitle
        FileLocation = floc
    End Sub

    Private Sub LauncherItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        LaunchFile()
    End Sub

    Private Sub LauncherItem_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        SetBackColorGray()
    End Sub

    Private Sub LauncherItem_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        SetBackColorDimGray()
    End Sub

#End Region
    
End Class

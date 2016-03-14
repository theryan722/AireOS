﻿Public Class InputDialog

#Region "Properties/Enum/Variables"

    Public Property Response As String

    Public Property TextValidation As ValidationType = ValidationType.AllText

    Public Enum ValidationType
        AllText
        NumbersOnly
        LettersOnly
    End Enum

    Private anum As String = "0123456789"

    Private achar As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

#End Region

#Region "UI"

    Private Sub TextBox1_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextValidation = ValidationType.LettersOnly Then
            If achar.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        ElseIf TextValidation = ValidationType.NumbersOnly Then
            If anum.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Response = TextBox1.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region "InputDialog"

    Public Sub New(Optional ByVal multiline As Boolean = False, Optional textval As ValidationType = ValidationType.AllText, Optional ByVal title As String = "", Optional ByVal message As String = "")
        InitializeComponent()
        If multiline Then
            TextBox1.Multiline = True
            TextBox1.Dock = Windows.Forms.DockStyle.Fill
            TextBox1.ScrollBars = Windows.Forms.ScrollBars.Vertical
        End If
        Me.Text = title
        lblMessage.Text = message
        TextValidation = textval
        Me.ShowDialog()
    End Sub

#End Region

End Class
Imports System.IO

Public Class dlgProperties

    Private fproperties As FileProperties
    Private isfolder As Boolean = False

#Region "Methods"

    Private Sub LoadProperties()
        TextBox1.Text = ""
        If isfolder Then
            TextBox1.Text = "Name: " & Path.GetDirectoryName(fproperties.GetFullPath) & vbNewLine
        Else
            TextBox1.Text = "Name: " & Path.GetFileName(fproperties.GetFullPath) & vbNewLine & "Folder: " & Path.GetDirectoryName(fproperties.GetFullPath) & vbNewLine & "Full Path: " & fproperties.GetFullPath & vbNewLine & "Size: " & fproperties.GetFileSize & vbNewLine & "Created: " & fproperties.GetFileCreationDate.ToString & vbNewLine & "Modified: " & fproperties.GetFileModifiedDate.ToString & vbNewLine & "Accessed: " & fproperties.GetAccessedDate & vbNewLine & "Read Only: " & fproperties.GetIfReadOnly.ToString
        End If
    End Sub

#End Region

#Region "dlgProperties"

    Public Sub New(ByVal path As String)
        fproperties = New FileProperties(path)
    End Sub

    Private Sub dlgProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fproperties.GetIfFileExists Then
            Me.Text = System.IO.Path.GetFileName(fproperties.GetFullPath) & " Properties"
            isfolder = False
        Else
            Me.Text = System.IO.Path.GetDirectoryName(fproperties.GetFullPath) & " Properties"
            isfolder = True
        End If
    End Sub

#End Region


End Class
Public Class dlgProperties

    Private fproperties As FileProperties

#Region "Methods"



#End Region

#Region "dlgProperties"

    Public Sub New(ByVal path As String)
        fproperties = New FileProperties(path)
    End Sub

    Private Sub dlgProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = System.IO.Path.GetFileName(fproperties.GetFullPath) & " Properties"
    End Sub

#End Region

    
End Class
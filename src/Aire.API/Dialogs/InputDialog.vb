Public Class InputDialog

#Region "Properties"

    Public Property Response As String

#End Region

#Region "Methods"



#End Region

#Region "UI"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

    End Sub

#End Region

#Region "InputDialog"

    Public Sub New(Optional ByVal multiline As Boolean = False, Optional ByVal title As String = "", Optional ByVal message As String = "")
        InitializeComponent()
        If multiline Then
            TextBox1.Multiline = True
            TextBox1.Dock = Windows.Forms.DockStyle.Fill
            TextBox1.ScrollBars = Windows.Forms.ScrollBars.Vertical
        End If
        Me.Text = title
        lblMessage.Text = message
        Me.ShowDialog()
    End Sub

#End Region

End Class
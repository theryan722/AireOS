Public Class InputDialog

#Region "Properties/Enum"

    Public Property Response As String

    Public Property TextValidation As ValidationType = ValidationType.AllText

    Public Enum ValidationType
        AllText
        NumbersOnly
        LettersOnly
    End Enum

#End Region

#Region "UI"

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
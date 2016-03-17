Imports System.Windows.Forms

Public Class InputDialog

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

    Private BACKSPACE As Boolean = False

#End Region

#Region "UI"

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If Not TextBox1.Multiline Then
            If e.KeyCode = Keys.Enter Then
                btnOk.PerformClick()
            End If
        End If
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If BACKSPACE = False Then
            If TextValidation = ValidationType.LettersOnly Then
                If achar.IndexOf(e.KeyChar) = -1 Then
                    e.Handled = True
                End If
            ElseIf TextValidation = ValidationType.NumbersOnly Then
                If anum.IndexOf(e.KeyChar) = -1 Then
                    e.Handled = True
                End If
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

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="multiline">Whether the textbox allows multiple lines</param>
    ''' <param name="textval">What kind of text evaluation to perform</param>
    ''' <param name="title">The title of the dialog</param>
    ''' <param name="message">The message to display</param>
    ''' <remarks></remarks>
    Public Sub New(Optional ByVal multiline As Boolean = False, Optional textval As ValidationType = ValidationType.AllText, Optional ByVal title As String = "", Optional ByVal message As String = "", Optional ByVal deftext As String = "", Optional ByVal autoshow As Boolean = True)
        InitializeComponent()
        If multiline Then
            TextBox1.Multiline = True
            TextBox1.Dock = Windows.Forms.DockStyle.Fill
            TextBox1.ScrollBars = Windows.Forms.ScrollBars.Vertical
        End If
        Me.Text = title
        lblMessage.Text = message
        TextValidation = textval
        TextBox1.Text = deftext
        If autoshow Then
            Me.ShowDialog()
        End If
    End Sub

#End Region

End Class
Imports System.Drawing

Public Class MessageBox

#Region "Enums"

    Enum MessageBoxResponse
        Yes
        No
        Cancel
        Ok
        Retry
    End Enum

    Enum MessageBoxIcon
        Information
        Warning
        Security
        [Stop]
        Critical
        Question
        None
    End Enum

    Enum MessageBoxButtons
        OkOnly
        OkCancel
        YesNo
        YesNoCancel
        RetryCancel
    End Enum

#End Region

#Region "Methods"

    Private Sub SetImage(ByVal icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Information
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_info
            Case MessageBoxIcon.Warning
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_warning
            Case MessageBoxIcon.Security
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_security
            Case MessageBoxIcon.[Stop]
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_stop
            Case MessageBoxIcon.Critical
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_critical
            Case MessageBoxIcon.Question
                pnl_picture.Visible = True
                PictureBox1.BackgroundImage = My.Resources.notify_question
            Case MessageBoxIcon.None
                pnl_picture.Visible = False
        End Select
    End Sub

    Private Sub SetButtons(ByVal buttons As MessageBoxButtons)
        Select Case buttons
            Case MessageBoxButtons.OkOnly
                btnOk.Show()
            Case MessageBoxButtons.OkCancel
                btnOk.Show()
                btnCancel.Show()
            Case MessageBoxButtons.YesNo
                btnYes.Show()
                btnNo.Show()
            Case MessageBoxButtons.YesNoCancel
                btnYes.Show()
                btnNo.Show()
                btnCancel.Show()
            Case MessageBoxButtons.RetryCancel
                btnRetry.Show()
                btnCancel.Show()
        End Select
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Me.DialogResult = Windows.Forms.DialogResult.Retry
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "MessageBox"

    Public Sub New(ByVal text As String, Optional ByVal title As String = "", Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OkOnly, Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.None, Optional ByVal backcolor As System.Drawing.Color = Nothing, Optional ByVal showintaskbar As Boolean = False, Optional ByVal topmost As Boolean = True)
        InitializeComponent()
        Dim bcolor As Color = If(backcolor = Nothing, SystemColors.Control, backcolor)
        TextBox1.BackColor = bcolor
        pnl_buttons.BackColor = bcolor
        TextBox1.Text = text
        Me.Text = title
        SetImage(icon)
        SetButtons(buttons)
        Me.ShowInTaskbar = showintaskbar
        Me.TopMost = topmost
    End Sub

#End Region

End Class
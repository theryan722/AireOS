Public Class dlgOptions

#Region "Variables"

    Private fcolor As Color
    Private bcolor As Color

#End Region

#Region "UI"

    Private Sub btnForecolor_Click(sender As Object, e As EventArgs) Handles btnForecolor.Click

    End Sub

    Private Sub btnBackcolor_Click(sender As Object, e As EventArgs) Handles btnBackcolor.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub

#End Region

#Region "Methods"

    Private Sub LoadSettings()

    End Sub

    Private Sub SaveSettings()

    End Sub

    Private Sub ResetSettings()
        check_topmost.Checked = False
        check_fullscreen.Checked = False
        check_allowexternal.Checked = False
        fcolor = System.Drawing.SystemColors.Window
        bcolor = System.Drawing.SystemColors.WindowText
        btnForecolor.BackColor = fcolor
        btnBackcolor.BackColor = bcolor
    End Sub

#End Region

#Region "dlgOptions"

    Private Sub dlgOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
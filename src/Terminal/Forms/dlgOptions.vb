Public Class dlgOptions

#Region "UI"

    Private Sub btnForecolor_Click(sender As Object, e As EventArgs) Handles btnForecolor.Click

    End Sub

    Private Sub btnBackcolor_Click(sender As Object, e As EventArgs) Handles btnBackcolor.Click
        Dim newb As New ColorDialog
        newb.Color = btnBackcolor.BackColor
        If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnBackcolor.BackColor = newb.Color
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim bb As New Aire.API.MessageBox("Are you sure you want to reset the settings to their default values?", "Reset Settings", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
        If bb.DialogResult = Windows.Forms.DialogResult.Yes Then
            ResetSettings()
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub LoadSettings()
        check_topmost.Checked = ConfigManager.GetIfTopmost
        check_fullscreen.Checked = ConfigManager.GetIfFullscreen
        check_allowexternal.Checked = ConfigManager.GetIfAllowExternal
        btnForecolor.BackColor = ConfigManager.GetForeColor
        btnBackcolor.BackColor = ConfigManager.GetBackColor
    End Sub

    Private Sub SaveSettings()
        ConfigManager.SetBackColor(btnBackcolor.BackColor)
        ConfigManager.SetForeColor(btnForecolor.BackColor)
        ConfigManager.SetIfAllowExternal(check_allowexternal.Checked)
        ConfigManager.SetIfFullscreen(check_fullscreen.Checked)
        ConfigManager.SetIfTopmost(check_topmost.Checked)
    End Sub

    Private Sub ResetSettings()
        check_topmost.Checked = False
        check_fullscreen.Checked = False
        check_allowexternal.Checked = False
        btnForecolor.BackColor = System.Drawing.SystemColors.Window
        btnBackcolor.BackColor = System.Drawing.SystemColors.WindowText
    End Sub

#End Region

#Region "dlgOptions"

    Private Sub dlgOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

#End Region

End Class
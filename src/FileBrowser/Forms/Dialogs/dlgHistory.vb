Public Class dlgHistory

#Region "UI"

#Region "Context Menu Strip"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub OpenInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNewWindowToolStripMenuItem.Click

    End Sub

#End Region

#Region "Buttons"

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearHistory()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNavigate_Click(sender As Object, e As EventArgs) Handles btnNavigate.Click

    End Sub

#End Region

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        OpenSelected()
    End Sub

#End Region

#Region "Methods"

    Private Sub OpenSelected(Optional ByVal newwin As Boolean = False)
        If ListBox1.SelectedIndex <> -1 Then
            If newwin Then
                Dim newb As New frmMain
                newb.Navigate(ListBox1.SelectedItem)
                newb.Show()
            Else
                frmMain.Navigate(ListBox1.SelectedItem)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ClearHistory()
        Dim bb As New Aire.API.MessageBox("Are you sure you want to clear the history?", "Clear History", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
        If bb.DialogResult = Windows.Forms.DialogResult.Yes Then
            ListBox1.Items.Clear()
            ConfigManager.ClearHistory()
        End If
    End Sub

    Private Sub LoadHistory()
        For Each line As String In ConfigManager.ReadHistory
            ListBox1.Items.Add(line)
        Next
    End Sub

#End Region

#Region "dlgHistory"

    Private Sub dlgHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()
    End Sub

#End Region

End Class
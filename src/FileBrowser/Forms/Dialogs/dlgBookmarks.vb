Public Class dlgBookmarks

#Region "UI"

#Region "Buttons"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenSelected()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearBookmarks()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveSelected()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddBookmark()
    End Sub

#End Region

#Region "Context Menu Strip"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenSelected()
    End Sub

    Private Sub OpenInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNewWindowToolStripMenuItem.Click
        OpenSelected(True)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveSelected()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        AddBookmark()
    End Sub

#End Region

#Region "ListBox"

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenSelected()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveSelected()
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        OpenSelected()
    End Sub

#End Region

#End Region

#Region "Methods"

    Private Sub AddBookmark()
        Dim bb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "Add Bookmark", "Enter a directory to bookmark")
        If bb.DialogResult = Windows.Forms.DialogResult.OK AndAlso Not bb.Response = "" AndAlso Not ListBox1.Items.Contains(bb.Response) Then
            If IO.Directory.Exists(bb.Response) Then
                ListBox1.Items.Add(bb.Response)
                ConfigManager.AddBookmark(bb.Response)
            Else
                Dim msg As New Aire.API.MessageBox("The path entered is not a valid one.", "Invalid Path", Aire.API.MessageBox.MessageBoxButtons.OkOnly, Aire.API.MessageBox.MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub RemoveSelected()
        If ListBox1.SelectedIndex <> -1 Then
            ConfigManager.RemoveBookmark(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

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

    Private Sub ClearBookmarks()
        Dim bb As New Aire.API.MessageBox("Are you sure you want to clear all bookmarks?", "Clear Bookmarks", Aire.API.MessageBox.MessageBoxButtons.YesNo, Aire.API.MessageBox.MessageBoxIcon.Question)
        If bb.DialogResult = Windows.Forms.DialogResult.Yes Then
            ListBox1.Items.Clear()
            ConfigManager.ClearBookmarks()
        End If
    End Sub

    Private Sub LoadBookmarks()
        For Each line As String In ConfigManager.ReadBookmarks
            ListBox1.Items.Add(line)
        Next
    End Sub

#End Region

#Region "dlgBookmarks"

    Private Sub dlgBookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookmarks()
    End Sub

#End Region

End Class
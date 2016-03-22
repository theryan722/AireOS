﻿Public Class dlgBookmarks

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

    End Sub

    Private Sub OpenInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNewWindowToolStripMenuItem.Click

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

    End Sub

#End Region

#Region "ListBox"

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick

    End Sub

#End Region

#End Region

#Region "Methods"

    Private Sub AddBookmark()
        Dim bb As New Aire.API.InputDialog(False, Aire.API.InputDialog.ValidationType.AllText, "Add Bookmark", "Enter a directory to bookmark")
        If bb.DialogResult = Windows.Forms.DialogResult.OK AndAlso bb.Response <> "" Then
            ListBox1.Items.Add(bb.Response)
            ConfigManager.AddToBookmarks(bb.Response)
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
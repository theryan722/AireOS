Public Class frmMain

#Region "Properties/Variables"



#End Region

#Region "Methods"

#Region "Edit"

    Private Sub Undo()
        If TextBox1.CanUndo Then
            TextBox1.Undo()
        End If
    End Sub

    Private Sub Redo()
        If TextBox1.CanRedo Then
            TextBox1.Redo()
        End If
    End Sub

    Private Sub Cut()
        TextBox1.Cut()
    End Sub

    Private Sub Copy()
        TextBox1.Copy()
    End Sub

    Private Sub Paste()
        TextBox1.Paste()
    End Sub

    Private Sub SelectAll()
        TextBox1.SelectAll()
    End Sub

    Private Sub ClearAll()
        TextBox1.Clear()
    End Sub

#End Region

    Private Sub Open()

    End Sub

    Private Sub Save()

    End Sub

    Private Sub SaveAs()

    End Sub

    Private Sub Print()

    End Sub

    Private Sub SetFont()
        Dim newb As New FontDialog
        newb.Font = TextBox1.Font
        If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = newb.Font
        End If
    End Sub

    Private Sub SetTopmost(ByVal val As Boolean)
        Me.TopMost = val
        TopmostToolStripMenuItem.Checked = val
    End Sub

    Private Sub SetColor(ByVal back As Boolean)
        If back Then
            Dim newb As New ColorDialog
            newb.Color = TextBox1.BackColor
            If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.BackColor = newb.Color
            End If
        Else
            Dim newb As New ColorDialog
            newb.Color = TextBox1.ForeColor
            If newb.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.ForeColor = newb.Color
            End If
        End If
    End Sub

#End Region

#Region "Menu Strip"

#Region "File"

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newb As New frmMain
        newb.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

#End Region

#Region "Edit"

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectAll()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearAll()
    End Sub

#End Region

#Region "View"

    Private Sub TopmostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopmostToolStripMenuItem.Click

    End Sub

#End Region

#Region "Format"

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        SetFont()
    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackcolorToolStripMenuItem.Click
        SetColor(True)
    End Sub

    Private Sub ForecolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForecolorToolStripMenuItem.Click
        SetColor(False)
    End Sub

#End Region

#Region "About"

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

    End Sub

#End Region

#End Region

#Region "Context Menu Strip"

    Private Sub UndoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem1.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem1.Click
        Redo()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        SelectAll()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        ClearAll()
    End Sub

#End Region

#Region "TextBox1"



#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AutoWordSelection = False
    End Sub

#End Region

End Class

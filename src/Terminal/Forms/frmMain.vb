Public Class frmMain

#Region "Properties/Variables"

    Private TypedText As String = ""

#End Region

#Region "Methods"



#End Region

#Region "Menu Strip"

#Region "File"

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newb As New frmMain
        newb.Show()
    End Sub

    Private Sub CloseWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseWindowToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitTerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitTerminalToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region

#Region "Edit"

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub CopyAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllToolStripMenuItem.Click

    End Sub

#End Region

#Region "View"

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click

    End Sub

    Private Sub TopmostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopmostToolStripMenuItem.Click

    End Sub

#End Region

#Region "About"

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

    End Sub

#End Region

#End Region

#Region "Context Menu Strip"

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click

    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click

    End Sub

#End Region

#Region "TextBox1"

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectionStart = Len(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                CommandManager.ExecuteCommand(TypedText, Me)
                TypedText = ""
            ElseIf e.KeyChar = ChrW(Keys.Back) Then
                If TypedText.Length > 0 Then
                    TypedText = TypedText.Substring(0, TypedText.Length - 1)
                Else
                    e.Handled = True
                End If
            Else
                TypedText += e.KeyChar
            End If
            TextBox1.SelectionStart = Len(TextBox1.Text)
        Catch ex As Exception
            Aire.API.Sys.Logging.Log.Write("ERROR: " & ex.ToString)
        End Try
    End Sub

#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class

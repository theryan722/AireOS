﻿Public Class frmMain

#Region "Methods"

    Private Sub SetRepeatAction(ByVal val As Boolean)
        Calculator1.RepeatAssignAction = val
        RepeatActionToolStripMenuItem.Checked = val
    End Sub

    Private Sub Copy()
        My.Computer.Clipboard.SetText(Calculator1.Value.ToString)
    End Sub

    Private Sub Paste()
        If My.Computer.Clipboard.GetText.Contains(".") Then
            Calculator1.Value = New Syncfusion.Windows.Forms.Tools.CalculatorValue(CDbl(My.Computer.Clipboard.GetText))
        Else
            Calculator1.Value = New Syncfusion.Windows.Forms.Tools.CalculatorValue(CInt(My.Computer.Clipboard.GetText))
        End If
    End Sub

    Private Sub SetTopmost(ByVal val As Boolean)
        Me.TopMost = val
        TopmostToolStripMenuItem.Checked = val
    End Sub

    Private Sub SetTouchMode(ByVal val As Boolean)
        Calculator1.EnableTouchMode = val
        TouchModeToolStripMenuItem.Checked = val
    End Sub

    Private Sub SetFinancialView(ByVal val As Boolean)
        If val Then
            Calculator1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial
            FinancialViewToolStripMenuItem.Checked = True
        Else
            Calculator1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.WindowsStandard
            FinancialViewToolStripMenuItem.Checked = False
        End If
    End Sub

#End Region

#Region "UI"

#Region "btnMenu"

    Private Sub RepeatActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepeatActionToolStripMenuItem.Click
        If Calculator1.RepeatAssignAction Then
            SetRepeatAction(False)
        Else
            SetRepeatAction(True)
        End If
    End Sub

    Private Sub TopmostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopmostToolStripMenuItem.Click
        If Me.TopMost Then
            SetTopmost(False)
        Else
            SetTopmost(True)
        End If
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newb As New frmMain
        newb.Show()
    End Sub

    Private Sub FinancialViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinancialViewToolStripMenuItem.Click
        If Calculator1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.WindowsStandard Then
            SetFinancialView(True)
        Else
            SetFinancialView(False)
        End If
    End Sub

    Private Sub TouchModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TouchModeToolStripMenuItem.Click
        If Calculator1.EnableTouchMode Then
            SetTouchMode(False)
        Else
            SetTouchMode(True)
        End If
    End Sub

#End Region

#Region "Context Menu Strip"

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub

#End Region

#End Region
    
End Class

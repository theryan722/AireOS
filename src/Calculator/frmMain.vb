Public Class frmMain

#Region "Properties"



#End Region

#Region "Methods"

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



#End Region

#Region "frmMain"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

    Private Sub TouchModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TouchModeToolStripMenuItem.Click
        If Calculator1.EnableTouchMode Then
           
        Else

        End If
    End Sub
    
End Class

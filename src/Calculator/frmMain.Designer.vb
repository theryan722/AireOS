<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Calculator1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TopmostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinancialViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TouchModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calculator1
        '
        Me.Calculator1.AccessibleDescription = ""
        Me.Calculator1.AccessibleName = ""
        Me.Calculator1.BeforeTouchSize = New System.Drawing.Size(309, 389)
        Me.Calculator1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Calculator1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.Calculator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calculator1.DoubleValue = 0.0R
        Me.Calculator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Calculator1.Location = New System.Drawing.Point(0, 0)
        Me.Calculator1.MetroColor = System.Drawing.SystemColors.Control
        Me.Calculator1.Name = "Calculator1"
        Me.Calculator1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Calculator1.Size = New System.Drawing.Size(309, 389)
        Me.Calculator1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMenu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(309, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.ToolStripSeparator2, Me.RepeatActionToolStripMenuItem, Me.ToolStripSeparator1, Me.TopmostToolStripMenuItem, Me.FinancialViewToolStripMenuItem, Me.TouchModeToolStripMenuItem})
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(29, 20)
        Me.btnMenu.Text = "ToolStripDropDownButton1"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'TopmostToolStripMenuItem
        '
        Me.TopmostToolStripMenuItem.Name = "TopmostToolStripMenuItem"
        Me.TopmostToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TopmostToolStripMenuItem.Text = "Topmost"
        '
        'FinancialViewToolStripMenuItem
        '
        Me.FinancialViewToolStripMenuItem.Name = "FinancialViewToolStripMenuItem"
        Me.FinancialViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FinancialViewToolStripMenuItem.Text = "Financial View"
        '
        'TouchModeToolStripMenuItem
        '
        Me.TouchModeToolStripMenuItem.Name = "TouchModeToolStripMenuItem"
        Me.TouchModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TouchModeToolStripMenuItem.Text = "Touch Mode"
        '
        'RepeatActionToolStripMenuItem
        '
        Me.RepeatActionToolStripMenuItem.Name = "RepeatActionToolStripMenuItem"
        Me.RepeatActionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatActionToolStripMenuItem.Text = "Repeat Action"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 411)
        Me.Controls.Add(Me.Calculator1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Calculator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calculator1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnMenu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents FinancialViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TouchModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopmostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RepeatActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

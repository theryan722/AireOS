<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintDialog
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
        Me.pnl_bottom = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_printers = New System.Windows.Forms.ListBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pnl_info = New System.Windows.Forms.Panel()
        Me.Tab_PageRange = New System.Windows.Forms.TabPage()
        Me.Tab_Options = New System.Windows.Forms.TabPage()
        Me.Tab_Margins = New System.Windows.Forms.TabPage()
        Me.Tab_Copies = New System.Windows.Forms.TabPage()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pnl_bottom.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.pnl_info.SuspendLayout()
        Me.Tab_Copies.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Controls.Add(Me.btnPrint)
        Me.pnl_bottom.Controls.Add(Me.btnCancel)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 267)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(449, 23)
        Me.pnl_bottom.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Location = New System.Drawing.Point(0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.Location = New System.Drawing.Point(374, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_printers)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer"
        '
        'lb_printers
        '
        Me.lb_printers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_printers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_printers.FormattingEnabled = True
        Me.lb_printers.ItemHeight = 15
        Me.lb_printers.Location = New System.Drawing.Point(3, 16)
        Me.lb_printers.Name = "lb_printers"
        Me.lb_printers.ScrollAlwaysVisible = True
        Me.lb_printers.Size = New System.Drawing.Size(443, 78)
        Me.lb_printers.TabIndex = 0
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(3, 3)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(40, 13)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Status:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Controls.Add(Me.Tab_PageRange)
        Me.TabControl1.Controls.Add(Me.Tab_Copies)
        Me.TabControl1.Controls.Add(Me.Tab_Margins)
        Me.TabControl1.Controls.Add(Me.Tab_Options)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 122)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(449, 145)
        Me.TabControl1.TabIndex = 3
        '
        'pnl_info
        '
        Me.pnl_info.Controls.Add(Me.lbl_status)
        Me.pnl_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_info.Location = New System.Drawing.Point(0, 97)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Size = New System.Drawing.Size(449, 25)
        Me.pnl_info.TabIndex = 4
        '
        'Tab_PageRange
        '
        Me.Tab_PageRange.Location = New System.Drawing.Point(4, 22)
        Me.Tab_PageRange.Name = "Tab_PageRange"
        Me.Tab_PageRange.Size = New System.Drawing.Size(441, 119)
        Me.Tab_PageRange.TabIndex = 0
        Me.Tab_PageRange.Text = "Page Range"
        Me.Tab_PageRange.UseVisualStyleBackColor = True
        '
        'Tab_Options
        '
        Me.Tab_Options.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Options.Name = "Tab_Options"
        Me.Tab_Options.Size = New System.Drawing.Size(441, 119)
        Me.Tab_Options.TabIndex = 1
        Me.Tab_Options.Text = "Options"
        Me.Tab_Options.UseVisualStyleBackColor = True
        '
        'Tab_Margins
        '
        Me.Tab_Margins.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Margins.Name = "Tab_Margins"
        Me.Tab_Margins.Size = New System.Drawing.Size(441, 119)
        Me.Tab_Margins.TabIndex = 2
        Me.Tab_Margins.Text = "Margins"
        Me.Tab_Margins.UseVisualStyleBackColor = True
        '
        'Tab_Copies
        '
        Me.Tab_Copies.Controls.Add(Me.CheckBox1)
        Me.Tab_Copies.Controls.Add(Me.NumericUpDown1)
        Me.Tab_Copies.Controls.Add(Me.Label1)
        Me.Tab_Copies.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Copies.Name = "Tab_Copies"
        Me.Tab_Copies.Size = New System.Drawing.Size(441, 119)
        Me.Tab_Copies.TabIndex = 3
        Me.Tab_Copies.Text = "Copies"
        Me.Tab_Copies.UseVisualStyleBackColor = True
        '
        'General
        '
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Size = New System.Drawing.Size(441, 119)
        Me.General.TabIndex = 4
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copies:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(51, 6)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(67, 20)
        Me.NumericUpDown1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Collated"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PrintDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 290)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnl_info)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnl_bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.TopMost = True
        Me.pnl_bottom.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.pnl_info.ResumeLayout(False)
        Me.pnl_info.PerformLayout()
        Me.Tab_Copies.ResumeLayout(False)
        Me.Tab_Copies.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_printers As System.Windows.Forms.ListBox
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_PageRange As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Options As System.Windows.Forms.TabPage
    Friend WithEvents pnl_info As System.Windows.Forms.Panel
    Friend WithEvents Tab_Copies As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Margins As System.Windows.Forms.TabPage
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

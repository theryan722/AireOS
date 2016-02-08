<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchBarItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl_divider = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(13, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "[]"
        '
        'pnl_divider
        '
        Me.pnl_divider.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnl_divider.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_divider.Location = New System.Drawing.Point(0, 27)
        Me.pnl_divider.Name = "pnl_divider"
        Me.pnl_divider.Size = New System.Drawing.Size(80, 3)
        Me.pnl_divider.TabIndex = 1
        '
        'LaunchBarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.pnl_divider)
        Me.Controls.Add(Me.lblName)
        Me.Name = "LaunchBarItem"
        Me.Size = New System.Drawing.Size(80, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pnl_divider As System.Windows.Forms.Panel

End Class

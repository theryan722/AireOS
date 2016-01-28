<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesktop
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
        Me.pnl_launchbar_loc = New System.Windows.Forms.Panel()
        Me.pnl_appbar_top = New System.Windows.Forms.Panel()
        Me.pnl_appbar_bottom = New System.Windows.Forms.Panel()
        Me.pnl_desktop = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnl_launchbar_loc
        '
        Me.pnl_launchbar_loc.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_launchbar_loc.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_launchbar_loc.Location = New System.Drawing.Point(0, 0)
        Me.pnl_launchbar_loc.Name = "pnl_launchbar_loc"
        Me.pnl_launchbar_loc.Size = New System.Drawing.Size(80, 685)
        Me.pnl_launchbar_loc.TabIndex = 0
        '
        'pnl_appbar_top
        '
        Me.pnl_appbar_top.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_appbar_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_appbar_top.Location = New System.Drawing.Point(80, 0)
        Me.pnl_appbar_top.Name = "pnl_appbar_top"
        Me.pnl_appbar_top.Size = New System.Drawing.Size(901, 48)
        Me.pnl_appbar_top.TabIndex = 1
        '
        'pnl_appbar_bottom
        '
        Me.pnl_appbar_bottom.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnl_appbar_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_appbar_bottom.Location = New System.Drawing.Point(80, 637)
        Me.pnl_appbar_bottom.Name = "pnl_appbar_bottom"
        Me.pnl_appbar_bottom.Size = New System.Drawing.Size(901, 48)
        Me.pnl_appbar_bottom.TabIndex = 2
        '
        'pnl_desktop
        '
        Me.pnl_desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_desktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_desktop.Location = New System.Drawing.Point(80, 48)
        Me.pnl_desktop.Name = "pnl_desktop"
        Me.pnl_desktop.Size = New System.Drawing.Size(901, 589)
        Me.pnl_desktop.TabIndex = 3
        '
        'frmDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 685)
        Me.Controls.Add(Me.pnl_desktop)
        Me.Controls.Add(Me.pnl_appbar_bottom)
        Me.Controls.Add(Me.pnl_appbar_top)
        Me.Controls.Add(Me.pnl_launchbar_loc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDesktop"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmDesktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_launchbar_loc As System.Windows.Forms.Panel
    Friend WithEvents pnl_appbar_top As System.Windows.Forms.Panel
    Friend WithEvents pnl_appbar_bottom As System.Windows.Forms.Panel
    Friend WithEvents pnl_desktop As System.Windows.Forms.Panel
End Class

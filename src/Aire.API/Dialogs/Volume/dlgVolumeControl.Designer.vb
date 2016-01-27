<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgVolumeControl
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lbl_vol = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(32, 3)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 145)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lbl_vol
        '
        Me.lbl_vol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_vol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vol.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_vol.Location = New System.Drawing.Point(0, 151)
        Me.lbl_vol.Name = "lbl_vol"
        Me.lbl_vol.Size = New System.Drawing.Size(89, 23)
        Me.lbl_vol.TabIndex = 1
        Me.lbl_vol.Text = "0%"
        Me.lbl_vol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgVolume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(89, 174)
        Me.Controls.Add(Me.lbl_vol)
        Me.Controls.Add(Me.TrackBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dlgVolume"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents lbl_vol As System.Windows.Forms.Label
End Class

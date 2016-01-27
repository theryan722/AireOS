<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bar_launchbar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bar_launchbar))
        Me.btnLauncher = New System.Windows.Forms.Button()
        Me.pnl_tray = New System.Windows.Forms.Panel()
        Me.lbl_timedate = New System.Windows.Forms.Label()
        Me.pnl_applications = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_tray.SuspendLayout()
        Me.pnl_applications.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLauncher
        '
        Me.btnLauncher.BackgroundImage = CType(resources.GetObject("btnLauncher.BackgroundImage"), System.Drawing.Image)
        Me.btnLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLauncher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLauncher.FlatAppearance.BorderSize = 0
        Me.btnLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLauncher.Location = New System.Drawing.Point(0, 0)
        Me.btnLauncher.Name = "btnLauncher"
        Me.btnLauncher.Size = New System.Drawing.Size(80, 25)
        Me.btnLauncher.TabIndex = 0
        Me.btnLauncher.UseVisualStyleBackColor = True
        '
        'pnl_tray
        '
        Me.pnl_tray.Controls.Add(Me.lbl_timedate)
        Me.pnl_tray.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_tray.Location = New System.Drawing.Point(0, 485)
        Me.pnl_tray.Name = "pnl_tray"
        Me.pnl_tray.Size = New System.Drawing.Size(80, 100)
        Me.pnl_tray.TabIndex = 1
        '
        'lbl_timedate
        '
        Me.lbl_timedate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timedate.Location = New System.Drawing.Point(0, 50)
        Me.lbl_timedate.Name = "lbl_timedate"
        Me.lbl_timedate.Size = New System.Drawing.Size(80, 50)
        Me.lbl_timedate.TabIndex = 0
        Me.lbl_timedate.Text = "TIME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATE"
        Me.lbl_timedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_applications
        '
        Me.pnl_applications.Controls.Add(Me.Button1)
        Me.pnl_applications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_applications.Location = New System.Drawing.Point(0, 25)
        Me.pnl_applications.Name = "pnl_applications"
        Me.pnl_applications.Size = New System.Drawing.Size(80, 460)
        Me.pnl_applications.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(28, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 19)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bar_launchbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(80, 585)
        Me.Controls.Add(Me.pnl_applications)
        Me.Controls.Add(Me.pnl_tray)
        Me.Controls.Add(Me.btnLauncher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bar_launchbar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.pnl_tray.ResumeLayout(False)
        Me.pnl_applications.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLauncher As System.Windows.Forms.Button
    Friend WithEvents pnl_tray As System.Windows.Forms.Panel
    Friend WithEvents pnl_applications As System.Windows.Forms.Panel
    Friend WithEvents lbl_timedate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bar_launchbar))
        Me.pnl_tray = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNotification = New System.Windows.Forms.Button()
        Me.btnVolume = New System.Windows.Forms.Button()
        Me.btnNetwork = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnBattery = New System.Windows.Forms.Button()
        Me.lbl_timedate = New System.Windows.Forms.Label()
        Me.pnl_applications = New System.Windows.Forms.Panel()
        Me.btnLauncher = New System.Windows.Forms.Button()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_tray.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_tray
        '
        Me.pnl_tray.Controls.Add(Me.Panel1)
        Me.pnl_tray.Controls.Add(Me.lbl_timedate)
        Me.pnl_tray.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_tray.Location = New System.Drawing.Point(0, 519)
        Me.pnl_tray.Name = "pnl_tray"
        Me.pnl_tray.Size = New System.Drawing.Size(80, 66)
        Me.pnl_tray.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNotification)
        Me.Panel1.Controls.Add(Me.btnVolume)
        Me.Panel1.Controls.Add(Me.btnNetwork)
        Me.Panel1.Controls.Add(Me.btnMore)
        Me.Panel1.Controls.Add(Me.btnBattery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 16)
        Me.Panel1.TabIndex = 1
        '
        'btnNotification
        '
        Me.btnNotification.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._16_notification
        Me.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNotification.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNotification.FlatAppearance.BorderSize = 0
        Me.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotification.Location = New System.Drawing.Point(48, 0)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(16, 16)
        Me.btnNotification.TabIndex = 4
        Me.btnNotification.UseVisualStyleBackColor = True
        '
        'btnVolume
        '
        Me.btnVolume.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources.volume_mute
        Me.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolume.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVolume.FlatAppearance.BorderSize = 0
        Me.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolume.Location = New System.Drawing.Point(32, 0)
        Me.btnVolume.Name = "btnVolume"
        Me.btnVolume.Size = New System.Drawing.Size(16, 16)
        Me.btnVolume.TabIndex = 3
        Me.btnVolume.UseVisualStyleBackColor = True
        '
        'btnNetwork
        '
        Me.btnNetwork.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources.networking_disconnected
        Me.btnNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNetwork.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNetwork.FlatAppearance.BorderSize = 0
        Me.btnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNetwork.Location = New System.Drawing.Point(16, 0)
        Me.btnNetwork.Name = "btnNetwork"
        Me.btnNetwork.Size = New System.Drawing.Size(16, 16)
        Me.btnNetwork.TabIndex = 2
        Me.btnNetwork.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.BackgroundImage = CType(resources.GetObject("btnMore.BackgroundImage"), System.Drawing.Image)
        Me.btnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMore.FlatAppearance.BorderSize = 0
        Me.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMore.Location = New System.Drawing.Point(64, 0)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(16, 16)
        Me.btnMore.TabIndex = 1
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'btnBattery
        '
        Me.btnBattery.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources.battery_danger
        Me.btnBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBattery.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBattery.FlatAppearance.BorderSize = 0
        Me.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBattery.Location = New System.Drawing.Point(0, 0)
        Me.btnBattery.Name = "btnBattery"
        Me.btnBattery.Size = New System.Drawing.Size(16, 16)
        Me.btnBattery.TabIndex = 0
        Me.btnBattery.UseVisualStyleBackColor = True
        '
        'lbl_timedate
        '
        Me.lbl_timedate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_timedate.Location = New System.Drawing.Point(0, 16)
        Me.lbl_timedate.Name = "lbl_timedate"
        Me.lbl_timedate.Size = New System.Drawing.Size(80, 50)
        Me.lbl_timedate.TabIndex = 0
        Me.lbl_timedate.Text = "TIME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATE"
        Me.lbl_timedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_applications
        '
        Me.pnl_applications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_applications.Location = New System.Drawing.Point(0, 25)
        Me.pnl_applications.Name = "pnl_applications"
        Me.pnl_applications.Size = New System.Drawing.Size(80, 494)
        Me.pnl_applications.TabIndex = 2
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
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 1000
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
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLauncher As System.Windows.Forms.Button
    Friend WithEvents pnl_tray As System.Windows.Forms.Panel
    Friend WithEvents pnl_applications As System.Windows.Forms.Panel
    Friend WithEvents lbl_timedate As System.Windows.Forms.Label
    Friend WithEvents btnBattery As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMore As System.Windows.Forms.Button
    Friend WithEvents btnNetwork As System.Windows.Forms.Button
    Friend WithEvents btnVolume As System.Windows.Forms.Button
    Friend WithEvents btnNotification As System.Windows.Forms.Button
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer
End Class

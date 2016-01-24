<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPower))
        Me.btnHibernate = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnSleep = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnHibernate
        '
        Me.btnHibernate.BackgroundImage = CType(resources.GetObject("btnHibernate.BackgroundImage"), System.Drawing.Image)
        Me.btnHibernate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHibernate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHibernate.FlatAppearance.BorderSize = 0
        Me.btnHibernate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHibernate.Location = New System.Drawing.Point(192, 0)
        Me.btnHibernate.Name = "btnHibernate"
        Me.btnHibernate.Size = New System.Drawing.Size(64, 64)
        Me.btnHibernate.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnHibernate, "Hibernate")
        Me.btnHibernate.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.BackgroundImage = CType(resources.GetObject("btnRestart.BackgroundImage"), System.Drawing.Image)
        Me.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestart.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRestart.FlatAppearance.BorderSize = 0
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Location = New System.Drawing.Point(128, 0)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(64, 64)
        Me.btnRestart.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnRestart, "Restart")
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnSleep
        '
        Me.btnSleep.BackgroundImage = CType(resources.GetObject("btnSleep.BackgroundImage"), System.Drawing.Image)
        Me.btnSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSleep.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSleep.FlatAppearance.BorderSize = 0
        Me.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSleep.Location = New System.Drawing.Point(64, 0)
        Me.btnSleep.Name = "btnSleep"
        Me.btnSleep.Size = New System.Drawing.Size(64, 64)
        Me.btnSleep.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSleep, "Sleep")
        Me.btnSleep.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.BackgroundImage = CType(resources.GetObject("btnShutdown.BackgroundImage"), System.Drawing.Image)
        Me.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShutdown.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShutdown.FlatAppearance.BorderSize = 0
        Me.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutdown.Location = New System.Drawing.Point(0, 0)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(64, 64)
        Me.btnShutdown.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnShutdown, "Shutdown")
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'dlgPower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 64)
        Me.Controls.Add(Me.btnHibernate)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnSleep)
        Me.Controls.Add(Me.btnShutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgPower"
        Me.Text = "Power"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHibernate As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnSleep As System.Windows.Forms.Button
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
End Class

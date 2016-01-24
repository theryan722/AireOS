<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLogout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLogout))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSwitchUser = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(64, 64)
        Me.btnLogout.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnLogout, "Logout")
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSwitchUser
        '
        Me.btnSwitchUser.BackgroundImage = CType(resources.GetObject("btnSwitchUser.BackgroundImage"), System.Drawing.Image)
        Me.btnSwitchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwitchUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSwitchUser.FlatAppearance.BorderSize = 0
        Me.btnSwitchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwitchUser.Location = New System.Drawing.Point(64, 0)
        Me.btnSwitchUser.Name = "btnSwitchUser"
        Me.btnSwitchUser.Size = New System.Drawing.Size(64, 64)
        Me.btnSwitchUser.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnSwitchUser, "Switch User")
        Me.btnSwitchUser.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.BackgroundImage = CType(resources.GetObject("btnLock.BackgroundImage"), System.Drawing.Image)
        Me.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLock.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLock.FlatAppearance.BorderSize = 0
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Location = New System.Drawing.Point(128, 0)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(64, 64)
        Me.btnLock.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnLock, "Lock User")
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'dlgLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 64)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.btnSwitchUser)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgLogout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSwitchUser As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
End Class

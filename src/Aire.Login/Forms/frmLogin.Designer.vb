<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnPower = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOtherUsers = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_users = New System.Windows.Forms.ListBox()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPower
        '
        Me.btnPower.BackgroundImage = CType(resources.GetObject("btnPower.BackgroundImage"), System.Drawing.Image)
        Me.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPower.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.Location = New System.Drawing.Point(486, 0)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(32, 32)
        Me.btnPower.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnPower, "Power")
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOtherUsers)
        Me.Panel1.Controls.Add(Me.btnPower)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 32)
        Me.Panel1.TabIndex = 1
        '
        'btnOtherUsers
        '
        Me.btnOtherUsers.BackColor = System.Drawing.SystemColors.Control
        Me.btnOtherUsers.BackgroundImage = CType(resources.GetObject("btnOtherUsers.BackgroundImage"), System.Drawing.Image)
        Me.btnOtherUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOtherUsers.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOtherUsers.FlatAppearance.BorderSize = 0
        Me.btnOtherUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOtherUsers.Location = New System.Drawing.Point(0, 0)
        Me.btnOtherUsers.Name = "btnOtherUsers"
        Me.btnOtherUsers.Size = New System.Drawing.Size(32, 32)
        Me.btnOtherUsers.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnOtherUsers, "Users")
        Me.btnOtherUsers.UseVisualStyleBackColor = False
        Me.btnOtherUsers.Visible = False
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(186, 111)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(193, 20)
        Me.txt_username.TabIndex = 2
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(186, 137)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(193, 20)
        Me.txt_password.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(186, 163)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(193, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username:"
        '
        'lb_users
        '
        Me.lb_users.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lb_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_users.FormattingEnabled = True
        Me.lb_users.ItemHeight = 20
        Me.lb_users.Location = New System.Drawing.Point(0, 125)
        Me.lb_users.Name = "lb_users"
        Me.lb_users.ScrollAlwaysVisible = True
        Me.lb_users.Size = New System.Drawing.Size(120, 84)
        Me.lb_users.TabIndex = 8
        Me.lb_users.Visible = False
        '
        'pb_user
        '
        Me.pb_user.Location = New System.Drawing.Point(235, 9)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(96, 96)
        Me.pb_user.TabIndex = 9
        Me.pb_user.TabStop = False
        '
        'btnHint
        '
        Me.btnHint.Location = New System.Drawing.Point(385, 111)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(35, 20)
        Me.btnHint.TabIndex = 10
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        Me.btnHint.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lb_users)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 209)
        Me.Panel2.TabIndex = 11
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(518, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.pb_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.Text = "Aire OS Login"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_users As System.Windows.Forms.ListBox
    Friend WithEvents pb_user As System.Windows.Forms.PictureBox
    Friend WithEvents btnOtherUsers As System.Windows.Forms.Button
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class

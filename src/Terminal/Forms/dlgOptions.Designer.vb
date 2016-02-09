<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOptions))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.check_allowexternal = New System.Windows.Forms.CheckBox()
        Me.check_topmost = New System.Windows.Forms.CheckBox()
        Me.check_fullscreen = New System.Windows.Forms.CheckBox()
        Me.btnForecolor = New System.Windows.Forms.Button()
        Me.btnBackcolor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(150, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 23)
        Me.Panel1.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReset.Location = New System.Drawing.Point(75, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'check_allowexternal
        '
        Me.check_allowexternal.AutoSize = True
        Me.check_allowexternal.Location = New System.Drawing.Point(0, 0)
        Me.check_allowexternal.Name = "check_allowexternal"
        Me.check_allowexternal.Size = New System.Drawing.Size(147, 17)
        Me.check_allowexternal.TabIndex = 0
        Me.check_allowexternal.Text = "Allow External Commands"
        Me.check_allowexternal.UseVisualStyleBackColor = True
        '
        'check_topmost
        '
        Me.check_topmost.AutoSize = True
        Me.check_topmost.Location = New System.Drawing.Point(0, 23)
        Me.check_topmost.Name = "check_topmost"
        Me.check_topmost.Size = New System.Drawing.Size(116, 17)
        Me.check_topmost.TabIndex = 1
        Me.check_topmost.Text = "Topmost at Startup"
        Me.check_topmost.UseVisualStyleBackColor = True
        '
        'check_fullscreen
        '
        Me.check_fullscreen.AutoSize = True
        Me.check_fullscreen.Location = New System.Drawing.Point(0, 46)
        Me.check_fullscreen.Name = "check_fullscreen"
        Me.check_fullscreen.Size = New System.Drawing.Size(123, 17)
        Me.check_fullscreen.TabIndex = 2
        Me.check_fullscreen.Text = "Fullscreen at Startup"
        Me.check_fullscreen.UseVisualStyleBackColor = True
        '
        'btnForecolor
        '
        Me.btnForecolor.Location = New System.Drawing.Point(0, 69)
        Me.btnForecolor.Name = "btnForecolor"
        Me.btnForecolor.Size = New System.Drawing.Size(75, 23)
        Me.btnForecolor.TabIndex = 3
        Me.btnForecolor.Text = "Forecolor"
        Me.btnForecolor.UseVisualStyleBackColor = True
        '
        'btnBackcolor
        '
        Me.btnBackcolor.Location = New System.Drawing.Point(81, 69)
        Me.btnBackcolor.Name = "btnBackcolor"
        Me.btnBackcolor.Size = New System.Drawing.Size(75, 23)
        Me.btnBackcolor.TabIndex = 4
        Me.btnBackcolor.Text = "Backcolor"
        Me.btnBackcolor.UseVisualStyleBackColor = True
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 122)
        Me.Controls.Add(Me.btnBackcolor)
        Me.Controls.Add(Me.btnForecolor)
        Me.Controls.Add(Me.check_fullscreen)
        Me.Controls.Add(Me.check_topmost)
        Me.Controls.Add(Me.check_allowexternal)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dlgOptions"
        Me.ShowInTaskbar = False
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents check_allowexternal As System.Windows.Forms.CheckBox
    Friend WithEvents check_topmost As System.Windows.Forms.CheckBox
    Friend WithEvents check_fullscreen As System.Windows.Forms.CheckBox
    Friend WithEvents btnForecolor As System.Windows.Forms.Button
    Friend WithEvents btnBackcolor As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class

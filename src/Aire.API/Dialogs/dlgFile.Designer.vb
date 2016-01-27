<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFile
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_file = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOpenSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.combo_fileextensions = New System.Windows.Forms.ComboBox()
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnl_bottom.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Controls.Add(Me.Panel3)
        Me.pnl_bottom.Controls.Add(Me.Panel1)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 284)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(489, 45)
        Me.pnl_bottom.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_file)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 20)
        Me.Panel3.TabIndex = 6
        '
        'txt_file
        '
        Me.txt_file.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_file.Location = New System.Drawing.Point(57, 0)
        Me.txt_file.Name = "txt_file"
        Me.txt_file.Size = New System.Drawing.Size(271, 20)
        Me.txt_file.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File Name:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.combo_fileextensions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(338, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 45)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnOpenSave)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 23)
        Me.Panel2.TabIndex = 3
        '
        'btnOpenSave
        '
        Me.btnOpenSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOpenSave.Location = New System.Drawing.Point(2, 0)
        Me.btnOpenSave.Name = "btnOpenSave"
        Me.btnOpenSave.Size = New System.Drawing.Size(74, 23)
        Me.btnOpenSave.TabIndex = 1
        Me.btnOpenSave.Text = "Open"
        Me.btnOpenSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(76, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'combo_fileextensions
        '
        Me.combo_fileextensions.Dock = System.Windows.Forms.DockStyle.Top
        Me.combo_fileextensions.FormattingEnabled = True
        Me.combo_fileextensions.Location = New System.Drawing.Point(0, 0)
        Me.combo_fileextensions.Name = "combo_fileextensions"
        Me.combo_fileextensions.Size = New System.Drawing.Size(151, 21)
        Me.combo_fileextensions.TabIndex = 2
        '
        'pnl_top
        '
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(489, 40)
        Me.pnl_top.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(328, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 20)
        Me.Panel4.TabIndex = 7
        '
        'dlgFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 329)
        Me.Controls.Add(Me.pnl_top)
        Me.Controls.Add(Me.pnl_bottom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFile"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File"
        Me.TopMost = True
        Me.pnl_bottom.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_file As System.Windows.Forms.TextBox
    Friend WithEvents combo_fileextensions As System.Windows.Forms.ComboBox
    Friend WithEvents btnOpenSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class

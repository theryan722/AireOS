<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.pnl_results = New System.Windows.Forms.Panel()
        Me.pnl_options = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.toggleWeb = New MetroFramework.Controls.MetroToggle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toggleApplications = New MetroFramework.Controls.MetroToggle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toggleDocuments = New MetroFramework.Controls.MetroToggle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toggleHelp = New MetroFramework.Controls.MetroToggle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toggleAll = New MetroFramework.Controls.MetroToggle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.pnl_options.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(0, 262)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(269, 30)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.UseSelectable = True
        '
        'pnl_results
        '
        Me.pnl_results.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_results.Location = New System.Drawing.Point(16, 0)
        Me.pnl_results.Name = "pnl_results"
        Me.pnl_results.Size = New System.Drawing.Size(253, 262)
        Me.pnl_results.TabIndex = 3
        '
        'pnl_options
        '
        Me.pnl_options.Controls.Add(Me.Panel7)
        Me.pnl_options.Controls.Add(Me.Panel6)
        Me.pnl_options.Controls.Add(Me.Panel5)
        Me.pnl_options.Controls.Add(Me.Panel4)
        Me.pnl_options.Controls.Add(Me.Panel3)
        Me.pnl_options.Controls.Add(Me.Panel2)
        Me.pnl_options.Controls.Add(Me.Panel1)
        Me.pnl_options.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_options.Location = New System.Drawing.Point(0, 0)
        Me.pnl_options.Name = "pnl_options"
        Me.pnl_options.Size = New System.Drawing.Size(16, 262)
        Me.pnl_options.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.toggleWeb)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(16, 136)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(0, 30)
        Me.Panel7.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Web"
        '
        'toggleWeb
        '
        Me.toggleWeb.AutoSize = True
        Me.toggleWeb.DisplayStatus = False
        Me.toggleWeb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toggleWeb.Location = New System.Drawing.Point(0, 13)
        Me.toggleWeb.Name = "toggleWeb"
        Me.toggleWeb.Size = New System.Drawing.Size(0, 17)
        Me.toggleWeb.TabIndex = 3
        Me.toggleWeb.Text = "Off"
        Me.toggleWeb.UseSelectable = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.toggleApplications)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(16, 106)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(0, 30)
        Me.Panel6.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Applications"
        '
        'toggleApplications
        '
        Me.toggleApplications.AutoSize = True
        Me.toggleApplications.DisplayStatus = False
        Me.toggleApplications.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toggleApplications.Location = New System.Drawing.Point(0, 13)
        Me.toggleApplications.Name = "toggleApplications"
        Me.toggleApplications.Size = New System.Drawing.Size(0, 17)
        Me.toggleApplications.TabIndex = 3
        Me.toggleApplications.Text = "Off"
        Me.toggleApplications.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.toggleDocuments)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(16, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(0, 30)
        Me.Panel5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Documents"
        '
        'toggleDocuments
        '
        Me.toggleDocuments.AutoSize = True
        Me.toggleDocuments.DisplayStatus = False
        Me.toggleDocuments.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toggleDocuments.Location = New System.Drawing.Point(0, 13)
        Me.toggleDocuments.Name = "toggleDocuments"
        Me.toggleDocuments.Size = New System.Drawing.Size(0, 17)
        Me.toggleDocuments.TabIndex = 3
        Me.toggleDocuments.Text = "Off"
        Me.toggleDocuments.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.toggleHelp)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(16, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(0, 30)
        Me.Panel4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Help"
        '
        'toggleHelp
        '
        Me.toggleHelp.AutoSize = True
        Me.toggleHelp.DisplayStatus = False
        Me.toggleHelp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toggleHelp.Location = New System.Drawing.Point(0, 13)
        Me.toggleHelp.Name = "toggleHelp"
        Me.toggleHelp.Size = New System.Drawing.Size(0, 17)
        Me.toggleHelp.TabIndex = 3
        Me.toggleHelp.Text = "Off"
        Me.toggleHelp.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.toggleAll)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(16, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 30)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All"
        '
        'toggleAll
        '
        Me.toggleAll.AutoSize = True
        Me.toggleAll.DisplayStatus = False
        Me.toggleAll.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toggleAll.Location = New System.Drawing.Point(0, 13)
        Me.toggleAll.Name = "toggleAll"
        Me.toggleAll.Size = New System.Drawing.Size(0, 17)
        Me.toggleAll.TabIndex = 3
        Me.toggleAll.Text = "Off"
        Me.toggleAll.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 246)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOptions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 16)
        Me.Panel1.TabIndex = 1
        '
        'btnOptions
        '
        Me.btnOptions.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._16_arrowright
        Me.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Location = New System.Drawing.Point(0, 0)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(16, 16)
        Me.btnOptions.TabIndex = 0
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(269, 292)
        Me.Controls.Add(Me.pnl_results)
        Me.Controls.Add(Me.pnl_options)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Search"
        Me.TopMost = True
        Me.pnl_options.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnl_results As System.Windows.Forms.Panel
    Friend WithEvents pnl_options As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toggleAll As MetroFramework.Controls.MetroToggle
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents toggleHelp As MetroFramework.Controls.MetroToggle
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents toggleDocuments As MetroFramework.Controls.MetroToggle
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents toggleWeb As MetroFramework.Controls.MetroToggle
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents toggleApplications As MetroFramework.Controls.MetroToggle
End Class

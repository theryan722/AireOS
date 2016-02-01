<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLauncher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLauncher))
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnFileExplorer = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(228, 30)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.UseSelectable = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(75, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 17)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOptions)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.btnFileExplorer)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnPower)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 30)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(164, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 381)
        Me.Panel2.TabIndex = 5
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._72_profile
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Location = New System.Drawing.Point(0, 0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(72, 72)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._72_search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(274, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnFileExplorer
        '
        Me.btnFileExplorer.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._72_filebrowser
        Me.btnFileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFileExplorer.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFileExplorer.FlatAppearance.BorderSize = 0
        Me.btnFileExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileExplorer.Location = New System.Drawing.Point(304, 0)
        Me.btnFileExplorer.Name = "btnFileExplorer"
        Me.btnFileExplorer.Size = New System.Drawing.Size(30, 30)
        Me.btnFileExplorer.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnFileExplorer, "File Browser")
        Me.btnFileExplorer.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.BackgroundImage = CType(resources.GetObject("btnPower.BackgroundImage"), System.Drawing.Image)
        Me.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPower.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.Location = New System.Drawing.Point(334, 0)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(30, 30)
        Me.btnPower.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnPower, "Power")
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.BackgroundImage = Global.Aire.Desktop.My.Resources.Resources._72_wrench
        Me.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Location = New System.Drawing.Point(244, 0)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(30, 30)
        Me.btnOptions.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnOptions, "Options")
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 411)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLauncher"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Launcher"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnFileExplorer As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class

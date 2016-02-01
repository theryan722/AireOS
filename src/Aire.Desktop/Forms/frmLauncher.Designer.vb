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
        Me.pb_profilepicture = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        CType(Me.pb_profilepicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_profilepicture
        '
        Me.pb_profilepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_profilepicture.Location = New System.Drawing.Point(0, 0)
        Me.pb_profilepicture.Name = "pb_profilepicture"
        Me.pb_profilepicture.Size = New System.Drawing.Size(72, 72)
        Me.pb_profilepicture.TabIndex = 0
        Me.pb_profilepicture.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(32, 302)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(169, 23)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.UseSelectable = True
        '
        'frmLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 411)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pb_profilepicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLauncher"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Launcher"
        Me.TopMost = True
        CType(Me.pb_profilepicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_profilepicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
End Class

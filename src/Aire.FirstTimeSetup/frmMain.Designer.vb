<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.WizardControl1 = New WizardBase.WizardControl()
        Me.StartStep1 = New WizardBase.StartStep()
        Me.LicenceStep1 = New WizardBase.LicenceStep()
        Me.IntermediateStep1 = New WizardBase.IntermediateStep()
        Me.FinishStep1 = New WizardBase.FinishStep()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        Me.WizardControl1.BackButtonEnabled = False
        Me.WizardControl1.BackButtonVisible = True
        Me.WizardControl1.CancelButtonEnabled = True
        Me.WizardControl1.CancelButtonVisible = True
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.EulaButtonEnabled = False
        Me.WizardControl1.EulaButtonText = "eula"
        Me.WizardControl1.EulaButtonVisible = False
        Me.WizardControl1.HelpButtonEnabled = True
        Me.WizardControl1.HelpButtonVisible = True
        Me.WizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.NextButtonEnabled = True
        Me.WizardControl1.NextButtonVisible = True
        Me.WizardControl1.Size = New System.Drawing.Size(550, 435)
        Me.WizardControl1.WizardSteps.AddRange(New WizardBase.WizardStep() {Me.StartStep1, Me.LicenceStep1, Me.IntermediateStep1, Me.FinishStep1})
        '
        'StartStep1
        '
        Me.StartStep1.BindingImage = Nothing
        Me.StartStep1.Icon = Nothing
        Me.StartStep1.Name = "StartStep1"
        Me.StartStep1.Subtitle = "This setup will help you create a user account and get started."
        Me.StartStep1.Title = "Welcome to AireOS"
        '
        'LicenceStep1
        '
        Me.LicenceStep1.BindingImage = CType(resources.GetObject("LicenceStep1.BindingImage"), System.Drawing.Image)
        Me.LicenceStep1.LicenseFile = ""
        Me.LicenceStep1.Name = "LicenceStep1"
        Me.LicenceStep1.Title = "License Agreement."
        Me.LicenceStep1.Warning = "Please read the following license agreement. You must accept the terms  of this a" & _
    "greement before continuing."
        Me.LicenceStep1.WarningFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'IntermediateStep1
        '
        Me.IntermediateStep1.BindingImage = CType(resources.GetObject("IntermediateStep1.BindingImage"), System.Drawing.Image)
        Me.IntermediateStep1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IntermediateStep1.Name = "IntermediateStep1"
        '
        'FinishStep1
        '
        Me.FinishStep1.BindingImage = CType(resources.GetObject("FinishStep1.BindingImage"), System.Drawing.Image)
        Me.FinishStep1.Name = "FinishStep1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 435)
        Me.Controls.Add(Me.WizardControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aire OS Setup"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As WizardBase.WizardControl
    Friend WithEvents StartStep1 As WizardBase.StartStep
    Friend WithEvents LicenceStep1 As WizardBase.LicenceStep
    Friend WithEvents IntermediateStep1 As WizardBase.IntermediateStep
    Friend WithEvents FinishStep1 As WizardBase.FinishStep

End Class

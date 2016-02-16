<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintDialog
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_printers = New System.Windows.Forms.ListBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_Copies = New System.Windows.Forms.TabPage()
        Me.check_collated = New System.Windows.Forms.CheckBox()
        Me.num_copies = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab_PageRange = New System.Windows.Forms.TabPage()
        Me.radio_evens = New System.Windows.Forms.RadioButton()
        Me.radio_odds = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_custompagerange = New System.Windows.Forms.TextBox()
        Me.radio_custom = New System.Windows.Forms.RadioButton()
        Me.radio_all = New System.Windows.Forms.RadioButton()
        Me.Tab_Sides = New System.Windows.Forms.TabPage()
        Me.radio_twosidedlongedge = New System.Windows.Forms.RadioButton()
        Me.radio_twosidedshortedge = New System.Windows.Forms.RadioButton()
        Me.radio_onesided = New System.Windows.Forms.RadioButton()
        Me.Tab_Margins = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_marginbottom = New System.Windows.Forms.NumericUpDown()
        Me.num_margintop = New System.Windows.Forms.NumericUpDown()
        Me.num_marginright = New System.Windows.Forms.NumericUpDown()
        Me.num_marginleft = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab_Media = New System.Windows.Forms.TabPage()
        Me.combo_media = New System.Windows.Forms.ComboBox()
        Me.btn_addmedia = New System.Windows.Forms.Button()
        Me.btn_removemedia = New System.Windows.Forms.Button()
        Me.btn_clearmedia = New System.Windows.Forms.Button()
        Me.lb_media = New System.Windows.Forms.ListBox()
        Me.Tab_Documents = New System.Windows.Forms.TabPage()
        Me.combo_documentslayout = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.combo_documents = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tab_Options = New System.Windows.Forms.TabPage()
        Me.num_priority = New System.Windows.Forms.NumericUpDown()
        Me.check_nowrap = New System.Windows.Forms.CheckBox()
        Me.check_prettyprint = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.check_fittopage = New System.Windows.Forms.CheckBox()
        Me.combo_orientation = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radio_reverseorder = New System.Windows.Forms.RadioButton()
        Me.radio_normalorder = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.check_mirror = New System.Windows.Forms.CheckBox()
        Me.num_charactersinch = New System.Windows.Forms.NumericUpDown()
        Me.num_linesinch = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnl_info = New System.Windows.Forms.Panel()
        Me.pnl_bottom.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Copies.SuspendLayout()
        CType(Me.num_copies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_PageRange.SuspendLayout()
        Me.Tab_Sides.SuspendLayout()
        Me.Tab_Margins.SuspendLayout()
        CType(Me.num_marginbottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_margintop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_marginright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_marginleft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Media.SuspendLayout()
        Me.Tab_Documents.SuspendLayout()
        Me.Tab_Options.SuspendLayout()
        CType(Me.num_priority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.num_charactersinch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_linesinch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_bottom
        '
        Me.pnl_bottom.Controls.Add(Me.btnPrint)
        Me.pnl_bottom.Controls.Add(Me.btnCancel)
        Me.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bottom.Location = New System.Drawing.Point(0, 268)
        Me.pnl_bottom.Name = "pnl_bottom"
        Me.pnl_bottom.Size = New System.Drawing.Size(374, 23)
        Me.pnl_bottom.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.Location = New System.Drawing.Point(299, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_printers)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer"
        '
        'lb_printers
        '
        Me.lb_printers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_printers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_printers.FormattingEnabled = True
        Me.lb_printers.ItemHeight = 15
        Me.lb_printers.Location = New System.Drawing.Point(3, 16)
        Me.lb_printers.Name = "lb_printers"
        Me.lb_printers.ScrollAlwaysVisible = True
        Me.lb_printers.Size = New System.Drawing.Size(368, 78)
        Me.lb_printers.TabIndex = 0
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(3, 3)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(40, 13)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Status:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_Copies)
        Me.TabControl1.Controls.Add(Me.Tab_PageRange)
        Me.TabControl1.Controls.Add(Me.Tab_Sides)
        Me.TabControl1.Controls.Add(Me.Tab_Margins)
        Me.TabControl1.Controls.Add(Me.Tab_Media)
        Me.TabControl1.Controls.Add(Me.Tab_Documents)
        Me.TabControl1.Controls.Add(Me.Tab_Options)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(374, 151)
        Me.TabControl1.TabIndex = 3
        '
        'Tab_Copies
        '
        Me.Tab_Copies.Controls.Add(Me.check_collated)
        Me.Tab_Copies.Controls.Add(Me.num_copies)
        Me.Tab_Copies.Controls.Add(Me.Label1)
        Me.Tab_Copies.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Copies.Name = "Tab_Copies"
        Me.Tab_Copies.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Copies.TabIndex = 3
        Me.Tab_Copies.Text = "Copies"
        Me.Tab_Copies.UseVisualStyleBackColor = True
        '
        'check_collated
        '
        Me.check_collated.AutoSize = True
        Me.check_collated.Location = New System.Drawing.Point(6, 32)
        Me.check_collated.Name = "check_collated"
        Me.check_collated.Size = New System.Drawing.Size(64, 17)
        Me.check_collated.TabIndex = 2
        Me.check_collated.Text = "Collated"
        Me.check_collated.UseVisualStyleBackColor = True
        '
        'num_copies
        '
        Me.num_copies.Location = New System.Drawing.Point(51, 6)
        Me.num_copies.Name = "num_copies"
        Me.num_copies.Size = New System.Drawing.Size(67, 20)
        Me.num_copies.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copies:"
        '
        'Tab_PageRange
        '
        Me.Tab_PageRange.Controls.Add(Me.radio_evens)
        Me.Tab_PageRange.Controls.Add(Me.radio_odds)
        Me.Tab_PageRange.Controls.Add(Me.Label2)
        Me.Tab_PageRange.Controls.Add(Me.txt_custompagerange)
        Me.Tab_PageRange.Controls.Add(Me.radio_custom)
        Me.Tab_PageRange.Controls.Add(Me.radio_all)
        Me.Tab_PageRange.Location = New System.Drawing.Point(4, 22)
        Me.Tab_PageRange.Name = "Tab_PageRange"
        Me.Tab_PageRange.Size = New System.Drawing.Size(366, 125)
        Me.Tab_PageRange.TabIndex = 0
        Me.Tab_PageRange.Text = "Page Range"
        Me.Tab_PageRange.UseVisualStyleBackColor = True
        '
        'radio_evens
        '
        Me.radio_evens.AutoSize = True
        Me.radio_evens.Location = New System.Drawing.Point(7, 75)
        Me.radio_evens.Name = "radio_evens"
        Me.radio_evens.Size = New System.Drawing.Size(55, 17)
        Me.radio_evens.TabIndex = 5
        Me.radio_evens.TabStop = True
        Me.radio_evens.Text = "Evens"
        Me.radio_evens.UseVisualStyleBackColor = True
        '
        'radio_odds
        '
        Me.radio_odds.AutoSize = True
        Me.radio_odds.Location = New System.Drawing.Point(7, 52)
        Me.radio_odds.Name = "radio_odds"
        Me.radio_odds.Size = New System.Drawing.Size(50, 17)
        Me.radio_odds.TabIndex = 4
        Me.radio_odds.TabStop = True
        Me.radio_odds.Text = "Odds"
        Me.radio_odds.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ex: 1-4,10-15"
        '
        'txt_custompagerange
        '
        Me.txt_custompagerange.Location = New System.Drawing.Point(73, 29)
        Me.txt_custompagerange.Name = "txt_custompagerange"
        Me.txt_custompagerange.Size = New System.Drawing.Size(100, 20)
        Me.txt_custompagerange.TabIndex = 2
        '
        'radio_custom
        '
        Me.radio_custom.AutoSize = True
        Me.radio_custom.Location = New System.Drawing.Point(7, 29)
        Me.radio_custom.Name = "radio_custom"
        Me.radio_custom.Size = New System.Drawing.Size(60, 17)
        Me.radio_custom.TabIndex = 1
        Me.radio_custom.TabStop = True
        Me.radio_custom.Text = "Custom"
        Me.radio_custom.UseVisualStyleBackColor = True
        '
        'radio_all
        '
        Me.radio_all.AutoSize = True
        Me.radio_all.Location = New System.Drawing.Point(7, 6)
        Me.radio_all.Name = "radio_all"
        Me.radio_all.Size = New System.Drawing.Size(36, 17)
        Me.radio_all.TabIndex = 0
        Me.radio_all.TabStop = True
        Me.radio_all.Text = "All"
        Me.radio_all.UseVisualStyleBackColor = True
        '
        'Tab_Sides
        '
        Me.Tab_Sides.Controls.Add(Me.radio_twosidedlongedge)
        Me.Tab_Sides.Controls.Add(Me.radio_twosidedshortedge)
        Me.Tab_Sides.Controls.Add(Me.radio_onesided)
        Me.Tab_Sides.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Sides.Name = "Tab_Sides"
        Me.Tab_Sides.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Sides.TabIndex = 5
        Me.Tab_Sides.Text = "Sides"
        Me.Tab_Sides.UseVisualStyleBackColor = True
        '
        'radio_twosidedlongedge
        '
        Me.radio_twosidedlongedge.AutoSize = True
        Me.radio_twosidedlongedge.Location = New System.Drawing.Point(3, 26)
        Me.radio_twosidedlongedge.Name = "radio_twosidedlongedge"
        Me.radio_twosidedlongedge.Size = New System.Drawing.Size(179, 17)
        Me.radio_twosidedlongedge.TabIndex = 2
        Me.radio_twosidedlongedge.TabStop = True
        Me.radio_twosidedlongedge.Text = "Two Sided - Long Edge (Portrait)"
        Me.radio_twosidedlongedge.UseVisualStyleBackColor = True
        '
        'radio_twosidedshortedge
        '
        Me.radio_twosidedshortedge.AutoSize = True
        Me.radio_twosidedshortedge.Location = New System.Drawing.Point(3, 49)
        Me.radio_twosidedshortedge.Name = "radio_twosidedshortedge"
        Me.radio_twosidedshortedge.Size = New System.Drawing.Size(200, 17)
        Me.radio_twosidedshortedge.TabIndex = 1
        Me.radio_twosidedshortedge.TabStop = True
        Me.radio_twosidedshortedge.Text = "Two Sided - Short Edge (Landscape)"
        Me.radio_twosidedshortedge.UseVisualStyleBackColor = True
        '
        'radio_onesided
        '
        Me.radio_onesided.AutoSize = True
        Me.radio_onesided.Location = New System.Drawing.Point(3, 3)
        Me.radio_onesided.Name = "radio_onesided"
        Me.radio_onesided.Size = New System.Drawing.Size(75, 17)
        Me.radio_onesided.TabIndex = 0
        Me.radio_onesided.TabStop = True
        Me.radio_onesided.Text = "One Sided"
        Me.radio_onesided.UseVisualStyleBackColor = True
        '
        'Tab_Margins
        '
        Me.Tab_Margins.Controls.Add(Me.Label7)
        Me.Tab_Margins.Controls.Add(Me.num_marginbottom)
        Me.Tab_Margins.Controls.Add(Me.num_margintop)
        Me.Tab_Margins.Controls.Add(Me.num_marginright)
        Me.Tab_Margins.Controls.Add(Me.num_marginleft)
        Me.Tab_Margins.Controls.Add(Me.Label6)
        Me.Tab_Margins.Controls.Add(Me.Label5)
        Me.Tab_Margins.Controls.Add(Me.Label4)
        Me.Tab_Margins.Controls.Add(Me.Label3)
        Me.Tab_Margins.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Margins.Name = "Tab_Margins"
        Me.Tab_Margins.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Margins.TabIndex = 2
        Me.Tab_Margins.Text = "Margins"
        Me.Tab_Margins.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "One point = 1/72 inch or 0.35mm"
        '
        'num_marginbottom
        '
        Me.num_marginbottom.Location = New System.Drawing.Point(51, 82)
        Me.num_marginbottom.Name = "num_marginbottom"
        Me.num_marginbottom.Size = New System.Drawing.Size(47, 20)
        Me.num_marginbottom.TabIndex = 7
        '
        'num_margintop
        '
        Me.num_margintop.Location = New System.Drawing.Point(51, 56)
        Me.num_margintop.Name = "num_margintop"
        Me.num_margintop.Size = New System.Drawing.Size(47, 20)
        Me.num_margintop.TabIndex = 6
        '
        'num_marginright
        '
        Me.num_marginright.Location = New System.Drawing.Point(51, 29)
        Me.num_marginright.Name = "num_marginright"
        Me.num_marginright.Size = New System.Drawing.Size(47, 20)
        Me.num_marginright.TabIndex = 5
        '
        'num_marginleft
        '
        Me.num_marginleft.Location = New System.Drawing.Point(51, 3)
        Me.num_marginleft.Name = "num_marginleft"
        Me.num_marginleft.Size = New System.Drawing.Size(47, 20)
        Me.num_marginleft.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Bottom:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Top:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Right:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Left:"
        '
        'Tab_Media
        '
        Me.Tab_Media.Controls.Add(Me.combo_media)
        Me.Tab_Media.Controls.Add(Me.btn_addmedia)
        Me.Tab_Media.Controls.Add(Me.btn_removemedia)
        Me.Tab_Media.Controls.Add(Me.btn_clearmedia)
        Me.Tab_Media.Controls.Add(Me.lb_media)
        Me.Tab_Media.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Media.Name = "Tab_Media"
        Me.Tab_Media.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Media.TabIndex = 6
        Me.Tab_Media.Text = "Media"
        Me.Tab_Media.UseVisualStyleBackColor = True
        '
        'combo_media
        '
        Me.combo_media.FormattingEnabled = True
        Me.combo_media.Items.AddRange(New Object() {"Letter", "Legal", "A4", "COM10", "DL", "Transparency", "Upper", "Lower", "MultiPurpose", "LargeCapacity"})
        Me.combo_media.Location = New System.Drawing.Point(2, 3)
        Me.combo_media.Name = "combo_media"
        Me.combo_media.Size = New System.Drawing.Size(121, 21)
        Me.combo_media.TabIndex = 4
        '
        'btn_addmedia
        '
        Me.btn_addmedia.Location = New System.Drawing.Point(129, 3)
        Me.btn_addmedia.Name = "btn_addmedia"
        Me.btn_addmedia.Size = New System.Drawing.Size(39, 21)
        Me.btn_addmedia.TabIndex = 3
        Me.btn_addmedia.Text = "Add"
        Me.btn_addmedia.UseVisualStyleBackColor = True
        '
        'btn_removemedia
        '
        Me.btn_removemedia.Location = New System.Drawing.Point(129, 61)
        Me.btn_removemedia.Name = "btn_removemedia"
        Me.btn_removemedia.Size = New System.Drawing.Size(59, 23)
        Me.btn_removemedia.TabIndex = 2
        Me.btn_removemedia.Text = "Remove"
        Me.btn_removemedia.UseVisualStyleBackColor = True
        '
        'btn_clearmedia
        '
        Me.btn_clearmedia.Location = New System.Drawing.Point(129, 90)
        Me.btn_clearmedia.Name = "btn_clearmedia"
        Me.btn_clearmedia.Size = New System.Drawing.Size(49, 22)
        Me.btn_clearmedia.TabIndex = 1
        Me.btn_clearmedia.Text = "Clear"
        Me.btn_clearmedia.UseVisualStyleBackColor = True
        '
        'lb_media
        '
        Me.lb_media.FormattingEnabled = True
        Me.lb_media.Location = New System.Drawing.Point(3, 30)
        Me.lb_media.Name = "lb_media"
        Me.lb_media.ScrollAlwaysVisible = True
        Me.lb_media.Size = New System.Drawing.Size(120, 82)
        Me.lb_media.TabIndex = 0
        '
        'Tab_Documents
        '
        Me.Tab_Documents.Controls.Add(Me.combo_documentslayout)
        Me.Tab_Documents.Controls.Add(Me.Label13)
        Me.Tab_Documents.Controls.Add(Me.combo_documents)
        Me.Tab_Documents.Controls.Add(Me.Label12)
        Me.Tab_Documents.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Documents.Name = "Tab_Documents"
        Me.Tab_Documents.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Documents.TabIndex = 4
        Me.Tab_Documents.Text = "Documents"
        Me.Tab_Documents.UseVisualStyleBackColor = True
        '
        'combo_documentslayout
        '
        Me.combo_documentslayout.FormattingEnabled = True
        Me.combo_documentslayout.Items.AddRange(New Object() {"BottomToTop_LeftToRight", "BottomToTop_RightToLeft", "LeftToRight_BottomToTop", "LeftToRight_TopToBottom", "RightToLeft_BottomToTop", "RightToLeft_TopToBottom", "TopToBottom_LeftToRight", "TopToBottom_RightToLeft"})
        Me.combo_documentslayout.Location = New System.Drawing.Point(56, 32)
        Me.combo_documentslayout.Name = "combo_documentslayout"
        Me.combo_documentslayout.Size = New System.Drawing.Size(148, 21)
        Me.combo_documentslayout.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Layout:"
        '
        'combo_documents
        '
        Me.combo_documents.FormattingEnabled = True
        Me.combo_documents.Items.AddRange(New Object() {"1", "2", "4", "6", "9", "16"})
        Me.combo_documents.Location = New System.Drawing.Point(118, 5)
        Me.combo_documents.Name = "combo_documents"
        Me.combo_documents.Size = New System.Drawing.Size(86, 21)
        Me.combo_documents.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Documents per page:"
        '
        'Tab_Options
        '
        Me.Tab_Options.Controls.Add(Me.num_priority)
        Me.Tab_Options.Controls.Add(Me.check_nowrap)
        Me.Tab_Options.Controls.Add(Me.check_prettyprint)
        Me.Tab_Options.Controls.Add(Me.Label14)
        Me.Tab_Options.Controls.Add(Me.check_fittopage)
        Me.Tab_Options.Controls.Add(Me.combo_orientation)
        Me.Tab_Options.Controls.Add(Me.Label11)
        Me.Tab_Options.Controls.Add(Me.Panel1)
        Me.Tab_Options.Controls.Add(Me.Label10)
        Me.Tab_Options.Controls.Add(Me.check_mirror)
        Me.Tab_Options.Controls.Add(Me.num_charactersinch)
        Me.Tab_Options.Controls.Add(Me.num_linesinch)
        Me.Tab_Options.Controls.Add(Me.Label9)
        Me.Tab_Options.Controls.Add(Me.Label8)
        Me.Tab_Options.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Options.Name = "Tab_Options"
        Me.Tab_Options.Size = New System.Drawing.Size(366, 125)
        Me.Tab_Options.TabIndex = 1
        Me.Tab_Options.Text = "Options"
        Me.Tab_Options.UseVisualStyleBackColor = True
        '
        'num_priority
        '
        Me.num_priority.Location = New System.Drawing.Point(224, 79)
        Me.num_priority.Name = "num_priority"
        Me.num_priority.Size = New System.Drawing.Size(51, 20)
        Me.num_priority.TabIndex = 13
        '
        'check_nowrap
        '
        Me.check_nowrap.AutoSize = True
        Me.check_nowrap.Location = New System.Drawing.Point(174, 59)
        Me.check_nowrap.Name = "check_nowrap"
        Me.check_nowrap.Size = New System.Drawing.Size(69, 17)
        Me.check_nowrap.TabIndex = 12
        Me.check_nowrap.Text = "No Wrap"
        Me.check_nowrap.UseVisualStyleBackColor = True
        '
        'check_prettyprint
        '
        Me.check_prettyprint.AutoSize = True
        Me.check_prettyprint.Location = New System.Drawing.Point(166, 36)
        Me.check_prettyprint.Name = "check_prettyprint"
        Me.check_prettyprint.Size = New System.Drawing.Size(77, 17)
        Me.check_prettyprint.TabIndex = 11
        Me.check_prettyprint.Text = "Pretty Print"
        Me.check_prettyprint.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(177, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Priority:"
        '
        'check_fittopage
        '
        Me.check_fittopage.AutoSize = True
        Me.check_fittopage.Location = New System.Drawing.Point(6, 100)
        Me.check_fittopage.Name = "check_fittopage"
        Me.check_fittopage.Size = New System.Drawing.Size(77, 17)
        Me.check_fittopage.TabIndex = 9
        Me.check_fittopage.Text = "Fit to Page"
        Me.check_fittopage.UseVisualStyleBackColor = True
        '
        'combo_orientation
        '
        Me.combo_orientation.FormattingEnabled = True
        Me.combo_orientation.Items.AddRange(New Object() {" Portrait", " Landscape", " ReverseLandscape", " ReversePortrait"})
        Me.combo_orientation.Location = New System.Drawing.Point(230, 9)
        Me.combo_orientation.Name = "combo_orientation"
        Me.combo_orientation.Size = New System.Drawing.Size(99, 21)
        Me.combo_orientation.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(163, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Orientation:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radio_reverseorder)
        Me.Panel1.Controls.Add(Me.radio_normalorder)
        Me.Panel1.Location = New System.Drawing.Point(48, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 17)
        Me.Panel1.TabIndex = 6
        '
        'radio_reverseorder
        '
        Me.radio_reverseorder.AutoSize = True
        Me.radio_reverseorder.Dock = System.Windows.Forms.DockStyle.Left
        Me.radio_reverseorder.Location = New System.Drawing.Point(58, 0)
        Me.radio_reverseorder.Name = "radio_reverseorder"
        Me.radio_reverseorder.Size = New System.Drawing.Size(65, 17)
        Me.radio_reverseorder.TabIndex = 1
        Me.radio_reverseorder.TabStop = True
        Me.radio_reverseorder.Text = "Reverse"
        Me.radio_reverseorder.UseVisualStyleBackColor = True
        '
        'radio_normalorder
        '
        Me.radio_normalorder.AutoSize = True
        Me.radio_normalorder.Dock = System.Windows.Forms.DockStyle.Left
        Me.radio_normalorder.Location = New System.Drawing.Point(0, 0)
        Me.radio_normalorder.Name = "radio_normalorder"
        Me.radio_normalorder.Size = New System.Drawing.Size(58, 17)
        Me.radio_normalorder.TabIndex = 0
        Me.radio_normalorder.TabStop = True
        Me.radio_normalorder.Text = "Normal"
        Me.radio_normalorder.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Order:"
        '
        'check_mirror
        '
        Me.check_mirror.AutoSize = True
        Me.check_mirror.Location = New System.Drawing.Point(6, 54)
        Me.check_mirror.Name = "check_mirror"
        Me.check_mirror.Size = New System.Drawing.Size(52, 17)
        Me.check_mirror.TabIndex = 4
        Me.check_mirror.Text = "Mirror"
        Me.check_mirror.UseVisualStyleBackColor = True
        '
        'num_charactersinch
        '
        Me.num_charactersinch.Location = New System.Drawing.Point(96, 29)
        Me.num_charactersinch.Name = "num_charactersinch"
        Me.num_charactersinch.Size = New System.Drawing.Size(46, 20)
        Me.num_charactersinch.TabIndex = 3
        '
        'num_linesinch
        '
        Me.num_linesinch.Location = New System.Drawing.Point(70, 3)
        Me.num_linesinch.Name = "num_linesinch"
        Me.num_linesinch.Size = New System.Drawing.Size(46, 20)
        Me.num_linesinch.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Characters/Inch:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Lines/Inch:"
        '
        'pnl_info
        '
        Me.pnl_info.Controls.Add(Me.lbl_status)
        Me.pnl_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_info.Location = New System.Drawing.Point(0, 97)
        Me.pnl_info.Name = "pnl_info"
        Me.pnl_info.Size = New System.Drawing.Size(374, 20)
        Me.pnl_info.TabIndex = 4
        '
        'PrintDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 291)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnl_info)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnl_bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.TopMost = True
        Me.pnl_bottom.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Copies.ResumeLayout(False)
        Me.Tab_Copies.PerformLayout()
        CType(Me.num_copies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_PageRange.ResumeLayout(False)
        Me.Tab_PageRange.PerformLayout()
        Me.Tab_Sides.ResumeLayout(False)
        Me.Tab_Sides.PerformLayout()
        Me.Tab_Margins.ResumeLayout(False)
        Me.Tab_Margins.PerformLayout()
        CType(Me.num_marginbottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_margintop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_marginright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_marginleft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Media.ResumeLayout(False)
        Me.Tab_Documents.ResumeLayout(False)
        Me.Tab_Documents.PerformLayout()
        Me.Tab_Options.ResumeLayout(False)
        Me.Tab_Options.PerformLayout()
        CType(Me.num_priority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_charactersinch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_linesinch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_info.ResumeLayout(False)
        Me.pnl_info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_printers As System.Windows.Forms.ListBox
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_PageRange As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Options As System.Windows.Forms.TabPage
    Friend WithEvents pnl_info As System.Windows.Forms.Panel
    Friend WithEvents Tab_Copies As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Margins As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Documents As System.Windows.Forms.TabPage
    Friend WithEvents check_collated As System.Windows.Forms.CheckBox
    Friend WithEvents num_copies As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_custompagerange As System.Windows.Forms.TextBox
    Friend WithEvents radio_custom As System.Windows.Forms.RadioButton
    Friend WithEvents radio_all As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents num_marginbottom As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_margintop As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_marginright As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_marginleft As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radio_evens As System.Windows.Forms.RadioButton
    Friend WithEvents radio_odds As System.Windows.Forms.RadioButton
    Friend WithEvents Tab_Sides As System.Windows.Forms.TabPage
    Friend WithEvents radio_twosidedlongedge As System.Windows.Forms.RadioButton
    Friend WithEvents radio_twosidedshortedge As System.Windows.Forms.RadioButton
    Friend WithEvents radio_onesided As System.Windows.Forms.RadioButton
    Friend WithEvents Tab_Media As System.Windows.Forms.TabPage
    Friend WithEvents combo_media As System.Windows.Forms.ComboBox
    Friend WithEvents btn_addmedia As System.Windows.Forms.Button
    Friend WithEvents btn_removemedia As System.Windows.Forms.Button
    Friend WithEvents btn_clearmedia As System.Windows.Forms.Button
    Friend WithEvents lb_media As System.Windows.Forms.ListBox
    Friend WithEvents num_charactersinch As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_linesinch As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents check_mirror As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents radio_reverseorder As System.Windows.Forms.RadioButton
    Friend WithEvents radio_normalorder As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents combo_orientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents check_fittopage As System.Windows.Forms.CheckBox
    Friend WithEvents combo_documents As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents combo_documentslayout As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents num_priority As System.Windows.Forms.NumericUpDown
    Friend WithEvents check_nowrap As System.Windows.Forms.CheckBox
    Friend WithEvents check_prettyprint As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class

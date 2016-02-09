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
        Me.Step_Language = New WizardBase.IntermediateStep()
        Me.FinishStep1 = New WizardBase.FinishStep()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_language_combo_language = New System.Windows.Forms.ComboBox()
        Me.Step_Time = New WizardBase.IntermediateStep()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_timezone = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_time = New System.Windows.Forms.MaskedTextBox()
        Me.Step_Network = New WizardBase.IntermediateStep()
        Me.Step_User = New WizardBase.IntermediateStep()
        Me.Step_ComputerInfo = New WizardBase.IntermediateStep()
        Me.Step_Language.SuspendLayout()
        Me.Step_Time.SuspendLayout()
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
        Me.WizardControl1.WizardSteps.AddRange(New WizardBase.WizardStep() {Me.StartStep1, Me.Step_Language, Me.Step_Time, Me.Step_ComputerInfo, Me.Step_User, Me.Step_Network, Me.FinishStep1})
        '
        'StartStep1
        '
        Me.StartStep1.BindingImage = Nothing
        Me.StartStep1.Icon = Nothing
        Me.StartStep1.Name = "StartStep1"
        Me.StartStep1.Subtitle = "This setup will help you create a user account and get started."
        Me.StartStep1.Title = "Welcome to AireOS"
        '
        'Step_Language
        '
        Me.Step_Language.BindingImage = CType(resources.GetObject("Step_Language.BindingImage"), System.Drawing.Image)
        Me.Step_Language.Controls.Add(Me.tab_language_combo_language)
        Me.Step_Language.Controls.Add(Me.Label1)
        Me.Step_Language.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Step_Language.Name = "Step_Language"
        Me.Step_Language.Subtitle = ""
        Me.Step_Language.Title = "Language"
        '
        'FinishStep1
        '
        Me.FinishStep1.BindingImage = CType(resources.GetObject("FinishStep1.BindingImage"), System.Drawing.Image)
        Me.FinishStep1.Name = "FinishStep1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Language:"
        '
        'tab_language_combo_language
        '
        Me.tab_language_combo_language.Enabled = False
        Me.tab_language_combo_language.FormattingEnabled = True
        Me.tab_language_combo_language.Items.AddRange(New Object() {"English"})
        Me.tab_language_combo_language.Location = New System.Drawing.Point(67, 80)
        Me.tab_language_combo_language.Name = "tab_language_combo_language"
        Me.tab_language_combo_language.Size = New System.Drawing.Size(82, 21)
        Me.tab_language_combo_language.TabIndex = 1
        Me.tab_language_combo_language.Text = "English"
        '
        'Step_Time
        '
        Me.Step_Time.BindingImage = CType(resources.GetObject("Step_Time.BindingImage"), System.Drawing.Image)
        Me.Step_Time.Controls.Add(Me.txt_time)
        Me.Step_Time.Controls.Add(Me.Label4)
        Me.Step_Time.Controls.Add(Me.DateTimePicker1)
        Me.Step_Time.Controls.Add(Me.Label3)
        Me.Step_Time.Controls.Add(Me.combo_timezone)
        Me.Step_Time.Controls.Add(Me.Label2)
        Me.Step_Time.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Step_Time.Name = "Step_Time"
        Me.Step_Time.Subtitle = ""
        Me.Step_Time.Title = "Time and Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Timezone:"
        '
        'combo_timezone
        '
        Me.combo_timezone.FormattingEnabled = True
        Me.combo_timezone.Items.AddRange(New Object() {"Africa/Abidjan", "Africa/Accra", "Africa/Addis_Ababa", "Africa/Algiers", "Africa/Asmara", "Africa/Bamako", "Africa/Bangui", "Africa/Banjul", "Africa/Bissau", "Africa/Blantyre", "Africa/Brazzaville", "Africa/Bujumbura", "Africa/Cairo", "Africa/Casablanca", "Africa/Ceuta", "Africa/Conakry", "Africa/Dakar", "Africa/Dar_es_Salaam", "Africa/Djibouti", "Africa/Douala", "Africa/El_Aaiun", "Africa/Freetown", "Africa/Gaborone", "Africa/Harare", "Africa/Johannesburg", "Africa/Juba", "Africa/Kampala", "Africa/Khartoum", "Africa/Kigali", "Africa/Kinshasa", "Africa/Lagos", "Africa/Libreville", "Africa/Lome", "Africa/Luanda", "Africa/Lubumbashi", "Africa/Lusaka", "Africa/Malabo", "Africa/Maputo", "Africa/Maseru", "Africa/Mbabane", "Africa/Mogadishu", "Africa/Monrovia", "Africa/Nairobi", "Africa/Ndjamena", "Africa/Niamey", "Africa/Nouakchott", "Africa/Ouagadougou", "Africa/Porto-Novo", "Africa/Sao_Tome", "Africa/Tripoli", "Africa/Tunis", "Africa/Windhoek", "America/Adak", "America/Anchorage", "America/Anguilla", "America/Antigua", "America/Araguaina", "America/Argentina/Buenos_Aires", "America/Argentina/Catamarca", "America/Argentina/Cordoba", "America/Argentina/Jujuy", "America/Argentina/La_Rioja", "America/Argentina/Mendoza", "America/Argentina/Rio_Gallegos", "America/Argentina/Salta", "America/Argentina/San_Juan", "America/Argentina/San_Luis", "America/Argentina/Tucuman", "America/Argentina/Ushuaia", "America/Aruba", "America/Asuncion", "America/Atikokan", "America/Bahia", "America/Bahia_Banderas", "America/Barbados", "America/Belem", "America/Belize", "America/Blanc-Sablon", "America/Boa_Vista", "America/Bogota", "America/Boise", "America/Cambridge_Bay", "America/Campo_Grande", "America/Cancun", "America/Caracas", "America/Cayenne", "America/Cayman", "America/Chicago", "America/Chihuahua", "America/Costa_Rica", "America/Creston", "America/Cuiaba", "America/Curacao", "America/Danmarkshavn", "America/Dawson", "America/Dawson_Creek", "America/Denver", "America/Detroit", "America/Dominica", "America/Edmonton", "America/Eirunepe", "America/El_Salvador", "America/Fort_Nelson", "America/Fortaleza", "America/Glace_Bay", "America/Godthab", "America/Goose_Bay", "America/Grand_Turk", "America/Grenada", "America/Guadeloupe", "America/Guatemala", "America/Guayaquil", "America/Guyana", "America/Halifax", "America/Havana", "America/Hermosillo", "America/Indiana/Indianapolis", "America/Indiana/Knox", "America/Indiana/Marengo", "America/Indiana/Petersburg", "America/Indiana/Tell_City", "America/Indiana/Vevay", "America/Indiana/Vincennes", "America/Indiana/Winamac", "America/Inuvik", "America/Iqaluit", "America/Jamaica", "America/Juneau", "America/Kentucky/Louisville", "America/Kentucky/Monticello", "America/Kralendijk", "America/La_Paz", "America/Lima", "America/Los_Angeles", "America/Lower_Princes", "America/Maceio", "America/Managua", "America/Manaus", "America/Marigot", "America/Martinique", "America/Matamoros", "America/Mazatlan", "America/Menominee", "America/Merida", "America/Metlakatla", "America/Mexico_City", "America/Miquelon", "America/Moncton", "America/Monterrey", "America/Montevideo", "America/Montserrat", "America/Nassau", "America/New_York", "America/Nipigon", "America/Nome", "America/Noronha", "America/North_Dakota/Beulah", "America/North_Dakota/Center", "America/North_Dakota/New_Salem", "America/Ojinaga", "America/Panama", "America/Pangnirtung", "America/Paramaribo", "America/Phoenix", "America/Port-au-Prince", "America/Port_of_Spain", "America/Porto_Velho", "America/Puerto_Rico", "America/Rainy_River", "America/Rankin_Inlet", "America/Recife", "America/Regina", "America/Resolute", "America/Rio_Branco", "America/Santa_Isabel", "America/Santarem", "America/Santiago", "America/Santo_Domingo", "America/Sao_Paulo", "America/Scoresbysund", "America/Sitka", "America/St_Barthelemy", "America/St_Johns", "America/St_Kitts", "America/St_Lucia", "America/St_Thomas", "America/St_Vincent", "America/Swift_Current", "America/Tegucigalpa", "America/Thule", "America/Thunder_Bay", "America/Tijuana", "America/Toronto", "America/Tortola", "America/Vancouver", "America/Whitehorse", "America/Winnipeg", "America/Yakutat", "America/Yellowknife", "Antarctica/Casey", "Antarctica/Davis", "Antarctica/DumontDUrville", "Antarctica/Macquarie", "Antarctica/Mawson", "Antarctica/McMurdo", "Antarctica/Palmer", "Antarctica/Rothera", "Antarctica/Syowa", "Antarctica/Troll", "Antarctica/Vostok", "Arctic/Longyearbyen", "Asia/Aden", "Asia/Almaty", "Asia/Amman", "Asia/Anadyr", "Asia/Aqtau", "Asia/Aqtobe", "Asia/Ashgabat", "Asia/Baghdad", "Asia/Bahrain", "Asia/Baku", "Asia/Bangkok", "Asia/Beirut", "Asia/Bishkek", "Asia/Brunei", "Asia/Chita", "Asia/Choibalsan", "Asia/Colombo", "Asia/Damascus", "Asia/Dhaka", "Asia/Dili", "Asia/Dubai", "Asia/Dushanbe", "Asia/Gaza", "Asia/Hebron", "Asia/Ho_Chi_Minh", "Asia/Hong_Kong", "Asia/Hovd", "Asia/Irkutsk", "Asia/Jakarta", "Asia/Jayapura", "Asia/Jerusalem", "Asia/Kabul", "Asia/Kamchatka", "Asia/Karachi", "Asia/Kathmandu", "Asia/Khandyga", "Asia/Kolkata", "Asia/Krasnoyarsk", "Asia/Kuala_Lumpur", "Asia/Kuching", "Asia/Kuwait", "Asia/Macau", "Asia/Magadan", "Asia/Makassar", "Asia/Manila", "Asia/Muscat", "Asia/Nicosia", "Asia/Novokuznetsk", "Asia/Novosibirsk", "Asia/Omsk", "Asia/Oral", "Asia/Phnom_Penh", "Asia/Pontianak", "Asia/Pyongyang", "Asia/Qatar", "Asia/Qyzylorda", "Asia/Rangoon", "Asia/Riyadh", "Asia/Sakhalin", "Asia/Samarkand", "Asia/Seoul", "Asia/Shanghai", "Asia/Singapore", "Asia/Srednekolymsk", "Asia/Taipei", "Asia/Tashkent", "Asia/Tbilisi", "Asia/Tehran", "Asia/Thimphu", "Asia/Tokyo", "Asia/Ulaanbaatar", "Asia/Urumqi", "Asia/Ust-Nera", "Asia/Vientiane", "Asia/Vladivostok", "Asia/Yakutsk", "Asia/Yekaterinburg", "Asia/Yerevan", "Atlantic/Azores", "Atlantic/Bermuda", "Atlantic/Canary", "Atlantic/Cape_Verde", "Atlantic/Faroe", "Atlantic/Madeira", "Atlantic/Reykjavik", "Atlantic/South_Georgia", "Atlantic/St_Helena", "Atlantic/Stanley", "Australia/Adelaide", "Australia/Brisbane", "Australia/Broken_Hill", "Australia/Currie", "Australia/Darwin", "Australia/Eucla", "Australia/Hobart", "Australia/Lindeman", "Australia/Lord_Howe", "Australia/Melbourne", "Australia/Perth", "Australia/Sydney", "Europe/Amsterdam", "Europe/Andorra", "Europe/Athens", "Europe/Belgrade", "Europe/Berlin", "Europe/Bratislava", "Europe/Brussels", "Europe/Bucharest", "Europe/Budapest", "Europe/Busingen", "Europe/Chisinau", "Europe/Copenhagen", "Europe/Dublin", "Europe/Gibraltar", "Europe/Guernsey", "Europe/Helsinki", "Europe/Isle_of_Man", "Europe/Istanbul", "Europe/Jersey", "Europe/Kaliningrad", "Europe/Kiev", "Europe/Lisbon", "Europe/Ljubljana", "Europe/London", "Europe/Luxembourg", "Europe/Madrid", "Europe/Malta", "Europe/Mariehamn", "Europe/Minsk", "Europe/Monaco", "Europe/Moscow", "Europe/Oslo", "Europe/Paris", "Europe/Podgorica", "Europe/Prague", "Europe/Riga", "Europe/Rome", "Europe/Samara", "Europe/San_Marino", "Europe/Sarajevo", "Europe/Simferopol", "Europe/Skopje", "Europe/Sofia", "Europe/Stockholm", "Europe/Tallinn", "Europe/Tirane", "Europe/Uzhgorod", "Europe/Vaduz", "Europe/Vatican", "Europe/Vienna", "Europe/Vilnius", "Europe/Volgograd", "Europe/Warsaw", "Europe/Zagreb", "Europe/Zaporozhye", "Europe/Zurich", "Indian/Antananarivo", "Indian/Chagos", "Indian/Christmas", "Indian/Cocos", "Indian/Comoro", "Indian/Kerguelen", "Indian/Mahe", "Indian/Maldives", "Indian/Mauritius", "Indian/Mayotte", "Indian/Reunion", "Pacific/Apia", "Pacific/Auckland", "Pacific/Bougainville", "Pacific/Chatham", "Pacific/Chuuk", "Pacific/Easter", "Pacific/Efate", "Pacific/Enderbury", "Pacific/Fakaofo", "Pacific/Fiji", "Pacific/Funafuti", "Pacific/Galapagos", "Pacific/Gambier", "Pacific/Guadalcanal", "Pacific/Guam", "Pacific/Honolulu", "Pacific/Johnston", "Pacific/Kiritimati", "Pacific/Kosrae", "Pacific/Kwajalein", "Pacific/Majuro", "Pacific/Marquesas", "Pacific/Midway", "Pacific/Nauru", "Pacific/Niue", "Pacific/Norfolk", "Pacific/Noumea", "Pacific/Pago_Pago", "Pacific/Palau", "Pacific/Pitcairn", "Pacific/Pohnpei", "Pacific/Port_Moresby", "Pacific/Rarotonga", "Pacific/Saipan", "Pacific/Tahiti", "Pacific/Tarawa", "Pacific/Tongatapu", "Pacific/Wake", "Pacific/Wallis"})
        Me.combo_timezone.Location = New System.Drawing.Point(65, 117)
        Me.combo_timezone.Name = "combo_timezone"
        Me.combo_timezone.Size = New System.Drawing.Size(150, 21)
        Me.combo_timezone.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(42, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Time:"
        '
        'txt_time
        '
        Me.txt_time.Location = New System.Drawing.Point(42, 94)
        Me.txt_time.Mask = "00:00"
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(37, 20)
        Me.txt_time.TabIndex = 5
        Me.txt_time.ValidatingType = GetType(Date)
        '
        'Step_Network
        '
        Me.Step_Network.BindingImage = CType(resources.GetObject("Step_Network.BindingImage"), System.Drawing.Image)
        Me.Step_Network.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Step_Network.Name = "Step_Network"
        '
        'Step_User
        '
        Me.Step_User.BindingImage = CType(resources.GetObject("Step_User.BindingImage"), System.Drawing.Image)
        Me.Step_User.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Step_User.Name = "Step_User"
        '
        'Step_ComputerInfo
        '
        Me.Step_ComputerInfo.BindingImage = CType(resources.GetObject("Step_ComputerInfo.BindingImage"), System.Drawing.Image)
        Me.Step_ComputerInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Step_ComputerInfo.Name = "Step_ComputerInfo"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 435)
        Me.Controls.Add(Me.WizardControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aire OS Setup"
        Me.TopMost = True
        Me.Step_Language.ResumeLayout(False)
        Me.Step_Language.PerformLayout()
        Me.Step_Time.ResumeLayout(False)
        Me.Step_Time.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As WizardBase.WizardControl
    Friend WithEvents StartStep1 As WizardBase.StartStep
    Friend WithEvents Step_Language As WizardBase.IntermediateStep
    Friend WithEvents FinishStep1 As WizardBase.FinishStep
    Friend WithEvents tab_language_combo_language As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Step_Time As WizardBase.IntermediateStep
    Friend WithEvents combo_timezone As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Step_ComputerInfo As WizardBase.IntermediateStep
    Friend WithEvents Step_User As WizardBase.IntermediateStep
    Friend WithEvents Step_Network As WizardBase.IntermediateStep

End Class

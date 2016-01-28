Public Class bar_launchbar

#Region "Variables/Properties/Enums"

    Public Enum BatteryStatus
        Battery100
        Battery75
        Battery50
        Battery25
        BatteryDanger
        Battery100Charge
        Battery75Charge
        Battery50Charge
        Battery25Charge
        BatteryDangerCharge
    End Enum

    Public Enum NetworkStatus
        Wired
        Wireless
        Disconnected
    End Enum

    Public Enum VolumeStatus
        VolumeHigh
        VolumeMedium
        VolumeLow
        VolumeMute
    End Enum

    Private desktop As frmDesktop
    Private launcher As frmLauncher

#End Region

#Region "UI"

    Private Sub btnLauncher_Click(sender As Object, e As EventArgs) Handles btnLauncher.Click
        If frmLauncher.Showing Then
            launcher.Focus()
        Else
            launcher = New frmLauncher(Me, desktop)
            launcher.Show()
            launcher.Location = PointToScreen(btnNetwork.Location)
        End If
    End Sub

#End Region

#Region "Methods"

#Region "Public"

    Public Sub SetBackColor(ByVal ncolor As Color)
        btnLauncher.BackColor = ncolor
        pnl_applications.BackColor = ncolor
        pnl_tray.BackColor = ncolor
        Me.BackColor = ncolor
    End Sub

    Public Function GetBackColor() As Color
        Return Me.BackColor
    End Function

    Public Sub SetBatteryIcon(ByVal icon As BatteryStatus)
        Select Case icon
            Case BatteryStatus.Battery100
                btnBattery.BackgroundImage = My.Resources.battery_100
            Case BatteryStatus.Battery75
                btnBattery.BackgroundImage = My.Resources.battery_75
            Case BatteryStatus.Battery50
                btnBattery.BackgroundImage = My.Resources.battery_50
            Case BatteryStatus.Battery25
                btnBattery.BackgroundImage = My.Resources.battery_25
            Case BatteryStatus.BatteryDanger
                btnBattery.BackgroundImage = My.Resources.battery_danger
            Case BatteryStatus.Battery100Charge
                btnBattery.BackgroundImage = My.Resources.battery_100_charging
            Case BatteryStatus.Battery75Charge
                btnBattery.BackgroundImage = My.Resources.battery_75_charging
            Case BatteryStatus.Battery50Charge
                btnBattery.BackgroundImage = My.Resources.battery_50_charging
            Case BatteryStatus.Battery25Charge
                btnBattery.BackgroundImage = My.Resources.battery_25_charging
            Case BatteryStatus.BatteryDangerCharge
                btnBattery.BackgroundImage = My.Resources.battery_danger_charging
        End Select
    End Sub

    Public Sub SetNetworkIcon(ByVal icon As NetworkStatus)
        Select Case icon
            Case NetworkStatus.Wired
                btnNetwork.BackgroundImage = My.Resources.network_wired
            Case NetworkStatus.Wireless
                btnNetwork.BackgroundImage = My.Resources.network_wireless
            Case NetworkStatus.Disconnected
                btnNetwork.BackgroundImage = My.Resources.networking_disconnected
        End Select
    End Sub

    Public Sub SetVolumeIcon(ByVal icon As VolumeStatus)
        Select Case icon
            Case VolumeStatus.VolumeHigh
                btnVolume.BackgroundImage = My.Resources.volume_high
            Case VolumeStatus.VolumeMedium
                btnVolume.BackgroundImage = My.Resources.volume_medium
            Case VolumeStatus.VolumeLow
                btnVolume.BackgroundImage = My.Resources.volume_low
            Case VolumeStatus.VolumeMute
                btnVolume.BackgroundImage = My.Resources.volume_mute
        End Select
    End Sub

#End Region

#End Region

#Region "bar_launchbar"

    Public Sub New(ByVal frm As frmDesktop)
        desktop = frm
    End Sub

#End Region

End Class
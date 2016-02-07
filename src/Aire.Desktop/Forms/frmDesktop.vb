Public Class frmDesktop

#Region "Properties/Variables/Enums"

    Public Property Windows As New List(Of DesktopWindows)
    Public Property User As String
    Public Property Session As DesktopSession

#Region "LaunchBar"

    Private launcher As frmLauncher
    Private batcount As Integer = 30

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

#End Region

#End Region

#Region "LaunchBar"

#Region "UI"

    Private Sub btnLauncher_Click(sender As Object, e As EventArgs) Handles btnLauncher.Click
        If frmLauncher.Showing Then
            launcher.Focus()
        Else
            launcher = New frmLauncher(Me)
            launcher.Show()
            launcher.Location = PointToScreen(btnLauncher.Location)
        End If
    End Sub

#Region "Tray"

    Private Sub btnVolume_Click(sender As Object, e As EventArgs) Handles btnVolume.Click
        Aire.API.Audio.Volume.DisplayVolumeControl()
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click

    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click

    End Sub

    Private Sub btnNetwork_Click(sender As Object, e As EventArgs) Handles btnNetwork.Click

    End Sub

    Private Sub btnBattery_Click(sender As Object, e As EventArgs) Handles btnBattery.Click

    End Sub

#End Region

#End Region

#Region "Methods"

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

#Region "AppBars"

#Region "Top"



#End Region

#Region "Bottom"



#End Region

#End Region

#Region "Methods"

    Public Sub SetDesktopBackground(ByVal img As String, Optional ByVal layout As ImageLayout = ImageLayout.Stretch)
        pnl_desktop.BackgroundImage = Image.FromFile(img)
        pnl_desktop.BackgroundImageLayout = layout
    End Sub

    Public Sub SetAppBarColor(ByVal clr As Color)
        pnl_appbar_top.BackColor = clr
        pnl_appbar_bottom.BackColor = clr
    End Sub

    Public Sub SetLaunchBarColor(ByVal ncolor As Color)
        btnLauncher.BackColor = ncolor
        pnl_applications.BackColor = ncolor
        pnl_launchbar_tray.BackColor = ncolor
        pnl_launchbar.BackColor = ncolor
    End Sub

    Public Sub StopUpdating()
        UpdateTimer.Stop()
    End Sub

    Public Sub StartUpdating()
        UpdateTimer.Start()
    End Sub

#End Region

#Region "UI"



#End Region

#Region "frmDesktop"

    Public Sub New(ByVal ouser As String, Optional ByVal ses As DesktopSession = Nothing)
        InitializeComponent()
        User = ouser
        Session = ses
    End Sub

#End Region

End Class
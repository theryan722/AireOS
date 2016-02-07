Public Class frmDesktop

#Region "Properties/Variables/Enums"

    Public Property Windows As New List(Of DesktopWindows)
    Public Property User As String
    Public Property Session As DesktopSession

#Region "LaunchBar"

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
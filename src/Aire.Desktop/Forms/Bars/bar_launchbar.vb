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

    Private desktop As frmDesktop

#End Region

#Region "UI"



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

#End Region

#End Region

#Region "bar_appbar"

    Public Sub New(ByVal frm As frmDesktop)
        desktop = frm
    End Sub

#End Region

End Class
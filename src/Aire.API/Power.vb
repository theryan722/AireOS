Namespace Sys

    Namespace Power

        Public Class Actions

            Public Shared Sub ShowPowerDialog()
                Dim newb As New dlgPower
                newb.ShowDialog()
            End Sub

            Public Shared Sub Shutdown()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Shutdown)
            End Sub

            Public Shared Sub Restart()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Restart)
            End Sub

            Public Shared Sub Hibernate()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Hibernate)
            End Sub

            Public Shared Sub Sleep()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Sleep)
            End Sub

        End Class

        Public Class Info

            Public Shared Function GetIfUsingBattery() As Boolean
                Dim bb As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0")
                Return If(bb.StartsWith("failed"), False, True)
            End Function

            Public Shared Function GetBatteryPercentage() As Integer
                Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""percentage""")
                Return CDbl(res.Split(":")(1).Replace(" ", "").Replace("%", ""))
            End Function

            Public Shared Function GetIfBatteryCharging() As Boolean
                Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""state""")
                Return (res.Split(":")(1).Replace(" ", "")) = "charging"
            End Function

            Public Shared Function GetTimeToBatteryFull() As String

            End Function

            Public Shared Function GetTimeToBatteryEmpty() As String

            End Function

        End Class

    End Namespace

End Namespace

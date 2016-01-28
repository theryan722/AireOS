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

            Dim batpercent As Double = 0

            Public Shared Function GetIfUsingBattery() As Boolean
                Try
                    Dim bb As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0")
                    Return If(bb.StartsWith("failed"), False, True)
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            Public Shared Function GetBatteryPercentage() As Integer
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""percentage""")
                    Return CDbl(res.Split(":")(1).Replace(" ", "").Replace("%", ""))
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            Public Shared Function GetIfBatteryCharging() As Boolean
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""state""")
                    Return (res.Split(":")(1).Replace(" ", "")) = "charging"
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            Public Shared Function GetTimeToBatteryFull() As String
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""to\ full""")
                    Return res.Split(":")(1).Replace(" ", "").Replace("minutes", "")
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return "ERROR"
                End Try
            End Function

            Public Shared Function GetTimeToBatteryEmpty() As String
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""to\ full""")
                    Return res.Split(":")(1).Replace(" ", "").Replace("minutes", "")
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return "ERROR"
                End Try
            End Function

        End Class

    End Namespace

End Namespace

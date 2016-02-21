Namespace Sys

    Namespace Power

        Public Class Actions

            ''' <summary>
            ''' Displays the system power dialog
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub ShowPowerDialog()
                Dim newb As New dlgPower
                newb.ShowDialog()
            End Sub

            ''' <summary>
            ''' Shuts down the computer
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub Shutdown()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Shutdown)
            End Sub

            ''' <summary>
            ''' Restarts the computer
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub Restart()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Restart)
            End Sub

            ''' <summary>
            ''' Puts the computer into hibernation
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub Hibernate()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Hibernate)
            End Sub

            ''' <summary>
            ''' Puts the computer to sleep
            ''' </summary>
            ''' <remarks></remarks>
            Public Shared Sub Sleep()
                Sys.Events.Raise_SystemPowerStateChanged(Events.PowerState.Sleep)
            End Sub

        End Class

        Public Class Info

            Private Shared batpercent As Double = -1

            ''' <summary>
            ''' Determine whether the computer is using a battery or not
            ''' </summary>
            ''' <returns>True, if the computer is using a battery, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfUsingBattery() As Boolean
                Try
                    Dim bb As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0")
                    Return If(bb.StartsWith("failed"), False, True)
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            ''' <summary>
            ''' Gets the percentage of the battery
            ''' </summary>
            ''' <returns>Integer, the percentage of the battery</returns>
            ''' <remarks></remarks>
            Public Shared Function GetBatteryPercentage() As Integer
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""percentage""")
                    Dim ret As Double = CDbl(res.Split(":")(1).Replace(" ", "").Replace("%", ""))
                    If batpercent = -1 Then
                        batpercent = ret
                    Else
                        If batpercent <> ret Then
                            batpercent = ret
                            Events.Raise_BatteryPercentChanged(ret)
                        End If
                    End If
                    Return ret
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            ''' <summary>
            ''' Gets whether the battery is charging or not
            ''' </summary>
            ''' <returns>True, if the battery is charging, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfBatteryCharging() As Boolean
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""state""")
                    Return (res.Split(":")(1).Replace(" ", "")) = "charging"
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return Nothing
                End Try
            End Function

            ''' <summary>
            ''' Gets the time to when the battery will be fully charged
            ''' </summary>
            ''' <returns>String, the time to when the battery will be fully charged</returns>
            ''' <remarks></remarks>
            Public Shared Function GetTimeToBatteryFull() As String
                Try
                    Dim res As String = Sys.Process.ExecuteCommandWithOutput("upower", "-i /org/freedesktop/UPower/devices/battery_BAT0| grep -E ""to\ full""")
                    Return res.Split(":")(1).Replace(" ", "").Replace("minutes", "")
                Catch ex As Exception
                    Sys.Logging.Log.Write("ERROR: ", ex.ToString)
                    Return "ERROR"
                End Try
            End Function

            ''' <summary>
            ''' Gets the time to when the battery will be empty
            ''' </summary>
            ''' <returns>String, the time to when the battery will be empty</returns>
            ''' <remarks></remarks>
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

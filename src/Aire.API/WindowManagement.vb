Namespace Sys

    Namespace Window

        Public Class Info

#Region "Private"

            Private Shared Function WindowIsNotBlackListed(ByVal wstr As String) As Boolean
                Dim ret As Boolean = True
                If wstr.Contains("Aire.Desktop.frmDesktop") Or wstr.Contains("Aire.Login.frmLoginBackground") Or wstr.Contains("Aire.Host.frmMain") Then
                    ret = False
                End If
                If wstr = "" Then
                    ret = False
                ElseIf wstr.Contains("ubuntu ") Then
                    If wstr.Contains("Hud") Or wstr.Contains("XdndCollectionWindowImp") Or wstr.Contains("Desktop") Or wstr.Contains("unity-launcher") Or wstr.Contains("unity-panel") Or wstr.Contains("unity-dash") Then
                        ret = False
                    End If
                End If
                Return ret
            End Function

#End Region

            Public Shared Function GetRunningWindows() As List(Of String)
                Dim ret As New List(Of String)
                Dim tname As String
                Dim arr() As String = Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l").Split(Environment.NewLine)
                For Each item As String In arr
                    If WindowIsNotBlackListed(item) Then
                        tname = GetName(item.Substring(0, 10))
                        If tname <> "" AndAlso tname <> Environment.NewLine Then
                            ret.Add(item.Substring(0, 10))
                        End If
                    End If
                Next
                Return ret
            End Function

            Public Shared Function GetName(ByVal win As String) As String
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowname " & win)
            End Function

            Public Shared Function GetIfClosed(ByVal win As String) As Boolean
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowpid " & win).ToLower.Contains("error")
            End Function

            Public Shared Function GetWindowByName(ByVal fname As String) As String
                Dim ret As String = ""
                For Each item As String In Aire.API.Sys.Window.Info.GetRunningWindows
                    If Aire.API.Sys.Window.Info.GetName(item).Contains(fname) Then
                        ret = item
                        Exit For
                    End If
                Next
                Return ret
            End Function

        End Class

        Public Class Actions

            Public Shared Sub SetAlwaysInBack(ByVal win As String)
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b add,below")
            End Sub

            Public Shared Sub Minimize(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowminimize " & win)
            End Sub

            Public Shared Sub Normal(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b remove,maximized_vert,maximized_horz")
            End Sub

            Public Shared Sub Maximize(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b add,maximized_vert,maximized_horz")
            End Sub

            Public Shared Sub ToggleMaximizeNormal(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b toggle,maximized_vert,maximized_horz")
            End Sub

            Public Shared Sub Kill(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowkill " & win)
            End Sub

            Public Shared Sub Activate(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowactivate " & win)
            End Sub

            Public Shared Sub Hide(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowunmap " & win)
            End Sub

            Public Shared Sub Show(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowmap " & win)
            End Sub

        End Class

    End Namespace

End Namespace
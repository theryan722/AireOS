Namespace Sys

    Namespace Window

        Public Class Info

#Region "Private"

            Private Shared Function WindowIsNotBlackListed(ByVal wname As String) As Boolean
                Dim ret As Boolean = True
                Select Case wname
                    Case "Aire.Desktop.frmDesktop"
                        ret = False
                End Select
                Return ret
            End Function

#End Region

            Public Shared Function GetRunningWindows() As List(Of String)
                Dim ret As New List(Of String)
                Dim tname As String
                Dim arr() As String = Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l").Split(Environment.NewLine)
                For Each item As String In arr
                    tname = GetName(item)
                    If tname <> "" AndAlso tname <> Environment.NewLine AndAlso WindowIsNotBlackListed(tname) Then
                        ret.Add(item.Substring(0, 10))
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

        End Class

    End Namespace

End Namespace
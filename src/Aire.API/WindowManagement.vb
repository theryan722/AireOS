Namespace Sys

    Namespace Window

        Public Class Info
            Private Shared runningwindows As List(Of String)

            Public Shared Function GetAndUpdateRunningWindows() As List(Of String)
                Dim ret As New List(Of String)
                Dim t As String = Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l")
                Dim arr() As String = t.Split(vbNewLine)
                For Each item As String In arr
                    If Not (item.Contains("ubuntu Desktop") Or item.Contains("ubuntu unity-launcher") Or item.Contains("ubuntu unity-panel") Or item.Contains("ubuntu unity-dash") Or item.Contains("ubuntu Hud")) Then
                        ret.Add(item.Substring(0, 10))
                    End If
                Next
                If runningwindows Is Nothing Then
                    runningwindows = ret
                Else
                    UpdateWindowChanges(ret)
                End If
                runningwindows = ret
                Return ret
            End Function

            Public Shared Function GetName(ByVal win As String) As String
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowname " & win)
            End Function

            Public Shared Function GetIfClosed(ByVal win As String) As Boolean
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowpid " & win).ToLower.Contains("error")
            End Function

            Private Shared Sub UpdateWindowChanges(ByVal wlist As List(Of String))
                Dim closed As New List(Of String)
                Dim opened As New List(Of String)
                For Each item As String In runningwindows
                    If Not wlist.Contains(item) Then
                        closed.Add(item)
                    End If
                Next
                For Each item As String In wlist
                    If Not runningwindows.Contains(item) Then
                        opened.Add(item)
                    End If
                Next
                If closed.Count > 0 Then
                    Events.Raise_WindowsClosed(closed)
                End If
                If opened.Count > 0 Then
                    Events.Raise_WindowsOpened(opened)
                End If
            End Sub

        End Class

        Public Class Actions

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
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

            ''' <summary>
            ''' Gets a list of window information, unfiltered
            ''' </summary>
            ''' <returns>List of string, information for all windows, unfiltered</returns>
            ''' <remarks></remarks>
            Public Shared Function GetAllWindowsUnfiltered() As List(Of String)
                Dim ret As New List(Of String)
                Dim tname As String
                Dim arr() As String = Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l").Split(Environment.NewLine)
                For Each item As String In arr
                    tname = GetName(item.Substring(0, 10))
                    If tname <> "" AndAlso tname <> Environment.NewLine Then
                        ret.Add(item)
                    End If
                Next
                Return ret
            End Function

            ''' <summary>
            ''' Gets a list of running windows
            ''' </summary>
            ''' <returns>List of string, the handles of running windows</returns>
            ''' <remarks></remarks>
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

            ''' <summary>
            ''' Gets the title of a window
            ''' </summary>
            ''' <param name="win">The window handle</param>
            ''' <returns>String, the title of the window</returns>
            ''' <remarks></remarks>
            Public Shared Function GetName(ByVal win As String) As String
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowname " & win)
            End Function

            ''' <summary>
            ''' Checks if a window is closed
            ''' </summary>
            ''' <param name="win">The window handle to check</param>
            ''' <returns>True, if the window is closed, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function GetIfClosed(ByVal win As String) As Boolean
                Return Sys.Process.ExecuteCommandWithOutput("xdotool", "getwindowpid " & win).ToLower.Contains("error")
            End Function

            ''' <summary>
            ''' Gets a window handle by its title/name
            ''' </summary>
            ''' <param name="fname">The window title</param>
            ''' <returns>String, the window handle</returns>
            ''' <remarks></remarks>
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

            ''' <summary>
            ''' Set a window to be always in the back
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub SetAlwaysInBack(ByVal win As String)
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b add,below")
            End Sub

            ''' <summary>
            ''' Minimizes a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Minimize(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowminimize " & win)
            End Sub

            ''' <summary>
            ''' Sets a window's windowstate to normal
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <param name="activatewin">Whether or not to activate the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Normal(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b remove,maximized_vert,maximized_horz")
            End Sub

            ''' <summary>
            ''' Maximizes a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <param name="activatewin">Whether or not to activate the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Maximize(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b add,maximized_vert,maximized_horz")
            End Sub

            ''' <summary>
            ''' Toggles whether a window is maximized or normal
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <param name="activatewin">Whether or not to activate the window</param>
            ''' <remarks></remarks>
            Public Shared Sub ToggleMaximizeNormal(ByVal win As String, Optional ByVal activatewin As Boolean = True)
                If activatewin Then
                    Activate(win)
                End If
                Sys.Process.ExecuteCommand("wmctrl", "-i -r " & win & " -b toggle,maximized_vert,maximized_horz")
            End Sub

            ''' <summary>
            ''' Closes a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Kill(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowkill " & win)
            End Sub

            ''' <summary>
            ''' Activates (gives focus to) a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Activate(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowactivate " & win)
            End Sub

            ''' <summary>
            ''' Hides a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Hide(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowunmap " & win)
            End Sub

            ''' <summary>
            ''' Shows a window
            ''' </summary>
            ''' <param name="win">The handle of the window</param>
            ''' <remarks></remarks>
            Public Shared Sub Show(ByVal win As String)
                Sys.Process.ExecuteCommand("xdotool", "windowmap " & win)
            End Sub

        End Class

    End Namespace

End Namespace
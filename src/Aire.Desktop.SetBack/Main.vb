Module Main

#Region "Helper"

    Private Sub SetDesktopAlwaysInBackground()
        Try
            Dim arr() As String = Aire.API.Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l").Split(Environment.NewLine)
            For Each item As String In arr
                If item.Contains("Aire.Desktop.frmDesktop") Then
                    Aire.API.Sys.Window.Actions.SetAlwaysInBack(item.Substring(0, 10))
                    Exit For
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub SetHostAlwaysInBackground()
        Try
            Dim arr() As String = Aire.API.Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l").Split(Environment.NewLine)
            For Each item As String In arr
                If item.Contains("Aire.Host.frmMain") Then
                    Aire.API.Sys.Window.Actions.SetAlwaysInBack(item.Substring(0, 10))
                    Exit For
                End If
            Next
        Catch
        End Try
    End Sub

#End Region

    Sub Main()
        SetDesktopAlwaysInBackground()
        SetHostAlwaysInBackground()
        End
    End Sub

End Module

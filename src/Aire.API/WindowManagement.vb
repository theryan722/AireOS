Namespace Sys

    Namespace Window

        Public Class Info

            Public Shared Function GetRunningWindows() As List(Of String)
                Dim ret As New List(Of String)
                Dim t As String = Sys.Process.ExecuteCommandWithOutput("wmctrl", "-l")
                Dim arr() As String = t.Split(vbNewLine)
                For Each item As String In arr
                    If Not (item.Contains("ubuntu Desktop") Or item.Contains("ubuntu unity-launcher") Or item.Contains("ubuntu unity-panel") Or item.Contains("ubuntu unity-dash") Or item.Contains("ubuntu Hud")) Then
                        ret.Add(item.Substring(0, 10))
                    End If
                Next
                Return ret
            End Function

            Public Shared Function GetName(ByVal win As String) As String

            End Function

        End Class

        Public Class Actions

            Public Shared Sub Minimize(ByVal win As String)

            End Sub

            Public Shared Sub Maximize(ByVal win As String)

            End Sub

            Public Shared Sub ToggleMaximizeNormal(ByVal win As String)

            End Sub

            Public Shared Sub Kill(ByVal win As String)

            End Sub

            Public Shared Sub Activate(ByVal win As String)

            End Sub

        End Class

    End Namespace

End Namespace
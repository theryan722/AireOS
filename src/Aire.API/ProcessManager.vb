Public Class Process

    Public Shared Sub Start(ByVal proc As String)
        System.Diagnostics.Process.Start(proc)
    End Sub

    Public Shared Sub ExecuteCommand(ByVal file As String, ByVal arguments As String)

    End Sub

    Public Shared Function ExecuteCommandWithOutput(ByVal file As String, ByVal arguments As String) As String

    End Function

End Class
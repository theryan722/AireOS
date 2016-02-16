Namespace Printing

    Public Class Info

        Public Shared Function GetDefaultPrinter() As Printer
            Dim bb() As String = Sys.Process.ExecuteCommandWithOutput("lpstat", "-d").Split(" ")
            Return New Printer(bb(3))
        End Function

        Public Shared Function GetPrinters() As List(Of Printer)
            Dim ret As New List(Of Printer)
            Dim bb() As String = Sys.Process.ExecuteCommandWithOutput("lpstat", "-p").Split(Environment.NewLine)
            For Each item As String In bb
                If item <> "" Then
                    Dim arr() As String = item.Split(" ")
                    ret.Add(New Printer(arr(1), item.ToLower.Contains("enabled")))
                End If
            Next
            Return ret
        End Function

    End Class

    Public Class Actions

        Public Shared Sub SetDefaultPrinter(ByVal dprint As Printer)
            Sys.Process.ExecuteCommand("lpoptions", "-d " & dprint.Name)
        End Sub

        Public Shared Sub PrintFile(ByVal file As String, Optional ByVal printer As Printer = Nothing, Optional ByVal printsettings As PrinterSettings = Nothing)
            Dim pstr As String = ""
            If printer.Name <> "" Then
                pstr &= "-d " & printer.Name & " "
            End If
            If printsettings Is Nothing Then
                pstr &= file
            Else
                pstr &= printsettings.ConvertToCommand() & " " & file
            End If
            Sys.Process.ExecuteCommand("lp", pstr)
        End Sub

        Public Shared Sub RemoveLastPrintJob()
            Sys.Process.ExecuteCommand("lprm")
        End Sub

        Public Shared Sub CancelAllPrintJobs()
            Sys.Process.ExecuteCommand("lpq", "cancel -a")
        End Sub

    End Class

End Namespace
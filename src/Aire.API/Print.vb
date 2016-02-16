Namespace Printing

    Public Class Info

        Public Shared Function GetDefaultPrinter() As Printer

        End Function

        Public Shared Function GetPrinters() As List(Of Printer)

        End Function

    End Class

    Public Class Actions

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
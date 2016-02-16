Namespace Printing

    Public Class Info

        Public Shared Function GetDefaultPrinter() As String

        End Function

        Public Shared Function GetPrinters() As List(Of String)

        End Function

    End Class

    Public Class Actions

        Public Shared Sub PrintFile(ByVal file As String, Optional ByVal printer As String = "", Optional ByVal printsettings As PrinterSettings = Nothing)
           
        End Sub

        Public Shared Sub ClearPrintQeue()

        End Sub

    End Class

End Namespace
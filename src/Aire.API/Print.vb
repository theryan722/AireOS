Namespace Printing

    Public Class Info

        ''' <summary>
        ''' Gets the default printer
        ''' </summary>
        ''' <returns>Printer, the default printer</returns>
        ''' <remarks></remarks>
        Public Shared Function GetDefaultPrinter() As Printer
            Dim bb() As String = Sys.Process.ExecuteCommandWithOutput("lpstat", "-d").Split(" ")
            Return New Printer(bb(3))
        End Function

        ''' <summary>
        ''' Gets a list of available printers
        ''' </summary>
        ''' <returns>List of Printers, the available printers</returns>
        ''' <remarks></remarks>
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

        ''' <summary>
        ''' Sets the default printer
        ''' </summary>
        ''' <param name="dprint">The printer to set as the default printer</param>
        ''' <remarks></remarks>
        Public Shared Sub SetDefaultPrinter(ByVal dprint As Printer)
            Sys.Process.ExecuteCommand("lpoptions", "-d " & dprint.Name)
        End Sub

        ''' <summary>
        ''' Prints specified text
        ''' </summary>
        ''' <param name="txt">The text to print</param>
        ''' <param name="printer">The printer to print to</param>
        ''' <param name="printsettings">The PrinterSettings to use</param>
        ''' <remarks></remarks>
        Public Shared Sub PrintText(ByVal txt As String, Optional ByVal printer As Printer = Nothing, Optional ByVal printsettings As PrinterSettings = Nothing)
            Dim file As String = Aire.DataManager.DataPaths.GetSysDataLocation & "/Temp/print.txt"
            My.Computer.FileSystem.WriteAllText(file, txt, False)
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
            My.Computer.FileSystem.WriteAllText(file, "", False)
        End Sub

        ''' <summary>
        ''' Prints a file
        ''' </summary>
        ''' <param name="file">The file to print</param>
        ''' <param name="printer">The printer to print to</param>
        ''' <param name="printsettings">The PrinterSettings to use</param>
        ''' <remarks></remarks>
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

        ''' <summary>
        ''' Removes the last print job
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub RemoveLastPrintJob()
            Sys.Process.ExecuteCommand("lprm")
        End Sub

        ''' <summary>
        ''' Cancels all print jobs
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub CancelAllPrintJobs()
            Sys.Process.ExecuteCommand("lpq", "cancel -a")
        End Sub

    End Class

End Namespace
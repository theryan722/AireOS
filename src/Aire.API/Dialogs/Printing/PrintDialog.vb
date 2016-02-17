Public Class PrintDialog

#Region "Properties/Variables/Enums"

    Public Property PrinterOptions As PrinterSettings
    Private printerlist As New List(Of Printer)

#End Region

#Region "UI"

#Region "TabControl1"

#Region "Copies"



#End Region

#Region "Page Range"



#End Region

#Region "Sides"



#End Region

#Region "Margins"



#End Region

#Region "Media"



#End Region

#Region "Documents"



#End Region

#Region "Options"



#End Region

#End Region

#Region "pnl_bottom"



#End Region

#Region "Printer GroupBox"



#End Region

#End Region

#Region "Methods"

    Private Sub LoadCopiesUI()
        num_copies.Value = 1
        check_collated.Checked = False
    End Sub

    Private Sub LoadPageRangeUI()
        radio_all.Checked = True
        txt_custompagerange.Enabled = False
    End Sub

    Private Sub LoadSidesUI()
        radio_onesided.Checked = True
    End Sub

    Private Sub LoadMarginsUI()
        num_marginleft.Value = 72
        num_marginright.Value = 72
        num_margintop.Value = 72
        num_marginbottom.Value = 72
    End Sub

    Private Sub LoadMediaUI()
        lb_media.Items.Add("Letter")
    End Sub

    Private Sub LoadDocumentsUI()
        combo_documents.SelectedItem = "1"
        combo_documentslayout.SelectedItem = "LeftToRight_TopToBottom"
    End Sub

    Private Sub LoadOptionsUI()
        num_linesinch.Value = 6
        num_charactersinch.Value = 10
        check_mirror.Checked = False
        radio_normalorder.Checked = True
        check_fittopage.Checked = True
        combo_orientation.SelectedItem = "Portrait"
        check_prettyprint.Checked = False
        check_nowrap.Checked = False
        num_priority.Value = 50
    End Sub

    Private Sub LoadPrinters()
        printerlist.Clear()
        lb_printers.Items.Clear()
        printerlist = Aire.API.Printing.Info.GetPrinters
        For Each item As Printer In printerlist
            lb_printers.Items.Add(item.Name)
        Next
    End Sub

    Private Sub LoadUI()
        LoadPrinters()
        LoadCopiesUI()
        LoadPageRangeUI()
        LoadSidesUI()
        LoadMarginsUI()
        LoadMediaUI()
        LoadDocumentsUI()
        LoadOptionsUI()
    End Sub

    Private Function CheckIfFieldsValid() As Boolean

    End Function

#End Region

#Region "PrintDialog"



#End Region

End Class
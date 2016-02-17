Public Class PrintDialog

#Region "Properties/Variables/Enums"

    Public Property SelectedPrinter As Printer
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If CheckIfFieldsValid() Then
            SetProperty()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Dim bb As New Aire.API.MessageBox("Some fields were not filled out properly. Please check and make sure all fields are filled out, as well as within their bounds.", "Error", MessageBox.MessageBoxButtons.OkOnly, MessageBox.MessageBoxIcon.Warning)
        End If
    End Sub

#End Region

#Region "Printer GroupBox"



#End Region

#End Region

#Region "Methods"

#Region "LoadUI"

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

#End Region

#Region "Check Fields"

    Private Function CheckPrinters() As Boolean
        Return lb_printers.SelectedIndex <> -1
    End Function

    Private Function CheckCopies()
        Return num_copies.Value > 0
    End Function

    Private Function CheckPageRange()
        Dim ret As Boolean = True
        If radio_custom.Checked Then
            If txt_custompagerange.Text = "" Or txt_custompagerange.Text.Contains(" ") Then
                ret = False
            End If
        End If
        Return ret
    End Function

    Private Function CheckSides()
        Return True
    End Function

    Private Function CheckMargins()
        Return num_marginleft.Value >= 0 AndAlso num_marginright.Value >= 0 AndAlso num_margintop.Value >= 0 AndAlso num_marginbottom.Value >= 0
    End Function

    Private Function CheckMedia()
        Return lb_media.Items.Count > 0
    End Function

    Private Function CheckDocuments()
        Return combo_documents.SelectedIndex <> -1 AndAlso combo_documentslayout.SelectedIndex <> -1
    End Function

    Private Function CheckOptions()
        Dim ret As Boolean = True
        If num_linesinch.Value <= 0 Or num_charactersinch.Value <= 0 Then
            ret = False
        End If
        If combo_orientation.SelectedIndex = -1 Then
            ret = False
        End If
        If num_priority.Value < 1 Or num_priority.Value > 100 Then
            ret = False
        End If
        Return ret
    End Function

#End Region

    Private Sub SetProperty()

    End Sub

    Private Function CheckIfFieldsValid() As Boolean
        Return CheckPrinters() AndAlso CheckCopies() AndAlso CheckPageRange() AndAlso CheckSides() AndAlso CheckMargins() AndAlso CheckMedia() AndAlso CheckDocuments() AndAlso CheckOptions()
    End Function

#End Region

#Region "PrintDialog"

    Private Sub PrintDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUI()
    End Sub

#End Region
    
End Class
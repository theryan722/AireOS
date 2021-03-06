﻿Public Class PrintDialog

#Region "Properties/Variables/Enums"

    Public Property SelectedPrinter As Printer
    Public Property PrinterOptions As PrinterSettings
    Private printerlist As New List(Of Printer)

#End Region

#Region "UI"

#Region "TabControl1"

#Region "Page Range"

    Private Sub radio_custom_CheckedChanged(sender As Object, e As EventArgs) Handles radio_custom.CheckedChanged
        If radio_custom.Checked Then
            txt_custompagerange.Enabled = True
        Else
            txt_custompagerange.Enabled = False
            txt_custompagerange.Text = ""
        End If
    End Sub

#End Region

#Region "Media"

    Private Sub btn_addmedia_Click(sender As Object, e As EventArgs) Handles btn_addmedia.Click
        If combo_media.SelectedIndex <> -1 Then
            If Not lb_media.Items.Contains(combo_media.SelectedItem) Then
                lb_media.Items.Add(combo_media.SelectedItem)
            End If
        End If
    End Sub

    Private Sub btn_removemedia_Click(sender As Object, e As EventArgs) Handles btn_removemedia.Click
        If lb_media.SelectedIndex <> -1 Then
            lb_media.Items.Remove(lb_media.SelectedItem)
        End If
    End Sub

    Private Sub btn_clearmedia_Click(sender As Object, e As EventArgs) Handles btn_clearmedia.Click
        lb_media.Items.Clear()
    End Sub

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

    Private Sub lb_printers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_printers.SelectedIndexChanged
        If lb_printers.SelectedIndex <> -1 Then
            Dim b As Boolean = printerlist(lb_printers.SelectedIndex).Enabled
            If b Then
                lbl_status.Text = "Status: Enabled"
            Else
                lbl_status.Text = "Status: Disabled"
            End If
        End If
    End Sub

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

#Region "Helper"

    Private Function ConvertMediaStringToType(ByVal str As String) As PrinterSettings.MediaType
        Select Case str
            Case "Letter"
                Return PrinterSettings.MediaType.Letter
            Case "Legal"
                Return PrinterSettings.MediaType.Legal
            Case "A4"
                Return PrinterSettings.MediaType.A4
            Case "COM10"
                Return PrinterSettings.MediaType.COM10
            Case "DL"
                Return PrinterSettings.MediaType.DL
            Case "Transparency"
                Return PrinterSettings.MediaType.Transparency
            Case "Upper"
                Return PrinterSettings.MediaType.Upper
            Case "Lower"
                Return PrinterSettings.MediaType.Lower
            Case "MultiPurpose"
                Return PrinterSettings.MediaType.MultiPurpose
            Case "LargeCapacity"
                Return PrinterSettings.MediaType.LargeCapacity
            Case Else
                Return PrinterSettings.MediaType.Letter
        End Select
    End Function

    Private Function GetOrientation() As PrinterSettings.PageOrientation
        Select Case combo_orientation.SelectedItem
            Case "Portrait"
                Return PrinterSettings.PageOrientation.Portrait
            Case "Landscape"
                Return PrinterSettings.PageOrientation.Landscape
            Case "ReverseLandscape"
                Return PrinterSettings.PageOrientation.ReverseLandscape
            Case "ReversePortrait"
                Return PrinterSettings.PageOrientation.ReversePortrait
            Case Else
                Return PrinterSettings.PageOrientation.Portrait
        End Select
    End Function

    Private Function GetDocumentsPerPage() As PrinterSettings.NUpStyle
        Select Case combo_documents.SelectedItem
            Case "1"
                Return PrinterSettings.NUpStyle.One
            Case "2"
                Return PrinterSettings.NUpStyle.Two
            Case "4"
                Return PrinterSettings.NUpStyle.Four
            Case "6"
                Return PrinterSettings.NUpStyle.Six
            Case "9"
                Return PrinterSettings.NUpStyle.Nine
            Case "16"
                Return PrinterSettings.NUpStyle.Sixteen
            Case Else
                Return PrinterSettings.NUpStyle.One
        End Select
    End Function

    Private Function GetDocumentsLayout() As PrinterSettings.NUpLayoutStyle
        Select Case combo_documentslayout.SelectedItem
            Case "BottomToTop_LeftToRight"
                Return PrinterSettings.NUpLayoutStyle.BottomToTop_LeftToRight
            Case "BottomToTop_RightToLeft"
                Return PrinterSettings.NUpLayoutStyle.BottomToTop_RightToLeft
            Case "LeftToRight_BottomToTop"
                Return PrinterSettings.NUpLayoutStyle.LeftToRight_BottomToTop
            Case "LeftToRight_TopToBottom"
                Return PrinterSettings.NUpLayoutStyle.LeftToRight_TopToBottom
            Case "RightToLeft_BottomToTop"
                Return PrinterSettings.NUpLayoutStyle.RightToLeft_BottomToTop
            Case "RightToLeft_TopToBottom"
                Return PrinterSettings.NUpLayoutStyle.RightToLeft_TopToBottom
            Case "TopToBottom_LeftToRight"
                Return PrinterSettings.NUpLayoutStyle.TopToBottom_LeftToRight
            Case "TopToBottom_RightToLeft"
                Return PrinterSettings.NUpLayoutStyle.TopToBottom_RightToLeft
            Case Else
                Return PrinterSettings.NUpLayoutStyle.LeftToRight_TopToBottom
        End Select
    End Function

    Public Function GetSides() As PrinterSettings.SideStyle
        If radio_onesided.Checked Then
            Return PrinterSettings.SideStyle.OneSided
        ElseIf radio_twosidedlongedge.Checked Then
            Return PrinterSettings.SideStyle.TwoSidedLongEdge
        Else
            Return PrinterSettings.SideStyle.TwoSidedShortEdge
        End If
    End Function

    Public Function GetParity() As PrinterSettings.ParityStyle
        If radio_odds.Checked Then
            Return PrinterSettings.ParityStyle.Odd
        ElseIf radio_evens.Checked Then
            Return PrinterSettings.ParityStyle.Even
        Else
            Return PrinterSettings.ParityStyle.Normal
        End If
    End Function

    Private Function GetMediaList() As List(Of PrinterSettings.MediaType)
        Dim ret As New List(Of PrinterSettings.MediaType)
        For Each item As String In lb_media.Items
            ret.Add(ConvertMediaStringToType(item))
        Next
        Return ret
    End Function

    Private Function GetOutputOrder() As PrinterSettings.OutputOrderStyle
        If radio_normalorder.Checked Then
            Return PrinterSettings.OutputOrderStyle.Normal
        Else
            Return PrinterSettings.OutputOrderStyle.Reverse
        End If
    End Function

#End Region

    Private Sub LoadPrinters()
        printerlist.Clear()
        lb_printers.Items.Clear()
        printerlist = Aire.API.Printing.Info.GetPrinters
        For Each item As Printer In printerlist
            lb_printers.Items.Add(item.Name)
        Next
    End Sub

    Private Sub SetProperty()
        SelectedPrinter = New Printer(lb_printers.SelectedItem)
        PrinterOptions = New PrinterSettings(GetMediaList(), num_copies.Value, check_fittopage.Checked, GetOrientation(), check_collated.Checked, GetSides(), txt_custompagerange.Text, GetParity(), GetDocumentsPerPage(), GetDocumentsLayout(), GetOutputOrder(), check_mirror.Checked, num_charactersinch.Value, num_linesinch.Value, num_marginleft.Value, num_marginright.Value, num_margintop.Value, num_marginright.Value, check_prettyprint.Checked, check_nowrap.Checked, num_priority.Value)
    End Sub

    Private Function CheckIfFieldsValid() As Boolean
        Return CheckPrinters() AndAlso CheckCopies() AndAlso CheckPageRange() AndAlso CheckSides() AndAlso CheckMargins() AndAlso CheckMedia() AndAlso CheckDocuments() AndAlso CheckOptions()
    End Function

    Private Sub LoadUIFromPrintSettings(ByVal printset As PrinterSettings)
        LoadUI()
        lb_media.Items.Clear()
        For Each item As PrinterSettings.MediaType In printset.Media
            lb_media.Items.Add(item.ToString)
        Next
        num_copies.Value = printset.Copies
        check_fittopage.Checked = printset.FitToPage
        combo_orientation.SelectedItem = printset.Orientation.ToString
        check_collated.Checked = printset.Collate
        Select Case printset.Sides
            Case PrinterSettings.SideStyle.OneSided
                radio_onesided.Checked = True
            Case PrinterSettings.SideStyle.TwoSidedLongEdge
                radio_twosidedlongedge.Checked = True
            Case PrinterSettings.SideStyle.TwoSidedShortEdge
                radio_twosidedshortedge.Checked = True
        End Select
        txt_custompagerange.Text = printset.PageRanges
        Select Case printset.Parity
            Case PrinterSettings.ParityStyle.Even
                radio_evens.Checked = True
            Case PrinterSettings.ParityStyle.Odd
                radio_odds.Checked = True
        End Select
        combo_documents.SelectedItem = printset.NUp.ToString
        combo_documentslayout.SelectedItem = printset.NUpLayout.ToString
        Select Case printset.OutputOrder
            Case PrinterSettings.OutputOrderStyle.Normal
                radio_normalorder.Checked = True
            Case PrinterSettings.OutputOrderStyle.Reverse
                radio_reverseorder.Checked = True
        End Select
        check_mirror.Checked = printset.Mirror
        num_charactersinch.Value = printset.CharactersPerInch
        num_linesinch.Value = printset.LinesPerInch
        num_marginleft.Value = printset.MarginLeft
        num_marginright.Value = printset.MarginRight
        num_margintop.Value = printset.MarginTop
        num_marginbottom.Value = printset.MarginBottom
        check_prettyprint.Checked = printset.PrettyPrint
        check_nowrap.Checked = printset.NoWrap
        num_priority.Value = printset.Priority
    End Sub

#End Region

#Region "PrintDialog"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="title">The title of the dialog</param>
    ''' <param name="printsettings">The printsettings to load</param>
    ''' <remarks></remarks>
    Public Sub New(Optional ByVal title As String = "Print", Optional ByVal printsettings As PrinterSettings = Nothing, Optional ByVal autoshow As Boolean = True)
        InitializeComponent()
        Me.Text = title
        If Not printsettings Is Nothing Then
            LoadUIFromPrintSettings(printsettings)
        Else
            LoadUI()
        End If
        If autoshow Then
            Me.ShowDialog()
        End If
    End Sub

#End Region

End Class
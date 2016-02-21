Public Class PrinterSettings

#Region "Enums"

    Enum MediaType
        Letter
        Legal
        A4
        COM10
        DL
        Transparency
        Upper
        Lower
        MultiPurpose
        LargeCapacity
    End Enum

    Enum PageOrientation
        Portrait
        Landscape '90 degrees
        ReverseLandscape '270 degrees
        ReversePortrait '180 degrees
    End Enum

    Enum SideStyle
        OneSided
        TwoSidedShortEdge
        TwoSidedLongEdge
    End Enum

    Enum ParityStyle
        Normal
        Even
        Odd
    End Enum

    Enum NUpStyle
        One
        Two
        Four
        Six
        Nine
        Sixteen
    End Enum

    Enum NUpLayoutStyle
        BottomToTop_LeftToRight
        BottomToTop_RightToLeft
        LeftToRight_BottomToTop
        LeftToRight_TopToBottom 'default
        RightToLeft_BottomToTop
        RightToLeft_TopToBottom
        TopToBottom_LeftToRight
        TopToBottom_RightToLeft
    End Enum

    Enum OutputOrderStyle
        Normal
        Reverse
    End Enum

#End Region

#Region "Properties"

    ''' <summary>
    ''' The media settings for the document
    ''' </summary>
    ''' <value>The MediaType properties to set, in list</value>
    ''' <returns>A list of all MediaType properties set for the document</returns>
    ''' <remarks></remarks>
    Public Property Media As List(Of MediaType)

    ''' <summary>
    ''' The number of copies to print
    ''' </summary>
    ''' <value>The number of copies to print</value>
    ''' <returns>The number of copies to print</returns>
    ''' <remarks></remarks>
    Public Property Copies As Integer

    ''' <summary>
    ''' Whether or not the document should be fitted to the page
    ''' </summary>
    ''' <value>Whether or not the document should be fitted to the page</value>
    ''' <returns>True, if the document should be fitted to the page, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property FitToPage As Boolean

    ''' <summary>
    ''' The orientation of the document
    ''' </summary>
    ''' <value>The orientation of the document, as PageOrientation</value>
    ''' <returns>PageOrientation</returns>
    ''' <remarks></remarks>
    Public Property Orientation As PageOrientation

    ''' <summary>
    ''' Whether or not to collate the documents
    ''' </summary>
    ''' <value>Whether or not to collate the documents</value>
    ''' <returns>True, if the documents will be collated, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property Collate As Boolean

    ''' <summary>
    ''' Whether the document should be printed on one side only, or double sided
    ''' </summary>
    ''' <value>whether the document should be printed on one side only, or double sided, as SideStyle</value>
    ''' <returns>SideStyle</returns>
    ''' <remarks></remarks>
    Public Property Sides As SideStyle

    ''' <summary>
    ''' The ranges of pages to print
    ''' </summary>
    ''' <value>The ranges of pages to print, e.g. "1-4,7-9"</value>
    ''' <returns>String, the ranges of pages to print</returns>
    ''' <remarks></remarks>
    Public Property PageRanges As String

    ''' <summary>
    ''' Whether to print normally, or to print only even or odd pages
    ''' </summary>
    ''' <value>Whether to print normally, or to print only even or odd pages, as ParityStyle</value>
    ''' <returns>ParityStyle</returns>
    ''' <remarks>If normal, than PageRanges can be used</remarks>
    Public Property Parity As ParityStyle

    ''' <summary>
    ''' How many documents to print per page
    ''' </summary>
    ''' <value>The number of documents to print per page, as NUpStyle</value>
    ''' <returns>NUpStyle</returns>
    ''' <remarks></remarks>
    Public Property NUp As NUpStyle

    ''' <summary>
    ''' The layout of how documents will be printed on a page
    ''' </summary>
    ''' <value>The layout of how documents will be printed on a page, as NUpLayoutStyle</value>
    ''' <returns>NUpLayoutStyle</returns>
    ''' <remarks></remarks>
    Public Property NUpLayout As NUpLayoutStyle

    ''' <summary>
    ''' Whether to print out the documents normally, or in reverse order
    ''' </summary>
    ''' <value>Whether to print out the documents normally, or in reverse order, as OutputOrderStyle</value>
    ''' <returns>OutputOrderStyle</returns>
    ''' <remarks></remarks>
    Public Property OutputOrder As OutputOrderStyle

    ''' <summary>
    ''' Whether to flip each page along the vertical axis
    ''' </summary>
    ''' <value>Whether to flip each page along the vertical axis</value>
    ''' <returns>True, if pages will be flipped, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property Mirror As Boolean

    ''' <summary>
    ''' The characters per inch
    ''' </summary>
    ''' <value>The characters per inch</value>
    ''' <returns>Integer, the characters per inch</returns>
    ''' <remarks></remarks>
    Public Property CharactersPerInch As Integer 'Default 10

    ''' <summary>
    ''' The lines per inch
    ''' </summary>
    ''' <value>The lines per inch</value>
    ''' <returns>Integer, the lines per inch</returns>
    ''' <remarks></remarks>
    Public Property LinesPerInch As Integer 'Default 6

    ''' <summary>
    ''' The left page margin
    ''' </summary>
    ''' <value>The left page margin, each point is 1/72 inch or 0.35mm</value>
    ''' <returns>Integer, the left page margin</returns>
    ''' <remarks></remarks>
    Public Property MarginLeft As Integer

    ''' <summary>
    ''' The right page margin
    ''' </summary>
    ''' <value>The right page margin, each point is 1/72 inch or 0.35mm</value>
    ''' <returns>Integer, the right page margin</returns>
    ''' <remarks></remarks>
    Public Property MarginRight As Integer

    ''' <summary>
    ''' The top page margin
    ''' </summary>
    ''' <value>The top page margin, each point is 1/72 inch or 0.35mm</value>
    ''' <returns>Integer, the top page margin</returns>
    ''' <remarks></remarks>
    Public Property MarginTop As Integer

    ''' <summary>
    ''' The bottom page margin
    ''' </summary>
    ''' <value>The bottom page margin, each point is 1/72 inch or 0.35mm</value>
    ''' <returns>Integer, the bottom page margin</returns>
    ''' <remarks></remarks>
    Public Property MarginBottom As Integer

    ''' <summary>
    ''' Whether to put a header at the top of each page with the page number, job title (usually the filename), and the date
    ''' </summary>
    ''' <value>Whether to put a header at the top of each page</value>
    ''' <returns>True, if a header will be displayed, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property PrettyPrint As Boolean

    ''' <summary>
    ''' Whether to disable wrapping of long lines or not
    ''' </summary>
    ''' <value>Whether to disable wrapping of long lines or not</value>
    ''' <returns>True, if wrapping will be disabled, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property NoWrap As Boolean

    ''' <summary>
    ''' The priority of the print job
    ''' </summary>
    ''' <value>The priority of the print job, from 1-100</value>
    ''' <returns>Integer, the priority of the print job</returns>
    ''' <remarks></remarks>
    Public Property Priority As Integer

#End Region

#Region "Helper"

    Private Function ConvertOrientationToString() As String
        Dim ret As String = " -o "
        Select Case Orientation
            Case PageOrientation.Landscape
                ret &= "orientation-requested=4"
            Case PageOrientation.Portrait
                ret &= "orientation-requested=3"
            Case PageOrientation.ReverseLandscape
                ret &= "orientation-requested=5"
            Case PageOrientation.ReversePortrait
                ret &= "orientation-requested=6"
        End Select
        Return ret
    End Function

    Private Function ConvertSidesToString() As String
        Dim ret As String = " -o "
        Select Case Sides
            Case SideStyle.OneSided
                ret &= "sides=one-sided"
            Case SideStyle.TwoSidedLongEdge
                ret &= "sides=two-sided-long-edge"
            Case SideStyle.TwoSidedShortEdge
                ret &= "sides=two-sided-short-edge"
        End Select
        Return ret
    End Function

    Private Function ConvertNUpToString() As String
        Dim ret As String = " -o "
        Select Case NUp
            Case NUpStyle.One
                ret &= "number-up=1"
            Case NUpStyle.Two
                ret &= "number-up=2"
            Case NUpStyle.Four
                ret &= "number-up=4"
            Case NUpStyle.Six
                ret &= "number-up=6"
            Case NUpStyle.Sixteen
                ret &= "number-up=16"
        End Select
        Return ret
    End Function

    Private Function ConvertNUpLayoutToString() As String
        Dim ret As String = " -o "
        Select Case NUpLayout
            Case NUpLayoutStyle.BottomToTop_LeftToRight
                ret &= "number-up-layout=btlr"
            Case NUpLayoutStyle.BottomToTop_RightToLeft
                ret &= "number-up-layout=btrl"
            Case NUpLayoutStyle.LeftToRight_BottomToTop
                ret &= "number-up-layout=lrbt"
            Case NUpLayoutStyle.LeftToRight_TopToBottom
                ret &= "number-up-layout=lrtb"
            Case NUpLayoutStyle.RightToLeft_BottomToTop
                ret &= "number-up-layout=rlbt"
            Case NUpLayoutStyle.RightToLeft_TopToBottom
                ret &= "number-up-layout=rltb"
            Case NUpLayoutStyle.TopToBottom_LeftToRight
                ret &= "number-up-layout=tblr"
            Case NUpLayoutStyle.TopToBottom_RightToLeft
                ret &= "number-up-layout=tbrl"
        End Select
        Return ret
    End Function

#End Region

#Region "PrinterSettings"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="pmedia">The media settings for the document</param>
    ''' <param name="pcopies">The number of copies to print</param>
    ''' <param name="pfittopage">Whether or not the document should be fitted to the page</param>
    ''' <param name="porientation">The orientation of the document</param>
    ''' <param name="pcollate">Whether or not to collate the documents</param>
    ''' <param name="psides">Whether the document should be printed on one side only, or double sided</param>
    ''' <param name="ppageranges">The ranges of pages to print</param>
    ''' <param name="pparity">Whether to print normally, or to print only even or odd pages</param>
    ''' <param name="pnup">How many documents to print per page</param>
    ''' <param name="pnuplayout">The layout of how documents will be printed on a page</param>
    ''' <param name="poutputorder">Whether to print out the documents normally, or in reverse order</param>
    ''' <param name="pmirror">Whether to flip each page along the vertical axis</param>
    ''' <param name="pcharactersperinch">The characters per inch</param>
    ''' <param name="plinesperinch">The lines per inch</param>
    ''' <param name="pmarginleft">The left page margin</param>
    ''' <param name="pmarginright">The right page margin</param>
    ''' <param name="pmargintop">The top page margin</param>
    ''' <param name="pmarginbottom">The bottom page margin</param>
    ''' <param name="pprettyprint">Whether to put a header at the top of each page with the page number, job title (usually the filename), and the date</param>
    ''' <param name="pnowrap">Whether to disable wrapping of long lines or not</param>
    ''' <param name="ppriority">The priority of the print job</param>
    ''' <remarks></remarks>
    Public Sub New(Optional ByVal pmedia As List(Of MediaType) = Nothing, Optional ByVal pcopies As Integer = 1, Optional ByVal pfittopage As Boolean = True, Optional ByVal porientation As PageOrientation = PageOrientation.Portrait, Optional ByVal pcollate As Boolean = False, Optional ByVal psides As SideStyle = SideStyle.OneSided, Optional ByVal ppageranges As String = "", Optional ByVal pparity As ParityStyle = ParityStyle.Normal, Optional ByVal pnup As NUpStyle = NUpStyle.One, Optional ByVal pnuplayout As NUpLayoutStyle = NUpLayoutStyle.LeftToRight_TopToBottom, Optional ByVal poutputorder As OutputOrderStyle = OutputOrderStyle.Normal, Optional ByVal pmirror As Boolean = False, Optional ByVal pcharactersperinch As Integer = 10, Optional ByVal plinesperinch As Integer = 6, Optional ByVal pmarginleft As Integer = 72, Optional ByVal pmarginright As Integer = 72, Optional ByVal pmargintop As Integer = 72, Optional pmarginbottom As Integer = 72, Optional ByVal pprettyprint As Boolean = False, Optional ByVal pnowrap As Boolean = False, Optional ByVal ppriority As Integer = 50)
        If pmedia Is Nothing Then
            pmedia = New List(Of MediaType)
            pmedia.Add(MediaType.Letter)
        End If
        Media = pmedia
        Copies = pcopies
        FitToPage = pfittopage
        Orientation = porientation
        Collate = pcollate
        Sides = psides
        PageRanges = ppageranges
        Parity = pparity
        NUp = pnup
        NUpLayout = pnuplayout
        OutputOrder = poutputorder
        Mirror = pmirror
        CharactersPerInch = pcharactersperinch
        LinesPerInch = plinesperinch
        MarginLeft = pmarginleft
        MarginRight = pmarginright
        MarginTop = pmargintop
        MarginBottom = pmarginbottom
        PrettyPrint = pprettyprint
        NoWrap = pnowrap
        Priority = ppriority
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Generates a commandline friendly string from the PrinterSettings properties
    ''' </summary>
    ''' <returns>String, the properties of the PrinterSettings</returns>
    ''' <remarks></remarks>
    Public Function ConvertToCommand() As String
        Dim ret As String = ""
        ret &= "-o media=" 'Media
            For i As Integer = 0 To Media.Count - 1
                If i = Media.Count - 1 Then
                    ret &= Media(i).ToString
                Else
                    ret &= Media(i).ToString & ","
                End If
            Next
        ret &= " -n " & Copies 'Copies
        ret &= " -o Collate=" & Collate.ToString 'Collate
        If FitToPage Then 'FitToPage
            ret &= " -o fit-to-page"
        End If
        ret &= ConvertOrientationToString() ' Orientation
        ret &= ConvertSidesToString() 'Sides
        If Parity = ParityStyle.Normal Then
            If PageRanges <> "" Then 'Page Ranges
                ret &= " -o page-ranges=" & PageRanges
            End If
        Else
            If Parity = ParityStyle.Odd Then 'Parity
                ret &= " -o page-set=odd"
            Else
                ret &= " -o page-set=even"
            End If
        End If
        ret &= ConvertNUpToString() 'NUp
        ret &= ConvertNUpLayoutToString() 'NUp Layout
        If OutputOrder = OutputOrderStyle.Normal Then 'Output Order
            ret &= " -o outputorder=normal"
        Else
            ret &= " -o outputorder=reverse"
        End If
        If Mirror Then 'Mirror
            ret &= " -o mirror"
        End If
        ret &= " -o cpi=" & CharactersPerInch 'Characters Per Inch
        ret &= " -o lpi=" & LinesPerInch 'Lines Per Inch
        ret &= " -o page-left=" & MarginLeft 'Margin Left
        ret &= " -o page-right=" & MarginRight 'Margin Right
        ret &= " -o page-top=" & MarginTop 'Margin Top
        ret &= " -o page-bottom=" & MarginBottom 'Margin Bottom
        If PrettyPrint Then 'Pretty Print
            ret &= " -o prettyprint"
        End If
        If NoWrap Then 'No Wrap
            ret &= " -o nowrap"
        End If
        ret &= " -o job-priority=" & Priority
        Return ret
    End Function

#End Region

End Class
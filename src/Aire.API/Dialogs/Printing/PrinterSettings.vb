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

    Public Property Media As List(Of MediaType)
    Public Property Copies As Integer
    Public Property FitToPage As Boolean
    Public Property Orientation As PageOrientation
    Public Property Collate As Boolean
    Public Property Sides As SideStyle
    Public Property PageRanges As String
    Public Property Parity As ParityStyle
    Public Property NUp As NUpStyle
    Public Property NUpLayout As NUpLayoutStyle
    Public Property OutputOrder As OutputOrderStyle
    Public Property Mirror As Boolean
    Public Property CharactersPerInch As Integer 'Default 10
    Public Property LinesPerInch As Integer 'Default 6
    Public Property MarginLeft As Integer 'Each point is 1/72 inch or 0.35mm
    Public Property MarginRight As Integer 'Each point is 1/72 inch or 0.35mm
    Public Property MarginTop As Integer 'Each point is 1/72 inch or 0.35mm
    Public Property MarginBottom As Integer 'Each point is 1/72 inch or 0.35mm
    Public Property PrettyPrint As Boolean
    Public Property NoWrap As Boolean
    Public Property Priority As Integer '1 - 100

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

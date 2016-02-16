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
    Public Property File As String

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

#End Region

#Region "Methods"

    Public Function ConvertToCommand() As String
        Dim ret As String = ""
        If Not Media Is Nothing Then 'Media
            ret &= "-0 media="
            For i As Integer = 0 To Media.Count - 1
                If i = Media.Count - 1 Then
                    ret &= Media(i).ToString
                Else
                    ret &= Media(i).ToString & ","
                End If
            Next
        End If
        ret &= " -n " & Copies 'Copies
        ret &= " -o Collate=" & Collate.ToString 'Collate
        If FitToPage Then 'FitToPage
            ret &= " -o fit-to-page"
        End If
        ret &= ConvertOrientationToString() ' Orientation

        Return ret
    End Function

#End Region

End Class

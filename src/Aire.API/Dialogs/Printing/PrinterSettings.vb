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

#End Region

#Region "Methods"

    Public Function ConvertToCommandString() As String
        Dim ret As String

        Return ret
    End Function

#End Region

End Class

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

#End Region

#Region "Properties"

    Public Property Media As MediaType
    Public Property Copies As Integer
    Public Property FitToPage As Boolean
    Public Property Orientation As PageOrientation
    Public Property Collate As Boolean
    Public Property Sides As SideStyle
    Public Property PageRanges As String
    Public Property Parity As ParityStyle
    Public Property NUp As NUpStyle

#End Region

End Class

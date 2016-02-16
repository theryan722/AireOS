﻿Public Class PrinterSettings

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
        Landscape
        Portrait
    End Enum

#End Region

#Region "Properties"

    Public Property Media As MediaType
    Public Property Copies As Integer
    Public Property FitToPage As Boolean
    Public Property Orientation As PageOrientation
    Public Property Collate As Boolean

#End Region

End Class

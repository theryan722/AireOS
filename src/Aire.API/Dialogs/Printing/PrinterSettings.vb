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

#Region "Methods"

    Public Function ConvertToCommand() As String
        Dim ret As String = ""
        If Not Media Is Nothing Then 'Media
            ret &= "-o media="
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
        ret &= " -o number-up=" & ConvertNUpToString() 'NUp


        Return ret
    End Function

#End Region

End Class

﻿Public Class Converter

    ''' <summary>
    ''' Converts a string to an ImageLayout
    ''' </summary>
    ''' <param name="str">The string to convert</param>
    ''' <returns>ImageLayout, the converted string</returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertStringToImageLayout(ByVal str As String) As System.Windows.Forms.ImageLayout
        Select Case str
            Case "None"
                Return Windows.Forms.ImageLayout.None
            Case "Tile"
                Return Windows.Forms.ImageLayout.Tile
            Case "Center"
                Return Windows.Forms.ImageLayout.Center
            Case "Stretch"
                Return Windows.Forms.ImageLayout.Stretch
            Case "Zoom"
                Return Windows.Forms.ImageLayout.Zoom
            Case Else
                Return Windows.Forms.ImageLayout.None
        End Select
    End Function

End Class

Imports System.Windows.Forms
Imports System.Drawing

Public Class FormPosition

    ''' <summary>
    ''' Centers the form either in the center of the screen, or to a parent
    ''' </summary>
    ''' <param name="frm">The form to center</param>
    ''' <param name="parent">The parent to which the form will be centered in</param>
    ''' <remarks></remarks>
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If
        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub

End Class

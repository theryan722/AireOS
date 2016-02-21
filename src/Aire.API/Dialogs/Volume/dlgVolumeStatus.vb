Imports System.Drawing
Imports System.Windows.Forms

Friend Class dlgVolumeStatus

    Private Shared Volume As Integer = 0

    ''' <summary>
    ''' Whether the control is showing
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Showing As Boolean = False

#Region "Methods"

    ''' <summary>
    ''' Updates the volume of the control
    ''' </summary>
    ''' <param name="vol">The volume to set</param>
    ''' <remarks></remarks>
    Public Sub UpdateVolume(ByVal vol As Integer)
        Volume = Math.Min(vol, 100)
        Me.Invalidate()
    End Sub

    Private Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single, Optional ByVal mute As Boolean = False)
        Dim progressAngle = CSng(360 / 100 * percentage)
        Dim remainderAngle = 360 - progressAngle
        Using progressPen As New Pen(Color.LightSeaGreen, 2), remainderPen As New Pen(Color.LightGray, 2)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.DrawArc(progressPen, rect, -90, progressAngle)
            g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle)
        End Using
        Using fnt As New Font(Me.Font.FontFamily, 14)
            Dim text As String
            If mute Then
                text = "Muted"
            Else
                text = percentage.ToString + "%"
            End If

            Dim textSize = g.MeasureString(Text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            g.DrawString(Text, fnt, Brushes.Black, textPoint)
        End Using
    End Sub

#End Region

#Region "dlgVolumeStatus"

    Private Sub dlgVolumeStatus_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Showing = False
    End Sub

    Private Sub dlgVolumeStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 5)
        Showing = True
        UpdateVolume(Aire.API.Audio.Volume.GetVolume())
        LifeTimer.Start()
    End Sub

    Private Sub dlgVolumeStatus_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Me.Paint
        DrawProgress(e.Graphics, New Rectangle(5, 5, 60, 60), Volume, Audio.Volume.GetIfMuted)
    End Sub

#End Region

#Region "Timer"

    Private Sub LifeTimer_Tick(sender As Object, e As EventArgs) Handles LifeTimer.Tick
        Me.Close()
    End Sub

#End Region

End Class
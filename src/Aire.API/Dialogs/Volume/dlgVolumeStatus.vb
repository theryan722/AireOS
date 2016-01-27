Imports System.Drawing
Imports System.Windows.Forms

Friend Class dlgVolumeStatus

    Private Shared Volume As Integer = 0
    Public Shared Showing As Boolean = False

#Region "Methods"

    Public Sub UpdateVolume(ByVal vol As Integer)
        Volume = Math.Min(vol, 100)
        Me.Invalidate()
    End Sub

    Private Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single)
        Dim progressAngle = CSng(360 / 100 * percentage)
        Dim remainderAngle = 360 - progressAngle
        Using progressPen As New Pen(Color.LightSeaGreen, 2), remainderPen As New Pen(Color.LightGray, 2)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.DrawArc(progressPen, rect, -90, progressAngle)
            g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle)
        End Using
        Using fnt As New Font(Me.Font.FontFamily, 14)
            Dim text As String = percentage.ToString + "%"
            Dim textSize = g.MeasureString(text, fnt)
            Dim textPoint As New Point(CInt(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), CInt(rect.Top + (rect.Height / 2) - (textSize.Height / 2)))
            g.DrawString(text, fnt, Brushes.Black, textPoint)
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
        DrawProgress(e.Graphics, New Rectangle(5, 5, 60, 60), Volume)
    End Sub

#End Region

#Region "Timer"

    Private Sub LifeTimer_Tick(sender As Object, e As EventArgs) Handles LifeTimer.Tick
        Me.Close()
    End Sub

#End Region

End Class
Imports System.Drawing

Friend Class dlgVolumeStatus

    Private Volume As Integer = 0
    Private ovolume As Integer = 0
    Private trun As Integer = 0
    Public Shadows Event StatClosed()

#Region "Event Handlers"

    Private Sub HandleVolumeChanged(ByVal vol As Integer)
        UpdateVolume(vol)
    End Sub

#End Region

#Region "Methods"

    Public Sub UpdateVolume(ByVal vol As Integer)
        Volume = vol
        Me.Invalidate()
    End Sub

    Public Sub DrawProgress(g As Graphics, rect As Rectangle, percentage As Single)
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
        RaiseEvent StatClosed()
    End Sub

    Private Sub dlgVolumeStatus_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Me.Paint
        DrawProgress(e.Graphics, New Rectangle(5, 5, 60, 60), Volume)
    End Sub

    Public Sub New(Optional ByVal vol As Integer = 0)
        InitializeComponent()
        UpdateVolume(vol)
        LifeTimer.Start()
        AddHandler Aire.API.Sys.Events.VolumeChanged, AddressOf HandleVolumeChanged
    End Sub

#End Region

#Region "Timer"

    Private Sub LifeTimer_Tick(sender As Object, e As EventArgs) Handles LifeTimer.Tick
        If trun = 0 Then
            ovolume = Volume
            trun += 1
        Else
            If ovolume = Volume Then
                Me.Close()
            Else
                ovolume = Volume
                trun += 1
            End If
        End If
    End Sub

#End Region

End Class
Friend Class dlgVolume

    Private Shared Volume As Integer = 0
    Public Shared Showing As Boolean = False

#Region "Methods"

    Public Sub UpdateUI(Optional notrackbar As Boolean = False)
        Dim vol As Integer = Audio.Volume.GetVolume()
        If Audio.Volume.GetIfMuted Then
            lbl_vol.Text = "Muted"
        Else
            lbl_vol.Text = vol & "%"
            If notrackbar Then
                TrackBar1.Value = vol
            End If
        End If
    End Sub

#End Region

#Region "UI"

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Audio.Volume.SetVolume(TrackBar1.Value)
        UpdateUI(True)
    End Sub

#End Region

#Region "dlgVolume"

    Private Sub dlgVolume_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Showing = False
    End Sub

    Private Sub dlgVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showing = True
        UpdateUI()
    End Sub

    Private Sub dlgVolume_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

#End Region
    
End Class
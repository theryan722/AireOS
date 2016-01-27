Friend Class dlgVolume

    Private Shared Volume As Integer = 0
    Public Shared Showing As Boolean = False

#Region "Methods"

    Private Sub UpdateUI()
        Dim vol As Integer = Audio.Volume.GetVolume()
        If Audio.Volume.GetIfMuted Then
            lbl_vol.Text = "Muted"
        Else
            lbl_vol.Text = vol & "%"
            TrackBar1.Value = vol
        End If

    End Sub

    Private Sub UpdateVolume()


    End Sub

#End Region

#Region "UI"



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
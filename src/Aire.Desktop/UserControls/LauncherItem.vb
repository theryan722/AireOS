Public Class LauncherItem

#Region "Properties/Variables"

    Private ftitle As String

    Public Property Title As String
        Get
            Return ftitle
        End Get
        Set(value As String)
            ftitle = value
            If value.Length > 20 Then
                lblTitle.Text = value.Substring(0, 20) & "..."
            Else
                lblTitle.Text = value
            End If
            ToolTip1.SetToolTip(lblTitle, value)
            ToolTip1.SetToolTip(Me, value)
        End Set
    End Property

    Public Property FileLocation As String

#End Region

#Region "Methods"

    Private Sub LaunchFile()

    End Sub

#End Region

#Region "lblText"

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        LaunchFile()
    End Sub

#End Region

#Region "LauncherItem"

    Private Sub LauncherItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LauncherItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        LaunchFile()
    End Sub

#End Region
    
End Class

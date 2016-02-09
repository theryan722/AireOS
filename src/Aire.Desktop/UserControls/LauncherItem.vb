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
                lblText.Text = value.Substring(0, 20) & "..."
            Else
                lblText.Text = value
            End If
            ToolTip1.SetToolTip(lblText, value)
            ToolTip1.SetToolTip(Me, value)
        End Set
    End Property
    Public Property FileLocation As String

#End Region

#Region "Methods"



#End Region

#Region "lblText"



#End Region

#Region "LauncherItem"

    Private Sub LauncherItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class

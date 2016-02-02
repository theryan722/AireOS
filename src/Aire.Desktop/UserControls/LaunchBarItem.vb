Public Class LaunchBarItem

#Region "Properties"

    Public Shadows Property BackColor As Color
        Get

        End Get
        Set(value As Color)

        End Set
    End Property

    Public Property Window As String

    Public Shadows Property Text As String

#End Region

#Region "Methods"



#End Region

#Region "UI"

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblName_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lblName.MouseDoubleClick

    End Sub

#End Region

#Region "LaunchBarItem"

    Private Sub LaunchBarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaunchBarItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

    End Sub

    Private Sub LaunchBarItem_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick

    End Sub

#End Region
    
End Class

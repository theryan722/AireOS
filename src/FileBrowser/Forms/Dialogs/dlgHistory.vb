Public Class dlgHistory

#Region "Properties/Variables"

    Private histsource As String

#End Region

#Region "UI"

#Region "Context Menu Strip"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub OpenInNewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNewWindowToolStripMenuItem.Click

    End Sub

#End Region

#Region "Buttons"

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnNavigate_Click(sender As Object, e As EventArgs) Handles btnNavigate.Click

    End Sub

#End Region

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick

    End Sub

#End Region

#Region "Methods"

    Private Sub OpenSelected(Optional ByVal newwin As Boolean = False)

    End Sub

    Private Sub ClearHistory()

    End Sub

    Private Sub LoadHistory()

    End Sub

#End Region

#Region "dlgHistory"

    Public Sub New(ByVal histloc As String)
        InitializeComponent()
        histsource = histloc
    End Sub

    Private Sub dlgHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

End Class
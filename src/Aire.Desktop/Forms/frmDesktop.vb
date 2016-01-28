Public Class frmDesktop

#Region "Properties"

    Public Property Windows As New List(Of DesktopWindows)
    Public Property User As String
    Public Property Session As DesktopSession

#End Region

#Region "Methods"

    Public Sub SetDesktopBackground(ByVal img As String, Optional ByVal layout As ImageLayout = ImageLayout.Stretch)
        pnl_desktop.BackgroundImage = Image.FromFile(img)
        pnl_desktop.BackgroundImageLayout = layout
    End Sub

    Public Sub SetAppBarColor(ByVal clr As Color)
        pnl_appbar_top.BackColor = clr
        pnl_appbar_bottom.BackColor = clr
    End Sub

#End Region

#Region "UI"



#End Region

#Region "frmDesktop"

    Public Sub New(ByVal ouser As String, Optional ByVal ses As DesktopSession = Nothing)
        InitializeComponent()
        User = ouser
        Session = ses
    End Sub

#End Region

End Class
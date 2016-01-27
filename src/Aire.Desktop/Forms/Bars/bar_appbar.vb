Public Class bar_appbar

#Region "Variables/Properties"

    Private desktop As frmDesktop

#End Region

#Region "UI"



#End Region

#Region "Methods"

#Region "Public"

    Public Sub SetBackColor(ByVal ncolor As Color)
        Me.BackColor = ncolor
    End Sub

    Public Function GetBackColor() As Color
        Return Me.BackColor
    End Function

#End Region

#End Region

#Region "bar_appbar"

    Public Sub New(ByVal frm As frmDesktop)
        desktop = frm
    End Sub

#End Region

End Class
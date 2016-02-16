Public Class Printer

    Public Property Name As String
    Public Property Enabled As Boolean

    Public Sub New(ByVal pname As String, Optional penabled As Boolean = False)
        Name = pname
        Enabled = penabled
    End Sub

End Class

Public Class Printer

    Public Property Name As String
    Public Property Active As Boolean

    Public Sub New(ByVal pname As String, Optional pactive As Boolean = False)
        Name = pname
        Active = pactive
    End Sub

End Class

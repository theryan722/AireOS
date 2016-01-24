Imports System.Data.SqlClient
Imports System.Data.SQLite

Namespace Databases

    Public Class UserData
        Private Shared userdatadb As String = AppDomain.CurrentDomain.BaseDirectory & "\SysData\userdata.s3db"

        Public Shared Sub test()
            Dim cnn As New SQLiteConnection("Data Source=" & userdatadb)
        End Sub

    End Class

End Namespace
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Databases

    Public Class UserData

        Public Shared Sub AddUser(ByVal username As String, ByVal password As String, ByVal salt As String, ByVal datastorageloc As String, ByVal hidden As String, ByVal passwordhint As String, ByVal permissionlevel As String)
            Dim data As New Dictionary(Of [String], [String])()
            data.Add("USERNAME", username)
            data.Add("PASSWORD", password)
            data.Add("SALT", salt)
            data.Add("DATASTORAGELOC", datastorageloc)
            data.Add("HIDDEN", hidden)
            data.Add("PASSWORDHINT", passwordhint)
            data.Add("PERMISSIONLEVEL", permissionlevel)
            Try
                DBConnection.Insert("Users", data)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End Sub

        Public Shared Sub RemoveUser(ByVal username As String)
            DBConnection.Delete(username)
        End Sub

#Region "Modify"

        Public Shared Sub ModifyPassword(ByVal username As String, ByVal password As String)
            DBConnection.Update(username, """PASSWORD""", password)
        End Sub

#End Region

    End Class

End Namespace
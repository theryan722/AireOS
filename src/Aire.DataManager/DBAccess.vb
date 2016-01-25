Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Databases

    Public Class UserData

#Region "Add/Remove"

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

#End Region

#Region "Modify"

        Public Shared Sub ModifyPassword(ByVal username As String, ByVal password As String)
            DBConnection.Update(username, """PASSWORD""", password)
        End Sub

        Public Shared Sub ModifySalt(ByVal username As String, ByVal salt As String)
            DBConnection.Update(username, "SALT", salt)
        End Sub

        Public Shared Sub ModifyDataStorageLoc(ByVal username As String, ByVal datastorageloc As String)
            DBConnection.Update(username, "DATASTORAGELOC", datastorageloc)
        End Sub

        Public Shared Sub ModifyHidden(ByVal username As String, ByVal hidden As String)
            DBConnection.Update(username, "HIDDEN", hidden)
        End Sub

        Public Shared Sub ModifyPasswordHint(ByVal username As String, ByVal passwordhint As String)
            DBConnection.Update(username, "PASSWORDHINT", passwordhint)
        End Sub

        Public Shared Sub ModifyPermissionLevel(ByVal username As String, ByVal permissionlevel As String)
            DBConnection.Update(username, "PERMISSIONLEVEL", permissionlevel)
        End Sub

#End Region

#Region "Get"

        Public Shared Function GetIfUserExists(ByVal username As String) As Boolean
            Try
                Dim result As Integer
                Dim query As [String] = "SELECT EXISTS(SELECT 1 FROM USERS WHERE USERNAME='" & username & "');"
                result = CInt(DBConnection.ExecuteScalar(query))
                Return If(result = 1, True, False)
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetPassword(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT PASSWORD FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetSalt(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT SALT FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetDataStorageLoc(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT DATASTORAGELOC FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetHidden(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT HIDDEN FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetPasswordHint(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT PASSWORDHINT FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetPermissionLevel(ByVal username As String) As String
            Try
                Dim result As String
                Dim query As [String] = "SELECT PERMISSIONLEVEL FROM USERS WHERE USERNAME = '" & username & "';"
                result = DBConnection.ExecuteScalar(query)
                Return result
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
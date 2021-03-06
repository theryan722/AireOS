﻿Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Databases

    Public Class UserData

#Region "Add/Remove"

        Public Shared Sub AddUser(ByVal username As String, ByVal password As String, ByVal datastorageloc As String, ByVal hidden As String, ByVal passwordhint As String, ByVal permissionlevel As String)
            Dim data As New Dictionary(Of [String], [String])()
            data.Add("USERNAME", username)
            data.Add("PASSWORD", password)
            data.Add("DATASTORAGELOC", datastorageloc)
            data.Add("HIDDEN", hidden)
            data.Add("PASSWORDHINT", passwordhint)
            data.Add("PERMISSIONLEVEL", permissionlevel)
            Try
                DBUserData.Insert("Users", data)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End Sub

        Public Shared Sub RemoveUser(ByVal username As String)
            DBUserData.Delete(username)
        End Sub

#End Region

#Region "Modify"

        Public Shared Sub ModifyPassword(ByVal username As String, ByVal password As String)
            DBUserData.Update(username, """PASSWORD""", password)
        End Sub

        Public Shared Sub ModifyDataStorageLoc(ByVal username As String, ByVal datastorageloc As String)
            DBUserData.Update(username, "DATASTORAGELOC", datastorageloc)
        End Sub

        Public Shared Sub ModifyHidden(ByVal username As String, ByVal hidden As String)
            DBUserData.Update(username, "HIDDEN", hidden)
        End Sub

        Public Shared Sub ModifyPasswordHint(ByVal username As String, ByVal passwordhint As String)
            DBUserData.Update(username, "PASSWORDHINT", passwordhint)
        End Sub

        Public Shared Sub ModifyPermissionLevel(ByVal username As String, ByVal permissionlevel As String)
            DBUserData.Update(username, "PERMISSIONLEVEL", permissionlevel)
        End Sub

#End Region

#Region "Get"

        Public Shared Function GetAllUsers() As List(Of String)
            Try
                Dim recipe As DataTable
                Dim query As [String] = "select USERNAME ""Username"" FROM USERS"
                recipe = DBUserData.GetDataTable(query)
                Dim ret As New List(Of String)
                For Each r As DataRow In recipe.Rows
                    ret.Add(r("Username").ToString())
                Next
                Return ret
            Catch ex As Exception
                Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
                [error] += ex.Message.ToString() + vbLf & vbLf
                MessageBox.Show([error])
                Return Nothing
            End Try
        End Function

        Public Shared Function GetIfUserExists(ByVal username As String) As Boolean
            Try
                Dim result As Integer
                Dim query As [String] = "SELECT EXISTS(SELECT 1 FROM USERS WHERE USERNAME='" & username & "');"
                result = CInt(DBUserData.ExecuteScalar(query))
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
                result = DBUserData.ExecuteScalar(query)
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
                result = DBUserData.ExecuteScalar(query)
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
                result = DBUserData.ExecuteScalar(query)
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
                result = DBUserData.ExecuteScalar(query)
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
                result = DBUserData.ExecuteScalar(query)
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
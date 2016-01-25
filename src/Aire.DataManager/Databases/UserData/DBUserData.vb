Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms

Friend Class DBUserData
    Private Shared dbConnection As String = "Data Source=" & Helper.FixPath(AppDomain.CurrentDomain.BaseDirectory & "SysData/userdata.s3db")

    Public Shared Sub SetDatabase(inputFile As String)
        dbConnection = [String].Format("Data Source={0}", inputFile)
    End Sub

    ''' <summary>
    '''     Allows the programmer to run a query against the Database.
    ''' </summary>
    ''' <param name="sql">The SQL to run</param>
    ''' <returns>A DataTable containing the result set.</returns>
    Public Shared Function GetDataTable(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cnn As New SQLiteConnection(dbConnection)
            cnn.Open()
            Dim mycommand As New SQLiteCommand(cnn)
            mycommand.CommandText = sql
            Dim reader As SQLiteDataReader = mycommand.ExecuteReader()
            dt.Load(reader)
            reader.Close()
            cnn.Close()
        Catch e As Exception
            Throw New Exception(e.Message)
        End Try
        Return dt
    End Function

    ''' <summary>
    '''     Allows the programmer to interact with the database for purposes other than a query.
    ''' </summary>
    ''' <param name="sql">The SQL to be run.</param>
    ''' <returns>An Integer containing the number of rows updated.</returns>
    Public Shared Function ExecuteNonQuery(sql As String) As Integer
        Dim cnn As New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim rowsUpdated As Integer = mycommand.ExecuteNonQuery()
        cnn.Close()
        Return rowsUpdated
    End Function

    ''' <summary>
    '''     Allows the programmer to retrieve single items from the DB.
    ''' </summary>
    ''' <param name="sql">The query to run.</param>
    ''' <returns>A string.</returns>
    Public Shared Function ExecuteScalar(sql As String) As String
        Dim cnn As New SQLiteConnection(dbConnection)
        cnn.Open()
        Dim mycommand As New SQLiteCommand(cnn)
        mycommand.CommandText = sql
        Dim value As Object = mycommand.ExecuteScalar()
        cnn.Close()
        If value IsNot Nothing Then
            Return value.ToString()
        End If
        Return ""
    End Function

    Public Shared Function Update(ByVal username As String, ByVal item As String, ByVal replacewith As String) As Boolean
        Dim exec As String = "UPDATE USERS SET item = '" & replacewith & "' WHERE USERNAME = '" & username & "'"

        Dim returnCode As [Boolean] = True
        Try
            ExecuteNonQuery(exec)
        Catch
            returnCode = False
        End Try
        Return returnCode
    End Function

    Public Shared Function Delete(ByVal username As String)
        Dim exec As String = "DELETE FROM USERS WHERE USERNAME = '" & username & "'"
        Dim returnCode As [Boolean] = True
        Try
            ExecuteNonQuery(exec)
        Catch
            returnCode = False
        End Try
        Return returnCode
    End Function

    ''' <summary>
    '''     Allows the programmer to easily insert into the DB
    ''' </summary>
    ''' <param name="tableName">The table into which we insert the data.</param>
    ''' <param name="data">A dictionary containing the column names and data for the insert.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Shared Function Insert(tableName As [String], data As Dictionary(Of [String], [String])) As Boolean
        Dim columns As [String] = ""
        Dim values As [String] = ""
        Dim returnCode As [Boolean] = True
        For Each val As KeyValuePair(Of [String], [String]) In data
            columns += [String].Format(" {0},", val.Key.ToString())
            values += [String].Format(" '{0}',", val.Value)
        Next
        columns = columns.Substring(0, columns.Length - 1)
        values = values.Substring(0, values.Length - 1)
        Try
            ExecuteNonQuery([String].Format("insert into {0}({1}) values({2});", tableName, columns, values))
        Catch fail As Exception

            MessageBox.Show(fail.Message, "Error")
            returnCode = False
        End Try
        Return returnCode
    End Function

    ''' <summary>
    '''     Allows the programmer to easily delete all data from the DB.
    ''' </summary>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Shared Function ClearDB() As Boolean
        Dim tables As DataTable
        Try
            tables = GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;")
            For Each table As DataRow In tables.Rows
                ClearTable(table("NAME").ToString())
            Next
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    '''     Allows the user to easily clear all data from a specific table.
    ''' </summary>
    ''' <param name="table">The name of the table to clear.</param>
    ''' <returns>A boolean true or false to signify success or failure.</returns>
    Public Shared Function ClearTable(table As [String]) As Boolean
        Try
            ExecuteNonQuery([String].Format("delete from {0};", table))
            Return True
        Catch
            Return False
        End Try
    End Function
End Class
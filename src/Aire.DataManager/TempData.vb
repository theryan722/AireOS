Imports System.IO
Imports System.Text

Public Class TempData

    ''' <summary>
    ''' Gets the currently logged in user
    ''' </summary>
    ''' <value>The currently logged in user</value>
    ''' <returns>String, the username of the currently logged in user</returns>
    ''' <remarks></remarks>
    Public Shared Property LoggedInUser As String
        Get
            Return Aire.SMManager.Manager.ReadFile(DataPaths.GetSysDataLocation & "/Temp/currentuser.txt")
        End Get
        Set(value As String)
            Aire.SMManager.Manager.UpdateFile(DataPaths.GetSysDataLocation & "/Temp/currentuser.txt", value)
        End Set
    End Property

End Class

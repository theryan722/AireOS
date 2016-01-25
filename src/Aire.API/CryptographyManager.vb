Imports BCrypt.Net.BCrypt

Namespace Cryptography

    Public Class Passwords

        Public Shared Function HashPassword(ByVal pass As String, ByVal salt As String) As String
            Return BCrypt.Net.BCrypt.HashPassword(pass, salt)
        End Function

        Public Shared Function GenerateSalt() As String
            Return BCrypt.Net.BCrypt.GenerateSalt()
        End Function

        Public Shared Function CheckPassword(ByVal pass As String, ByVal hashedpass As String) As Boolean
            Return Verify(pass, hashedpass)
        End Function

    End Class

    Public Class Text

        Public Shared Function HashText(ByVal text As String) As String
            Return HashString(text)
        End Function

    End Class

End Namespace
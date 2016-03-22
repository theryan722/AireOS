Imports BCrypt.Net.BCrypt

Namespace Cryptography

    Public Class Passwords

        ''' <summary>
        ''' Hashes a password string
        ''' </summary>
        ''' <param name="pass">The password to hash</param>
        ''' <returns>String, the hashed password</returns>
        ''' <remarks></remarks>
        Public Shared Function HashPassword(ByVal pass As String) As String
            Return HashPassword(pass, GenerateSalt())
        End Function

        ''' <summary>
        ''' Hashes a password string
        ''' </summary>
        ''' <param name="pass">The password to hash</param>
        ''' <param name="salt">The salt to hash the password with</param>
        ''' <returns>String, the hashed password</returns>
        ''' <remarks></remarks>
        Public Shared Function HashPassword(ByVal pass As String, ByVal salt As String) As String
            Return BCrypt.Net.BCrypt.HashPassword(pass, salt)
        End Function

        ''' <summary>
        ''' Generates a salt
        ''' </summary>
        ''' <returns>String, the generated salt</returns>
        ''' <remarks></remarks>
        Public Shared Function GenerateSalt() As String
            Return BCrypt.Net.BCrypt.GenerateSalt()
        End Function

        ''' <summary>
        ''' Compares a password string to a hashed password and checks if they match
        ''' </summary>
        ''' <param name="pass">The password in plaintext</param>
        ''' <param name="hashedpass">The hashed password</param>
        ''' <returns>True, if the passwords match, otherwise false</returns>
        ''' <remarks></remarks>
        Public Shared Function CheckPassword(ByVal pass As String, ByVal hashedpass As String) As Boolean
            Dim res As Boolean = Verify(pass, hashedpass)
            If res Then
                Return True
            Else
                Threading.Thread.Sleep(2000)
                Return False
            End If
        End Function

    End Class

    Public Class Text

        ''' <summary>
        ''' Hashes a string
        ''' </summary>
        ''' <param name="text">The string to hash</param>
        ''' <returns>The hashed string</returns>
        ''' <remarks></remarks>
        Public Shared Function HashText(ByVal text As String) As String
            Return HashString(text)
        End Function

    End Class

End Namespace
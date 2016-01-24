Namespace Sys

    Namespace Logging

        Public Class Log

#Region "Enums"

            Enum LogSource
                General
                MessageBox
                System
            End Enum

#End Region

#Region "Methods"

            Public Shared Sub Write(ByVal message As String, Optional source As LogSource = LogSource.General)
                Select Case source
                    Case LogSource.General
                    Case LogSource.MessageBox
                    Case LogSource.System
                End Select
            End Sub

#End Region

        End Class

    End Namespace

End Namespace
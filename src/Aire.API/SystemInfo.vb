Namespace Sys

    Namespace Info

        Public Class OS

            Public Shared Function Name() As String

            End Function

            Public Shared Function Version() As String

            End Function

            Public Shared Function Release() As String

            End Function

        End Class

        Public Class Computer

            Public Shared Function Name() As String

            End Function

            Public Shared Function MachineName() As String

            End Function

            Public Shared Function TimeAlive() As Integer

            End Function

        End Class

        Public Class Network

            Public Shared Function IsAvailable() As Boolean

            End Function

        End Class

        Public Class Memory

            Public Shared Function TotalPhysicalMemory() As Integer

            End Function

            Public Shared Function TotalVirtualMemory() As Integer

            End Function

            Public Shared Function AvailablePhysicalMemory() As Integer

            End Function

            Public Shared Function AvailableVirtualMemory() As Integer

            End Function

        End Class

        Public Class Hardware

            Public Shared Function ProcessorCount() As Integer

            End Function

        End Class

    End Namespace

End Namespace
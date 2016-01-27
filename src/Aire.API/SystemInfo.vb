﻿Namespace Sys

    Namespace Info

        Public Class OS

            Public Shared Function Name() As String
                Return Aire.Info.Info.OSName
            End Function

            Public Shared Function Version() As String
                Return Aire.Info.Info.OSVersion
            End Function

            Public Shared Function Release() As String
                Return Aire.Info.Info.OSRelease
            End Function

        End Class

        Public Class Computer

            Public Shared Function Name() As String
                Return My.Computer.Name
            End Function

            Public Shared Function MachineName() As String
                Return Environment.MachineName
            End Function

            Public Shared Function TimeAwake() As Integer
                Return Environment.TickCount
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
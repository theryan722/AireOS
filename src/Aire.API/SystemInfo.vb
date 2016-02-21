Namespace Sys

    Namespace Info

        Public Class OS

            ''' <summary>
            ''' The name of the operating system
            ''' </summary>
            ''' <returns>String, the OS name</returns>
            ''' <remarks></remarks>
            Public Shared Function Name() As String
                Return Aire.Info.Info.OSName
            End Function

            ''' <summary>
            ''' The version of the operating system
            ''' </summary>
            ''' <returns>String, the version of the OS</returns>
            ''' <remarks></remarks>
            Public Shared Function Version() As String
                Return Aire.Info.Info.OSVersion
            End Function

            ''' <summary>
            ''' The release info of the operating system
            ''' </summary>
            ''' <returns>String, the release info of the OS</returns>
            ''' <remarks></remarks>
            Public Shared Function Release() As String
                Return Aire.Info.Info.OSRelease
            End Function

        End Class

        Public Class Computer

            ''' <summary>
            ''' The name of the computer
            ''' </summary>
            ''' <returns>String, the computer name</returns>
            ''' <remarks></remarks>
            Public Shared Function Name() As String
                Return My.Computer.Name
            End Function

            ''' <summary>
            ''' The name of the machine
            ''' </summary>
            ''' <returns>String, the machine name</returns>
            ''' <remarks></remarks>
            Public Shared Function MachineName() As String
                Return Environment.MachineName
            End Function

            ''' <summary>
            ''' The amount of time the system has been awake
            ''' </summary>
            ''' <returns>Integer, the time the system has been awake in milliseconds</returns>
            ''' <remarks></remarks>
            Public Shared Function TimeAwake() As Integer
                Return Environment.TickCount
            End Function

        End Class

        Public Class Network

            ''' <summary>
            ''' Whether or not a network connection is available
            ''' </summary>
            ''' <returns>True, if a network connection is available, otherwise false</returns>
            ''' <remarks></remarks>
            Public Shared Function IsAvailable() As Boolean
                Return My.Computer.Network.IsAvailable
            End Function

        End Class

        Public Class Memory

            ''' <summary>
            ''' Gets the total physical memory
            ''' </summary>
            ''' <returns>Integer, the total physical memory</returns>
            ''' <remarks></remarks>
            Public Shared Function TotalPhysicalMemory() As Integer
                Return My.Computer.Info.TotalPhysicalMemory
            End Function

            ''' <summary>
            ''' Gets the total virtual memory
            ''' </summary>
            ''' <returns>Integer, the total virtual memory</returns>
            ''' <remarks></remarks>
            Public Shared Function TotalVirtualMemory() As Integer
                Return My.Computer.Info.TotalVirtualMemory
            End Function

            ''' <summary>
            ''' Gets the available physical memory
            ''' </summary>
            ''' <returns>Integer, the available physical memory</returns>
            ''' <remarks></remarks>
            Public Shared Function AvailablePhysicalMemory() As Integer
                Return My.Computer.Info.AvailablePhysicalMemory
            End Function

            ''' <summary>
            ''' Gets the available virtual memory
            ''' </summary>
            ''' <returns>Integer, the available virtual memory</returns>
            ''' <remarks></remarks>
            Public Shared Function AvailableVirtualMemory() As Integer
                Return My.Computer.Info.AvailableVirtualMemory
            End Function

        End Class

        Public Class Hardware

            ''' <summary>
            ''' Gets the amount of processors
            ''' </summary>
            ''' <returns>Integer, the amount of processors</returns>
            ''' <remarks></remarks>
            Public Shared Function ProcessorCount() As Integer
                Return Environment.ProcessorCount
            End Function

        End Class

    End Namespace

End Namespace
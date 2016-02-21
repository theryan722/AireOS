Public Class Printer

    ''' <summary>
    ''' The name of the printer
    ''' </summary>
    ''' <value>The name of the printer</value>
    ''' <returns>String, the name of the printer</returns>
    ''' <remarks></remarks>
    Public Property Name As String

    ''' <summary>
    ''' Whether the printer is enabled or not
    ''' </summary>
    ''' <value>Whether the printer is enabled or not</value>
    ''' <returns>True, if the printer is enabled, otherwise false</returns>
    ''' <remarks></remarks>
    Public Property Enabled As Boolean

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="pname">The name of the printer</param>
    ''' <param name="penabled">Whether the printer is enabled or not</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pname As String, Optional penabled As Boolean = True)
        Name = pname
        Enabled = penabled
    End Sub

End Class

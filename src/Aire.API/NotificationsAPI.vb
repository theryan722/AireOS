Namespace Notifications

    Public Class MessageBox
        Private mresponse As MessageBoxResponse

        Public Function Response() As MessageBoxResponse
            Return mresponse
        End Function

        Enum MessageBoxResponse
            Yes
            No
            Cancel
            Ok
            Retry
        End Enum

        Enum MessageBoxIcon
            Information
            Warning
            Alert
            Critical
            Question
            None
        End Enum

        Enum MessageBoxButtons
            OkOnly
            OkCancel
            YesNo
            YesNoCancel
            RetryCancel

        End Enum

        Public Sub New(ByVal text As String, Optional ByVal title As String = "", Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.None, Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OkOnly)

        End Sub

    End Class

End Namespace
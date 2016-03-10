Public Class ConfigManager

#Region "Enums"

    Public Enum FileViewStyle
        ExtraLargeIcons
        LargeIcons
        MediumIcons
        SmallIcons
        List
    End Enum

#End Region

#Region "Properties"

    Public Property ViewStyle As FileViewStyle

    Public Property Topmost As Boolean

    Public Property Sidebar As Boolean

    Public Property NavigationPane As Boolean

#End Region

End Class

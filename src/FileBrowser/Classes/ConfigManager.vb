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

    Public Shared Property ViewStyle As FileViewStyle

    Public Shared Property Topmost As Boolean

    Public Shared Property Sidebar As Boolean

    Public Shared Property NavigationPane As Boolean

    Public Shared Property SearchIsCaseSensitive As Boolean

#End Region

End Class

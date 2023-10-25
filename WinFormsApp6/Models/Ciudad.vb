Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Ciudad
        Public Property Id As Integer

        Public Property Nombre As String

        Public Property IdPais As Integer?

        Public Overridable Property IdPaisNavigation As Pai
    End Class
End Namespace

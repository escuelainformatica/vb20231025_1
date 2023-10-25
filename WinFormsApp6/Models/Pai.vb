Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Pai
        Public Property Id As Integer

        Public Property Nombre As String

        Public Overridable ReadOnly Property Ciudads As ICollection(Of Ciudad) = New List(Of Ciudad)()
    End Class
End Namespace

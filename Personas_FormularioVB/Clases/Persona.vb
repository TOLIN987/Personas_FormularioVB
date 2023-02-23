Imports System

Namespace Personas_Formulario
    Friend Class Persona
        Protected nombre As String
        Protected fechaNacimiento As DateTime?

        Public Property _Nombre As String
            Get
                Return nombre
            End Get
            Set(ByVal value As String)
                nombre = value
            End Set
        End Property

        Public Property _FechaNacimiento As DateTime?
            Get
                Return fechaNacimiento
            End Get
            Set(ByVal value As DateTime?)
                fechaNacimiento = value
            End Set
        End Property

        Public ReadOnly Property _Edad As Integer
            Get
                Dim edad As Integer
                edad = DateTime.Now.Year - fechaNacimiento.Value.Year
                Return edad
            End Get
        End Property

        Public Sub New()
            nombre = String.Empty
            fechaNacimiento = Nothing
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
            Me.nombre = nombre
            Me.fechaNacimiento = fechaNacimiento
        End Sub
    End Class
End Namespace


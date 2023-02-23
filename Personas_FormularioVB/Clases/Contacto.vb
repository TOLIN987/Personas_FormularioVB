Imports System.Windows.Forms

Namespace Personas_Formulario
    Friend Class Contacto
        Inherits Persona

        Private telefono As String
        Private correo As String

        Public Property _Telefono As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public Property _Correo As String
            Get
                Return correo
            End Get
            Set(ByVal value As String)
                correo = value
            End Set
        End Property
    End Class
End Namespace


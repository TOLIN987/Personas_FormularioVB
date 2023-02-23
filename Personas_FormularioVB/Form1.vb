Imports Personas_FormularioVB.Personas_Formulario

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private arreglocontactos As Contacto()
    Private Sub txtCantidadcontactos_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso txtCantidadcontactos.Text.Contains("."c) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnempezar_Click(sender As Object, e As EventArgs) Handles btnempezar.Click
        If txtCantidadcontactos.Text.Contains("."c) AndAlso txtCantidadcontactos.Text.Contains(Nothing) Then
            MessageBox.Show("Ingrese un numero entero")
            txtCantidadcontactos.Clear()
            Return
        End If

        If Not txtCantidadcontactos.Text.Contains("."c) Then
            txtCantidadcontactos.Enabled = False
        End If

        Dim cantidadContactos As Integer = Integer.Parse(txtCantidadcontactos.Text)
        arreglocontactos = New Contacto(cantidadContactos - 1) {}
        txtcorreo.Visible = True
        txtnombre.Visible = True
        txttelefono.Visible = True
        dtpFechanacimiento.Visible = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim cantidadContactos As Integer = Integer.Parse(txtCantidadcontactos.Text)
        Dim validacion As Boolean = False
        validacion = Validar(txtcorreo.Text)

        If validacion = False Then
            MessageBox.Show("Ingrese un correo valido")
            txtcorreo.Clear()
            Return
        End If

        For i = 0 To cantidadContactos - 1
            arreglocontactos(i) = New Contacto()


            If validacion = True Then

                arreglocontactos(i)._FechaNacimiento = DateTime.Parse(dtpFechanacimiento.Text)
                arreglocontactos(i)._Nombre = txtnombre.Text
                arreglocontactos(i)._Telefono = txttelefono.Text
                arreglocontactos(i)._Correo = txtcorreo.Text
                dtpFechanacimiento.Value = DateTime.Now
                txtnombre.Clear()
                txttelefono.Clear()
                txtcorreo.Clear()
            End If
        Next
    End Sub
    Public Function Validar(ByVal correo As String) As Boolean
        If String.IsNullOrEmpty(correo) Then
            Return False
        End If

        If Not correo.Contains("@") Then
            Return False
        End If

        Dim partesCorreo As String() = correo.Split("@"c)

        If partesCorreo.Length <> 2 Then
            Return False
        End If

        If String.IsNullOrEmpty(partesCorreo(0)) OrElse String.IsNullOrEmpty(partesCorreo(1)) Then
            Return False
        End If

        If partesCorreo(1).IndexOf(".") = -1 Then
            Return False
        End If

        Return True
    End Function
End Class

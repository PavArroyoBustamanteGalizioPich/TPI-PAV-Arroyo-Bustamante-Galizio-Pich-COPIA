Public Class gestionClientes


    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDatosCliente.Enabled = False
        gbDatosComputadora.Enabled = False
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        gbDatosCliente.Enabled = True
        gbDatosComputadora.Enabled = True
        btnNuevoCliente.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim msjError As String = ""

        If (txtApellido.Text.Equals("")) Then
            msjError &= "- El apellido no puede quedar vacío!" & vbCrLf
        End If

        If (txtNombre.Text.Equals("")) Then
            msjError &= "- El nombre no puede quedar vacío!" & vbCrLf
        End If

        If (txtNroDocumento.Text.Equals("")) Then
            msjError &= "- El número de documento no puede quedar vacío!" & vbCrLf
        ElseIf txtNroDocumento.Text.Length < 8 Then
            msjError &= "- El número de documento ingresado no es válido"
        End If

        ' esta validación es valida unicamente para los dni, para LE o LC son 7 num segudo del genero M o F


        If (txtTelefono.Text.Equals("")) Then
            msjError &= "- El teléfono no puede quedar vacío!" & vbCrLf
        ElseIf txtTelefono.Text.Length < 5 Then
            msjError &= "- El teléfono ingresado no es válido"
        End If



        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress, txtTelefono.KeyPress, txtCantMemoria.KeyPress, txtCapAlm.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
            e.Handled = True
        End If

    End Sub



End Class
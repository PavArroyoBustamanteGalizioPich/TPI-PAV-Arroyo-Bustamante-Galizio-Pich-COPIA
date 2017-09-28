Public Class ACEstadoOt


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If validarDatos() Then
            Dim estado As New TiposVo
            estado.id = Convert.ToInt32(txtIdEstado.Text)
            estado.nombreTipo = txtEstado.Text
            estado.descripcionTipo = txtDescripEstado.Text
            Dim cant As Int32 = EstadoOtDao.insertarEstado(estado)

            If cant = 1 Then
                MessageBox.Show("El estado ha sido insertado")
                txtDescripEstado.Text = ""
                txtEstado.Text = ""
                txtIdEstado.Text = ""
                txtEstado.Enabled = False
                txtDescripEstado.Enabled = False
                btnGuardar.Enabled = False
            Else
                MessageBox.Show("Error al insertar el estado")
            End If
        End If
    End Sub


    Private Sub ACEstadoOt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdEstado.Enabled = False
        txtEstado.Enabled = False
        txtDescripEstado.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnNvoEstado_Click(sender As Object, e As EventArgs) Handles btnNvoEstado.Click
        txtIdEstado.Text = Utilidades.sugerirId("estadoOrdenTrabajo", "idEstado")
        txtEstado.Enabled = True
        txtDescripEstado.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Function validarDatos() As Boolean
        Dim e As String = ""
        If txtEstado.Text.Equals("") Then
            e &= "El nombre del estado no puede estar vacío"
        End If
        If txtDescripEstado.Text.Equals("") Then
            e &= "La descripción del estado no puede estar vacía"
        End If
        If e.Equals("") Then
            Return True
        Else
            MessageBox.Show(e, "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress, txtDescripEstado.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub


End Class
Public Class ABMTipoRepuesto
    Implements Buscable

    Private tipoRepuestoBuscado As Boolean
    Private filaBuscada As DataGridViewRow
    Private Sub ABMTipoRepuesto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub txtTipoRepuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoRepuesto.KeyPress, txtDesc.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub ABMTipoRepuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, btnBuscar.KeyUp, btnCancelar.KeyUp, btnGuardar.KeyUp, btnNuevo.KeyUp, txtDesc.KeyUp, txtIdRepuesto.KeyUp, txtTipoRepuesto.KeyUp

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtTipoRepuesto.Enabled = False
        txtDesc.Enabled = False
        btnGuardar.Enabled = False


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdRepuesto.Enabled = False
        txtTipoRepuesto.Enabled = True
        txtDesc.Enabled = True
        btnGuardar.Enabled = True
        txtTipoRepuesto.Text = ""
        txtDesc.Text = ""
        txtIdRepuesto.Text = Utilidades.sugerirId("tipoComponente", "idTipoComponente")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdRepuesto.Enabled = True
        txtIdRepuesto.Text = ""
        txtTipoRepuesto.Enabled = False
        txtTipoRepuesto.Text = ""
        txtDesc.Enabled = False
        txtDesc.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarDatos() Then
            Dim tipoRepuesto As New TiposDto
            tipoRepuesto.id = Convert.ToInt32(txtIdRepuesto.Text)
            tipoRepuesto.nombreTipo = txtTipoRepuesto.Text
            tipoRepuesto.descripcionTipo = txtDesc.Text
            If Not tipoRepuestoBuscado Then
                Dim cant As Int32 = TipoRepuestoDao.insertarTipoRepuesto(tipoRepuesto)
                If cant = 1 Then
                    MessageBox.Show("Tipo Repuesto insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdRepuesto.Text = Utilidades.sugerirId("tipoComponente", "idTipoComponente")
                    txtTipoRepuesto.Text = ""
                    txtDesc.Text = ""

                Else : MessageBox.Show("No se pudo insertar el tipo de repuesto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                Dim cant As Int32 = TipoRepuestoDao.actualizarTipoCompinente(tipoRepuesto)
                If cant = 1 Then
                    MessageBox.Show("El registro se ha actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdRepuesto.Text = ""
                    txtTipoRepuesto.Text = ""
                    txtDesc.Text = ""
                    btnGuardar.Enabled = False
                    txtIdRepuesto.Enabled = True
                    txtTipoRepuesto.Enabled = False
                    txtDesc.Enabled = False
                    tipoRepuestoBuscado = False
                    btnBuscar.Enabled = True
                Else : MessageBox.Show("El registro no pudo ser actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        End If

    End Sub




    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not txtIdRepuesto.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdRepuesto.Text)
            Dim tipoRepuesto As TiposDto = TipoRepuestoDao.buscarTipoComponente(id)
            If Not IsNothing(tipoRepuesto.id) Then
                btnGuardar.Enabled = True
                txtIdRepuesto.Enabled = False
                txtTipoRepuesto.Enabled = True
                txtDesc.Enabled = True
                txtIdRepuesto.Text = tipoRepuesto.id
                txtTipoRepuesto.Text = tipoRepuesto.nombreTipo
                txtDesc.Text = tipoRepuesto.descripcionTipo
                tipoRepuestoBuscado = True
            End If

        Else
            Dim grilla As New grillaGenerica("Tipos de Repuesto", grillaGenerica.formularios.TIPO_REPUESTO, Me)
            grilla.ShowDialog()
            If Not IsNothing(filabuscada) Then
                txtIdRepuesto.Enabled = False
                txtTipoRepuesto.Enabled = True
                txtDesc.Enabled = True
                txtIdRepuesto.Text = filaBuscada.Cells(0).Value.ToString()
                txtTipoRepuesto.Text = filaBuscada.Cells(1).Value.ToString()
                txtDesc.Text = filaBuscada.Cells(2).Value.ToString()
                tipoRepuestoBuscado = True
                btnGuardar.Enabled = True
                filabuscada = Nothing

            End If


        End If
    End Sub


    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filabuscada = fila

    End Sub

    Private Function validarDatos() As Boolean
        Dim mensaje As String = ""

        If txtIdRepuesto.Text = "" Then
            mensaje = "Ingrese ID!" & vbCrLf

        End If


        If txtTipoRepuesto.Text = "" Then
            mensaje = "Ingrese Tipo de Repuesto!" & vbCrLf

        End If

        If txtDesc.Text = "" Then
            mensaje = "Ingrese una descripción del tipo de Repuesto!" & vbCrLf

            Return False
        End If

        If Not mensaje.Equals("") Then
            MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True

    End Function



    Private Sub txtTipoRepuesto_TextChanged(sender As Object, e As EventArgs) Handles txtTipoRepuesto.TextChanged

    End Sub
End Class

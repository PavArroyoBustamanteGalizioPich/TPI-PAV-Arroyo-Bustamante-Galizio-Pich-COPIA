Public Class ABMServicio
    Implements Buscable

    Private servicioSeleccionado As DataGridViewRow
    Private servicioActual As ServicioDto

    Private Sub txtNombreServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreServicio.KeyPress, txtDescripServ.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub


    Private Sub ABMServicio_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, txtIdServicio.KeyUp, txtCostoServicio.KeyUp, txtDescripServ.KeyUp, txtGarantiaServ.KeyUp, txtNombreServicio.KeyUp, btnActualizar.KeyUp, btnBuscar.KeyUp, btnCancelar.KeyUp, btnGuardar.KeyUp, btnNuevo.KeyUp, cbRepRequerido.KeyUp, chkEstadoServicio.KeyUp

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ABMServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombreServicio.Enabled = False
        txtCostoServicio.Enabled = False
        txtDescripServ.Enabled = False
        txtGarantiaServ.Enabled = False
        cbRepRequerido.Enabled = False
        chkEstadoServicio.Enabled = False
        btnGuardar.Enabled = False
        btnActualizar.Enabled = False
        txtFechaBaja.Enabled = False
        Utilidades.cargarCombo("tipoComponente", cbRepRequerido)
        cbRepRequerido.SelectedValue = -1


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdServicio.Enabled = False
        txtCostoServicio.Enabled = True
        txtGarantiaServ.Enabled = True
        txtNombreServicio.Enabled = True
        txtDescripServ.Enabled = True
        cbRepRequerido.Enabled = True
        btnGuardar.Enabled = True
        Me.limpiarComponentes()
        txtIdServicio.Text = Utilidades.sugerirId("servicio", "idServicio")
        txtNombreServicio.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If Not txtIdServicio.Text.Equals("") Then
            servicioActual = ServicioDao.buscarServicio(Convert.ToInt32(txtIdServicio.Text))
            If IsNothing(servicioActual) Then
                MessageBox.Show("El id de servicio ingresado no corresponde a un servicio registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else

            Try
                Dim mostrarGrilla As New GrillaGenerica("Servicios", GrillaGenerica.formularios.SERVICIO, Me)
                mostrarGrilla.ShowDialog()
                If Not servicioSeleccionado.Equals(Nothing) Then
                    servicioActual = New ServicioDto
                    servicioActual.idServ = Convert.ToInt32(servicioSeleccionado.Cells(0).Value)
                    servicioActual.nomServicio = servicioSeleccionado.Cells(1).Value
                    servicioActual.detalleServicio = servicioSeleccionado.Cells(2).Value
                    servicioActual.costoServicio = Convert.ToSingle(servicioSeleccionado.Cells(3).Value)
                    servicioActual.garantiaServicio = Convert.ToInt32(servicioSeleccionado.Cells(4).Value)
                    If Not IsDBNull(servicioSeleccionado.Cells(5).Value) Then
                        servicioActual.fechaBajaServicio = CDate(servicioSeleccionado.Cells(5).Value)
                    Else : servicioActual.fechaBajaServicio = Nothing
                    End If
                    If Not IsDBNull(servicioSeleccionado.Cells(6).Value) Then
                        servicioActual.repuestoReq = Convert.ToInt32(servicioSeleccionado.Cells(6).Value)
                    End If
                End If
            Catch ex As Exception

            End Try

        End If
        If Not IsNothing(servicioActual) Then
            txtIdServicio.Enabled = False
            btnActualizar.Enabled = True
            txtCostoServicio.Enabled = True
            txtGarantiaServ.Enabled = True
            chkEstadoServicio.Enabled = True
            txtIdServicio.Text = servicioActual.idServ
            txtNombreServicio.Text = servicioActual.nomServicio
            txtCostoServicio.Text = servicioActual.costoServicio
            txtDescripServ.Text = servicioActual.detalleServicio
            txtGarantiaServ.Text = servicioActual.garantiaServicio
            If servicioActual.repuestoReq.Equals(Nothing) Then
                cbRepRequerido.SelectedValue = -1
            Else : cbRepRequerido.SelectedValue = servicioActual.repuestoReq
            End If
            If Not servicioActual.fechaBajaServicio.Equals(Nothing) Then
                chkEstadoServicio.Text = "Inactivo"
                chkEstadoServicio.Checked = False
                txtFechaBaja.Text = servicioActual.fechaBajaServicio.ToString("dd/MM/yyyy")

            Else
                chkEstadoServicio.Checked = True
                chkEstadoServicio.Text = "Activo"
            End If


        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.desabilitarComponentes()
        Me.limpiarComponentes()
        servicioActual = Nothing
        btnNuevo.Focus()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not txtCostoServicio.Text = "" And Not txtGarantiaServ.Text = "" Then
            servicioActual.garantiaServicio = Convert.ToInt32(txtGarantiaServ.Text)
            servicioActual.costoServicio = Convert.ToSingle(txtCostoServicio.Text)

            If chkEstadoServicio.Checked Then
                servicioActual.fechaBajaServicio = Nothing
            End If

            If ServicioDao.actualizarServicio(servicioActual) = 1 Then
                MessageBox.Show("El registro se actualzó correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                desabilitarComponentes()
                limpiarComponentes()
                servicioActual = Nothing
            Else : MessageBox.Show("Ocurrió un error al actualizar el registro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else : MessageBox.Show("El costo del servicio y la garantía no pueden quedar vacios", "Datos incompletos!", MessageBoxButtons.OK)
        End If
    End Sub

    Public Function validarDatos() As Boolean
        Dim msjError As String = ""
        If txtNombreServicio.Text.Equals("") Then
            msjError &= "El nombre del servicio no puede quedar vacio!" & vbCrLf
        End If
        If txtDescripServ.Text.Equals("") Then
            msjError &= "La descripción del servicio no puede quedar vacio!" & vbCrLf
        End If

        If txtCostoServicio.Text.Equals("") Then
            msjError &= "El costo del servicio no puede quedar vacio!" & vbCrLf
        End If

        If txtGarantiaServ.Text.Equals("") Then
            txtGarantiaServ.Text = "0"
        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Datos incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarDatos() Then
            Dim servicio As New ServicioDto

            servicio.idServ = Convert.ToInt32(txtIdServicio.Text)
            servicio.nomServicio = txtNombreServicio.Text
            servicio.detalleServicio = txtDescripServ.Text
            servicio.costoServicio = Convert.ToSingle(txtCostoServicio.Text)
            servicio.garantiaServicio = Convert.ToInt32(txtGarantiaServ.Text)
            If cbRepRequerido.SelectedValue = -1 Then
                servicio.repuestoReq = Nothing
            Else
                servicio.repuestoReq = cbRepRequerido.SelectedValue
            End If

            If ServicioDao.insertarServicio(servicio) = 1 Then
                MessageBox.Show("Servicio registrado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.limpiarComponentes()
                Me.desabilitarComponentes()
                txtIdServicio.Enabled = True
                btnGuardar.Enabled = False
            Else : MessageBox.Show("No se pudo registrar el servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        End If
    End Sub


    Private Sub desabilitarComponentes()
        txtIdServicio.Enabled = True
        txtNombreServicio.Enabled = False
        txtCostoServicio.Enabled = False
        txtDescripServ.Enabled = False
        txtGarantiaServ.Enabled = False
        cbRepRequerido.Enabled = False
        chkEstadoServicio.Enabled = False
        btnGuardar.Enabled = False
        btnActualizar.Enabled = False
        txtFechaBaja.Enabled = False
        cbRepRequerido.SelectedValue = -1

    End Sub

    Private Sub limpiarComponentes()
        txtCostoServicio.Text = ""
        txtDescripServ.Text = ""
        txtIdServicio.Text = ""
        txtNombreServicio.Text = ""
        txtFechaBaja.Text = ""
        txtGarantiaServ.Text = ""
        cbRepRequerido.SelectedValue = -1
        chkEstadoServicio.Checked = True

    End Sub

  
    Public Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        servicioSeleccionado = fila
    End Sub

    
    Private Sub chkEstadoServicio_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoServicio.CheckedChanged
        If chkEstadoServicio.Checked = False Then
            chkEstadoServicio.Text = "Inactivo"
            If servicioActual.fechaBajaServicio.Equals(Nothing) Then
                txtFechaBaja.Text = Date.Today.ToString("dd/MM/yyyy")
                servicioActual.fechaBajaServicio = Date.Now
            Else : txtFechaBaja.Text = servicioActual.fechaBajaServicio.ToString("dd/MM/yyyy")
            End If

        Else
            chkEstadoServicio.Text = "Activo"
            'servicioActual.fechaBajaServicio = Nothing
            txtFechaBaja.Text = ""

        End If
    End Sub

    Private Sub txtGarantiaServ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGarantiaServ.KeyPress, txtCostoServicio.KeyPress, txtIdServicio.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub

   
    Private Sub txtNombreServicio_TextChanged(sender As Object, e As EventArgs) Handles txtNombreServicio.TextChanged

    End Sub

    Private Sub cbRepRequerido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRepRequerido.SelectedIndexChanged

    End Sub
End Class
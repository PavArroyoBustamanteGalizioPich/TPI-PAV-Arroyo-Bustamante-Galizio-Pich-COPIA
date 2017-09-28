Public Class ABMCRepuesto
    Implements Buscable

    Private repuestoBuscado As Boolean
    Private repuestoActual As RepuestoVo
    Private filaBuscada As DataGridViewRow

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.deshabilitarComponentes()
        Utilidades.cargarCombo("proveedor", CBProveedor)
        Utilidades.cargarCombo("tipoComponente", cbTipo)
        Utilidades.cargarCombo("marcaComponente", cbMarca)
        repuestoBuscado = False
        btnNuevo.Focus()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiarComponentes()
        Me.habilitarComponentes()
        txtId.Text = Utilidades.sugerirId("componente", "idComponente")
        txtId.Enabled = False
        txtFechaCompra.Text = Date.Today.ToString("dd/MM/yyyy")
        btnBuscar.Enabled = False
        cbTipo.Focus()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If Not txtId.Text.Equals("") Then
            'parte buscar uno
            Dim id As Int32 = Convert.ToInt32(txtId.Text)
            repuestoActual = RepuestoDao.buscarRepuesto(id)
            If IsNothing(repuestoActual) Then

                MessageBox.Show("El Id ingresado no corresponde con un repuesto registrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtId.Focus()

            End If

        Else
            Dim grilla As New grillaGenerica("Listado de Repuestos", grillaGenerica.formularios.REPUESTO, Me)
            grilla.ShowDialog()
            If Not IsNothing(filaBuscada) Then
                repuestoActual = New RepuestoVo
                repuestoActual.id = Convert.ToInt32(filaBuscada.Cells(0).Value)
                repuestoActual.descripcion = filaBuscada.Cells(1).Value.ToString()
                repuestoActual.idMarca = Convert.ToInt32(filaBuscada.Cells(2).Value)
                repuestoActual.nombreMarca = filaBuscada.Cells(3).Value.ToString()
                repuestoActual.tipo = Convert.ToInt32(filaBuscada.Cells(4).Value)
                repuestoActual.proveedor = Convert.ToInt32(filaBuscada.Cells(6).Value)
                repuestoActual.garantia = Convert.ToInt32(filaBuscada.Cells(8).Value)
                repuestoActual.precioCompra = Convert.ToDecimal(filaBuscada.Cells(9).Value)
                repuestoActual.porcentajeGanancia = Convert.ToInt32(filaBuscada.Cells(10).Value)
                repuestoActual.fechaCompra = CDate(filaBuscada.Cells(11).Value)

            End If
        End If

        If Not IsNothing(repuestoActual) Then
            repuestoBuscado = True
            txtId.Text = repuestoActual.id
            txtDescripcion.Text = repuestoActual.descripcion
            cbTipo.SelectedValue = repuestoActual.idMarca
            cbMarca.SelectedValue = repuestoActual.idMarca
            txtPrecio.Text = repuestoActual.precioCompra
            txtPorcentaje.Text = repuestoActual.porcentajeGanancia
            CBProveedor.SelectedValue = repuestoActual.proveedor
            txtGarantia.Text = repuestoActual.garantia
            txtFechaCompra.Text = repuestoActual.fechaCompra.ToString("dd/MM/yyyy")
            Me.habilitarComponentes()
            txtId.Enabled = False
            cbMarca.Enabled = False
            txtDescripcion.Enabled = False
            cbTipo.Enabled = False
            btnBuscar.Enabled = False

        End If


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarDatos() Then
            If Not repuestoBuscado Then
                'parte de insercion
                Dim cant As Int32
                Dim repuesto As New RepuestoVo
                repuesto.id = Convert.ToInt32(txtId.Text)
                repuesto.descripcion = txtDescripcion.Text.Trim()
                repuesto.tipo = cbTipo.SelectedValue
                If Not IsNothing(cbMarca.SelectedValue) Then
                    repuesto.idMarca = cbMarca.SelectedValue
                Else
                    repuesto.idMarca = 0
                    repuesto.nombreMarca = cbMarca.Text
                End If

                repuesto.precioCompra = Convert.ToDecimal(txtPrecio.Text)
                repuesto.porcentajeGanancia = Convert.ToInt32(txtPorcentaje.Text.Trim())
                repuesto.proveedor = CBProveedor.SelectedValue
                repuesto.garantia = Convert.ToInt32(txtGarantia.Text.Trim())
                repuesto.fechaCompra = CDate(txtFechaCompra.Text)

                cant = RepuestoDao.insertarRepuesto(repuesto)
                If cant = 1 Then
                    MessageBox.Show("El repuesto fue insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnNuevo.PerformClick()

                Else
                    If cant = -1 Then
                        MessageBox.Show("Ocurrio un error al insertar la marca del repuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        cbMarca.Focus()
                    Else
                        MessageBox.Show("Ocurrió un error al insertar el repuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If


            Else
                'parte de actualizacion
                repuestoActual.precioCompra = Convert.ToDecimal(txtPrecio.Text.Trim())
                repuestoActual.porcentajeGanancia = Convert.ToInt32(txtPorcentaje.Text())
                repuestoActual.proveedor = CBProveedor.SelectedValue
                repuestoActual.garantia = Convert.ToInt32(txtGarantia.Text.Trim())
                repuestoActual.fechaCompra = CDate(txtFechaCompra.Text)

                Dim cantFilas As Int32 = RepuestoDao.actualizarRepuesto(repuestoActual)
                If cantFilas = 1 Then
                    MessageBox.Show("El registro se actualizó correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.deshabilitarComponentes()
                    Me.limpiarComponentes()
                    txtId.Enabled = True
                    btnBuscar.Enabled = True
                    btnNuevo.Focus()
                    repuestoActual = Nothing
                Else : MessageBox.Show("Ocurrió un error al actualizar el registro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        End If

    End Sub







    Private Function validarDatos() As Boolean

        Dim msjError As String = ""

        If txtDescripcion.Text.Equals("") Then
            msjError &= "La descripción del repuesto no puede estar vacía!" & vbCrLf
        End If

        If txtPrecio.Text.Equals("") Then
            msjError &= "El precio de compra no puede estar vacío!" & vbCrLf
        Else
            If Not IsNumeric(txtPrecio.Text) Then
                msjError &= "El precio ingresado no es válido!" & vbCrLf
            End If
        End If

        If txtGarantia.Text.Equals("") Then
            txtGarantia.Text = "0"
        End If

        If txtPorcentaje.Text.Equals("") Then
            txtPorcentaje.Text = "10"
        End If


        If Not IsDate(txtFechaCompra.Text) Then
            msjError &= "La fecha ingresada no es una fecha válida!" & vbCrLf
            txtFechaCompra.Text = Date.Today.ToString("dd/MM/yyyy")
        Else
            If CDate(txtFechaCompra.Text) > Date.Today Then
                msjError &= "La fecha ingresada no es válida!" & vbCrLf
            End If
        End If

        If cbMarca.Text.Equals("") Then
            msjError &= "La marca del repuesto no puede quedar vacía!" & vbCrLf
        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Datos Invalidos!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True


    End Function

    Private Sub deshabilitarComponentes()
        txtDescripcion.Enabled = False
        txtGarantia.Enabled = False
        txtPorcentaje.Enabled = False
        txtPrecio.Enabled = False
        txtFechaCompra.Enabled = False
        btnGuardar.Enabled = False
        CBProveedor.Enabled = False
        cbTipo.Enabled = False
        cbMarca.Enabled = False

    End Sub

    Private Sub habilitarComponentes()
        txtId.Enabled = False
        txtDescripcion.Enabled = True
        txtGarantia.Enabled = True
        txtPorcentaje.Enabled = True
        txtPrecio.Enabled = True
        txtFechaCompra.Enabled = True
        btnGuardar.Enabled = True
        CBProveedor.Enabled = True
        cbTipo.Enabled = True
        cbMarca.Enabled = True

    End Sub


    Private Sub limpiarComponentes()
        txtId.Text = ""
        txtDescripcion.Text = ""
        txtGarantia.Text = ""
        txtPorcentaje.Text = ""
        txtPrecio.Text = ""
        txtFechaCompra.Text = ""
        cbMarca.SelectedValue = -1
        CBProveedor.SelectedValue = 1
        cbTipo.SelectedValue = 1
    End Sub


    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress, txtGarantia.KeyPress, txtPorcentaje.KeyPress

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then

            e.Handled = True
        End If

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then

            e.Handled = True
        End If

    End Sub


    
   
   
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.limpiarComponentes()
        Me.deshabilitarComponentes()
        btnBuscar.Enabled = True
        txtId.Enabled = True
        btnNuevo.Focus()
    End Sub
End Class
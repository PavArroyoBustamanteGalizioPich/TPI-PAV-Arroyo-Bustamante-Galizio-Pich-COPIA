Public Class ABMCOrdenTrabajo

    Private cliente As ClienteDto
    Private computadora As ComputadoraDto
    Private servicioSeleccionado As ServicioDto
    'Private repuestoSeleccionado As RepuestoDto
    Private serviciosAgregados As Collections.ArrayList
    Private ordenActual As OrdenTrabajoDto
    'Private repuestosAgregados As Collections.ArrayList

    Private compusCargadas As Boolean
    Private combosCargados As Boolean
    Private comboRepuestosCargado As Boolean


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        serviciosAgregados = New ArrayList



        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub RegistroOT2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("Seguro que desea salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub



    Private Sub RegistroOT2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gbDatosCliOT.Enabled = False
        panelDatosNvaOt.Enabled = False

        btnGuardarOt.Enabled = False
        btnCancelarOt.Enabled = False
        btnActualizarOt.Enabled = False
        Utilidades.cargarCombo("tipoDocumento", cbTipoDocOT)
        Utilidades.cargarCombo("estadoOrdenTrabajo", cbEstadoOt)
        Utilidades.cargarCombo("servicio", cbServiciosOt)
        cbServiciosOt.SelectedValue = -1
        combosCargados = True
        'los repuestos se cargan en caso de que el servicio requiera alguno
        inicializarGrillas()


    End Sub

    Private Sub btnNvaOt_Click(sender As Object, e As EventArgs) Handles btnNvaOt.Click

        ' habilitacion/desabilitacion de los componentes que corresponden
        gbDatosCliOT.Enabled = True
        panelDatosNvaOt.Enabled = True
        panelBuscarOT.Enabled = False
        btnActualizarOt.Enabled = False
        btnGuardarOt.Enabled = True
        btnCancelarOt.Enabled = True
        btnNvaOt.Enabled = False

        gbAniadirServicios.Enabled = False
        panelCierre.Enabled = False
        txtNroCliente.ReadOnly = True
        txtNombreCLiente.ReadOnly = True
        txtApellidoCliente.ReadOnly = True
        txtTipoPcOt.ReadOnly = True
        txtDescripcionPcOt.ReadOnly = True
        txtFechaRecepcionOt.Text = Format(Date.Now, "dd/MM/yyyy")
        txtNroDocCliOT.Focus()
        txtNroOT.Text = Utilidades.sugerirId("ordenTrabajo", "idOrdenTrabajo")
        txtNroOT.Enabled = False

        'gbServicios.Enabled = True ' este se desabilita
        'gbAniadirServicios.Enabled = True

        'btnQuitarServicio.Enabled = False


    End Sub

    Private Sub txtNroDocCliOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocCliOT.KeyPress, txtNroOT.KeyPress
        If (Not IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

        End If
    End Sub



    Private Sub btnGuardarOt_Click(sender As Object, e As EventArgs) Handles btnGuardarOt.Click
        
        If validarDatos() Then
            ordenActual = New OrdenTrabajoDto
            ordenActual.idOrden = Convert.ToInt32(txtNroOT.Text.Trim())
            ordenActual.fechaRecepcion = CDate(txtFechaRecepcionOt.Text)
            ordenActual.estado = cbEstadoOt.SelectedValue 'deberia ser 1
            ordenActual.computadora = computadora
            ordenActual.cliente = cliente
            ordenActual.falla = txtDescrFalla.Text.Trim()

            Dim result As Conexion.EventosSql = OrdenTrabajoDao.insertarOrdenTrabajo(ordenActual)

            If result = Conexion.EventosSql.INSERCION_CORRECTA Then

                MessageBox.Show("LA orden de trabajo se registró correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cliente = Nothing
                computadora = Nothing
                ordenActual = Nothing
                Me.limpiarTextos()
            Else : MessageBox.Show("Error")

            End If




        End If

    End Sub


    Private Sub btnBuscarCliOT_Click(sender As Object, e As EventArgs) Handles btnBuscarCliOT.Click


        If Not txtNroDocCliOT.Text.Equals("") Then

            cliente = ClienteDao.buscarCliente(cbTipoDocOT.SelectedValue, txtNroDocCliOT.Text.Trim())

            If IsNothing(cliente) Then
                If MessageBox.Show("El Cliente no existe, desea agregarlo?", "Existe Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim gestionClientes As New GestionClientes(txtNroDocCliOT.Text.Trim(), cbTipoDocOT.SelectedValue, cliente)
                    gestionClientes.ShowDialog()
                    btnBuscarCliOT.PerformClick()

                End If

            End If

            If Not IsNothing(cliente) Then
                txtNroCliente.Text = cliente.idCliente
                txtNombreCLiente.Text = cliente.nombre
                txtApellidoCliente.Text = cliente.apellido
                Utilidades.cargarCombo("computadora", "idComputadora", "client", cliente.idCliente, cbNroPc, "idComputadora")
                cbNroPc.SelectedValue = -1
                compusCargadas = True
                If Not IsNothing(computadora) Then

                End If

            End If


        Else



        End If




    End Sub

    Private Sub btnBuscarOT_Click(sender As Object, e As EventArgs) Handles btnBuscarOT.Click
        If Not txtNroOT.Text.Equals("") Then
            ordenActual = Nothing
            cliente = Nothing
            computadora = Nothing
            Dim id As Int32 = Convert.ToInt32(txtNroOT.Text.Trim())
            ordenActual = OrdenTrabajoDao.buscarOt(id)

            If Not IsNothing(ordenActual) Then
                txtNroCliente.Text = ordenActual.cliente.idCliente
                ' falta toda la parte del cliente y las computadoras
                txtFechaRecepcionOt.Text = ordenActual.fechaRecepcion.ToString("dd/MM/yyyy")
                If Not ordenActual.fechaReparacion.Equals(Nothing) Then
                    txtFechaReparacion.Text = ordenActual.fechaReparacion.ToString("dd/MM/yyyy")
                End If

                cbEstadoOt.SelectedValue = ordenActual.estado
                txtDescrFalla.Text = ordenActual.falla
                If ordenActual.monto > 0 Then
                    txtMontoOt.Text = ordenActual.monto
                End If
                btnActualizarOt.Enabled = True

            End If


            panelDatosNvaOt.Enabled = True
            panelDatosClienteOt.Enabled = False
            panelDatosPcOt.Enabled = False
            txtFechaRecepcionOt.Enabled = False
            txtDescrFalla.Enabled = False
            btnCancelarOt.Enabled = True
            btnNvaOt.Enabled = False
            btnGuardarOt.Enabled = True


        Else
            MessageBox.Show("- Ingrese un número de Orden de trabajo!", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNroOT.Focus()

        End If

        ' SI LA OT SE ENCUENTRA SE ACTIVA EL BOTON ACTUALIZAR y los paneles aniadirServicio y aniadirReparacion
    End Sub
    'inserta los detalles pero estan incompletas las busquedas y las validaciones
    Private Sub btnActualizarOt_Click(sender As Object, e As EventArgs) Handles btnActualizarOt.Click

        If validarDatos() Then
            ordenActual.estado = Convert.ToInt32(cbEstadoOt.SelectedValue)
            'ordenActual.serviciosAgregados = serviciosAgregados

            Dim result As Conexion.EventosSql = OrdenTrabajoDao.actualizarOrden(ordenActual)
            If result = Conexion.EventosSql.INSERCION_CORRECTA Then
                MessageBox.Show("Correcto")
            Else : MessageBox.Show("Error")
            End If

        End If

    End Sub

    Private Sub limpiarTextos()

        txtNroDocCliOT.Text = ""
        txtNroOT.Text = ""
        txtNombreCLiente.Text = ""
        txtApellidoCliente.Text = ""
        txtTipoPcOt.Text = ""
        txtFechaRecepcionOt.Text = ""
        txtTipoRepRequerido.Text = ""
        txtDescrFalla.Text = ""
        txtDescripcionPcOt.Text = ""
        txtNroCobroOt.Text = ""
        txtNroCliente.Text = ""
        txtFechaReparacion.Text = ""
        txtMontoOt.Text = ""

    End Sub

    Private Sub btnCancelarOt_Click(sender As Object, e As EventArgs) Handles btnCancelarOt.Click


        Me.limpiarTextos()
        gbDatosCliOT.Enabled = False
        panelDatosNvaOt.Enabled = False

        btnGuardarOt.Enabled = False
        btnCancelarOt.Enabled = False
        btnActualizarOt.Enabled = False
        btnNvaOt.Enabled = True
        panelBuscarOT.Enabled = True
        txtNroOT.Focus()
        ordenActual = Nothing
        cliente = Nothing
        computadora = Nothing


    End Sub






    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GestionarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarProveedoresToolStripMenuItem.Click
        Dim formProveedores As New ABMCProveedores
        formProveedores.ShowDialog()
    End Sub

    Private Sub GestionarRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarRepuestosToolStripMenuItem.Click
        Dim formRepuestos As New ABMCRepuesto
        formRepuestos.ShowDialog()
    End Sub

    Private Sub GestionarTipoDeRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarTipoDeRepuestosToolStripMenuItem.Click
        Dim formTipRepuesto As New ABMTipoRepuesto
        formTipRepuesto.ShowDialog()
    End Sub

    Private Sub GestionarServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarServiciosToolStripMenuItem.Click
        Dim formServicios As New ABMServicio
        formServicios.ShowDialog()
    End Sub

    Private Sub GestionarTipoDePcMemoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarTipoDePcMemoriaToolStripMenuItem.Click
        Dim formTPcMem As New ABMTipoPc_Memoria
        formTPcMem.ShowDialog()
    End Sub

    Private Sub GestionarEstadosDeOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarEstadosDeOTToolStripMenuItem.Click
        Dim formEstadoOt As New ACEstadoOt
        formEstadoOt.ShowDialog()

    End Sub

    Private Sub GestionarTiposDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarTiposDeDocumentoToolStripMenuItem.Click
        Dim formTiposDos As New ACTipoDocumento
        formTiposDos.ShowDialog()
    End Sub

    Private Sub GestionarProcesadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarProcesadoresToolStripMenuItem.Click
        Dim formProcesadores As New ABMCProcesador
        formProcesadores.ShowDialog()
    End Sub

    Private Sub btnNuevaPcOt_Click(sender As Object, e As EventArgs) Handles btnNuevaPcOt.Click
        'Dim formNvaCompu As New GestionComputadoras
        'formNvaCompu.ShowDialog()
    End Sub


    Private Sub GestionarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarClientesToolStripMenuItem.Click
        Dim formClientes As New GestionClientes
        formClientes.ShowDialog()
    End Sub

    Private Sub txtNombreCLienteOt_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCLiente.TextChanged

    End Sub

    Private Sub cbTipoDocOT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDocOT.SelectedIndexChanged

    End Sub

    Private Sub txtNroDocCliOT_TextChanged(sender As Object, e As EventArgs) Handles txtNroDocCliOT.TextChanged

    End Sub

    Private Sub cbNroPc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNroPc.SelectedValueChanged

        If IsNumeric(cbNroPc.SelectedValue) Then

            If cbNroPc.SelectedValue > 0 Then
                If compusCargadas Then
                    computadora = ComputadoraDao.buscarComputadora(Convert.ToInt32(cbNroPc.SelectedValue))
                    'computadoraActual = ComputadoraDao.buscarComputadora(1)
                    txtDescripcionPcOt.Text = computadora.toString()
                    txtTipoPcOt.Text = computadora.nombreTipoPc

                End If

            End If


        End If


    End Sub


    Private Function validarDatos() As Boolean
        Dim msjError As String = ""

        If (txtNroCliente.Text.Equals("")) Then
            msjError &= "- Debe especificar un cliente" & vbCrLf
        End If

        If (txtDescrFalla.Text.Equals("")) Then
            msjError &= "- La descripción de la falla no puede quedar vacía" & vbCrLf
        End If



        If (txtFechaRecepcionOt.Text.Equals("  /  /")) Then
            txtFechaRecepcionOt.Text = Format(Date.Now, "dd/MM/yyyy")
        ElseIf (Not txtFechaRecepcionOt.Text = Format(CDate(txtFechaRecepcionOt.Text), "dd/MM/yyyy")) Then
            msjError &= "- Ingrese una fecha valida (dd/mm/aaaa)"

        End If


        If (Not msjError.Equals("")) Then
            MessageBox.Show(msjError, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True

    End Function

    Private Sub inicializarGrillas()

        Dim anchoTotalServicios As Int32 = lvServicios.Size.Width
        Dim anchoTotalRepuestos As Int32 = lvRepuestos.Size.Width

        lvServicios.Columns(0).Width = Math.Round(0.1 * anchoTotalServicios)
        lvServicios.Columns(1).Width = Math.Round(0.53 * anchoTotalServicios)
        lvServicios.Columns(2).Width = Math.Round(0.15 * anchoTotalServicios)
        lvServicios.Columns(3).Width = Math.Round(0.15 * anchoTotalServicios)

        lvRepuestos.Columns(0).Width = Math.Round(0.1 * anchoTotalRepuestos)
        lvRepuestos.Columns(1).Width = Math.Round(0.53 * anchoTotalRepuestos)
        lvRepuestos.Columns(2).Width = Math.Round(0.15 * anchoTotalRepuestos)
        lvRepuestos.Columns(3).Width = Math.Round(0.15 * anchoTotalRepuestos)


    End Sub
 
    Private Sub cbServiciosOt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServiciosOt.SelectedIndexChanged

        If combosCargados Then

            If cbServiciosOt.SelectedValue > 0 Then
                Dim id As Int32 = Convert.ToInt32(cbServiciosOt.SelectedValue)
                servicioSeleccionado = ServicioDao.buscarServicio(id)
                If servicioSeleccionado.repuestoReq > 0 Then
                    txtTipoRepRequerido.Text = servicioSeleccionado.repuesto.nombreTipo
                    Utilidades.cargarCombo("componente", "idComponente", "tipoComp", servicioSeleccionado.repuestoReq, cbRepuestoOt)
                    cbRepuestoOt.SelectedValue = -1
                    comboRepuestosCargado = True
                Else
                    txtTipoRepRequerido.Text = ""
                    cbRepuestoOt.DataSource = Nothing
                    comboRepuestosCargado = False
                End If
            Else : servicioSeleccionado = Nothing
            End If


        End If

    End Sub

    Private Sub cbRepuestoOt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRepuestoOt.SelectedIndexChanged

        If comboRepuestosCargado Then

            If cbRepuestoOt.SelectedValue > 0 Then
                Dim id As Int32 = Convert.ToInt32(cbRepuestoOt.SelectedValue)
                servicioSeleccionado.repuesto = RepuestoDao.buscarRepuesto(id)
            Else : servicioSeleccionado.repuesto = Nothing
            End If

        End If

    End Sub

    Private Sub btnAniadirServicioOt_Click(sender As Object, e As EventArgs) Handles btnAniadirServicioOt.Click
        Dim agregado As Boolean

        If Not IsNothing(servicioSeleccionado) Then

            If servicioSeleccionado.repuestoReq > 0 Then
                If Not cbRepuestoOt.SelectedValue > 0 Then
                    MessageBox.Show("Por favor seleccione un repuesto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

            End If


            servicioSeleccionado.cantidad = Convert.ToInt32(txtCantServicios.Text.Trim())

            If IsNothing(ordenActual.serviciosAgregados) Then
                ordenActual.serviciosAgregados = New ArrayList
            End If

            If ordenActual.serviciosAgregados.Count = 0 Then
                ordenActual.serviciosAgregados.Add(servicioSeleccionado)
                agregado = True
            Else
                If Not ordenActual.serviciosAgregados.Contains(servicioSeleccionado) Then
                    ordenActual.serviciosAgregados.Add(servicioSeleccionado)
                    agregado = True
                End If
            End If
        End If

        If agregado Then
            If servicioSeleccionado.repuestoReq > 0 Then

                servicioSeleccionado.repuesto.cantidad = Convert.ToInt32(txtCantServicios.Text.Trim())
                'dgvRepuestos.Rows.Add()

                'Dim indx As Int32 = dgvRepuestos.Rows.Count - 1
                'dgvRepuestos.Rows(indx).Cells(0).Value = servicioSeleccionado.repuesto.descripcion
                'dgvRepuestos.Rows(indx).Cells(1).Value = servicioSeleccionado.repuesto.cantidad
                'dgvRepuestos.Rows(indx).Cells(2).Value = servicioSeleccionado.repuesto.cantidad * servicioSeleccionado.repuesto.precioVenta()
                Dim itemRepuesto As New ListViewItem
                itemRepuesto.Text = servicioSeleccionado.repuesto.id
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.descripcion)
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.cantidad)
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.calcularMonto() * servicioSeleccionado.cantidad)
                lvRepuestos.Items.Add(itemRepuesto)



            End If
            'Dim idx As Int32 = dgvServicios.Rows.Count - 1
            ' dgvServicios.Rows(idx).Cells(0).Value = servicioSeleccionado.nomServicio
            'dgvServicios.Rows(idx).Cells(1).Value = servicioSeleccionado.cantidad
            'dgvServicios.Rows(idx).Cells(2).Value = servicioSeleccionado.costoServicio * servicioSeleccionado.cantidad
            Dim item As New ListViewItem
            item.Text = servicioSeleccionado.idServ
            item.SubItems.Add(servicioSeleccionado.nomServicio)
            item.SubItems.Add(servicioSeleccionado.cantidad)
            item.SubItems.Add(servicioSeleccionado.cantidad * servicioSeleccionado.costoServicio)
            lvServicios.Items.Add(item)
            ordenActual.armarDetalles()
            txtMontoOt.Text = ordenActual.calcularTotal()
        End If
        btnQuitarServicio.Enabled = True

    End Sub

    Private Sub btnQuitarServicio_Click(sender As Object, e As EventArgs) Handles btnQuitarServicio.Click

        'lvServicios.CheckedItems.Count > 0
        If lvServicios.SelectedItems.Count = 1 Then
            Dim servTemp As New ServicioDto
            Dim idx As Int32
            servTemp.idServ = Convert.ToInt32(lvServicios.SelectedItems(0).Text.Trim())
            idx = ordenActual.serviciosAgregados.IndexOf(servTemp)
            servTemp = CType(ordenActual.serviciosAgregados.Item(idx), ServicioDto)
            If servTemp.repuestoReq > 0 Then
                Dim repItemTemp As ListViewItem = lvRepuestos.FindItemWithText(servTemp.repuesto.id)
                repItemTemp.Remove()
            End If
            ordenActual.serviciosAgregados.RemoveAt(idx)
            lvServicios.SelectedItems(0).Remove()
            If lvServicios.Items.Count = 0 Then
                btnQuitarServicio.Enabled = False
            End If
            txtMontoOt.Text = ordenActual.calcularTotal()
        End If


    End Sub
End Class
Public Class ABMCOrdenTrabajo
    Implements Buscable

    Private cliente As ClienteDto
    Private computadora As ComputadoraDto
    Private servicioSeleccionado As ServicioDto
    Private cobro As CobroDto

    Private serviciosBrindados As List(Of ServicioDto)
    Private ordenActual As OrdenTrabajoDto


    Private compusCargadas As Boolean
    Private combosCargados As Boolean
    Private comboRepuestosCargado As Boolean

    Private filaBuscada As DataGridViewRow


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'serviciosAgregados = New List(Of ServicioDto)

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
        btnGestionCliente.Enabled = False
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
        cbNroPc.Enabled = True
        txtDescrFalla.Enabled = True
        panelDatosPcOt.Enabled = True
        txtTipoPcOt.ReadOnly = True
        txtDescripcionPcOt.ReadOnly = True
        cbNroPc.Enabled = True
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
                compusCargadas = True
                cbNroPc.SelectedValue = -1
                btnGestionCliente.Enabled = True
            End If


        Else

        End If



    End Sub

    Private Sub btnBuscarOT_Click(sender As Object, e As EventArgs) Handles btnBuscarOT.Click

        Dim id As Int32
        ordenActual = Nothing
        cliente = Nothing
        computadora = Nothing
        If Not txtNroOT.Text.Equals("") Then
            id = Convert.ToInt32(txtNroOT.Text.Trim())
        Else
            Dim grilla As New GrillaGenerica("Ordenes de Trabajo", GrillaGenerica.formularios.ORDEN_TRABAJO, Me)
            grilla.ShowDialog()
            If Not IsNothing(filaBuscada) Then
                id = Convert.ToInt32(filaBuscada.Cells("Id Orden").Value)
            End If

        End If
        ordenActual = OrdenTrabajoDao.buscarOt(id)

        If Not IsNothing(ordenActual) Then
            txtNroOT.Text = ordenActual.idOrden
            txtNroCliente.Text = ordenActual.cliente.idCliente
            txtNombreCLiente.Text = ordenActual.cliente.nombre
            txtApellidoCliente.Text = ordenActual.cliente.apellido
            Utilidades.cargarCombo("computadora", "idComputadora", "client", ordenActual.cliente.idCliente, cbNroPc, "idComputadora")
            cbNroPc.SelectedValue = ordenActual.computadora.idComputadora
            txtTipoPcOt.Text = ordenActual.computadora.nombreTipoPc
            txtDescripcionPcOt.Text = ordenActual.computadora.toString()
            computadora = ordenActual.computadora
            ' falta toda la parte del cliente y las computadoras
            txtFechaRecepcionOt.Text = ordenActual.fechaRecepcion.ToString("dd/MM/yyyy")
            If Not ordenActual.fechaReparacion.Equals(Nothing) Then
                txtFechaReparacion.Text = ordenActual.fechaReparacion.ToString("dd/MM/yyyy")
            Else : txtFechaReparacion.Text = ""
            End If

            cbEstadoOt.SelectedValue = ordenActual.estado
            txtDescrFalla.Text = ordenActual.falla
            If ordenActual.monto > 0 Then
                txtMontoOt.Text = ordenActual.monto
            Else : txtMontoOt.Text = ""
            End If

            If Not IsNothing(ordenActual.cobro) Then
                txtNroCobroOt.Text = ordenActual.cobro.id
            Else : txtNroCobroOt.Text = ""
            End If
            btnActualizarOt.Enabled = True
            'panelDatosOt.Enabled = True
            'cbEstadoOt.Enabled = True
            'txtFechaRecepcionOt.Enabled = False
            'txtDescrFalla.Enabled = False
            cargarDetalles()
            panelDatosNvaOt.Enabled = True
            panelDatosClienteOt.Enabled = False
            panelDatosPcOt.Enabled = False
            txtFechaRecepcionOt.Enabled = False
            txtDescrFalla.Enabled = False
            btnCancelarOt.Enabled = True
            btnNvaOt.Enabled = False

            gbAniadirServicios.Enabled = False
            panelCierre.Enabled = False
            btnGuardarOt.Enabled = False
            btnActualizarOt.Enabled = True
            Me.cambioEstado(True)
        End If



        ' SI LA OT SE ENCUENTRA SE ACTIVA EL BOTON ACTUALIZAR y los paneles aniadirServicio y aniadirReparacion
    End Sub


    Public Sub cambioEstado(ByVal buscada As Boolean)
        Dim indice As Int32
        If buscada Then
            indice = ordenActual.estado - 1
        Else : indice = cbEstadoOt.SelectedValue - 1
        End If

        Select Case indice
            Case OrdenTrabajoDto.estadosOrden.RECEPTADA
                Exit Select
            Case OrdenTrabajoDto.estadosOrden.EN_REPARACION
                gbAniadirServicios.Enabled = True
                Exit Select
            Case OrdenTrabajoDto.estadosOrden.REPARADA
                panelCierre.Enabled = True
                gbAniadirServicios.Enabled = False
                If Not IsNothing(ordenActual) Then
                    If Not ordenActual.fechaReparacion.Equals(Nothing) Then
                        txtFechaReparacion.Text = ordenActual.fechaReparacion.ToString("dd/MM/yyyy")
                    Else : txtFechaReparacion.Text = Date.Today.ToString("dd/MM/yyyy")
                    End If

                Else : txtFechaReparacion.Text = Date.Today.ToString("dd/MM/yyyy")

                End If
                Exit Select
            Case OrdenTrabajoDto.estadosOrden.CERRADA
                panelCierre.Enabled = False
                gbAniadirServicios.Enabled = False
                Exit Select
            Case OrdenTrabajoDto.estadosOrden.IRREPARABLE
                If IsNothing(ordenActual.cobro) Then
                    panelCierre.Enabled = True
                End If

                gbAniadirServicios.Enabled = False

                Exit Select
        End Select
    End Sub

    Public Sub cargarDetalles()

        If Not IsNothing(ordenActual.detalles) Then
            lvServicios.Items.Clear()
            lvRepuestos.Items.Clear()

            For Each detalle As DetalleOrdenTrabajoDto In ordenActual.detalles

                Dim servTemp As ServicioDto = ServicioDao.buscarServicio(detalle.servicio)

                Dim item As New ListViewItem
                item.Text = servTemp.idServ
                item.SubItems.Add(servTemp.nomServicio)
                item.SubItems.Add(detalle.cantidad)
                item.SubItems.Add(detalle.cantidad * detalle.montoUnitServicio)
                lvServicios.Items.Add(item)

                If detalle.repuesto > 0 Then
                    servTemp.repuesto = RepuestoDao.buscarRepuesto(detalle.repuesto)
                    servTemp.repuesto.monto = detalle.montoUnitrepuesto
                    item = New ListViewItem
                    item.Text = servTemp.repuesto.id
                    item.SubItems.Add(servTemp.repuesto.descripcion)
                    item.SubItems.Add(detalle.cantidad)
                    item.SubItems.Add(detalle.cantidad * servTemp.repuesto.monto)
                    lvRepuestos.Items.Add(item)

                End If

                If IsNothing(serviciosBrindados) Then
                    serviciosBrindados = New List(Of ServicioDto)
                End If
                serviciosBrindados.Add(servTemp)

            Next

        End If
    End Sub

    'inserta los detalles pero estan incompletas las busquedas y las validaciones
    Private Sub btnActualizarOt_Click(sender As Object, e As EventArgs) Handles btnActualizarOt.Click

        If validarDatos() Then

            If combosCargados Then

                Dim indice As Int32 = cbEstadoOt.SelectedValue - 1
                Select Case indice
                    Case OrdenTrabajoDto.estadosOrden.RECEPTADA
                        Exit Select
                    Case OrdenTrabajoDto.estadosOrden.EN_REPARACION
                        ordenActual.estado = Convert.ToInt32(cbEstadoOt.SelectedValue)
                        'ordenActual.serviciosAgregados = serviciosAgregados

                        Dim result As Conexion.EventosSql = OrdenTrabajoDao.actualizarOrden(ordenActual)
                        If result = Conexion.EventosSql.INSERCION_CORRECTA Then
                            MessageBox.Show("Correcto")
                        Else : MessageBox.Show("Error")
                        End If

                        Exit Select
                    Case OrdenTrabajoDto.estadosOrden.REPARADA

                        ordenActual.estado = cbEstadoOt.SelectedValue
                        ordenActual.fechaReparacion = CDate(txtFechaReparacion.Text)
                        Dim result As Conexion.EventosSql = OrdenTrabajoDao.actualizarOrden(ordenActual, OrdenTrabajoDto.estadosOrden.REPARADA)
                        If result = Conexion.EventosSql.INSERCION_CORRECTA Then
                            MessageBox.Show("Actualización Correcta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Actualización Incorrecta! :(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        Exit Select
                    Case OrdenTrabajoDto.estadosOrden.CERRADA
                        If Not IsNothing(cobro) Then
                            ordenActual.estado = Convert.ToInt32(cbEstadoOt.SelectedValue)
                            Dim result As Conexion.EventosSql = OrdenTrabajoDao.actualizarOrden(ordenActual, OrdenTrabajoDto.estadosOrden.CERRADA, cobro)
                            If result = Conexion.EventosSql.INSERCION_CORRECTA Then
                                MessageBox.Show("Actualización Correcta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Actualización Incorrecta! :(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                        Exit Select
                    Case OrdenTrabajoDto.estadosOrden.IRREPARABLE
                        If Not IsNothing(cobro) Then
                            ordenActual.estado = Convert.ToInt32(cbEstadoOt.SelectedValue)
                            Dim result As Conexion.EventosSql = OrdenTrabajoDao.actualizarOrden(ordenActual, OrdenTrabajoDto.estadosOrden.CERRADA, cobro)
                            If result = Conexion.EventosSql.INSERCION_CORRECTA Then
                                MessageBox.Show("Actualización Correcta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Actualización Incorrecta! :(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                        Exit Select
                End Select
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
        cbEstadoOt.SelectedValue = 1
        btnGuardarOt.Enabled = False
        btnCancelarOt.Enabled = False
        btnActualizarOt.Enabled = False
        btnNvaOt.Enabled = True
        panelBuscarOT.Enabled = True
        txtNroOT.Enabled = True
        txtNroOT.Focus()
        ordenActual = Nothing
        cliente = Nothing
        computadora = Nothing
        lvServicios.Items.Clear()
        lvRepuestos.Items.Clear()
        cbNroPc.DataSource = Nothing

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

    Private Sub GestionarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarClientesToolStripMenuItem.Click
        Dim formClientes As New GestionClientes
        formClientes.ShowDialog()
    End Sub


    Private Sub cbNroPc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNroPc.SelectedValueChanged

        If compusCargadas Then
            If cbNroPc.SelectedValue > 0 Then
                computadora = ComputadoraDao.buscarComputadora(Convert.ToInt32(cbNroPc.SelectedValue))

                txtDescripcionPcOt.Text = computadora.toString()
                txtTipoPcOt.Text = computadora.nombreTipoPc

            End If

        End If

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

        If Not IsNothing(cbServiciosOt.SelectedValue) Then
            If IsNothing(serviciosBrindados) Then
                serviciosBrindados = New List(Of ServicioDto)
            End If

            If Not IsNothing(servicioSeleccionado) Then

                If servicioSeleccionado.repuestoReq > 0 Then
                    If Not cbRepuestoOt.SelectedValue > 0 Then
                        MessageBox.Show("Por favor seleccione un repuesto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                End If


                servicioSeleccionado.cantidad = Convert.ToInt32(txtCantServicios.Text.Trim())
            End If


            If servicioSeleccionado.repuestoReq > 0 Then

                servicioSeleccionado.repuesto.cantidad = Convert.ToInt32(txtCantServicios.Text.Trim())

                Dim itemRepuesto As New ListViewItem
                itemRepuesto.Text = servicioSeleccionado.repuesto.id
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.descripcion)
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.cantidad)
                itemRepuesto.SubItems.Add(servicioSeleccionado.repuesto.calcularMonto() * servicioSeleccionado.cantidad)
                lvRepuestos.Items.Add(itemRepuesto)

            End If
            Dim item As New ListViewItem
            item.Text = servicioSeleccionado.idServ
            item.SubItems.Add(servicioSeleccionado.nomServicio)
            item.SubItems.Add(servicioSeleccionado.cantidad)
            item.SubItems.Add(servicioSeleccionado.cantidad * servicioSeleccionado.costoServicio)
            lvServicios.Items.Add(item)
            ordenActual.armarDetalles(servicioSeleccionado)

            ' faltaria hacer que cuando se agregue un servicio nuevo, si éste ya está cargado en los detalles
            ' que se actualice el monto que está almacenado en el detalle en caso de que sea distinto

            If Not serviciosBrindados.Contains(servicioSeleccionado) Then
                serviciosBrindados.Add(servicioSeleccionado)
            Else
                Dim idx As Int32 = serviciosBrindados.IndexOf(servicioSeleccionado)
                serviciosBrindados(idx).cantidad += servicioSeleccionado.cantidad
            End If

            txtMontoOt.Text = ordenActual.calcularTotal()


            btnQuitarServicio.Enabled = True

        Else : MessageBox.Show("Por favor seleccione un servicio!")
        End If

    End Sub

    Private Sub btnQuitarServicio_Click(sender As Object, e As EventArgs) Handles btnQuitarServicio.Click

        'lvServicios.CheckedItems.Count > 0
        If lvServicios.SelectedItems.Count = 1 Then
            Dim servTemp As New ServicioDto

            servTemp.idServ = Convert.ToInt32(lvServicios.SelectedItems(0).Text.Trim())
            servTemp = ServicioDao.buscarServicio(servTemp.idServ)
            ordenActual.eliminarDetalle(servTemp)

            If servTemp.repuestoReq > 0 Then
                Dim repItemTemp As ListViewItem = lvRepuestos.FindItemWithText(servTemp.repuesto.id)
                repItemTemp.Remove()
            End If


            lvServicios.SelectedItems(0).Remove()
            If lvServicios.Items.Count = 0 Then
                btnQuitarServicio.Enabled = False
            End If
            txtMontoOt.Text = ordenActual.calcularTotal()

        End If
    End Sub

    Private Sub cbEstadoOt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstadoOt.SelectedIndexChanged

        If combosCargados Then

            Me.cambioEstado(False)
        End If

    End Sub

    Private Sub btnAniadirCobroOt_Click(sender As Object, e As EventArgs) Handles btnAniadirCobroOt.Click

        cobro = New CobroDto
        cobro.id = Utilidades.sugerirId("cobro", "idCobro")
        txtNroCobroOt.Text = cobro.id
        cobro.monto = Convert.ToSingle(txtMontoOt.Text)
        cobro.fechaCobro = Date.Today
        Dim estado As OrdenTrabajoDto.estadosOrden = cbEstadoOt.SelectedValue - 1
        Select Case estado
            Case OrdenTrabajoDto.estadosOrden.REPARADA
                cbEstadoOt.SelectedValue = OrdenTrabajoDto.estadosOrden.CERRADA + 1
                Exit Select

            Case OrdenTrabajoDto.estadosOrden.IRREPARABLE
                cbEstadoOt.SelectedValue = OrdenTrabajoDto.estadosOrden.IRREPARABLE + 1
                Exit Select

        End Select




    End Sub


    Private Function validarDatos() As Boolean
        Dim msjError As String = ""

        If (txtNroCliente.Text.Equals("")) Then
            msjError &= "- Debe especificar un cliente" & vbCrLf
        End If

        If (txtDescrFalla.Text.Equals("")) Then
            msjError &= "- La descripción de la falla no puede quedar vacía" & vbCrLf
        End If

        If IsNothing(cbNroPc.SelectedValue) Then
            msjError &= "-Por favor seleccione una computadora de la lista!" & vbCrLf
        End If

        If IsNothing(cbEstadoOt.SelectedValue) Then
            cbEstadoOt.SelectedValue = 1
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

    Private Sub cbNroPc_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbNroPc.SelectedIndexChanged

    End Sub

    Private Sub OrdenDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeTrabajoToolStripMenuItem.Click
        Dim form As New ReporteOrdenTrabajo
        form.ShowDialog()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        Dim form As New pruebaDataSet
        form.ShowDialog()
    End Sub

    Public Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub

    Private Sub btnNuevaPcOt_Click(sender As Object, e As EventArgs) Handles btnGestionCliente.Click
        Dim formCliente As New GestionClientes(cliente)
        formCliente.ShowDialog()
    End Sub

    Private Sub ListadosPeriodicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosPeriodicosToolStripMenuItem.Click
        Dim listados As New ListadosPeriodicos
        listados.ShowDialog()
    End Sub

    Private Sub ListadoIngresosMensualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoIngresosMensualesToolStripMenuItem.Click
        Dim formIngresos As New IngresosMensuales
        formIngresos.ShowDialog()
    End Sub
End Class
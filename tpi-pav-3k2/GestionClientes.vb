Public Class GestionClientes
    Implements Buscable
    Private clienteBuscado As Boolean
    Private filaBuscada As DataGridViewRow
    Private clienteActual As ClienteDto
    Private desdeOt As Boolean
    Private cargado As Boolean


    Public Sub New()
        InitializeComponent()
        cargado = False
        Utilidades.cargarCombo("tipoDocumento", cbTipoDoc)
        Utilidades.cargarCombo("tipoPc", cbTipoPc)
        Utilidades.cargarCombo("tipoMemoria", cbTipoMemoria)
        Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
        Me.deshabilitarComponentes()
        btnNuevoCliente.Enabled = False
    End Sub
    Public Sub New(ByVal nroDoc As String, ByVal tipoDoc As Int32)
        cargado = False
        InitializeComponent()
        Utilidades.cargarCombo("tipoDocumento", cbTipoDoc)
        Utilidades.cargarCombo("tipoPc", cbTipoPc)
        Utilidades.cargarCombo("tipoMemoria", cbTipoMemoria)
        Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
        cbMarcaProc.SelectedValue = -1
        chkEstadoCliente.Enabled = False
        txtNroDocumento.Text = nroDoc
        cbTipoDoc.SelectedItem = tipoDoc
        desdeOt = True
    End Sub


    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPcsRegistradas.ReadOnly = True

        Me.deshabilitarComponentes()
        If desdeOt Then
            btnNuevoCliente.PerformClick()
            txtNombre.Focus()
        End If
        cargado = True
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Me.limpiarComponentes()
        Me.habilitarComponentes()
        txtNroCliente.Text = Utilidades.sugerirId("cliente", "idCliente")
        txtNroCompu.Text = Utilidades.sugerirId("computadora", "idComputadora")
        cbModeloProc.DataSource = Nothing
        txtNroCliente.Enabled = False
        txtNroCompu.Enabled = False
        btnBuscar.Enabled = False
        txtFechaAlta.Text = Date.Today.ToString("dd/MM/yyyy")
        txtNroDocumento.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        clienteActual = Nothing
        If Not (txtNroCliente.Text.Equals("") And txtNroDocumento.Text.Equals("")) Then
            Dim id, tipoDoc As Int32
            Dim nro As String = ""

            If Not txtNroCliente.Text.Equals("") Then
                id = Convert.ToInt32(txtNroCliente.Text)
            End If
            If Not txtNroDocumento.Text.Equals("") Then
                nro = txtNroDocumento.Text
            End If
            tipoDoc = cbTipoDoc.SelectedValue
            clienteActual = ClienteDao.buscarCliente(tipoDoc, nro, id)
        Else
            Dim grilla As New GrillaGenerica("Clientes", GrillaGenerica.formularios.CLIENTE, Me)
            grilla.ShowDialog()

            If Not IsNothing(filaBuscada) Then
                clienteActual = New ClienteDto()
                clienteActual.idCliente = Convert.ToInt32(filaBuscada.Cells("Nro Cliente").Value)
                clienteActual.nombre = filaBuscada.Cells("Nombre").Value.ToString()
                clienteActual.apellido = filaBuscada.Cells("Apellido").Value.ToString()
                clienteActual.telefono = filaBuscada.Cells("Teléfono").Value.ToString()
                clienteActual.email = filaBuscada.Cells("E-Mail").Value.ToString()
                clienteActual.tipoDocumento = Convert.ToInt32(filaBuscada.Cells("ID Tipo Documento").Value)
                clienteActual.nroDocumento = filaBuscada.Cells("Nro Documento").Value.ToString()
                clienteActual.fechaAlta = CDate(filaBuscada.Cells("Fecha Alta").Value)
                If Not IsDBNull(filaBuscada.Cells("Fecha Baja").Value) Then
                    clienteActual.fechaBaja = CDate(filaBuscada.Cells("Fecha Baja").Value)

                End If

            End If
        End If

        If Not IsNothing(clienteActual) Then
            txtNroCliente.Text = clienteActual.idCliente
            txtNroDocumento.Text = clienteActual.nroDocumento
            cbTipoDoc.SelectedValue = clienteActual.tipoDocumento
            txtNombre.Text = clienteActual.nombre
            txtApellido.Text = clienteActual.apellido
            txtTelefono.Text = clienteActual.telefono
            txtEmail.Text = clienteActual.email
            txtFechaAlta.Text = clienteActual.fechaAlta.ToString("dd/MM/yyyy")
            If Not clienteActual.fechaBaja.Equals(Nothing) Then
                chkEstadoCliente.Checked = False
            Else : chkEstadoCliente.Checked = True
            End If
            txtTelefono.Enabled = True
            txtEmail.Enabled = True
            btnActualizarCli.Enabled = True
            btnGestionPc.Enabled = True
            btnMostrarPcs.Enabled = True
            chkEstadoCliente.Enabled = True
            txtNroCliente.Enabled = False

            If Not IsNothing(clienteActual.computadoras) Then
                Dim prim As Boolean = True
                For Each compu As Int32 In clienteActual.computadoras

                    If prim Then
                        txtPcsRegistradas.Text &= compu
                        prim = False
                    Else : txtPcsRegistradas.Text &= ", " & compu
                    End If

                Next
            End If
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarDatos() Then

            Dim cliente As New ClienteDto
            Dim computadora As New ComputadoraDto
            cliente.idCliente = Convert.ToInt32(txtNroCliente.Text.Trim())
            cliente.tipoDocumento = Convert.ToInt32(cbTipoDoc.SelectedValue)
            cliente.nroDocumento = txtNroDocumento.Text.Trim()
            cliente.nombre = txtNombre.Text
            cliente.apellido = txtApellido.Text.Trim()
            cliente.telefono = txtTelefono.Text.Trim()
            cliente.email = txtEmail.Text
            cliente.fechaAlta = CDate(txtFechaAlta.Text)

            computadora.idComputadora = Convert.ToInt32(txtNroCompu.Text)
            computadora.tipoPc = Convert.ToInt32(cbTipoPc.SelectedValue)
            computadora.nroCliente = cliente.idCliente
            computadora.fechaAlta = Date.Today
            If cbTipoMemoria.SelectedValue > 0 Then
                computadora.tipoMemoria = cbTipoMemoria.SelectedValue
            Else : computadora.tipoMemoria = 0
            End If

            If Not txtCantMemoria.Text.Equals("") Then
                computadora.cantidadMemoria = Convert.ToDecimal(txtCantMemoria.Text)
            Else : computadora.cantidadMemoria = 0
            End If

            If cbModeloProc.SelectedValue > 0 Then
                computadora.procesador = Convert.ToInt32(cbModeloProc.SelectedValue)
            Else : computadora.procesador = 0
            End If

            If Not txtCapAlm.Text.Equals("") Then
                computadora.capAlmacenamiento = Convert.ToInt32(txtCapAlm.Text.Trim())
            Else : computadora.capAlmacenamiento = 0
            End If

            Dim cantFilas As Int32 = ClienteDao.insertarCliente(cliente, computadora)
            Select Case cantFilas
                Case 1
                    MessageBox.Show("El cliente se registró correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If desdeOt Then
                        Me.Close()
                    Else
                        Me.limpiarComponentes()
                        txtNroCliente.Text = Utilidades.sugerirId("cliente", "idCliente")
                        txtNroCompu.Text = Utilidades.sugerirId("computadora", "idComputadora")
                        txtNroDocumento.Text = ""
                        cbTipoDoc.SelectedValue = 1
                        cbTipoPc.SelectedValue = 1
                        cbMarcaProc.SelectedValue = -1
                        cbTipoMemoria.SelectedValue = -1
                        cbModeloProc.SelectedValue = -1
                    End If
                    Exit Select

                Case -1
                    MessageBox.Show("Ocurrió un error al insertar el nuevo cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtNombre.Focus()
                    Exit Select
                Case -2
                    MessageBox.Show("Ocurrió un error al insertar la computadora del nuevo cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cbTipoPc.Focus()
                    Exit Select
                Case -3
                    MessageBox.Show("El cliente que intenta registrar ya se encuentra registrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Case Else
                    MessageBox.Show("Ocurrió un error, Por favor compruebe los datos ingresados!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtNombre.Focus()
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub btnActualizarCli_Click(sender As Object, e As EventArgs) Handles btnActualizarCli.Click
        clienteActual.telefono = txtTelefono.Text.Trim()
        clienteActual.email = txtEmail.Text.Trim()
        If chkEstadoCliente.Checked Then
            clienteActual.fechaBaja = Nothing
        End If
        Dim cantFilas As Int32

        cantFilas = ClienteDao.actualizarCliente(clienteActual)
        If cantFilas = 1 Then
            MessageBox.Show("El registro se ha actualizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.limpiarComponentes()
            Me.deshabilitarComponentes()
            txtNroDocumento.Text = ""
            cbTipoDoc.SelectedValue = 1
            clienteActual = Nothing
        Else : MessageBox.Show("Ocurrió un error al actualizar el registro!", "información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress, txtTelefono.KeyPress, txtCantMemoria.KeyPress, txtCapAlm.KeyPress, txtNroCliente.KeyPress, txtNroCompu.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
            e.Handled = True
        End If

    End Sub

    Private Function validarDatos() As Boolean

        Dim msjError As String = ""

        If txtNroDocumento.Text.Equals("") Then
            msjError &= "El número de documento no puede quedar vacio!" & vbCrLf
        Else
            If txtNroDocumento.Text.Length < 6 Then
                msjError &= "El número de documento ingresado no es válido" & vbCrLf
            End If
        End If

        If txtNombre.Text.Equals("") Then
            msjError &= "El nombre del cliente no puede quedar vacío!" & vbCrLf

        End If

        If txtApellido.Text.Equals("") Then
            msjError &= "El apellido del cliente no puede quedar vacío!" & vbCrLf
        End If

        If txtTelefono.Text.Equals("") Then
            msjError &= "El telefono del cliente no puede quedar vacío!" & vbCrLf
        End If

        If txtNombre.Text.Equals("") Then
            msjError &= "El nombre del cliente no puede quedar vacío!" & vbCrLf

        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If
        Return True
    End Function
    Public Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub

    Private Sub cbMarcaProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarcaProc.SelectedIndexChanged
        If cargado Then
            If Not IsNothing(cbMarcaProc.SelectedValue) Then
                If IsNumeric(cbMarcaProc.SelectedValue.ToString()) Then
                    Dim valor As Int32 = cbMarcaProc.SelectedValue
                    If valor > 0 Then
                        cbModeloProc.DataSource = Nothing
                        Utilidades.cargarCombo("procesador", "idProcesador", "marca", valor, cbModeloProc)
                        cbModeloProc.SelectedValue = -1
                    End If

                End If
            End If
        End If


    End Sub

    Private Sub chkEstadoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoCliente.CheckedChanged

        If chkEstadoCliente.Checked = False Then
            chkEstadoCliente.Text = "Inactivo"
            If clienteActual.fechaBaja.Equals(Nothing) Then
                txtFechaBaja.Text = Date.Today.ToString("dd/MM/yyyy")
                clienteActual.fechaBaja = Date.Now
            Else : txtFechaBaja.Text = clienteActual.fechaBaja.ToString("dd/MM/yyyy")
            End If

        Else
            chkEstadoCliente.Text = "Activo"
            'servicioActual.fechaBajaServicio = Nothing
            txtFechaBaja.Text = ""

        End If




    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.limpiarComponentes()
        Me.deshabilitarComponentes()
        clienteActual = Nothing
        txtNroCliente.Enabled = True
        txtNroDocumento.Enabled = True
        txtNroDocumento.Text = ""
        cbTipoMemoria.SelectedValue = -1
        cbMarcaProc.SelectedValue = -1
        cbModeloProc.SelectedValue = -1
        cbTipoDoc.SelectedValue = 1
        cbTipoDoc.Enabled = True
        btnBuscar.Enabled = True
        txtNroCliente.Focus()

    End Sub
    Private Sub deshabilitarComponentes()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False
        txtFechaAlta.Enabled = False
        txtFechaBaja.Enabled = False
        chkEstadoCliente.Enabled = False
        txtNroCompu.Enabled = False
        cbTipoPc.Enabled = False
        cbMarcaProc.Enabled = False
        cbModeloProc.Enabled = False
        cbTipoMemoria.Enabled = False
        txtCantMemoria.Enabled = False
        txtCapAlm.Enabled = False
        btnGuardar.Enabled = False
        btnActualizarCli.Enabled = False
        btnGestionPc.Enabled = False
        btnMostrarPcs.Enabled = False

    End Sub

    Private Sub habilitarComponentes()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        chkEstadoCliente.Enabled = False

        cbTipoPc.Enabled = True
        cbMarcaProc.Enabled = True
        cbModeloProc.Enabled = True
        cbTipoMemoria.Enabled = True
        txtCantMemoria.Enabled = True
        txtCapAlm.Enabled = True
        btnGuardar.Enabled = True
        'btnActualizarCli.Enabled = True
    End Sub

    Private Sub limpiarComponentes()
        txtNroCliente.Text = ""
        'txtNroDocumento.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtFechaAlta.Text = ""
        txtFechaBaja.Text = ""
        txtNroCompu.Text = ""
        txtPcsRegistradas.Text = ""
        txtCantMemoria.Text = ""
        txtCapAlm.Text = ""
        'cbTipoDoc.SelectedValue = 1
        cbTipoPc.SelectedValue = 1
        cbTipoMemoria.SelectedValue = -1
        cbModeloProc.SelectedValue = -1
        cbMarcaProc.SelectedValue = -1

    End Sub


    Private Sub btnMostrarPcs_Click(sender As Object, e As EventArgs) Handles btnMostrarPcs.Click
        Dim grilla As New GrillaGenerica("Computadoras Por Cliente", GrillaGenerica.formularios.COMPUTADORAS_CLIENTE, Me, clienteActual)
        grilla.ShowDialog()
        filaBuscada = Nothing
    End Sub

    Private Sub btnGestionPc_Click(sender As Object, e As EventArgs) Handles btnGestionPc.Click
        Dim formCompus As New GestionComputadoras(clienteActual)
        formCompus.ShowDialog()
    End Sub
End Class
Public Class GestionComputadoras
    Implements Buscable

    Private cliente As ClienteDto
    Private cargado As Boolean
    Private computadoraActual As ComputadoraDto
    Private filaBuscada As DataGridViewRow

    Public Sub New(ByRef cliente As ClienteDto)
        InitializeComponent()
        Me.cliente = cliente
    End Sub


    Private Sub GestionComputadoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.cargarCombo("tipoDocumento", cbTipoDoc)
        Utilidades.cargarCombo("tipoMemoria", cbTipoMemoria)
        Utilidades.cargarCombo("tipoPc", cbTipoPc)
        Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
        Utilidades.cargarCombo("computadora", "idComputadora", "client", cliente.idCliente, cbPcsRegistradas, "idComputadora")
        cbMarcaProc.SelectedValue = -1
        cbPcsRegistradas.SelectedValue = -1
        cbTipoDoc.SelectedValue = cliente.tipoDocumento
        txtApellido.Text = cliente.apellido
        txtNroDocumento.Text = cliente.nroDocumento
        txtNombre.Text = cliente.nombre
        txtFechaBajaPc.Enabled = False
        Me.deshabilitarComponentes()
        cargado = True
    End Sub

    Private Sub cbMarcaProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarcaProc.SelectedIndexChanged
        If cargado Then

            If IsNumeric(cbMarcaProc.SelectedValue) Then
                Dim valor As Int32 = cbMarcaProc.SelectedValue
                If valor > 0 Then
                    cbModeloProc.DataSource = Nothing
                    Utilidades.cargarCombo("procesador", "idProcesador", "marca", valor, cbModeloProc)
                    cbModeloProc.SelectedValue = -1
                End If
            End If

        End If
    End Sub

    Private Sub cbPcsRegistradas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPcsRegistradas.SelectedIndexChanged

        If cargado Then
            Me.habilitarComponentes()
            btnActualizarPc.Enabled = True
            If cbPcsRegistradas.SelectedValue > 0 Then
                computadoraActual = ComputadoraDao.buscarComputadora(Convert.ToInt32(cbPcsRegistradas.SelectedValue))
                txtNroCompu.Text = computadoraActual.idComputadora
                cbTipoPc.SelectedValue = computadoraActual.tipoPc

                If computadoraActual.tipoMemoria <> 0 Then
                    cbTipoMemoria.SelectedValue = computadoraActual.tipoMemoria
                End If

                If computadoraActual.cantidadMemoria <> 0 Then
                    txtCantMemoria.Text = computadoraActual.cantidadMemoria
                Else : txtCantMemoria.Text = ""
                End If

                If computadoraActual.capAlmacenamiento <> 0 Then
                    txtCapAlm.Text = computadoraActual.capAlmacenamiento
                Else : txtCapAlm.Text = ""
                End If

                If computadoraActual.procesador <> 0 Then
                    cbMarcaProc.SelectedValue = computadoraActual.marcaProcesador
                    cbModeloProc.SelectedValue = computadoraActual.procesador
                End If

                If computadoraActual.fechaBaja.Equals(Nothing) Then
                    chkEstadoPc.Checked = True
                Else : chkEstadoPc.Checked = False

                End If

            End If
        End If

    End Sub

    Private Sub chkEstadoPc_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoPc.CheckedChanged

        If chkEstadoPc.Checked Then
            chkEstadoPc.Text = "Activo"
            txtFechaBajaPc.Text = ""

        Else

            chkEstadoPc.Text = "Inactivo"
            If Not computadoraActual.fechaBaja.Equals(Nothing) Then
                txtFechaBajaPc.Text = computadoraActual.fechaBaja.ToString("dd/MM/yyyy")
            Else
                txtFechaBajaPc.Text = Date.Today.ToString("dd/MM/yyyy")
            End If


        End If


    End Sub

    Private Sub btnGuardarPc_Click(sender As Object, e As EventArgs) Handles btnGuardarPc.Click

        computadoraActual = New ComputadoraDto
        computadoraActual.idComputadora = Convert.ToInt32(txtNroCompu.Text)
        computadoraActual.tipoPc = Convert.ToInt32(cbTipoPc.SelectedValue)

        If cbTipoMemoria.SelectedValue > 0 Then
            computadoraActual.tipoMemoria = Convert.ToInt32(cbTipoMemoria.SelectedValue)
        End If
        If cbModeloProc.SelectedValue > 0 Then
            computadoraActual.procesador = Convert.ToInt32(cbModeloProc.SelectedValue)
        End If
        If txtCantMemoria.TextLength > 0 Then
            computadoraActual.cantidadMemoria = Convert.ToInt32(txtCantMemoria.Text)
        End If
        If txtCapAlm.TextLength > 0 Then
            computadoraActual.capAlmacenamiento = Convert.ToInt32(txtCapAlm.Text)
        End If
        computadoraActual.fechaAlta = Date.Today
        computadoraActual.nroCliente = cliente.idCliente

        Dim result As Conexion.EventosSql = ComputadoraDao.insertarComputadora(computadoraActual)

        If result = Conexion.EventosSql.INSERCION_CORRECTA Then
            MessageBox.Show("La computadora se insertó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Utilidades.cargarCombo("computadora", "idComputadora", "client", cliente.idCliente, cbPcsRegistradas, "idComputadora")
            Me.limpiarComponentes()
            Me.deshabilitarComponentes()
        Else : MessageBox.Show("Ocurrió un error al insertar la nueva computadora", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnMostrarPcs_Click(sender As Object, e As EventArgs) Handles btnMostrarPcs.Click
        Dim grilla As New GrillaGenerica("Computadoras", GrillaGenerica.formularios.COMPUTADORAS_CLIENTE, Me, cliente)
        grilla.ShowDialog()

        If Not IsNothing(filaBuscada) Then
            computadoraActual = New ComputadoraDto
            computadoraActual.idComputadora = Convert.ToInt32(filaBuscada.Cells("ID Computadora").Value)
            computadoraActual.tipoPc = Convert.ToInt32(filaBuscada.Cells("ID Tipo Pc").Value)
            ' computadoraActual.nroCliente = Convert.ToInt32(filaBuscada.Cells("Cliente").Value)
            computadoraActual.nroCliente = cliente.idCliente

            If Not IsDBNull(filaBuscada.Cells("ID Tipo Memoria").Value) Then
                computadoraActual.tipoMemoria = Convert.ToInt32(filaBuscada.Cells("ID Tipo Memoria").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("ID Procesador").Value) Then
                computadoraActual.procesador = Convert.ToInt32(filaBuscada.Cells("ID Procesador").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Marca Procesador").Value) Then
                computadoraActual.marcaProcesador = Convert.ToInt32(filaBuscada.Cells("Marca Procesador").Value)

            End If
            If Not IsDBNull(filaBuscada.Cells("Cantidad de Memoria").Value) Then
                computadoraActual.cantidadMemoria = Convert.ToInt32(filaBuscada.Cells("Cantidad de Memoria").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Almacenamiento").Value) Then
                computadoraActual.capAlmacenamiento = Convert.ToInt32(filaBuscada.Cells("Almacenamiento").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Fecha Baja").Value) Then
                computadoraActual.fechaBaja = CDate(filaBuscada.Cells("Fecha Baja").Value)
            Else : computadoraActual.fechaBaja = Nothing
            End If

            txtNroCompu.Text = computadoraActual.idComputadora
            cbTipoPc.SelectedValue = computadoraActual.tipoPc

            If computadoraActual.procesador > 0 Then
                cbMarcaProc.SelectedValue = computadoraActual.marcaProcesador
                cbModeloProc.SelectedValue = computadoraActual.procesador
            End If

            If computadoraActual.tipoMemoria > 0 Then
                cbTipoMemoria.SelectedValue = computadoraActual.tipoMemoria
            End If

            If computadoraActual.cantidadMemoria > 0 Then
                txtCantMemoria.Text = computadoraActual.cantidadMemoria
            End If
            If computadoraActual.capAlmacenamiento > 0 Then
                txtCapAlm.Text = computadoraActual.capAlmacenamiento
            End If

            If Not computadoraActual.fechaBaja.Equals(Nothing) Then
                chkEstadoPc.Checked = False
                chkEstadoPc.Text = "Inactivo"
                txtFechaBajaPc.Text = computadoraActual.fechaBaja.ToString("dd/MM/yyyy")
            Else : chkEstadoPc.Checked = True

            End If
            Me.habilitarComponentes()
            btnActualizarPc.Enabled = True
        End If


    End Sub


    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila

    End Sub

    

    Public Sub limpiarComponentes()
        txtNroCompu.Text = ""
        cbTipoPc.SelectedValue = 1
        cbTipoMemoria.SelectedValue = -1
        cbMarcaProc.SelectedValue = -1
        cbModeloProc.SelectedValue = -1
        txtCapAlm.Text = ""
        txtCantMemoria.Text = ""
        txtFechaBajaPc.Enabled = False
        chkEstadoPc.Checked = True

    End Sub


    Public Sub deshabilitarComponentes()

        txtNroCompu.Enabled = False
        txtCantMemoria.Enabled = False
        txtCapAlm.Enabled = False
        txtFechaBajaPc.Enabled = False
        cbMarcaProc.Enabled = False
        cbTipoPc.Enabled = False
        cbTipoMemoria.Enabled = False
        txtFechaBajaPc.Enabled = False
        txtNroDocumento.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        btnGuardarPc.Enabled = False
        btnActualizarPc.Enabled = False
    End Sub

    Public Sub habilitarComponentes()

        txtNroCompu.Enabled = False
        txtCantMemoria.Enabled = True
        txtCapAlm.Enabled = True

        cbMarcaProc.Enabled = True
        cbTipoPc.Enabled = True
        cbTipoMemoria.Enabled = True
    End Sub

    Private Sub btnNuevaPc_Click(sender As Object, e As EventArgs) Handles btnNuevaPc.Click
        Me.limpiarComponentes()
        Me.habilitarComponentes()
        btnGuardarPc.Enabled = True
        cbPcsRegistradas.SelectedValue = -1
        btnActualizarPc.Enabled = False
        txtNroCompu.Text = Utilidades.sugerirId("computadora", "idComputadora")
    End Sub

    Private Sub btnActualizarPc_Click(sender As Object, e As EventArgs) Handles btnActualizarPc.Click

        If cbTipoMemoria.SelectedValue > 0 Then
            computadoraActual.tipoMemoria = Convert.ToInt32(cbTipoMemoria.SelectedValue)
        End If
        If cbModeloProc.SelectedValue > 0 Then
            computadoraActual.procesador = Convert.ToInt32(cbModeloProc.SelectedValue)
        End If
        If txtCantMemoria.TextLength > 0 Then
            computadoraActual.cantidadMemoria = Convert.ToInt32(txtCantMemoria.Text)
        End If
        If txtCapAlm.TextLength > 0 Then
            computadoraActual.capAlmacenamiento = Convert.ToInt32(txtCapAlm.Text)
        End If

        If chkEstadoPc.Checked = False Then

            If computadoraActual.fechaBaja.Equals(Nothing) Then
                computadoraActual.fechaBaja = Date.Today
            End If
        Else : computadoraActual.fechaBaja = Nothing

        End If

        Dim result As Conexion.EventosSql = ComputadoraDao.actualizarComputadora(computadoraActual)

        If result = Conexion.EventosSql.INSERCION_CORRECTA Then
            MessageBox.Show("El registro se actualizó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.limpiarComponentes()
            Me.deshabilitarComponentes()
        Else
            MessageBox.Show("Ocurrió un error al actualizar el registro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnCancelarPc_Click(sender As Object, e As EventArgs) Handles btnCancelarPc.Click
        Me.limpiarComponentes()
        Me.deshabilitarComponentes()
        cbPcsRegistradas.SelectedValue = -1
    End Sub
End Class
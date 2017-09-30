Public Class gestionClientes
    Implements Buscable
    Private clienteBuscado As Boolean
    Private filaBuscada As DataGridViewRow
    Private clienteActual As ClienteDto
    Private desdeOt As Boolean
    Private cargado As Boolean

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

        ' el modelo de procesador se carga cuando cambia la seleccion del como marca
        cargado = True
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Me.limpiarComponentes()
        Me.habilitarComponentes()
        txtNroCliente.Text = Utilidades.sugerirId("cliente", "idCliente")
        txtNroCompu.Text = Utilidades.sugerirId("computadora", "idComputadora")
        txtNroCliente.Enabled = False
        txtNroCompu.Enabled = False
        btnBuscar.Enabled = False
        txtFechaAlta.Text = Date.Today.ToString("dd/MM/yyyy")
        txtNroDocumento.Focus()
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

            If cantFilas = 1 Then
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

            End If








        End If

    End Sub

    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress, txtTelefono.KeyPress, txtCantMemoria.KeyPress, txtCapAlm.KeyPress, txtNroCliente.KeyPress, txtNroCompu.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then
            e.Handled = True
        End If

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

    End Sub

    Private Sub habilitarComponentes()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        'chkEstadoCliente.Enabled = True

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
        'txtNroCompu.Text = ""
        txtCantMemoria.Text = ""
        txtCapAlm.Text = ""
        'cbTipoDoc.SelectedValue = 1
        cbTipoPc.SelectedValue = 1
        cbTipoMemoria.SelectedValue = -1
        'cbModeloProc.SelectedValue = -1
        'cbMarcaProc.SelectedValue = -1

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
            If IsNumeric(cbMarcaProc.SelectedValue.ToString()) Then
                Dim valor As Int32 = cbMarcaProc.SelectedValue
                If valor > 0 Then
                    cbModeloProc.DataSource = Nothing
                    Utilidades.cargarCombo("procesador", "idProcesador", "marca", valor, cbModeloProc)
                    cbModeloProc.SelectedValue = -1
                End If

            End If
        End If


    End Sub

    

  
    Private Sub txtNroDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtNroDocumento.TextChanged

    End Sub
End Class
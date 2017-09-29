Public Class gestionClientes


    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.deshabilitarComponentes()
        Utilidades.cargarCombo("tipoDocumento", cbTipoDoc)
        Utilidades.cargarCombo("tipoPc", cbTipoPc)
        Utilidades.cargarCombo("tipoMemoria", cbTipoMemoria)
        Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
        ' el modelo se carga cuando cambia la seleccion del como marca

    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Me.limpiarComponentes()
        Me.habilitarComponentes()
        txtNroCliente.Enabled = False
        txtNroCliente.Text = Utilidades.sugerirId("cliente", "idCliente")
        txtNroCompu.Text = Utilidades.sugerirId("computadora", "idComputadora")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub txtNroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocumento.KeyPress, txtTelefono.KeyPress, txtCantMemoria.KeyPress, txtCapAlm.KeyPress
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
        chkBajaCliente.Enabled = False
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
        txtFechaAlta.Enabled = True
        txtFechaBaja.Enabled = True
        chkBajaCliente.Enabled = True
        txtNroCompu.Enabled = False
        cbTipoPc.Enabled = True
        cbMarcaProc.Enabled = True
        cbModeloProc.Enabled = True
        cbTipoMemoria.Enabled = True
        txtCantMemoria.Enabled = True
        txtCapAlm.Enabled = True
        btnGuardar.Enabled = True
        btnActualizarCli.Enabled = True
    End Sub

    Private Sub limpiarComponentes()
        txtNroCliente.Text = ""
        txtNroDocumento.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtFechaAlta.Text = ""
        txtFechaBaja.Text = ""
        txtNroCompu.Text = ""
        txtCantMemoria.Text = ""
        txtCapAlm.Text = ""
        cbTipoDoc.SelectedValue = 1
        cbTipoPc.SelectedValue = 1
        cbTipoMemoria.SelectedValue = -1
        cbModeloProc.SelectedValue = -1
        cbMarcaProc.SelectedValue = -1

    End Sub
  
    
End Class
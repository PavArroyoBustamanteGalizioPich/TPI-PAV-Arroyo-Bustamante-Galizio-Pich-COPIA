Public Class ABMCOrdenTrabajo

    Private clienteActual As ClienteDto
    Private computadoraActual As ComputadoraDto

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





    End Sub

    Private Sub txtNroDocCliOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroDocCliOT.KeyPress, txtNroOT.KeyPress
        If (Not IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

        End If
    End Sub



    Private Sub btnGuardarOt_Click(sender As Object, e As EventArgs) Handles btnGuardarOt.Click
        Dim msjError As String = ""

        If (txtNroCliente.Text.Equals("")) Then
            msjError &= "- Debe especificar un cliente" & vbCrLf
        End If

        If (txtDescrFallaOt.Text.Equals("")) Then
            msjError &= "- La descripción de la falla no puede quedar vacía" & vbCrLf
        End If

        If (txtFechaRecepcionOt.Text.Equals("  /  /")) Then
            txtFechaRecepcionOt.Text = Format(Date.Now, "dd/MM/yyyy")
        ElseIf (Not txtFechaRecepcionOt.Text = Format(CDate(txtFechaRecepcionOt.Text), "dd/MM/yyyy")) Then
            msjError &= "- Ingrese una fecha valida (dd/mm/aaaa)"

        End If


        If (Not msjError.Equals("")) Then
            MessageBox.Show(msjError, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub


    Private Sub btnBuscarCliOT_Click(sender As Object, e As EventArgs) Handles btnBuscarCliOT.Click


        If Not txtNroDocCliOT.Text.Equals("") Then

            clienteActual = ClienteDao.buscarCliente(cbTipoDocOT.SelectedValue, txtNroDocCliOT.Text.Trim())

            If IsNothing(clienteActual) Then
                If MessageBox.Show("El Cliente no existe, desea agregarlo?", "Existe Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim gestionClientes As New GestionClientes(txtNroDocCliOT.Text.Trim(), cbTipoDocOT.SelectedValue, clienteActual)
                    gestionClientes.ShowDialog()
                    btnBuscarCliOT.PerformClick()

                End If

            End If

            If Not IsNothing(clienteActual) Then
                txtNroCliente.Text = clienteActual.idCliente
                txtNombreCLiente.Text = clienteActual.nombre
                txtApellidoCliente.Text = clienteActual.apellido
                Utilidades.cargarCombo("computadora", "idComputadora", "client", clienteActual.idCliente, cbNroPc, "idComputadora")
                cbNroPc.SelectedValue = -1
                If Not IsNothing(computadoraActual) Then
                    txtDescripcionPcOt.Text = computadoraActual.toString()
                End If

            End If


        Else



        End If

        


    End Sub

    Private Sub btnBuscarOT_Click(sender As Object, e As EventArgs) Handles btnBuscarOT.Click
        If Not txtNroOT.Text.Equals("") Then

            panelDatosNvaOt.Enabled = True
            panelDatosClienteOt.Enabled = False
            panelDatosPcOt.Enabled = False
            txtFechaRecepcionOt.Enabled = False
            txtDescrFallaOt.Enabled = False
            btnCancelarOt.Enabled = True
            btnNvaOt.Enabled = False
            btnGuardarOt.Enabled = True


        Else
            MessageBox.Show("- Ingrese un número de Orden de trabajo!", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNroOT.Focus()

        End If

        ' SI LA OT SE ENCUENTRA SE ACTIVA EL BOTON ACTUALIZAR y los paneles aniadirServicio y aniadirReparacion
    End Sub

    Private Sub btnActualizarOt_Click(sender As Object, e As EventArgs) Handles btnActualizarOt.Click
        'Esto va a ser más facil validarlo cuando esté listo el acceso a datos
    End Sub

    Private Sub limpiarTextos()

        txtNroDocCliOT.Text = ""
        txtNroOT.Text = ""
        txtNombreCLiente.Text = ""
        txtApellidoCliente.Text = ""
        txtTipoPcOt.Text = ""
        txtFechaRecepcionOt.Text = ""
        txtTipoRepRequerido.Text = ""
        txtDescrFallaOt.Text = ""
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
                computadoraActual = ComputadoraDao.buscarComputadora(Convert.ToInt32(cbNroPc.SelectedValue))
            End If


        End If


    End Sub
End Class
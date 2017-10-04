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
        cbTipoDoc.Enabled = False
        txtNroDocumento.Enabled = False
        txtApellido.Enabled = False
        txtNombre.Enabled = False


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

                If Not computadoraActual.fechaBaja.Equals(Nothing) Then
                    chkEstadoPc.Checked = True

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

    End Sub

    Private Sub btnMostrarPcs_Click(sender As Object, e As EventArgs) Handles btnMostrarPcs.Click
        Dim grilla As New GrillaGenerica("Computadoras", GrillaGenerica.formularios.COMPUTADORAS_CLIENTE, Me, cliente)
        grilla.ShowDialog()

        If Not IsNothing(filaBuscada) Then
            computadoraActual = New ComputadoraDto
            computadoraActual.idComputadora = Convert.ToInt32(filaBuscada.Cells("ID Computadora").Value)
            computadoraActual.tipoPc = Convert.ToInt32(filaBuscada.Cells("ID Tipo Pc").Value)
            ' computadoraActual.nroCliente = Convert.ToInt32(filaBuscada.Cells("Cliente").Value)


            If Not IsDBNull(filaBuscada.Cells("ID Tipo Memoria")) Then
                computadoraActual.tipoMemoria = Convert.ToInt32(filaBuscada.Cells("ID Tipo Memoria").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("ID Procesador")) Then
                computadoraActual.procesador = Convert.ToInt32(filaBuscada.Cells("ID Procesador").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Marca Procesador")) Then
                computadoraActual.marcaProcesador = Convert.ToInt32(filaBuscada.Cells("Marca Procesador").Value)

            End If
            If Not IsDBNull(filaBuscada.Cells("Cantidad de Memoria")) Then
                computadoraActual.cantidadMemoria = Convert.ToInt32(filaBuscada.Cells("Cantidad de Memoria").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Almacenamiento")) Then
                computadoraActual.capAlmacenamiento = Convert.ToInt32(filaBuscada.Cells("Almacenamiento").Value)

            End If

            If Not IsDBNull(filaBuscada.Cells("Fecha Baja")) Then
                computadoraActual.fechaBaja = CDate(filaBuscada.Cells("Fecha Baja").Value)

            End If

            


        End If


    End Sub


    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila

    End Sub
End Class
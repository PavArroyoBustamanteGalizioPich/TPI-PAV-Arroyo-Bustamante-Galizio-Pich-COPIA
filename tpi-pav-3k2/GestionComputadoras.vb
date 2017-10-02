Public Class GestionComputadoras

    Private cliente As ClienteDto
    Private cargado As Boolean
    Private computadoraActual As ComputadoraDto

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
                'falta agregarle la marca de procesador a la tabla computadora
                If computadoraActual.procesador <> 0 Then
                    cbTipoMemoria.SelectedValue = computadoraActual.tipoMemoria
                End If

            End If
        End If

    End Sub
End Class
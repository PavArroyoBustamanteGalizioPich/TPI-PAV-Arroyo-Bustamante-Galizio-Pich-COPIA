Public Class ACTipoDocumento
    Implements Buscable

    Private filaBuscada As DataGridViewRow
    Private tipoDocBuscado As Boolean

    Private Sub ACTipoDocumento_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, btnBuscar.KeyUp, btnCancelar.KeyUp, btnGuardar.KeyUp, btnNvoTipoDoc.KeyUp, txtIdTipoDoc.KeyUp, txtDescripTipoDoc.KeyUp, txtTipoDoc.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
    Private Sub ACTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescripTipoDoc.Enabled = False
        txtTipoDoc.Enabled = False
        btnGuardar.Enabled = False
        filaBuscada = Nothing

    End Sub



    Private Sub btnNvoTipoDoc_Click(sender As Object, e As EventArgs) Handles btnNvoTipoDoc.Click
        txtIdTipoDoc.Text = Utilidades.sugerirId("tipoDocumento", "idTipoDocumento")
        txtIdTipoDoc.Enabled = False
        txtTipoDoc.Enabled = True
        txtDescripTipoDoc.Enabled = True
        txtDescripTipoDoc.Text = ""
        txtTipoDoc.Enabled = True
        btnGuardar.Enabled = True
        txtTipoDoc.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarDatos() Then
            Dim tipoDocumento As New TiposVo
            tipoDocumento.id = Convert.ToInt32(txtIdTipoDoc.Text)
            tipoDocumento.nombreTipo = txtTipoDoc.Text
            tipoDocumento.descripcionTipo = txtDescripTipoDoc.Text
            If Not tipoDocBuscado Then
                Dim cant As Int32 = TipoDocumentoDao.insertarTipoDocumento(tipoDocumento)
                If cant = 1 Then
                    MessageBox.Show("Tipo Documento insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdTipoDoc.Text = Utilidades.sugerirId("tipoDocumento", "idTipoDocumento")
                    txtTipoDoc.Text = ""
                    txtDescripTipoDoc.Text = ""

                Else : MessageBox.Show("No se pudo insertar el tipo de documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                Dim cant As Int32 = TipoDocumentoDao.actualizarTipoDocumento(tipoDocumento)
                If cant = 1 Then
                    MessageBox.Show("El registro se ha actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdTipoDoc.Text = ""
                    txtTipoDoc.Text = ""
                    txtDescripTipoDoc.Text = ""
                    btnGuardar.Enabled = False
                    txtIdTipoDoc.Enabled = True
                    txtTipoDoc.Enabled = False
                    txtDescripTipoDoc.Enabled = False
                    tipoDocBuscado = False
                    btnBuscar.Enabled = True
                Else : MessageBox.Show("El registro no pudo ser actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not txtIdTipoDoc.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdTipoDoc.Text)
            Dim tipoDocumento As TiposVo = TipoDocumentoDao.buscarTipoDocumento(id)
            If Not IsNothing(tipoDocumento.id) Then
                btnGuardar.Enabled = True
                txtIdTipoDoc.Enabled = False
                txtTipoDoc.Enabled = True
                txtDescripTipoDoc.Enabled = True
                txtIdTipoDoc.Text = tipoDocumento.id
                txtTipoDoc.Text = tipoDocumento.nombreTipo
                txtDescripTipoDoc.Text = tipoDocumento.descripcionTipo
                tipoDocBuscado = True
            End If

        Else
            Dim grilla As New grillaGenerica("Tipos de Documento", grillaGenerica.formularios.TIPO_DOCUMENTO, Me)
            grilla.ShowDialog()
            If Not IsNothing(filaBuscada) Then
                txtIdTipoDoc.Enabled = False
                txtTipoDoc.Enabled = True
                txtDescripTipoDoc.Enabled = True
                txtIdTipoDoc.Text = filaBuscada.Cells(0).Value.ToString()
                txtTipoDoc.Text = filaBuscada.Cells(1).Value.ToString()
                txtDescripTipoDoc.Text = filaBuscada.Cells(2).Value.ToString()
                tipoDocBuscado = True
                btnGuardar.Enabled = True
                filaBuscada = Nothing

            End If


        End If

    End Sub

    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub



    Public Function validarDatos() As Boolean
        Dim msjError As String = ""

        If txtTipoDoc.Text.Equals("") Then
            msjError &= "El nombre del tipo de documento no puede quedar vacio!" & vbCrLf
        End If

        If txtDescripTipoDoc.Text.Equals("") Then
            msjError &= "La descripcion del tipoo de documento no puede quedar vacia!" & vbCrLf
        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True

    End Function

    Private Sub txtIdTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdTipoDoc.KeyPress

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub

    
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdTipoDoc.Enabled = True
        txtIdTipoDoc.Text = ""
        txtTipoDoc.Enabled = False
        txtTipoDoc.Text = ""
        txtDescripTipoDoc.Enabled = False
        txtDescripTipoDoc.Text = ""
        txtIdTipoDoc.Focus()
    End Sub

    
    
End Class
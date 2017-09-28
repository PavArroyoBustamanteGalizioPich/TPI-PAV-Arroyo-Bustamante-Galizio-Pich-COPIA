Public Class ABMTipoPc_Memoria
    Implements Buscable
    Private tipoPCBuscado As Boolean
    Private tipoMemBuscada As Boolean
    Private filabuscada As DataGridViewRow

    'parte tipo memoria
    Private Sub ABMTipoPc_Memoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTipoMemoria.Enabled = False
        txtTipoPc.Enabled = False
        txtDescrMemoria.Enabled = False
        txtDescrTPc.Enabled = False
        btnGuardarMem.Enabled = False
        btnGuardarTpc.Enabled = False
        tipoMemBuscada = False
        tipoPCBuscado = False
    End Sub

    Private Sub btnGuardarMem_Click(sender As Object, e As EventArgs) Handles btnGuardarMem.Click

        If validarTipoMemoria() Then
            Dim tipoMemoria As New TiposVo
            tipoMemoria.id = Convert.ToInt32(txtIdMemoria.Text)
            tipoMemoria.nombreTipo = txtTipoMemoria.Text
            tipoMemoria.descripcionTipo = txtDescrMemoria.Text
            If Not tipoMemBuscada Then
                Dim cant As Int32 = TipoMemoriaDao.insertarTipoMemoria(tipoMemoria)
                If cant = 1 Then
                    MessageBox.Show("Tipo Memoria insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdMemoria.Text = Utilidades.sugerirId("tipoMemoria", "idTipoMemoria")
                    txtTipoMemoria.Text = ""
                    txtDescrMemoria.Text = ""

                Else : MessageBox.Show("No se pudo insertar el tipo de memoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                Dim cant As Int32 = TipoMemoriaDao.actualizarTipoMemoria(tipoMemoria)
                If cant = 1 Then
                    MessageBox.Show("El registro se ha actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdMemoria.Text = ""
                    txtTipoMemoria.Text = ""
                    txtDescrMemoria.Text = ""
                    btnGuardarMem.Enabled = False
                    txtIdMemoria.Enabled = True
                    txtTipoMemoria.Enabled = False
                    txtDescrMemoria.Enabled = False
                    tipoMemBuscada = False
                    btnBuscarTMem.Enabled = True
                Else : MessageBox.Show("El registro no pudo ser actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        End If

    End Sub


    Private Sub txtIdMemoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMemoria.KeyPress, txtIdTipoPc.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True

        End If
    End Sub

    Private Sub btnBuscarTMem_Click(sender As Object, e As EventArgs) Handles btnBuscarTMem.Click
        If Not txtIdMemoria.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdMemoria.Text)
            Dim tipoMemoria As TiposVo = TipoMemoriaDao.buscarTipoMemoria(id)
            If Not IsNothing(tipoMemoria.id) Then
                btnGuardarMem.Enabled = True
                txtIdMemoria.Enabled = False
                txtTipoMemoria.Enabled = True
                txtDescrMemoria.Enabled = True
                txtIdMemoria.Text = tipoMemoria.id
                txtTipoMemoria.Text = tipoMemoria.nombreTipo
                txtDescrMemoria.Text = tipoMemoria.descripcionTipo
                tipoMemBuscada = True
            End If

        Else
            Dim grilla As New grillaGenerica("Tipos de Memoria", grillaGenerica.formularios.TIPO_MEMORIA, Me)
            grilla.ShowDialog()
            If Not IsNothing(filabuscada) Then
                txtIdMemoria.Enabled = False
                txtTipoMemoria.Enabled = True
                txtDescrMemoria.Enabled = True
                txtIdMemoria.Text = filabuscada.Cells(0).Value.ToString()
                txtTipoMemoria.Text = filabuscada.Cells(1).Value.ToString()
                txtDescrMemoria.Text = filabuscada.Cells(2).Value.ToString()
                tipoMemBuscada = True
                btnGuardarMem.Enabled = True
                filabuscada = Nothing

            End If


        End If

    End Sub



    Private Sub btnNvoTipoMem_Click(sender As Object, e As EventArgs) Handles btnNvoTipoMem.Click
        txtTipoMemoria.Text = ""
        txtDescrMemoria.Text = ""
        txtIdMemoria.Text = Utilidades.sugerirId("tipoMemoria", "idTipoMemoria")
        txtIdMemoria.Enabled = False
        txtTipoMemoria.Enabled = True
        txtDescrMemoria.Enabled = True
        btnGuardarMem.Enabled = True
        tipoMemBuscada = False
        btnBuscarTMem.Enabled = False
    End Sub

    Private Function validarTipoMemoria() As Boolean
        Dim msjError As String = ""

        If txtTipoMemoria.Equals("") Then
            msjError &= "El nombre del tipo de memoria no puede quedar vacío!" & vbCrLf
        End If

        If txtDescrMemoria.Equals("") Then
            msjError &= "La descripción del tipo de memoria no puede quedar vacío!" & vbCrLf
        End If
        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else : Return True
        End If
    End Function

    Private Sub btnCancelarMem_Click(sender As Object, e As EventArgs) Handles btnCancelarMem.Click
        txtIdMemoria.Text = ""
        txtDescrMemoria.Text = ""
        txtTipoMemoria.Text = ""
        txtIdMemoria.Enabled = True
        txtTipoMemoria.Enabled = False
        txtDescrMemoria.Enabled = False
        btnNvoTipoMem.Enabled = True
        btnGuardarMem.Enabled = False
        btnBuscarTMem.Enabled = True

    End Sub


    
    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filabuscada = fila

    End Sub


    ' esta es la parte de tipo pc
    Private Sub btnNvoTipoPc_Click(sender As Object, e As EventArgs) Handles btnNvoTipoPc.Click
        txtTipoPc.Text = ""
        txtDescrTPc.Text = ""
        txtIdTipoPc.Text = Utilidades.sugerirId("tipoPC", "idTipoPc")
        txtIdTipoPc.Enabled = False
        txtTipoPc.Enabled = True
        txtDescrTPc.Enabled = True
        btnGuardarTpc.Enabled = True
        tipoPCBuscado = False
        btnBuscarTPc.Enabled = False
    End Sub

    Private Function validarTipoPC() As Boolean
        Dim msjError As String = ""

        If txtTipoPc.Equals("") Then
            msjError &= "El nombre del tipo de pc no puede quedar vacío!" & vbCrLf
        End If

        If txtDescrTPc.Equals("") Then
            msjError &= "La descripción del tipo de pc no puede quedar vacío!" & vbCrLf
        End If
        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else : Return True
        End If
    End Function

    Private Sub btnBuscarTPc_Click(sender As Object, e As EventArgs) Handles btnBuscarTPc.Click
        If Not txtIdTipoPc.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdTipoPc.Text)
            Dim tipoPC As TiposVo = TipoPcDao.buscarTipoPc(id)
            If Not IsNothing(tipoPC.id) Then
                btnGuardarTpc.Enabled = True
                txtIdTipoPc.Enabled = False
                txtTipoPc.Enabled = True
                txtDescrTPc.Enabled = True
                txtIdTipoPc.Text = tipoPC.id
                txtTipoPc.Text = tipoPC.nombreTipo
                txtDescrTPc.Text = tipoPC.descripcionTipo
                tipoPCBuscado = True
            End If

        Else
            Dim grilla As New grillaGenerica("Tipos de Memoria", grillaGenerica.formularios.TIPO_PC, Me)
            grilla.ShowDialog()
            If Not IsNothing(filabuscada) Then
                txtIdTipoPc.Enabled = False
                txtTipoPc.Enabled = True
                txtDescrTPc.Enabled = True
                txtIdTipoPc.Text = filabuscada.Cells(0).Value.ToString()
                txtTipoPc.Text = filabuscada.Cells(1).Value.ToString()
                txtDescrTPc.Text = filabuscada.Cells(2).Value.ToString()
                tipoPCBuscado = True
                btnGuardarTpc.Enabled = True
                filabuscada = Nothing

            End If


        End If
    End Sub

    Private Sub btnGuardarTpc_Click(sender As Object, e As EventArgs) Handles btnGuardarTpc.Click
        If validarTipoMemoria() Then
            Dim tipoPc As New TiposVo
            tipoPc.id = Convert.ToInt32(txtIdTipoPc.Text)
            tipoPc.nombreTipo = txtTipoPc.Text
            tipoPc.descripcionTipo = txtDescrTPc.Text
            If Not tipoPCBuscado Then
                Dim cant As Int32 = TipoPcDao.insertarTipoPc(tipoPc)
                If cant = 1 Then
                    MessageBox.Show("Tipo Pc insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdTipoPc.Text = Utilidades.sugerirId("tipoPC", "idTipoPc")
                    txtTipoPc.Text = ""
                    txtDescrTPc.Text = ""

                Else : MessageBox.Show("No se pudo insertar el tipo de PC", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            Else
                Dim cant As Int32 = TipoPcDao.actualizarTipoPc(tipoPc)
                If cant = 1 Then
                    MessageBox.Show("El registro se ha actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdTipoPc.Text = ""
                    txtTipoPc.Text = ""
                    txtDescrTPc.Text = ""
                    btnGuardarTpc.Enabled = False
                    txtIdTipoPc.Enabled = True
                    txtTipoPc.Enabled = False
                    txtDescrTPc.Enabled = False
                    tipoPCBuscado = False
                    btnBuscarTPc.Enabled = True
                Else : MessageBox.Show("El registro no pudo ser actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        End If
    End Sub

   
    Private Sub btnCancelarTPC_Click(sender As Object, e As EventArgs) Handles btnCancelarTPC.Click
        txtIdTipoPc.Text = ""
        txtDescrTPc.Text = ""
        txtTipoPc.Text = ""
        txtIdTipoPc.Enabled = True
        txtTipoPc.Enabled = False
        txtDescrTPc.Enabled = False
        btnNvoTipoPc.Enabled = True
        btnGuardarTpc.Enabled = False
        btnBuscarTPc.Enabled = True
    End Sub

    Private Sub txtTipoMemoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoMemoria.KeyPress, txtTipoPc.KeyPress, txtDescrTPc.KeyPress, txtDescrMemoria.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub




    Private Sub txtTipoMemoria_TextChanged(sender As Object, e As EventArgs) Handles txtTipoMemoria.TextChanged

    End Sub
End Class
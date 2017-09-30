Public Class ABMCProcesador
    Implements Buscable

    Private filaBuscada As DataGridViewRow
    Private procesadorBuscado As Boolean
    Private procesadorActual As ProcesadorDto

    Private tienePunto As Boolean

    Private Sub cbMarcaProc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbMarcaProc.KeyPress, txtModelProc.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub ABMCProcesador_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, btnBuscar.KeyUp, btnCancelar.KeyUp, btnGuardar.KeyUp, btnNuevo.KeyUp, txtCantCore.KeyUp, txtFrecuencia.KeyUp, txtIdProc.KeyUp, txtModelProc.KeyUp, cbMarcaProc.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
    Private Sub ABMCProcesador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
        Me.desabilitarComponentes()
        tienePunto = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If Not txtIdProc.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdProc.Text.Trim())
            procesadorActual = ProcesadorDao.buscarProcesador(id)

            If IsNothing(procesadorActual) Then

                MessageBox.Show("El id de procesador ingresado no corresponde a un procesador registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else ' en caso que deje vacio

            Dim grilla As New grillaGenerica("Procesadores", grillaGenerica.formularios.PROCESADOR, Me)
            grilla.ShowDialog()
            If Not IsNothing(filaBuscada) Then
                procesadorActual = New ProcesadorDto
                procesadorActual.idProcesador = Convert.ToInt32(filaBuscada.Cells(0).Value)
                procesadorActual.modelo = filaBuscada.Cells(1).Value.ToString()
                procesadorActual.fecuencia = Convert.ToSingle(filaBuscada.Cells(2).Value)
                procesadorActual.cantNucleos = Convert.ToInt32(filaBuscada.Cells(3).Value)
                procesadorActual.idMarca = Convert.ToInt32(filaBuscada.Cells(4).Value)
                procesadorActual.marca = filaBuscada.Cells(5).Value
                filaBuscada = Nothing
            End If

        End If
        If Not IsNothing(procesadorActual) Then
            txtIdProc.Enabled = False
            txtModelProc.Enabled = False
            cbMarcaProc.Enabled = False
            txtCantCore.Enabled = True
            txtFrecuencia.Enabled = True
            btnGuardar.Enabled = True
            txtIdProc.Text = procesadorActual.idProcesador
            cbMarcaProc.SelectedValue = procesadorActual.idMarca
            txtModelProc.Text = procesadorActual.modelo
            txtCantCore.Text = procesadorActual.cantNucleos
            txtFrecuencia.Text = procesadorActual.fecuencia
            procesadorBuscado = True
        End If


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarDatos() Then
            If Not procesadorBuscado Then


                procesadorActual = New ProcesadorDto
                procesadorActual.idProcesador = Convert.ToInt32(txtIdProc.Text.Trim())
                procesadorActual.modelo = txtModelProc.Text.Trim()
                procesadorActual.fecuencia = Convert.ToSingle(txtFrecuencia.Text)
                procesadorActual.cantNucleos = Convert.ToInt32(txtCantCore.Text.Trim())
                procesadorActual.idMarca = cbMarcaProc.SelectedValue
                procesadorActual.marca = cbMarcaProc.Text

                Dim cantFilas As Int32 = ProcesadorDao.insertarProcesador(procesadorActual)
                If cantFilas = 1 Then
                    MessageBox.Show("El procesador fue insertado correctamente!", "Información!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.limpiarComponentes()
                    txtIdProc.Text = Utilidades.sugerirId("procesador", "idProcesador")
                    Utilidades.cargarCombo("marcaProcesador", cbMarcaProc)
                    procesadorActual = Nothing
                Else

                    Select Case cantFilas
                        ' Case -2146232060
                        ' MessageBox.Show("El modelo de procesador ingresado ya pertenece a un procesador registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' Exit Select
                        Case -1
                            MessageBox.Show("Ocurrio un error al insertar la marca del procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Select
                        Case Else
                            MessageBox.Show("Ocurrió un error al insertar el procesador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Select

                End If

            Else
                If Not txtCantCore.Text.Equals("") And Not txtFrecuencia.Text.Equals("") Then
                    procesadorActual.cantNucleos = Convert.ToInt32(txtCantCore.Text.Trim())
                    procesadorActual.fecuencia = Convert.ToSingle(txtFrecuencia.Text)

                    Dim cantFilas As Int32 = ProcesadorDao.actualizarProcesador(procesadorActual)
                    If cantFilas = 1 Then
                        MessageBox.Show("El registro se ha actualizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        procesadorBuscado = False
                        procesadorActual = Nothing
                        Me.desabilitarComponentes()
                        Me.limpiarComponentes()
                        txtIdProc.Enabled = True
                        txtIdProc.Focus()
                    End If

                End If
            End If

        End If

    End Sub

    Private Sub txtCantCore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantCore.KeyPress, txtIdProc.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub


    Private Sub desabilitarComponentes()
        cbMarcaProc.Enabled = False
        txtModelProc.Enabled = False
        txtCantCore.Enabled = False
        txtFrecuencia.Enabled = False
        btnGuardar.Enabled = False
    End Sub

    Private Sub habilitarComponentes()
        cbMarcaProc.Enabled = True
        txtModelProc.Enabled = True
        txtCantCore.Enabled = True
        txtFrecuencia.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub limpiarComponentes()
        txtIdProc.Text = ""
        txtModelProc.Text = ""
        txtCantCore.Text = ""
        txtFrecuencia.Text = ""
        cbMarcaProc.SelectedItem = -1
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrecuencia.KeyPress
        If Not txtFrecuencia.Text.Equals("") Then
            If Asc(e.KeyChar) = 46 Then
                If tienePunto Then
                    e.Handled = True
                Else : tienePunto = True
                End If
            End If
        Else : tienePunto = False

        End If

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46) Then

            e.Handled = True
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.habilitarComponentes()
        Me.limpiarComponentes()
        txtIdProc.Enabled = False
        txtIdProc.Text = Utilidades.sugerirId("procesador", "idProcesador")
    End Sub

    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub

    Private Function validarDatos() As Boolean
        Dim msjError As String = ""

        If txtModelProc.Text.Equals("") Then
            msjError &= "El modelo del procesador no puede quedar vacío" & vbCrLf
        End If

        If txtFrecuencia.Text.Equals("") Then
            msjError &= "Debe indicar la frecuencia de trabajo del procesador" & vbCrLf
        ElseIf Not IsNumeric(txtFrecuencia.Text) Then
            msjError &= "La frecuencia de trabajo debe ser un número entero o decimal (use el punto (.) para como separador de decimales)" & vbCrLf
        End If
        If txtCantCore.Text.Equals("") Then
            msjError &= "Debe indicar la cantidad de núcleos (lógicos) que posee el procesador" & vbCrLf
        End If

        If cbMarcaProc.Text.Equals("") Then
            msjError &= "Debe indicar la marca del procesador" & vbCrLf
        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True

    End Function
    
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdProc.Enabled = True
        Me.limpiarComponentes()
        Me.desabilitarComponentes()
        procesadorActual = Nothing
        filaBuscada = Nothing
        txtIdProc.Focus()
    End Sub

   
    Private Sub cbMarcaProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarcaProc.SelectedIndexChanged

    End Sub
End Class
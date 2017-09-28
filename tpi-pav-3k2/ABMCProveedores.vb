Public Class ABMCProveedores
    Implements Buscable


    Private proveedorBuscado As Boolean
    Private filaBuscada As DataGridViewRow
    Private proveedorActual As ProveedorVo

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub


    Private Sub ABMCProveedores_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, txtIdProveedor.KeyUp, txtRazonSocial.KeyUp, txtCuit.KeyUp, txtTelefono.KeyUp, btnBuscar.KeyUp, btnNuevo.KeyUp, btnCancelar.KeyUp, btnGuardar.KeyUp

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.desabilitarComponentes()
        btnNuevo.Focus()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtIdProveedor.Enabled = False
        txtIdProveedor.Text = Utilidades.sugerirId("proveedor", "nroProveedor")
        txtCuit.Text = ""
        txtTelefono.Text = ""
        txtRazonSocial.Text = ""
        txtFechaBaja.Text = ""
        btnGuardar.Enabled = True
        txtRazonSocial.Enabled = True
        txtCuit.Enabled = True
        txtTelefono.Enabled = True
        txtFechaBaja.Enabled = False
        chkEstadoProov.Checked = True
        chkEstadoProov.Enabled = False
        chkEstadoProov.Text = "Activo"
        proveedorActual = Nothing


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click



        If Not txtIdProveedor.Text.Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdProveedor.Text)
            proveedorActual = ProveedorDao.buscarProveedor(id)
            If IsNothing(proveedorActual) Then
                MessageBox.Show("El id de proveedor ingresado no corresponde a un proveedor registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            ' aca es en el caso que deje el campo nro vacio
            Dim grilla As New grillaGenerica("Proveedores", grillaGenerica.formularios.PROVEEDOR, Me)
            grilla.ShowDialog()
            'If Not filaBuscada.Equals(Nothing) Then
            If Not IsNothing(filaBuscada) Then
                proveedorActual = New ProveedorVo
                proveedorActual.nroProveedor = Convert.ToInt32(filaBuscada.Cells(0).Value.ToString())
                proveedorActual.razonSocial = filaBuscada.Cells(1).Value.ToString()
                proveedorActual.cuit = filaBuscada.Cells(2).Value.ToString()

                If Not IsDBNull(filaBuscada.Cells(3).Value) Then
                    proveedorActual.telefono = filaBuscada.Cells(3).Value.ToString()
                Else : proveedorActual.telefono = Nothing

                End If
                If Not IsDBNull(filaBuscada.Cells(4).Value) Then
                    proveedorActual.fechaBaja = CDate(filaBuscada.Cells(4).Value)
                Else : proveedorActual.fechaBaja = Nothing
                End If

                btnBuscar.Enabled = True
                filaBuscada = Nothing
            End If

        End If

        If Not IsNothing(proveedorActual) Then
            proveedorBuscado = True
            txtIdProveedor.Enabled = False
            txtIdProveedor.Text = proveedorActual.nroProveedor
            txtRazonSocial.Text = proveedorActual.razonSocial
            txtRazonSocial.Enabled = True
            txtCuit.Text = proveedorActual.cuit
            If Not IsNothing(proveedorActual.telefono) Then
                txtTelefono.Text = proveedorActual.telefono

            End If
            txtTelefono.Enabled = True

            If Not proveedorActual.fechaBaja.Equals(Nothing) Then
                chkEstadoProov.Checked = False
                chkEstadoProov.Text = "Inactivo"
                txtFechaBaja.Text = proveedorActual.fechaBaja.ToString("dd/MM/yyyy")
            Else
                chkEstadoProov.Checked = True
                chkEstadoProov.Text = "Activo"
                txtFechaBaja.Text = ""
            End If
            chkEstadoProov.Enabled = True
            btnGuardar.Enabled = True

        End If





    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If validarDatos() Then
            Dim cantFilas As Int32
            

            If Not proveedorBuscado Then

                Dim proveedor As New ProveedorVo
                proveedor.nroProveedor = Convert.ToInt32(txtIdProveedor.Text.Trim())
                proveedor.razonSocial = txtRazonSocial.Text
                proveedor.cuit = txtCuit.Text
                If Not txtTelefono.Text.Length < 6 Then
                    proveedor.telefono = txtTelefono.Text
                Else : proveedor.telefono = Nothing
                End If
                proveedor.fechaBaja = Nothing
                cantFilas = ProveedorDao.insertarProveedor(proveedor)
                If cantFilas = 1 Then
                    MessageBox.Show("Proveedor insertado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIdProveedor.Text = Utilidades.sugerirId("proveedor", "nroProveedor")
                    txtRazonSocial.Text = ""
                    txtCuit.Text = ""
                    txtTelefono.Text = ""
                    txtRazonSocial.Focus()
                Else
                    If cantFilas = -2146232060 Then
                        MessageBox.Show("El cuit que inteta registrar ya pertenece a un proveedor registrado ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else : MessageBox.Show("Ocurrió un error al insertar el proveedor! ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If


                End If

            Else

                
                If Not txtTelefono.Text.Equals("") Then
                    proveedorActual.telefono = txtTelefono.Text.Trim()
                Else : proveedorActual.telefono = Nothing
                End If

                If chkEstadoProov.Checked Then
                    proveedorActual.fechaBaja = Nothing
                End If

                proveedorActual.razonSocial = txtRazonSocial.Text.Trim()

                'la parte de la actualizacion no anda
                cantFilas = ProveedorDao.actualizarProveedor(proveedorActual)
                If cantFilas = 1 Then
                    MessageBox.Show("El registro se ha actualizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.desabilitarComponentes()
                    Me.limpiarComponentes()
                    txtIdProveedor.Focus()
                    proveedorBuscado = False

                Else : MessageBox.Show("El registro no pudo ser actualizado! ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

            proveedorActual = Nothing


        End If

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.desabilitarComponentes()
        Me.limpiarComponentes()
        proveedorActual = Nothing
        txtIdProveedor.Focus()

    End Sub

    Public Function validarDatos() As Boolean
        Dim msjError As String = ""

        If txtRazonSocial.Text.Equals("") Then
            msjError &= "La razon social es obligatoria!" & vbCrLf
        End If

        If txtCuit.Text.Equals("") Then
            msjError &= "El cuit no puede quedar vacío" & vbCrLf
        Else
            If txtCuit.Text.Length < 11 Then
                msjError &= "El cuit ingresado no es válido" & vbCrLf
            End If
        End If

        If (Not txtTelefono.Text.Equals("")) And txtTelefono.Text.Length < 6 Then
            msjError &= "El nro de teléfono ingresado no es válido!" & vbCrLf

        End If

        If Not msjError.Equals("") Then
            MessageBox.Show(msjError, "Datos incorrectos!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True

    End Function

    Private Sub desabilitarComponentes()
        txtIdProveedor.Enabled = True
        txtRazonSocial.Enabled = False
        txtCuit.Enabled = False
        txtTelefono.Enabled = False
        chkEstadoProov.Enabled = False
        btnGuardar.Enabled = False
        txtFechaBaja.Enabled = False
        chkEstadoProov.Checked = True
    End Sub

    Private Sub limpiarComponentes()
        txtIdProveedor.Text = ""
        txtRazonSocial.Text = ""
        txtCuit.Text = ""
        txtTelefono.Text = ""
        txtFechaBaja.Text = ""
    End Sub

   



    Private Sub txtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProveedor.KeyPress, txtCuit.KeyPress, txtTelefono.KeyPress
        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub


    Private Sub chkEstadoProov_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoProov.CheckedChanged

        If chkEstadoProov.Checked = False Then
            chkEstadoProov.Text = "Inactivo"
            If proveedorActual.fechaBaja.Equals(Nothing) Then
                txtFechaBaja.Text = Date.Today.ToString("dd/MM/yyyy")
                proveedorActual.fechaBaja = Date.Now
            Else : txtFechaBaja.Text = proveedorActual.fechaBaja.ToString("dd/MM/yyyy")
            End If

        Else
            chkEstadoProov.Text = "Activo"
            If Not IsNothing(proveedorActual) Then
                'proveedorActual.fechaBaja = Nothing
            End If
            txtFechaBaja.Text = ""

            End If


    End Sub

    Sub setFilaBuscada(ByRef fila As DataGridViewRow) Implements Buscable.setFilaBuscada
        filaBuscada = fila
    End Sub


    Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged

    End Sub
End Class

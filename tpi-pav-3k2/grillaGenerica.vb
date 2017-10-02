Public Class grillaGenerica

    Public Enum formularios
        SERVICIO  'ya esta
        REPUESTO
        ORDEN_TRABAJO
        TIPO_MEMORIA  'ya está
        TIPO_PC   'ya está
        CLIENTE
        PROVEEDOR 'ya está
        COMPUTADORA
        TIPO_REPUESTO ' ya está
        TIPO_DOCUMENTO 'ya está
        PROCESADOR 'ya está

    End Enum
    Private form As formularios
    Private formularioEmisor As Buscable
    Public Sub New(ByRef titulo As String, ByVal nombreFormEmisor As formularios, ByRef formEmisor As Buscable)
        InitializeComponent()
        Me.Text = titulo
        form = nombreFormEmisor
        formularioEmisor = formEmisor

        Select Case form
            Case formularios.SERVICIO
                dgvBusqueda.DataSource = ServicioDao.buscarServicios()
                Me.Size = New System.Drawing.Size(780, Me.Size.Height)
                Exit Select

            Case formularios.TIPO_MEMORIA
                dgvBusqueda.DataSource = TipoMemoriaDao.buscarTiposMemoria()
                Me.Size = New System.Drawing.Size(600, 400)
                

                Exit Select
            Case formularios.TIPO_PC
                dgvBusqueda.DataSource = TipoPcDao.buscarTiposPc
                Me.Size = New System.Drawing.Size(600, 400)
                

                Exit Select

            Case formularios.TIPO_REPUESTO
                dgvBusqueda.DataSource = TipoRepuestoDao.buscarTiposRepuesto()
                Me.Size = New System.Drawing.Size(600, 400)
                
                Exit Select

            Case formularios.TIPO_DOCUMENTO
                dgvBusqueda.DataSource = TipoDocumentoDao.buscarTiposDocumento()
                Me.Size = New System.Drawing.Size(600, 400)

                Exit Select


            Case formularios.PROVEEDOR
                dgvBusqueda.DataSource = ProveedorDao.buscarProveedores
                Me.Size = New System.Drawing.Size(700, 400)
                
                Exit Select

            Case formularios.PROCESADOR
                dgvBusqueda.DataSource = ProcesadorDao.buscarProcesadores()
                Me.Size = New System.Drawing.Size(600, 400)
                

            Case formularios.REPUESTO
                dgvBusqueda.DataSource = RepuestoDao.buscarRepuestos()
                dgvBusqueda.Columns(4).Visible = False
                dgvBusqueda.Columns(2).Visible = False
                dgvBusqueda.Columns(6).Visible = False
                Me.Size = New System.Drawing.Size(950, 400)
                Exit Select

            Case formularios.CLIENTE
                ' buscar la forma de mostrar los clientes en una fila y todas las compus juntas
                ' de última las compus las muestro aparte
                dgvBusqueda.DataSource = ClienteDao.buscarClientes()
                dgvBusqueda.Columns(4).Visible = False
                'Dim primeraFila As Boolean = True
                'Dim idCli As Int32
                'Dim nroFila As Int32
                'no anda
                'dgvBusqueda.Columns(10).ValueType = GetType(String)


                'For Each fila As DataGridViewRow In dgvBusqueda.Rows
                'dgvBusqueda.Rows(nroFila).Cells(10).ValueType = GetType(String)

                'CTypeDynamic(dgvBusqueda.Rows(nroFila).Cells(10).Value, GetType(String))
                'If primeraFila Then
                'idCli = Convert.ToInt32(fila.Cells(0).Value)
                'nroFila = fila.Index
                'primeraFila = False
                'Else
                'If Convert.ToInt32(fila.Cells(0).Value) = idCli Then
                'Dim compu As String = fila.Cells(10).Value
                'dgvBusqueda.Rows(nroFila).Cells(10).Value = dgvBusqueda.Rows(fila.Index).Cells(0).Value.ToString & ", " & compu
                'dgvBusqueda.Rows.RemoveAt(fila.Index)
                'Else : primeraFila = True
                'End If
                'End If
                'Next

                Me.Size = New System.Drawing.Size(900, 400)

                Exit Select

            Case formularios.COMPUTADORA
                Exit Select

            Case formularios.ORDEN_TRABAJO
                Exit Select

        End Select


        cbCriterioBusqueda.Items.Clear()
        For Each columna As DataGridViewColumn In dgvBusqueda.Columns
            cbCriterioBusqueda.Items.Add(columna.HeaderText)
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        cbCriterioBusqueda.SelectedIndex = 0



    End Sub
    Private Sub grillaGenerica_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    

    Private Sub dgvBusqueda_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick

        Dim filaSeleccionada As DataGridViewRow = dgvBusqueda.CurrentRow
        If filaSeleccionada.Index >= 0 Then

            formularioEmisor.setFilaBuscada(filaSeleccionada)
        Else : formularioEmisor.setFilaBuscada(Nothing)
        End If
        Me.Close()

    End Sub


    'NO anda bien este. Devuelve la fila siguiente, a no ser que sea la última
    Private Sub dgvBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvBusqueda.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then

            Dim filaSeleccionada As DataGridViewRow = dgvBusqueda.CurrentRow
            If filaSeleccionada.Index >= 0 Then
                formularioEmisor.setFilaBuscada(filaSeleccionada)
            Else : formularioEmisor.setFilaBuscada(Nothing)
            End If
            Me.Close()
        End If
    End Sub


End Class
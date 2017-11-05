Public Class ConsultasReportes


    Public Shared Function reporteOt(ByVal id As Int32, ByRef ds As dataSetOrdenTrabajo) As Boolean


        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select ord.idOrdenTrabajo, ord.nroCliente, ord.compu, ord.monto, ord.detalleFalla, est.estado,"
            comando &= "ord.fechaRecepcion, ord.fechaReparacion, cob.fechaCobro from ordenTrabajo ord "
            comando &= " left join estadoOrdenTrabajo est on est.idEstado = ord.estado"
            comando &= " left join cobro as cob on cob.idCobro = ord.cobro  where idOrdenTrabajo =" & id & "; "
            sql.CommandText = comando

            ds.OrdenTrabajo.Load(sql.ExecuteReader())

            If ds.OrdenTrabajo.Rows.Count = 1 Then

                comando = "select det.idDetalleOrdenTrabajo, det.servicio, det.idOrden, det.componente, serv.nombreServicio, comp.descripcion as 'Repuesto',"
                comando &= "det.cantidad, det.montoUnitarioServicio, det.montoUnitarioComponente from detalleOrdenTrabajo det"
                comando &= " left join servicio serv on det.servicio = serv.idServicio"
                comando &= " left join componente comp on det.componente = comp.idComponente"
                comando &= " left join marcaComponente marc on comp.marca = marc.idMarcaComponente where idOrden = " & id & ";"

                sql.CommandText = comando
                ds.DetalleOrden.Load(sql.ExecuteReader())

                Dim nroCliente = Convert.ToInt32(ds.OrdenTrabajo.Rows(0)("nroCliente"))
                comando = "select idCliente, nombre, apellido, telefono from cliente where idCliente = " & nroCliente & ";"
                sql.CommandText = comando
                ds.Cliente.Load(sql.ExecuteReader())
                Return True

            Else : Return False

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        Finally : conex.Close()

        End Try

    End Function


    Public Shared Function listadoOrdenesRecibidas(ByRef fechaDesde As Date, ByRef fechaHasta As Date, ByRef ds As dataSetListadoRecibidas) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select ord.idOrdenTrabajo, ord.nroCliente, cli.apellido, cli.nombre, ord.compu, ord.detalleFalla,"
            comando &= "est.estado, ord.monto, ord.fechaRecepcion from ordenTrabajo ord"
            comando &= " join cliente cli on ord.nroCliente = cli.idCliente "
            comando &= " join estadoOrdenTrabajo est on ord.estado = est.idEstado where ord.fechaRecepcion between '" & fechaDesde.ToString("yyyy/MM/dd")
            comando &= "' and '" & fechaHasta.ToString("yyyy/MM/dd") & "';"

            sql.CommandText = comando
            ds.OrdenTrabajo.Load(sql.ExecuteReader())
            If ds.OrdenTrabajo.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function listadoClientesRegistrados(ByRef fechaDesde As Date, ByRef fechaHasta As Date, ByRef ds As dataSetListadoRecibidas) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select cli.idCliente, cli.nombre, cli.apellido, cli.telefono, cli.fechaAlta, cli.fechaBaja,"
            comando &= "cli.email, cli.nroDocumento, tipoD.tipo as 'tipoDocumento' from cliente cli"
            comando &= " join tipoDocumento tipoD on cli.tipoDoc = tipoD.idTipoDocumento where fechaAlta between '"
            comando &= fechaDesde.ToString("yyyy/MM/dd") & "' and '" & fechaHasta.ToString("yyyy/MM/dd") & "';"

            sql.CommandText = comando
            ds.Cliente.Load(sql.ExecuteReader())
            If ds.Cliente.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function listadoOrdenesIrreparables(ByRef fechaDesde As Date, ByRef fechaHasta As Date, ByRef ds As dataSetListadoRecibidas) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select ord.idOrdenTrabajo, ord.nroCliente, cli.apellido, cli.nombre, ord.compu, ord.detalleFalla,"
            comando &= "est.estado, ord.monto, ord.fechaRecepcion from ordenTrabajo ord"
            comando &= " join cliente cli on ord.nroCliente = cli.idCliente "
            comando &= " join estadoOrdenTrabajo est on ord.estado = est.idEstado where (ord.fechaRecepcion between '" & fechaDesde.ToString("yyyy/MM/dd")
            comando &= "' and '" & fechaHasta.ToString("yyyy/MM/dd") & "') and ord.estado = 5;"

            sql.CommandText = comando
            ds.OrdenTrabajo.Load(sql.ExecuteReader())
            If ds.OrdenTrabajo.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function listadoOrdenesReparadas(ByRef fechaDesde As Date, ByRef fechaHasta As Date, ByRef ds As dataSetListadoRecibidas) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select ord.idOrdenTrabajo, ord.nroCliente, cli.apellido, cli.nombre, ord.compu, ord.detalleFalla,"
            comando &= "est.estado, ord.monto, ord.fechaRecepcion, ord.fechaReparacion from ordenTrabajo ord"
            comando &= " join cliente cli on ord.nroCliente = cli.idCliente "
            comando &= " join estadoOrdenTrabajo est on ord.estado = est.idEstado where (ord.fechaRecepcion between '" & fechaDesde.ToString("yyyy/MM/dd")
            comando &= "' and '" & fechaHasta.ToString("yyyy/MM/dd") & "') and (ord.estado = 3 or ord.estado = 4);"

            sql.CommandText = comando
            ds.OrdenCompleta.Load(sql.ExecuteReader())
            If ds.OrdenCompleta.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function listadoCobro(ByRef fechaDesde As Date, ByRef fechaHasta As Date, ByRef ds As dataSetListadoRecibidas) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "select ord.idOrdenTrabajo, ord.nroCliente, cli.apellido, cli.nombre, ord.compu, ord.detalleFalla,"
            comando &= "est.estado, ord.monto, ord.fechaRecepcion, ord.cobro as 'idCobro', co.fechaCobro from ordenTrabajo ord"
            comando &= " join cliente cli on ord.nroCliente = cli.idCliente "
            comando &= " join cobro co on ord.cobro = co.idCobro "
            comando &= " join estadoOrdenTrabajo est on ord.estado = est.idEstado where (ord.fechaRecepcion between '" & fechaDesde.ToString("yyyy/MM/dd")
            comando &= "' and '" & fechaHasta.ToString("yyyy/MM/dd") & "') and (ord.estado = 4 or ord.estado = 5);"

            sql.CommandText = comando
            ds.OrdenCompletaCobro.Load(sql.ExecuteReader())
            If ds.OrdenTrabajo.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function listadoCobro(ByRef fechaDesde As Int32, ByRef fechaHasta As Int32, ByRef ds As DataSetIngresosMensuales) As Boolean
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()

        Dim comando As String


        Try
            conex.Open()
            sql.CommandType = CommandType.Text
            sql.Connection = conex

            comando = "Select month(fechaCobro) as 'Mes' , Year(fechaCobro) as 'Anio',SUM(monto) as 'TotalMes', "
            comando &= " count(idCobro) as 'Cantidad', AVG(monto) as 'Promedio' from cobro where YEAR(fechaCobro) between " & fechaDesde & " and " & fechaHasta
            comando &= " group by month(fechaCobro), YEAR(fechaCobro)"
            comando &= " order by month(fechaCobro) asc;"

            sql.CommandText = comando
            ds.Ingreso.Load(sql.ExecuteReader())
            If ds.Ingreso.Rows.Count > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        Finally : conex.Close()

        End Try

    End Function




End Class

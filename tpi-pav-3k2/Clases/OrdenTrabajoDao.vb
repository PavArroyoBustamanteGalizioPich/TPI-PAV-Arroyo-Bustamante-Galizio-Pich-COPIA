Public Class OrdenTrabajoDao


    Public Shared Function insertarOrdenTrabajo(ByRef orden As OrdenTrabajoDto) As Conexion.EventosSql
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim result As Int32
        Dim comando As String

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "insert into ordenTrabajo(idOrdenTrabajo, fechaRecepcion,estado,compu,nroCliente,detalleFalla) values("
            comando &= orden.idOrden & ",'" & orden.fechaRecepcion.ToString("yyyy/MM/dd") & "'," & orden.estado & "," & orden.computadora.idComputadora & ","
            comando &= orden.cliente.idCliente & ",'" & orden.falla & "')"

            sql.CommandText = comando

            result = sql.ExecuteNonQuery()
            Return Conexion.EventosSql.INSERCION_CORRECTA


        Catch ex As Exception
            Return Conexion.EventosSql.OTRO
        Finally : conex.Close()
        End Try


    End Function


    Public Shared Function buscarOt(ByVal id As Int32) As OrdenTrabajoDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim tabla As New DataTable
        Dim comando As String
        Dim orden As New OrdenTrabajoDto

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "select ot.idOrdenTrabajo as 'ID OT', ot.fechaRecepcion as 'Fecha Recepcion', ot.fechaReparacion as 'Fecha Reparacion',"
            comando &= "ot.estado as 'Estado', ot.compu as 'ID Computadora', ot.nroCliente as 'Nro Cliente', ot.cobro as 'Cobro',"
            comando &= "ot.detalleFalla as 'Falla', ot.monto as 'Monto' from ordenTrabajo ot where idOrdenTrabajo =" & id

            sql.CommandText = comando
            'aca trae unicamente la ot con todas las referencias de compu y cliente

            tabla.Load(sql.ExecuteReader())

            orden.idOrden = Convert.ToInt32(tabla.Rows(0)("ID OT"))
            orden.estado = Convert.ToInt32(tabla.Rows(0)("Estado"))
            orden.fechaRecepcion = CDate(tabla.Rows(0)("Fecha Recepcion"))
            If Not IsDBNull(tabla.Rows(0)("Fecha Reparacion")) Then
                orden.fechaReparacion = CDate(tabla(0)("Fecha Reparacion"))
            Else : orden.fechaReparacion = Nothing
            End If
            orden.falla = tabla.Rows(0)("Falla").ToString()

            If Not IsDBNull(tabla.Rows(0)("Cobro")) Then
                Dim cob As New CobroDto
                orden.cobro = cob
                orden.cobro.id = Convert.ToInt32(tabla.Rows(0)("Cobro"))
            Else : orden.cobro = Nothing
            End If

            If Not IsDBNull(tabla.Rows(0)("Monto")) Then
                orden.monto = Convert.ToInt32(tabla.Rows(0)("Monto"))
            Else : orden.monto = 0
            End If


            Dim compu As New ComputadoraDto
            Dim cliente As New ClienteDto

            
            Dim idCliente As Int32 = Convert.ToInt32(tabla.Rows(0)("Nro Cliente"))
            Dim idComputadora As Int32 = Convert.ToInt32(tabla.Rows(0)("ID Computadora"))
            orden.cliente = ClienteDao.buscarCliente(idCliente)
            orden.computadora = ComputadoraDao.buscarComputadora(idComputadora)


            comando = "select * from detalleOrdenTrabajo where idOrden = " & orden.idOrden
            sql.CommandType = CommandType.Text
            sql.CommandText = comando
            Dim tablaDetalles As New DataTable
            tablaDetalles.Load(sql.ExecuteReader())
            Dim detalles As New List(Of DetalleOrdenTrabajoDto)
            For Each fila As DataRow In tablaDetalles.Rows

                If Not IsDBNull(fila("idDetalleOrdenTrabajo")) Then
                    Dim detalle As New DetalleOrdenTrabajoDto

                    detalle.id = Convert.ToInt32(fila("idDetalleOrdenTrabajo"))
                    detalle.servicio = Convert.ToInt32(fila("servicio"))
                    If Not IsDBNull(fila("componente")) Then
                        detalle.repuesto = Convert.ToInt32(fila("componente"))
                        detalle.montoUnitrepuesto = Convert.ToDecimal(fila("montoUnitarioComponente"))
                    Else : detalle.repuesto = 0
                    End If

                    detalle.cantidad = Convert.ToInt32(fila("cantidad"))
                    detalle.montoUnitServicio = Convert.ToDecimal(fila("montoUnitarioServicio"))
                    detalles.Add(detalle)
                End If

            Next

            orden.detalles = detalles
            Return orden

        Catch ex As Exception
            Return Nothing
        Finally : conex.Close()
        End Try



    End Function

    Public Shared Function buscarOrdenes() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim comando As String
        Dim tabla As New DataTable
        Dim abierta As Boolean
        Try

            If Not conex.State = ConnectionState.Open Then

                conex.Open()
                abierta = True
            End If


            sql.Connection = conex
            comando = "select ord.idOrdenTrabajo as 'Id Orden', est.estado as 'Estado', ord.nroCliente as 'Cliente', "
            comando &= "ord.compu as 'Computadora', ord.detalleFalla as 'Falla', ord.monto as 'Monto' from ordenTrabajo ord"
            comando &= " join estadoOrdenTrabajo est on ord.estado = est.idEstado;"

            sql.CommandType = CommandType.Text
            sql.CommandText = comando

            tabla.Load(sql.ExecuteReader())

        Catch ex As SqlClient.SqlException
        Finally
            If abierta Then
                conex.Close()
            End If
        End Try

        Return tabla
    End Function


    ' este hay que terminarlo
    Public Shared Function actualizarOrden(ByRef orden As OrdenTrabajoDto) As Conexion.EventosSql
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim resultado As Int32
        Dim comando As String
        Dim transaccion As SqlClient.SqlTransaction = Nothing

        Try

            conex.Open()
            sql.Connection = conex
            transaccion = conex.BeginTransaction
            sql.Transaction = transaccion
            sql.CommandType = CommandType.Text

            comando = "update ordenTrabajo set estado = " & orden.estado & ", monto  = " & Utilidades.armarNumero(orden.monto.ToString()) & " where idOrdenTrabajo = " & orden.idOrden
            sql.CommandText = comando
            resultado = sql.ExecuteNonQuery()

            If resultado = 1 Then

                For Each detalle As DetalleOrdenTrabajoDto In orden.detalles
                    ' despues convertir a stringBuilder
                    detalle.id = Utilidades.sugerirId("detalleOrdenTrabajo", "idDetalleOrdenTrabajo")
                    comando = "insert into detalleOrdenTrabajo values(" & detalle.id & ","
                    comando &= detalle.servicio & ","
                    If detalle.repuesto > 0 Then
                        comando &= detalle.repuesto & ","
                    Else : comando &= "null, "
                    End If
                    comando &= detalle.cantidad & "," & Utilidades.armarNumero(detalle.montoUnitServicio.ToString()) & ","
                    If detalle.montoUnitrepuesto > 0 Then
                        comando &= Utilidades.armarNumero(detalle.montoUnitrepuesto.ToString()) & ","
                    Else : comando &= "null,"
                    End If
                    comando &= orden.idOrden & ")"

                    sql.CommandText = comando
                    sql.ExecuteNonQuery()
                Next
                transaccion.Commit()
            Else : Throw New Exception
            End If
            Return Conexion.EventosSql.INSERCION_CORRECTA
        Catch ex As Exception
            transaccion.Rollback()
        Finally : conex.Close()
        End Try

        Return Conexion.EventosSql.OTRO

    End Function

    Public Shared Function actualizarOrden(ByRef orden As OrdenTrabajoDto, ByVal est As OrdenTrabajoDto.estadosOrden, Optional ByRef cobro As CobroDto = Nothing) As Conexion.EventosSql

        Dim con As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim transaccion As SqlClient.SqlTransaction = Nothing
        Dim comando As String = ""

        Select Case est
            Case OrdenTrabajoDto.estadosOrden.REPARADA
                comando = "UPDATE ordenTrabajo SET estado = " & orden.estado & " , fechaReparacion = '" & orden.fechaReparacion.ToString("yyyy/MM/dd") & "' WHERE idOrdenTrabajo = " & orden.idOrden & ";"
                Try
                    con.Open()
                    sql.Connection = con
                    sql.CommandType = CommandType.Text
                    sql.CommandText = comando
                    sql.ExecuteNonQuery()
                    Return Conexion.EventosSql.INSERCION_CORRECTA

                Catch ex As SqlClient.SqlException
                    Return Conexion.EventosSql.OTRO

                Finally : con.Close()
                End Try

                Exit Select
            Case OrdenTrabajoDto.estadosOrden.CERRADA
                Try
                    con.Open()
                    sql.Connection = con
                    transaccion = con.BeginTransaction()
                    sql.Transaction = transaccion
                    sql.CommandType = CommandType.Text
                    sql.CommandText = "INSERT INTO cobro VALUES (" & cobro.id & ", '" & cobro.fechaCobro.ToString("yyyy/MM/dd") & "', " & Utilidades.armarNumero(cobro.monto.ToString()) & ")"
                    sql.ExecuteNonQuery()
                    sql.CommandText = " UPDATE ordenTrabajo SET estado = " & orden.estado & ", cobro = " & cobro.id & "WHERE idOrdenTrabajo = " & orden.idOrden
                    sql.ExecuteNonQuery()
                    transaccion.Commit()
                    Return Conexion.EventosSql.INSERCION_CORRECTA

                Catch ex As SqlClient.SqlException
                    transaccion.Rollback()
                    Return Conexion.EventosSql.OTRO
                Finally : con.Close()

                End Try


                Exit Select

        End Select
        
        Return Conexion.EventosSql.OTRO

    End Function

End Class

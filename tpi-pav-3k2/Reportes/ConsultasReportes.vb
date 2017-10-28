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
                Return True

            Else : Return False

            End If



        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False
        Finally : conex.Close()

        End Try






    End Function

End Class

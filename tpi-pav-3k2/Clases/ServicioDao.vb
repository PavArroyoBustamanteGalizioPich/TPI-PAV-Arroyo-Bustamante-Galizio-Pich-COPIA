Public Class ServicioDao

    Public Shared Function insertarServicio(ByRef servicio As ServicioDto)
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim filas As Int32
        Dim comando As String

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text

        If servicio.repuestoReq = Nothing Then
            comando = "insert into servicio(idServicio, nombreServicio, detalle, costo, garantia)"
            comando &= " values (" & servicio.idServ & ",'" & servicio.nomServicio & "','" & servicio.detalleServicio & "'," & servicio.costoServicio & "," & servicio.garantiaServicio & ")"
        Else
            comando = "insert into servicio(idServicio, nombreServicio, detalle, costo, garantia, repuestoRequerido)"
            comando &= " values (" & servicio.idServ & ",'" & servicio.nomServicio & "','" & servicio.detalleServicio & "'," & servicio.costoServicio & "," & servicio.garantiaServicio & "," & servicio.repuestoReq & ")"

        End If
        sql.CommandText = comando
        filas = sql.ExecuteNonQuery()

        conex.Close()
        Return filas
    End Function

    Public Shared Function buscarServicio(ByVal idServicio As Int32) As ServicioDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim tabla As New DataTable
        Dim comando As String
        Dim servicio As New ServicioDto
        
        comando = "select serv.idServicio as 'ID Servicio', serv.nombreServicio as 'Nombre', serv.detalle as 'Detalle',"
        comando &= "serv.costo as 'Costo', serv.garantia as 'Garantia', serv.fechaBaja as 'Fecha Baja',"
        comando &= "serv.repuestoRequerido as 'ID Repuesto Requerido', tipo.tipo as 'Tipo Repuesto'"
        comando &= " from servicio serv left join tipoComponente tipo on serv.repuestoRequerido = tipo.idTipoComponente where idServicio = " & idServicio
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = comando
        tabla.Load(sql.ExecuteReader())
        If tabla.Rows.Count = 1 Then
            servicio.idServ = Convert.ToInt32(tabla.Rows(0)("ID Servicio"))
            servicio.nomServicio = tabla.Rows(0)("Nombre")
            servicio.detalleServicio = tabla.Rows(0)("Detalle")
            servicio.costoServicio = Convert.ToDecimal(tabla.Rows(0)("Costo"))
            servicio.garantiaServicio = Convert.ToInt32(tabla.Rows(0)("Garantia"))
            If Not IsDBNull(tabla.Rows(0)("Fecha Baja")) Then
                servicio.fechaBajaServicio = CDate(tabla.Rows(0)("Fecha Baja"))
            Else : servicio.fechaBajaServicio = Nothing
            End If
            If Not IsDBNull(tabla.Rows(0)("ID Repuesto Requerido")) Then
                servicio.repuestoReq = Convert.ToInt32(tabla.Rows(0)("ID Repuesto Requerido"))
                Dim repuesto As New RepuestoDto

                repuesto.tipo = servicio.repuestoReq
                repuesto.nombreTipo = tabla.Rows(0)("Tipo Repuesto").ToString()
                servicio.repuesto = repuesto
            End If
            conex.Close()
            Return servicio

        End If
        conex.Close()
        Return Nothing

    End Function


    Public Shared Function buscarServicios() As DataTable

        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim comando As String

        Try
            comando = "select serv.idServicio as 'ID Servicio', serv.nombreServicio as 'Nombre', serv.detalle as 'Detalle',"
            comando &= "serv.costo as 'Costo', serv.garantia as 'Garantia', serv.fechaBaja as 'Fecha Baja',"
            comando &= "serv.repuestoRequerido as 'ID Repuesto Requerido', rep.descripcion as 'Repuesto'"
            comando &= " from servicio serv left join componente rep on serv.repuestoRequerido = rep.idComponente"

            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())
            conex.Close()
        Catch ex As SqlClient.SqlException


        End Try



        Return tabla
    End Function

    Public Shared Function actualizarServicio(ByVal servicio As ServicioDto) As Int32
        Dim cantFilas As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        Dim comando As String
        comando = "update servicio set costo=" & servicio.costoServicio & ", garantia=" & servicio.garantiaServicio

        If Not servicio.fechaBajaServicio.Equals(Nothing) Then
            comando &= ", fechaBaja ='" & servicio.fechaBajaServicio.ToString("yyyy/MM/dd") & "' "
        Else
            comando &= ", fechaBaja = null "

        End If
        comando &= " where idServicio = " & servicio.idServ
        sql.CommandText = comando
        cantFilas = sql.ExecuteNonQuery()

        conex.Close()
        Return cantFilas
    End Function

End Class

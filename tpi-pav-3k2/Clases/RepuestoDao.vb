Public Class RepuestoDao

    Public Shared Function buscarRepuestos() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim comando As String

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "select comp.idComponente as 'Id Repuesto', comp.descripcion as 'Descripción', comp.marca as 'ID Marca', marcComp.marca as 'Marca',"
            comando &= "comp.tipoComp as 'ID Tipo', tComp.tipo as 'Tipo Repuesto', comp.numProveedor as 'Nro Proveedor', prov.razonSocial as 'Proveedor', comp.garantia as 'Garantía', comp.precioCompra as 'Precio Compra',"
            comando &= "comp.porcentajeGanancia as '% de Ganancia', comp.fechaCompra as 'Fecha Compra' from componente as comp join marcaComponente as marcComp on comp.marca = marcComp.idMarcaComponente"
            comando &= " join tipoComponente as tComp on comp.tipoComp = tComp.idTipoComponente"
            comando &= " join proveedor as prov on comp.numProveedor = prov.nroProveedor;"

            sql.CommandText = comando

            tabla.Load(sql.ExecuteReader())

        Catch ex As SqlClient.SqlException
        Finally : conex.Close()

        End Try
        Return tabla

    End Function


    Public Shared Function buscarRepuesto(ByVal id As Int32) As RepuestoDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim repuesto As RepuestoDto

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = "select * from componente where idComponente = @ID order by idComponente"
            Dim param As New SqlClient.SqlParameter
            param.DbType = DbType.Int32
            param.ParameterName = "@ID"
            param.SqlDbType = SqlDbType.Int
            param.Value = id
            sql.Parameters.Add(param)
            tabla.Load(sql.ExecuteReader())
            repuesto = New RepuestoDto
            repuesto.id = Convert.ToInt32(tabla.Rows(0)("idComponente"))
            repuesto.descripcion = tabla.Rows(0)("descripcion").ToString()
            repuesto.idMarca = Convert.ToInt32(tabla.Rows(0)("marca"))
            repuesto.tipo = Convert.ToInt32(tabla.Rows(0)("tipoComp"))
            repuesto.proveedor = Convert.ToInt32(tabla.Rows(0)("numProveedor"))
            repuesto.garantia = Convert.ToInt32(tabla.Rows(0)("garantia"))
            repuesto.precioCompra = Convert.ToDecimal(tabla.Rows(0)("precioCompra"))
            repuesto.porcentajeGanancia = Convert.ToInt32(tabla.Rows(0)("porcentajeGanancia"))
            repuesto.fechaCompra = CDate(tabla.Rows(0)("fechaCompra"))

            Return repuesto
        Catch ex As SqlClient.SqlException
            Return Nothing
        Finally : conex.Close()
        End Try

    End Function


    Public Shared Function insertarRepuesto(ByRef repuesto As RepuestoDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand

        Dim cantFilas As Int32
        Dim comando As String

        If repuesto.idMarca = 0 Then
            repuesto.idMarca = Utilidades.sugerirId("marcaComponente", "idMarcaComponente")
            Try
                conex.Open()
                sql.Connection = conex
                sql.CommandType = CommandType.Text
                sql.CommandText = "insert into marcaComponente values(" & repuesto.idMarca & ",'" & repuesto.nombreMarca & "')"
                sql.ExecuteNonQuery()

            Catch ex As SqlClient.SqlException
                conex.Close()
                Return -1

            End Try

        End If

        If Not conex.State = ConnectionState.Open Then
            conex.Open()
        End If

        Try
            comando = "insert into componente values(" & repuesto.id & ",'" & repuesto.descripcion & "',"
            comando &= repuesto.idMarca & "," & repuesto.tipo & "," & repuesto.proveedor & "," & repuesto.garantia
            comando &= "," & repuesto.precioCompra & "," & repuesto.porcentajeGanancia & ",'" & repuesto.fechaCompra.ToString("yyyy/MM/dd") & "')"
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = comando
            cantFilas = sql.ExecuteNonQuery()
            conex.Close()
            Return cantFilas
        Catch ex As SqlClient.SqlException

            Return 0
        Finally : conex.Close()

        End Try

    End Function

    Public Shared Function actualizarRepuesto(ByRef repuesto As RepuestoDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim comando As String
        Dim cantFilas As Int32

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "update componente set numProveedor = @Proov, garantia = @Gtia, precioCompra = " & repuesto.precioCompra & ", porcentajeGanancia = @Porcentaje,"
            comando &= "fechaCompra = @Fecha where idComponente = " & repuesto.id
            sql.CommandText = comando

            Dim paramProveedor As New SqlClient.SqlParameter
            paramProveedor.SqlDbType = SqlDbType.Int
            paramProveedor.ParameterName = "@Proov"
            paramProveedor.Value = repuesto.proveedor

            Dim gtia As New SqlClient.SqlParameter
            gtia.SqlDbType = SqlDbType.Int
            gtia.ParameterName = "@Gtia"
            gtia.Value = repuesto.garantia

            'Dim precio As New SqlClient.SqlParameter
            'precio.SqlDbType = SqlDbType.Float
            'precio.ParameterName = "@Precio"
            'precio.SqlDbType = SqlDbType.Decimal
            ' precio.Value = repuesto.precioCompra

            Dim porcentaje As New SqlClient.SqlParameter
            porcentaje.SqlDbType = SqlDbType.Int

            porcentaje.ParameterName = "@Porcentaje"
            porcentaje.Value = repuesto.porcentajeGanancia

            Dim fechaC As New SqlClient.SqlParameter
            fechaC.SqlDbType = SqlDbType.Date
            fechaC.ParameterName = "@Fecha"
            fechaC.Value = repuesto.fechaCompra

            sql.Parameters.Add(paramProveedor)
            sql.Parameters.Add(gtia)
            'sql.Parameters.Add(precio)
            sql.Parameters.Add(porcentaje)
            sql.Parameters.Add(fechaC)

            cantFilas = sql.ExecuteNonQuery()

            Return cantFilas
        Catch ex As SqlClient.SqlException
            Return -1
        Finally : conex.Close()
        End Try

    End Function


End Class

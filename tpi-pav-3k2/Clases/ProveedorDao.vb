Public Class ProveedorDao

    Public Shared Function insertarProveedor(ByRef proveedor As ProveedorVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32
        Dim comando As String
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text

        comando = "insert into proveedor(nroProveedor,razonSocial,cuit,telefono)"
        comando &= " values( " & proveedor.nroProveedor & ",'" & proveedor.razonSocial
        comando &= "','" & proveedor.cuit & "',"

        If Not IsNothing(proveedor.telefono) Then
            comando &= "'" & proveedor.telefono & "')"
        Else : comando &= "null)"
        End If

        Try
            sql.CommandText = comando
            cant = sql.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            cant = ex.ErrorCode
        Finally : conex.Close()
        End Try

        Return cant
    End Function

    Public Shared Function buscarProveedores() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from proveedor"

        Try
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()

        End Try

        Return tabla
    End Function

    Public Shared Function buscarProveedor(ByVal id As Int32) As ProveedorVo
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim proveedor As ProveedorVo
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from proveedor where nroProveedor = " & id

        Try
            tabla.Load(sql.ExecuteReader())

            proveedor = New ProveedorVo
            proveedor.nroProveedor = Convert.ToInt32(tabla.Rows(0)(0))
            proveedor.razonSocial = tabla.Rows(0)(1).ToString()
            proveedor.cuit = tabla.Rows(0)(2).ToString()
            If Not IsDBNull(tabla.Rows(0)(3)) Then
                proveedor.telefono = tabla.Rows(0)(3).ToString()
            Else : proveedor.telefono = Nothing
            End If
            If Not IsDBNull(tabla.Rows(0)(4)) Then
                proveedor.fechaBaja = CDate(tabla.Rows(0)(4))
            Else : proveedor.fechaBaja = Nothing
            End If

          

        Catch ex As Exception
            proveedor = Nothing
        Finally : conex.Close()
        End Try


        Return proveedor

    End Function


    Public Shared Function actualizarProveedor(ByRef proveedor As ProveedorVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cantFilas As Int32
        Dim comando As String
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text

        
        comando = "update proveedor set razonSocial = '" & proveedor.razonSocial & "', telefono = "

        If Not IsNothing(proveedor.telefono) Then
            comando &= "'" & proveedor.telefono & "', "
        Else : comando &= "null, "
        End If

        If Not proveedor.fechaBaja.Equals(Nothing) Then
            comando &= "fechaBaja = '" & proveedor.fechaBaja.ToString("yyyy/MM/dd") & "' "
        Else : comando &= "fechaBaja = null "
        End If

        comando &= " where nroProveedor = " & proveedor.nroProveedor


        sql.CommandText = comando
        

        Try
            cantFilas = sql.ExecuteNonQuery()
        Catch ex As Exception
            cantFilas = 0
        Finally : conex.Close()
        End Try

        Return cantFilas
    End Function

End Class

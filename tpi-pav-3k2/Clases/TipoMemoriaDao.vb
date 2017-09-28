Public Class TipoMemoriaDao


    Public Shared Function insertarTipoMemoria(ByRef tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "insert into tipoMemoria values(" & tipo.id & ", '" & tipo.nombreTipo & "','" & tipo.descripcionTipo & "')"

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant
    End Function


    Public Shared Function buscarTiposMemoria() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoMemoria"

        Try
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function buscarTipoMemoria(ByVal id As Int32) As TiposVo
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim tipoMem As New TiposVo
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoMemoria where idTipoMemoria=" & id

        Try
            tabla.Load(sql.ExecuteReader())

            tipoMem.id = Convert.ToInt32(tabla.Rows(0)(0))
            tipoMem.nombreTipo = tabla.Rows(0)(1).ToString()
            tipoMem.descripcionTipo = tabla.Rows(0)(2).ToString()
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tipoMem
    End Function

    Public Shared Function actualizarTipoMemoria(ByVal tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "update tipoMemoria set tipo='" & tipo.nombreTipo & "', descripcion ='" & tipo.descripcionTipo & "' where idTipoMemoria = " & tipo.id

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant

    End Function


End Class

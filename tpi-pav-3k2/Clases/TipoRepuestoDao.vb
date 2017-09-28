Public Class TipoRepuestoDao
    Public Shared Function insertarTipoRepuesto(ByRef tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "insert into tipoComponente values(" & tipo.id & ", '" & tipo.nombreTipo & "','" & tipo.descripcionTipo & "')"

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant
    End Function


    Public Shared Function buscarTiposRepuesto() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoComponente"

        Try
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function buscarTipoComponente(ByVal id As Int32) As TiposVo
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim tipoComponente As New TiposVo
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoComponente where idTipoComponente=" & id

        Try
            tabla.Load(sql.ExecuteReader())

            tipoComponente.id = Convert.ToInt32(tabla.Rows(0)(0))
            tipoComponente.nombreTipo = tabla.Rows(0)(1).ToString()
            tipoComponente.descripcionTipo = tabla.Rows(0)(2).ToString()
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tipoComponente
    End Function

    Public Shared Function actualizarTipoCompinente(ByVal tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "update tipoComponente set tipo='" & tipo.nombreTipo & "', descripcion ='" & tipo.descripcionTipo & "' where idTipoComponente = " & tipo.id

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant

    End Function

End Class

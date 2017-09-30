Public Class TipoDocumentoDao

    Public Shared Function insertarTipoDocumento(ByRef tipo As TiposDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "insert into tipoDocumento values(" & tipo.id & ", '" & tipo.nombreTipo & "','" & tipo.descripcionTipo & "')"

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant
    End Function


    Public Shared Function buscarTiposDocumento() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoDocumento"

        Try
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function buscarTipoDocumento(ByVal id As Int32) As TiposDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim tipo As New TiposDto
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoDocumento where idTipoDocumento=" & id

        Try
            tabla.Load(sql.ExecuteReader())
            tipo.id = Convert.ToInt32(tabla.Rows(0)(0))
            tipo.nombreTipo = tabla.Rows(0)(1).ToString()
            tipo.descripcionTipo = tabla.Rows(0)(2).ToString()
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tipo
    End Function

    Public Shared Function actualizarTipoDocumento(ByVal tipo As TiposDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "update tipoDocumento set tipo='" & tipo.nombreTipo & "', descripcion ='" & tipo.descripcionTipo & "' where idTipoDocumento = " & tipo.id

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant

    End Function

End Class

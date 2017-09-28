Public Class TipoPcDao

    Public Shared Function insertarTipoPc(ByRef tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "insert into tipoPc values(" & tipo.id & ", '" & tipo.nombreTipo & "','" & tipo.descripcionTipo & "')"

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant
    End Function


    Public Shared Function buscarTiposPc() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoPc"

        Try
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()
        End Try
        Return tabla
    End Function

    Public Shared Function buscarTipoPc(ByVal id As Int32) As TiposVo
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim tipo As New TiposVo
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from tipoPc where idTipoPc=" & id

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

    Public Shared Function actualizarTipoPc(ByVal tipo As TiposVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32

        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "update tipoPc set tipo='" & tipo.nombreTipo & "', descripcion ='" & tipo.descripcionTipo & "' where idTipoPc = " & tipo.id

        Try
            cant = sql.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try
        Return cant

    End Function

End Class

Public Class EstadoOtDao

    Public Shared Function insertarEstado(ByRef estado As TiposDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim cmd As New SqlClient.SqlCommand
        conex.Open()
        cmd.Connection = conex
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into estadoOrdenTrabajo values (" & estado.id & ",'" & estado.nombreTipo & "','" & estado.descripcionTipo & "')"

        Dim cant As Integer

        Try
            cant = cmd.ExecuteNonQuery()
        Catch ex As Exception
            cant = 0
        Finally : conex.Close()
        End Try


        Return cant
    End Function


    Public Shared Function buscarEstados() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from estadoOrdenTrabajo"
        Try
            tabla.Load(sql.ExecuteReader())

        Catch ex As SqlClient.SqlException
            MessageBox.Show("Error al buscar los estados de OT en la base de datos")
        End Try

        Return tabla
    End Function

End Class

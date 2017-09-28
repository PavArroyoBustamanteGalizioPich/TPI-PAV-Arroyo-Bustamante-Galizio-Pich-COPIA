Public Class ProcesadorDao

    Public Shared Function insertarProcesador(ByRef procesador As ProcesadorVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cantFilas As Int32
        Dim comando As String
        Dim comandoMarca
        'conex.Open()
        'sql.Connection = conex
        sql.CommandType = CommandType.Text

        'primero compruevo que la marca exista o sea != de -1, si no existe entonces la creo

        If procesador.idMarca = Nothing Then
            procesador.idMarca = Utilidades.sugerirId("marcaProcesador", "idMarca")
            comandoMarca = "insert into marcaProcesador values(" & procesador.idMarca & ", '" & procesador.marca & "')"
            Try
                conex.Open()
                sql.Connection = conex
                sql.CommandText = comandoMarca
                sql.ExecuteNonQuery()

            Catch ex As SqlClient.SqlException
                Return -1
            Finally : conex.Close()
            End Try

        End If

        conex.Open()
        sql.Connection = conex
        comando = "insert into procesador values(" & procesador.idProcesador & ",'" & procesador.modelo & "',"
        comando &= procesador.fecuencia & "," & procesador.cantNucleos & "," & procesador.idMarca & ")"

        Try
            sql.CommandText = comando
            cantFilas = sql.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            cantFilas = ex.ErrorCode
        Finally : conex.Close()
        End Try

        Return cantFilas

    End Function

    ' deberia andar el buscar todos
    Public Shared Function buscarProcesadores() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Dim comando As String
        conex.Open()

        sql.Connection = conex
        sql.CommandType = CommandType.Text

        comando = "select procesador.idProcesador as 'ID Procesador', procesador.modeloProcesador as 'Modelo', procesador.frecuencia as 'Frecuencia', procesador.cantidadNucleos as 'Nro de nucleos', procesador.marca as 'ID Marca', marcaProcesador.marca as 'Marca' from procesador join marcaProcesador on procesador.marca = marcaProcesador.idMarca"
        Try
            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())
        Catch ex As Exception
        Finally : conex.Close()
        End Try

        Return tabla
    End Function

    Public Shared Function buscarProcesador(ByVal id As Int32) As ProcesadorVo
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim procesador As ProcesadorVo


        conex.Open()
        sql.Connection = conex
        sql.CommandType = CommandType.Text
        sql.CommandText = "select * from procesador where idProcesador = " & id

        Try
            tabla.Load(sql.ExecuteReader())
            procesador = New ProcesadorVo
            procesador.idProcesador = Convert.ToInt32(tabla.Rows(0)(0))
            procesador.modelo = tabla.Rows(0)(1).ToString()
            procesador.fecuencia = Convert.ToSingle(tabla.Rows(0)(2))
            procesador.cantNucleos = Convert.ToInt32(tabla.Rows(0)(3))
            procesador.idMarca = Convert.ToInt32(tabla.Rows(0)(4))


        Catch ex As SqlClient.SqlException
            procesador = Nothing
        Finally : conex.Close()

        End Try

        Return procesador
    End Function


    Public Shared Function actualizarProcesador(ByRef procesador As ProcesadorVo) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cantFilas As Int32
        Dim comando As String

        conex.Open()
        sql.Connection = conex

        comando = "update procesador set frecuencia = " & procesador.fecuencia & ", cantidadNucleos = "
        comando &= procesador.cantNucleos & " where idProcesador = " & procesador.idProcesador

        Try
            sql.CommandText = comando
            cantFilas = sql.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            cantFilas = ex.ErrorCode
        Finally : conex.Close()
        End Try
        Return cantFilas
    End Function

End Class

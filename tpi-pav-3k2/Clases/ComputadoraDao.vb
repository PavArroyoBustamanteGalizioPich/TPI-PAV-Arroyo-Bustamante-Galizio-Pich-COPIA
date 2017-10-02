Public Class ComputadoraDao

    Public Shared Function insertarComputadora(ByRef computadora As ComputadoraDto, Optional ByRef sqlCli As SqlClient.SqlCommand = Nothing) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand
        Dim cantFilas As Int32
        Dim abierta As Boolean = False
        Dim comando As String
        If Not conex.State = ConnectionState.Open Then
            conex.Open()
            abierta = True
        End If

        If Not IsNothing(sqlCli) Then
            sql = sqlCli
        Else : sql = New SqlClient.SqlCommand
        End If

        Try
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            comando = "insert into computadora values(" & computadora.idComputadora & "," & computadora.tipoPc & ","

            If computadora.procesador > 0 Then
                comando &= computadora.procesador & ","
            Else : comando &= " null,"
            End If

            If computadora.cantidadMemoria > 0 Then
                comando &= computadora.cantidadMemoria & ","
            Else : comando &= " null,"

            End If
            If computadora.tipoMemoria > 0 Then
                comando &= computadora.tipoMemoria & ","
            Else : comando &= "null,"
            End If

            If computadora.capAlmacenamiento > 0 Then
                comando &= computadora.capAlmacenamiento & ",'"
            Else : comando &= " null,'"
            End If

            comando &= computadora.fechaAlta.ToString("yyyy/MM/dd") & "', null ," & computadora.nroCliente & ")"

            sql.CommandText = comando

            cantFilas = sql.ExecuteNonQuery()
            Return cantFilas
        Catch ex As SqlClient.SqlException
            Return -1
        Finally
            If abierta Then
                conex.Close()
            End If

        End Try


    End Function

End Class

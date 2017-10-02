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

    Public Shared Function buscarComputadora(ByVal id As Int32) As ComputadoraDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim tabla As New DataTable
        Dim computadora As ComputadoraDto


        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = "select * from computadora where idComputadora = " & id
            tabla.Load(sql.ExecuteReader())
            computadora = New ComputadoraDto
            computadora.idComputadora = Convert.ToInt32(tabla.Rows(0)("idComputadora"))
            computadora.tipoPc = Convert.ToInt32(tabla.Rows(0)("tipo"))
            If Not IsDBNull(tabla.Rows(0)("microProcesador")) Then
                computadora.procesador = Convert.ToInt32(tabla.Rows(0)("microprocesador"))

            End If
            If Not IsDBNull(tabla.Rows(0)("tipoMem")) Then
                computadora.tipoMemoria = Convert.ToInt32(tabla.Rows(0)("tipoMem"))
            End If
            If Not IsDBNull(tabla.Rows(0)("cantidadMemoria")) Then
                computadora.cantidadMemoria = Convert.ToInt32(tabla.Rows(0)("cantidadMemoria"))
            End If
            If Not IsDBNull(tabla.Rows(0)("almacenamiento")) Then
                computadora.capAlmacenamiento = Convert.ToInt32(tabla.Rows(0)("almacenamiento"))
            End If
            If Not IsDBNull(tabla.Rows(0)("fechaBaja")) Then
                computadora.fechaBaja = CDate(tabla.Rows(0)("fechaBaja"))
            Else : computadora.fechaBaja = Nothing
            End If

            computadora.fechaAlta = CDate(tabla.Rows(0)("fechaAlta"))
            computadora.nroCliente = Convert.ToInt32(tabla.Rows(0)("client"))


        Catch ex As Exception
            Return Nothing
        Finally : conex.Close()
        End Try

        Return computadora
    End Function


    Public Shared Function computadorasPorCliente(ByRef cliente As ClienteDto) As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim tabla As New DataTable
        Dim comando As String
        Dim abierta As Boolean = False

        Try
            If Not conex.State = ConnectionState.Open Then
                conex.Open()
                abierta = True
            End If

            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "select compu.idComputadora as 'ID Computadora', compu.tipo as 'ID Tipo Pc', tipoP.tipo as 'Tipo Pc',"
            comando &= "compu.microProcesador as 'ID Procesador', proce.modeloProcesador as 'Procesador', tipoM.idTipoMemoria as 'ID Tipo Memoria',"
            comando &= "tipoM.tipo as 'Tipo Memoria',"
            comando &= "compu.cantidadMemoria as 'Cantidad de Memoria', compu.almacenamiento as 'Almacenamiento', compu.fechaAlta as 'Fecha Alta',"
            comando &= "compu.fechaBaja as 'Fecha Baja' from computadora compu"
            comando &= " left join tipoPc tipoP on tipoP.idTipoPc = compu.tipo"
            comando &= " left join procesador proce on proce.idProcesador = compu.microProcesador"
            comando &= " left join tipoMemoria tipoM on tipoM.idTipoMemoria = compu.tipoMem where client = " & cliente.idCliente

            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())


        Catch ex As SqlClient.SqlException
        Finally
            If abierta Then
                conex.Close()
            End If

        End Try

        Return tabla
    End Function



End Class

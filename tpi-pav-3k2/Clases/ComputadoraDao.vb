Public Class ComputadoraDao

    Public Shared Function insertarComputadora(ByRef computadora As ComputadoraDto) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim cantFilas As Int32
        Dim abierta As Boolean = False
        Dim comando As String
        If Not conex.State = ConnectionState.Open Then
            conex.Open()
            abierta = True
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
        Dim comando As String

        Try

            ' este hay que cambiarlo para que traiga la marca del procesador para cargar el combo
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            comando = "select compu.idComputadora as 'ID Computadora',compu.client as 'Cliente', compu.tipo as 'ID Tipo Pc', tipoP.tipo as 'Tipo Pc',"
            comando &= "compu.microProcesador as 'ID Procesador', proce.marca as 'Marca Procesador', proce.modeloProcesador as 'Procesador', tipoM.idTipoMemoria as 'ID Tipo Memoria',"
            comando &= "tipoM.tipo as 'Tipo Memoria',"
            comando &= "compu.cantidadMemoria as 'Tamaño Memoria', compu.almacenamiento as 'Almacenamiento', compu.fechaAlta as 'Fecha Alta',"
            comando &= "compu.fechaBaja as 'Fecha Baja' from computadora compu"
            comando &= " left join tipoPc tipoP on tipoP.idTipoPc = compu.tipo"
            comando &= " left join procesador proce on proce.idProcesador = compu.microProcesador"
            comando &= " left join tipoMemoria tipoM on tipoM.idTipoMemoria = compu.tipoMem where idComputadora = " & id
            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())
            computadora = New ComputadoraDto
            computadora.idComputadora = Convert.ToInt32(tabla.Rows(0)("ID Computadora"))
            computadora.tipoPc = Convert.ToInt32(tabla.Rows(0)("ID Tipo Pc"))
            If Not IsDBNull(tabla.Rows(0)("Procesador")) Then
                computadora.procesador = Convert.ToInt32(tabla.Rows(0)("Procesador"))

            End If
            If Not IsDBNull(tabla.Rows(0)("ID Tipo Memoria")) Then
                computadora.tipoMemoria = Convert.ToInt32(tabla.Rows(0)("ID Tipo Memoria"))
            End If
            If Not IsDBNull(tabla.Rows(0)("Tamaño Memoria")) Then
                computadora.cantidadMemoria = Convert.ToInt32(tabla.Rows(0)("Tamaño Memoria"))
            End If
            If Not IsDBNull(tabla.Rows(0)("Almacenamiento")) Then
                computadora.capAlmacenamiento = Convert.ToInt32(tabla.Rows(0)("Almacenamiento"))
            End If
            If Not IsDBNull(tabla.Rows(0)("Fecha Baja")) Then
                computadora.fechaBaja = CDate(tabla.Rows(0)("Fecha Baja"))
            Else : computadora.fechaBaja = Nothing
            End If

            If Not IsDBNull(tabla.Rows(0)("Marca Procesador")) Then
                computadora.marcaProcesador = Convert.ToInt32(tabla.Rows(0)("Marca Procesador"))

            End If

            computadora.fechaAlta = CDate(tabla.Rows(0)("Fecha Alta"))
            computadora.nroCliente = Convert.ToInt32(tabla.Rows(0)("Cliente"))


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
            comando &= "compu.microProcesador as 'ID Procesador', proce.idMarca as 'Marca Procesador', proce.modeloProcesador as 'Procesador', tipoM.idTipoMemoria as 'ID Tipo Memoria',"
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

    'falta cuscar todas
    Public Shared Function buscarComputadoras() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim tabla As New DataTable
        Dim comando As String


        Try

            conex.Open()
           

            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "select compu.idComputadora as 'ID Computadora', compu.tipo as 'ID Tipo Pc', tipoP.tipo as 'Tipo Pc',"
            comando &= "compu.microProcesador as 'ID Procesador', proce.modeloProcesador as 'Procesador', tipoM.idTipoMemoria as 'ID Tipo Memoria',"
            comando &= "tipoM.tipo as 'Tipo Memoria',"
            comando &= "compu.cantidadMemoria as 'Cantidad de Memoria', compu.almacenamiento as 'Almacenamiento', compu.fechaAlta as 'Fecha Alta',"
            comando &= "compu.fechaBaja as 'Fecha Baja' from computadora compu"
            comando &= " left join tipoPc tipoP on tipoP.idTipoPc = compu.tipo"
            comando &= " left join procesador proce on proce.idProcesador = compu.microProcesador"
            comando &= " left join tipoMemoria tipoM on tipoM.idTipoMemoria = compu.tipoMem"

            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())


        Catch ex As SqlClient.SqlException
        Finally

            conex.Close()


        End Try

        Return tabla
    End Function

    Public Shared Function actualizarComputadora(ByRef computadora As ComputadoraDto) As Conexion.EventosSql
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim comando As String

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            comando = "update computadora set "
            If computadora.procesador <> 0 Then
                comando &= "microprocesador = " & computadora.procesador & ","
            Else : comando &= "microprocesador = null,"
            End If

            If computadora.tipoMemoria <> 0 Then
                comando &= "tipoMem = " & computadora.tipoMemoria & ","
            Else : comando &= "tipoMem = null,"
            End If

            If computadora.cantidadMemoria <> 0 Then
                comando &= "cantidadMemoria = " & computadora.cantidadMemoria & ","
            Else : comando &= "cantidadMemoria = null,"
            End If

            If computadora.capAlmacenamiento <> 0 Then
                comando &= "almacenamiento = " & computadora.capAlmacenamiento & ","
            Else : comando &= "almacenaiento = null,"
            End If

            If Not computadora.fechaBaja.Equals(Nothing) Then
                comando &= "fechaBaja = " & computadora.fechaBaja.ToString("yyyy/MM/dd")
            Else : comando &= "fechaBaja = null"
            End If
            comando &= " where idComputadora = " & computadora.idComputadora
            sql.CommandText = comando
            Dim cantFilas As Int32 = sql.ExecuteNonQuery()

            Return Conexion.EventosSql.INSERCION_CORRECTA

        Catch ex As SqlClient.SqlException
            Return Conexion.EventosSql.ERROR_COMPUTADORA

        Finally : conex.Close()
        End Try



    End Function



End Class

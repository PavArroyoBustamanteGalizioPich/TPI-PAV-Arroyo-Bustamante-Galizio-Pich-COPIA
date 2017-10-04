
Imports System.Data.SqlClient.SqlTransaction
Public Class ClienteDao


    Public Shared Function insertarCliente(ByRef cliente As ClienteDto, ByRef computadora As ComputadoraDto) As Conexion.EventosSql

        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As SqlClient.SqlCommand = Conexion.getComando()
        Dim comando As String
        Dim transaccion As SqlClient.SqlTransaction
        Dim cantFilas As Int32
        conex.Open()
        transaccion = conex.BeginTransaction()
        Try

            sql.Connection = conex

            sql.CommandType = CommandType.Text
            sql.Transaction = transaccion

            comando = "insert into cliente values(" & cliente.idCliente & ",'" & cliente.nombre & "','" & cliente.apellido
            comando &= "','" & cliente.telefono & "','" & cliente.fechaAlta.ToString("yyyy/MM/dd")
            comando &= "', null, '" & cliente.email & "', '" & cliente.nroDocumento & "'," & cliente.tipoDocumento & ")"
            sql.CommandText = comando


            cantFilas = sql.ExecuteNonQuery()
            If cantFilas = 1 Then
                cantFilas = ComputadoraDao.insertarComputadora(computadora)
                If cantFilas = 1 Then
                    transaccion.Commit() ' se hace el comit solamente si se inserta bien la compu
                    Return Conexion.EventosSql.INSERCION_CORRECTA
                Else : Throw New Exception("COMPUTADORA")
                End If
            Else : Throw New Exception("CLIENTE")
            End If

        Catch ex As SqlClient.SqlException
            transaccion.Rollback()

            If ex.Message.StartsWith("Violation of UNIQUE KEY constraint") Then
                Return Conexion.EventosSql.VIOLACION_UQ
            End If

        Catch ex As Exception
            transaccion.Rollback()
            If ex.Message.Equals("COMPUTADORA") Then
                Return Conexion.EventosSql.ERROR_COMPUTADORA
            End If
            If ex.Message.Equals("CLIENTE") Then
                Return Conexion.EventosSql.ERROR_CLIENTE
            End If
        Finally : conex.Close()
        End Try

        Return 0

    End Function


    Public Shared Function actualizarCliente(ByRef cliente As ClienteDto) As Conexion.EventosSql

        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim cant As Int32
        Dim comando As String
        Try

            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            comando = "update cliente set telefono = '" & cliente.telefono & "', email = '"
            comando &= cliente.email & "',"

            If Not cliente.fechaBaja.Equals(Nothing) Then
                comando &= "fechaBaja = '" & cliente.fechaBaja.ToString("yyyy/MM/dd") & "' "
            Else : comando &= "fechaBaja = null "
            End If

            comando &= "where idCliente = " & cliente.idCliente

            sql.CommandText = comando
            cant = sql.ExecuteNonQuery()
            Return Conexion.EventosSql.INSERCION_CORRECTA

        Catch ex As SqlClient.SqlException
            Return Conexion.EventosSql.OTRO
        Finally : conex.Close()
        End Try


    End Function

    Public Shared Function buscarClientes() As DataTable
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim comando As String

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text

            comando = "select cli.idCliente as 'Nro Cliente', cli.nombre as 'Nombre', cli.apellido as 'Apellido',"
            comando &= "t.tipo as 'Tipo Documento', cli.tipoDoc as 'ID Tipo Documento', cli.nroDocumento as 'Nro Documento',"
            comando &= "cli.telefono as 'Teléfono', cli.fechaAlta as 'Fecha Alta', cli.fechaBaja as 'Fecha Baja',"
            comando &= "cli.email as 'E-Mail'"
            comando &= " from cliente cli"
            comando &= " join tipoDocumento t on t.idTipoDocumento = cli.tipoDoc"
            comando &= " order by cli.idCliente"

            sql.CommandText = comando

            tabla.Load(sql.ExecuteReader())



        Catch ex As SqlClient.SqlException
        Finally : conex.Close()
        End Try


        Return tabla
    End Function


    Public Shared Function buscarCliente(ByVal tipoDoc As Int32, ByVal nroDoc As String, ByVal id As Int32) As ClienteDto
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim comando As String
        Dim cliente As ClienteDto

        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            comando = "select * from cliente where idCliente = " & id & " or (nroDocumento = '" & nroDoc & "' and tipoDoc = " & tipoDoc & ")"
            sql.CommandText = comando
            tabla.Load(sql.ExecuteReader())

            cliente = New ClienteDto
            cliente.idCliente = Convert.ToInt32(tabla.Rows(0)(0))
            cliente.nombre = tabla.Rows(0)(1).ToString()
            cliente.apellido = tabla.Rows(0)(2).ToString()
            cliente.telefono = tabla.Rows(0)(3).ToString()
            cliente.fechaAlta = CDate(tabla.Rows(0)(4))
            If Not IsDBNull(tabla.Rows(0)(5)) Then
                cliente.fechaBaja = CDate(tabla.Rows(0)(5))
            End If
            cliente.email = tabla.Rows(0)(6).ToString()
            cliente.nroDocumento = tabla.Rows(0)(7).ToString()
            cliente.tipoDocumento = Convert.ToInt32(tabla.Rows(0)(8))
            tabla.Clear()
            

            Return cliente

        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally : conex.Close()
        End Try


    End Function

End Class

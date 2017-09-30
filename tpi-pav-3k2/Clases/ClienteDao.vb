
Imports System.Data.SqlClient.SqlTransaction
Public Class ClienteDao


    Public Shared Function insertarCliente(ByRef cliente As ClienteDto, ByRef computadora As ComputadoraDto) As Int32

        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim comando As String
        Dim transaccion As SqlClient.SqlTransaction
        Dim cantFilas As Int32
        conex.Open()
        transaccion = conex.BeginTransaction()
        Try
            
            sql.Connection = conex

            sql.CommandType = CommandType.Text
            sql.Transaction = transaccion

            comando = "insert into cliente values(" & cliente.idCliente & ",'" & cliente.nombre & "'," & cliente.apellido
            comando &= "','" & cliente.telefono & "','" & cliente.fechaAlta.ToString("yyyy/MM/dd")
            comando &= "', null, '" & cliente.email & "', '" & cliente.nroDocumento & "'," & cliente.tipoDocumento & ")"
            sql.CommandText = comando

            'sql.BeginExecuteNonQuery()
            cantFilas = sql.ExecuteNonQuery()
            If cantFilas = 1 Then
                cantFilas = ComputadoraDao.insertarComputadora(computadora) 'falta implementar
                If cantFilas = 1 Then
                    transaccion.Commit() ' se hace el comit solamente si se inserta bien la compu
                    Return 1
                Else : Throw New Exception("COMPUTADORA")
                End If
            Else : Throw New Exception("CLIENTE")
            End If


        Catch ex As SqlClient.SqlException

            transaccion.Rollback()
            Return -3
        Catch ex As Exception
            transaccion.Rollback()
            If ex.Message.Equals("COMPUTADORA") Then
                Return -2
            End If
            If ex.Message.Equals("CLIENTE") Then
                Return -1
            End If
        Finally : conex.Close()
        End Try

        Return 0

    End Function

End Class

Public Class Conexion

    Public Enum EventosSql
        INSERCION_CORRECTA
        VIOLACION_PK
        VIOLACION_UQ
        ERROR_CLIENTE
        ERROR_COMPUTADORA
        ERROR_MARCA_PROCESADOR
        OTRO

    End Enum


    Private Shared conex As SqlClient.SqlConnection
    Private Shared sql As SqlClient.SqlCommand
    Private Sub New()

    End Sub

    Public Shared Function getConexion() As SqlClient.SqlConnection

        If IsNothing(conex) Then
            conex = New SqlClient.SqlConnection
            conex.ConnectionString = "Data Source=MATIAS-PC;Initial Catalog=MegDatabase;Integrated Security=True"
            'conex.ConnectionString = "Data Source=MAQUIS;Initial Catalog=MegDatabase;Persist Security Info=True;User ID=avisuales1;Password=avisuales1"
        End If
        Return conex
    End Function

    Public Shared Function getComando() As SqlClient.SqlCommand
        If IsNothing(sql) Then
            sql = New SqlClient.SqlCommand
        End If
        Return sql
    End Function

End Class

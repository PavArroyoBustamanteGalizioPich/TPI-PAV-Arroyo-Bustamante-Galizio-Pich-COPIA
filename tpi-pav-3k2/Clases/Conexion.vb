Public Class Conexion
    Private Shared conex As SqlClient.SqlConnection
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

End Class

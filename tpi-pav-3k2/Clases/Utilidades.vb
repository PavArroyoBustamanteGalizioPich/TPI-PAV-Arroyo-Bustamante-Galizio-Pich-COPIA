Public Class Utilidades

    Public Shared Function sugerirId(ByVal nombreTabla As String, ByVal nombrePk As String) As Int32
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim idSugerido As Int32
        Try
            conex.Open()
            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = "select max(" & nombrePk & ") from " & nombreTabla
            tabla.Load(sql.ExecuteReader())


            idSugerido = Convert.ToInt32(tabla.Rows(0)(0)) + 1
        Catch ex As Exception
            idSugerido = 1
        Finally : conex.Close()
        End Try


        Return idSugerido
    End Function

    Public Shared Sub cargarCombo(ByRef nombreTabla As String, ByRef combo As ComboBox)
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            conex.Open()

            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = "select * from " & nombreTabla
            tabla.Load(sql.ExecuteReader())
            combo.DataSource = tabla
            combo.ValueMember = tabla.Columns(0).ColumnName
            combo.DisplayMember = tabla.Columns(1).ColumnName
        Catch ex As Exception

        Finally : conex.Close()
        End Try
    End Sub

    Public Shared Sub cargarCombo(ByRef nombreTabla As String, ByRef pk As String, ByRef tablaRestriccion As String, ByVal restriccion As Int32, ByRef combo As ComboBox, Optional ByRef display As String = "")
        Dim conex As SqlClient.SqlConnection = Conexion.getConexion()
        Dim sql As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            conex.Open()

            sql.Connection = conex
            sql.CommandType = CommandType.Text
            sql.CommandText = "select * from " & nombreTabla & " where " & tablaRestriccion & " = " & restriccion & " order by " & pk
            tabla.Load(sql.ExecuteReader())
            combo.DataSource = tabla
            combo.ValueMember = tabla.Columns(0).ColumnName
            If display.Equals("") Then
                combo.DisplayMember = tabla.Columns(1).ColumnName
            Else 'combo.DisplayMember = display
            End If

        Catch ex As Exception

        Finally : conex.Close()
        End Try
    End Sub

End Class

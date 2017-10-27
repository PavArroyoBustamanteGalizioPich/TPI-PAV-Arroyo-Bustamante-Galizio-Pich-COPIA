Partial Class dataSetOrdenTrabajo
    Partial Class DetalleOrdenDataTable

        Private Sub DetalleOrdenDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idOrdenColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

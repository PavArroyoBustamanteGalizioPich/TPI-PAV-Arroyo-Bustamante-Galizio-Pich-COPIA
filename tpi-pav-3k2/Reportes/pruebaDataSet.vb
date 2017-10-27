Public Class pruebaDataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id = Convert.ToInt32(txtId.Text.Trim())
        Dim ds As New dataSetOrdenTrabajo

        ConsultasReportes.reporteOt(id, ds)

        dgvOrden.DataSource = ds.OrdenTrabajo
        dgvDetalles.DataSource = ds.DetalleOrden



    End Sub
End Class
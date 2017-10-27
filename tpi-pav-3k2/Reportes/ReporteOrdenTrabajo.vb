Public Class ReporteOrdenTrabajo

   

    Private Sub rvReporteOT_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If Not txtIdOrden.Text.Trim().Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdOrden.Text.Trim())
            Dim ds As New dataSetOrdenTrabajo
            Dim reporte As New reporteOT


            'Dim ds As New DataSet
            ConsultasReportes.reporteOt(id, ds)
            'dgvOrden.DataMember = "OrdenTrabajo"
            'dgvOrden.DataSource = ds.Tables("OrdenTrabajo")

            'dgvDetalle.DataMember = "DetalleOrden"
            'dgvDetalle.DataSource = ds.Tables("DetalleOrden")

            reporte.SetDataSource(ds)
            'reporteOrden.RefreshReport()
            Me.reporteOrden.ReportSource = reporte
            'reporteOrden.RefreshReport()
            reporteOrden.Show()



        End If


    End Sub

    
    Private Sub reporteOrden_Load(sender As Object, e As EventArgs) Handles reporteOrden.Load

    End Sub

    Private Sub ReporteOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
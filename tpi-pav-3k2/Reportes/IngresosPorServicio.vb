Public Class IngresosPorServicio

    Private Sub IngresosPorServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reporte As New InformeIngresosServicios
        Dim ds As New DataSetIngresosMensuales
        ConsultasReportes.informeIngresosServicio(ds)
        reporte.SetDataSource(ds)

        crvIngresosServicio.ReportSource = Nothing

        crvIngresosServicio.ReportSource = reporte
        crvIngresosServicio.Show()


    End Sub
End Class
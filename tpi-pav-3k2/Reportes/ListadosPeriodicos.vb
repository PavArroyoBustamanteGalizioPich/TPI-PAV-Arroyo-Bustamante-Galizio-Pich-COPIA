﻿Public Class ListadosPeriodicos

    Private Enum reportes
        ORDENES_RECIBIDAS
        CLIENTES_REGISTRADOS
        ORDENES_IRREPARABLES
        ORDENES_REPARADAS
        COBROS
    End Enum
   
    Private Sub ListadosPeriodicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbReporte.Items.Add("ORDENES RECEPTADAS")
        cbReporte.Items.Add("CLIENTES REGISTRADOS")
        cbReporte.Items.Add("ORDENES IRREPARABLES")
        cbReporte.Items.Add("ORDENES REPARADAS")
        cbReporte.Items.Add("COBROS")
        cbReporte.SelectedIndex = 0

        dtpHasta.Value = Today
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click

        Dim fechaDesde As Date = dtpDesde.Value
        Dim fechaHasta As Date = dtpHasta.Value

        If Not fechaHasta <= fechaDesde Then

            Dim id As reportes = cbReporte.SelectedIndex

            Select Case id

                Case reportes.ORDENES_RECIBIDAS
                    Dim reporte As New ListadoOrdenesRecibidas
                    Dim ds As New dataSetListadoRecibidas
                    ConsultasReportes.listadoOrdenesRecibidas(fechaDesde, fechaHasta, ds)
                    reporte.SetDataSource(ds)

                    crvReportes.ReportSource = Nothing
                    reporte.SetParameterValue("FechaDesde", fechaDesde)
                    reporte.SetParameterValue("FechaHasta", fechaHasta)


                    crvReportes.ReportSource = reporte
                    crvReportes.Show()
                    Exit Select

                Case reportes.CLIENTES_REGISTRADOS
                    Dim reporte As New listadoClientesRegistrados
                    Dim ds As New dataSetListadoRecibidas
                    ConsultasReportes.listadoClientesRegistrados(fechaDesde, fechaHasta, ds)
                    reporte.SetDataSource(ds)

                    crvReportes.ReportSource = Nothing
                    reporte.SetParameterValue("FechaDesde", fechaDesde)
                    reporte.SetParameterValue("FechaHasta", fechaHasta)


                    crvReportes.ReportSource = reporte
                    crvReportes.Show()
                    Exit Select

                Case reportes.ORDENES_IRREPARABLES
                    Dim reporte As New listadoOrdenesIrreparables
                    Dim ds As New dataSetListadoRecibidas
                    ConsultasReportes.listadoOrdenesIrreparables(fechaDesde, fechaHasta, ds)
                    reporte.SetDataSource(ds)

                    crvReportes.ReportSource = Nothing
                    reporte.SetParameterValue("FechaDesde", fechaDesde)
                    reporte.SetParameterValue("FechaHasta", fechaHasta)


                    crvReportes.ReportSource = reporte
                    crvReportes.Show()
                    Exit Select

                Case reportes.ORDENES_REPARADAS
                    Dim reporte As New ListadoOrdenesReparadas
                    Dim ds As New dataSetListadoRecibidas
                    ConsultasReportes.listadoOrdenesReparadas(fechaDesde, fechaHasta, ds)
                    reporte.SetDataSource(ds)

                    crvReportes.ReportSource = Nothing
                    reporte.SetParameterValue("FechaDesde", fechaDesde)
                    reporte.SetParameterValue("FechaHasta", fechaHasta)


                    crvReportes.ReportSource = reporte
                    crvReportes.Show()
                    Exit Select

                Case reportes.COBROS
                    Dim reporte As New ListadoCobros
                    Dim ds As New dataSetListadoRecibidas
                    ConsultasReportes.listadoCobro(fechaDesde, fechaHasta, ds)
                    reporte.SetDataSource(ds)

                    crvReportes.ReportSource = Nothing
                    reporte.SetParameterValue("FechaDesde", fechaDesde)
                    reporte.SetParameterValue("FechaHasta", fechaHasta)


                    crvReportes.ReportSource = reporte
                    crvReportes.Show()
                    Exit Select

            End Select

        Else : MessageBox.Show("Las fechas seleccionadas no son válidas!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If



    End Sub

    Private Sub cbReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReporte.SelectedIndexChanged

    End Sub
End Class
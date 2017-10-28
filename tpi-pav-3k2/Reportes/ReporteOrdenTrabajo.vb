Public Class ReporteOrdenTrabajo

   

    Private Sub rvReporteOT_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If Not txtIdOrden.Text.Trim().Equals("") Then
            Dim id As Int32 = Convert.ToInt32(txtIdOrden.Text.Trim())
            Dim ds As New dataSetOrdenTrabajo

            reporteOrden.ReportSource = Nothing
            If ConsultasReportes.reporteOt(id, ds) Then
                Dim reporte As New reporteOT
                reporte.SetDataSource(ds)

                Me.reporteOrden.ReportSource = reporte
                reporteOrden.Show()
            Else : MessageBox.Show("El número indicado no pertenece a una orden de trabajo registrada!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else : MessageBox.Show("Por favor indique el nro de orden que desea buscar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    
    Private Sub reporteOrden_Load(sender As Object, e As EventArgs) Handles reporteOrden.Load

    End Sub

    Private Sub ReporteOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtIdOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdOrden.KeyPress

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    
End Class
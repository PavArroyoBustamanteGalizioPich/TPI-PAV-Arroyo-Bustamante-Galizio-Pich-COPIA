Public Class IngresosMensuales

    Private Sub IngresosMensuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtAnioDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnioDesde.KeyPress, txtAnioHasta.KeyPress

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub

   
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim anioDesde As Int32 = Convert.ToInt32(txtAnioDesde.Text)
        Dim anioHasta As Int32 = Convert.ToInt32(txtAnioHasta.Text)

        If (anioDesde <= anioHasta And anioHasta <= Date.Today.Year) Then
            Dim reporte As New ListadoIngresosMensuales
            Dim ds As New DataSetIngresosMensuales
            ConsultasReportes.listadoCobro(anioDesde, anioHasta, ds)
            reporte.SetDataSource(ds)

            crvIngresosMensuales.ReportSource = Nothing

            crvIngresosMensuales.ReportSource = reporte
            crvIngresosMensuales.Show()
        Else : MessageBox.Show("Las fechas ingresadas son inválidas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

       
    End Sub
End Class
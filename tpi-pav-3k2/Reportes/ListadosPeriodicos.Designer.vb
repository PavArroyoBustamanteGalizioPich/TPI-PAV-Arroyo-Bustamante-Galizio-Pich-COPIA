<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadosPeriodicos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelParametros = New System.Windows.Forms.Panel()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbReporte = New System.Windows.Forms.ComboBox()
        Me.lblListadoAMostrar = New System.Windows.Forms.Label()
        Me.crvReportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panelParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelParametros
        '
        Me.panelParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelParametros.Controls.Add(Me.btnGenerarReporte)
        Me.panelParametros.Controls.Add(Me.dtpHasta)
        Me.panelParametros.Controls.Add(Me.Label2)
        Me.panelParametros.Controls.Add(Me.dtpDesde)
        Me.panelParametros.Controls.Add(Me.Label1)
        Me.panelParametros.Controls.Add(Me.cbReporte)
        Me.panelParametros.Controls.Add(Me.lblListadoAMostrar)
        Me.panelParametros.Location = New System.Drawing.Point(13, 13)
        Me.panelParametros.Name = "panelParametros"
        Me.panelParametros.Size = New System.Drawing.Size(917, 69)
        Me.panelParametros.TabIndex = 0
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(835, 14)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarReporte.TabIndex = 6
        Me.btnGenerarReporte.Text = "Generar"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(629, 17)
        Me.dtpHasta.MaxDate = New Date(2050, 12, 1, 0, 0, 0, 0)
        Me.dtpHasta.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtpHasta.TabIndex = 5
        Me.dtpHasta.Value = New Date(2017, 11, 2, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(338, 18)
        Me.dtpDesde.MaxDate = New Date(2040, 12, 1, 0, 0, 0, 0)
        Me.dtpDesde.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpDesde.TabIndex = 3
        Me.dtpDesde.Value = New Date(2017, 10, 28, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Desde:"
        '
        'cbReporte
        '
        Me.cbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReporte.FormattingEnabled = True
        Me.cbReporte.Location = New System.Drawing.Point(97, 18)
        Me.cbReporte.Name = "cbReporte"
        Me.cbReporte.Size = New System.Drawing.Size(160, 21)
        Me.cbReporte.TabIndex = 1
        '
        'lblListadoAMostrar
        '
        Me.lblListadoAMostrar.AutoSize = True
        Me.lblListadoAMostrar.Location = New System.Drawing.Point(4, 22)
        Me.lblListadoAMostrar.Name = "lblListadoAMostrar"
        Me.lblListadoAMostrar.Size = New System.Drawing.Size(91, 13)
        Me.lblListadoAMostrar.TabIndex = 0
        Me.lblListadoAMostrar.Text = "Listado a Mostrar:"
        '
        'crvReportes
        '
        Me.crvReportes.ActiveViewIndex = -1
        Me.crvReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportes.Location = New System.Drawing.Point(13, 89)
        Me.crvReportes.Name = "crvReportes"
        Me.crvReportes.ShowGroupTreeButton = False
        Me.crvReportes.ShowLogo = False
        Me.crvReportes.ShowParameterPanelButton = False
        Me.crvReportes.ShowRefreshButton = False
        Me.crvReportes.Size = New System.Drawing.Size(917, 332)
        Me.crvReportes.TabIndex = 1
        Me.crvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ListadosPeriodicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 433)
        Me.Controls.Add(Me.crvReportes)
        Me.Controls.Add(Me.panelParametros)
        Me.Name = "ListadosPeriodicos"
        Me.Text = "Listados Periodicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelParametros.ResumeLayout(False)
        Me.panelParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelParametros As System.Windows.Forms.Panel
    Friend WithEvents crvReportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbReporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblListadoAMostrar As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.Button
End Class

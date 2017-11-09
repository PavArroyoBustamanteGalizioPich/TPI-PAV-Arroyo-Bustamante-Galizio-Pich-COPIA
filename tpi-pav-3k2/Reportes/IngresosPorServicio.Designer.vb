<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresosPorServicio
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
        Me.crvIngresosServicio = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvIngresosServicio
        '
        Me.crvIngresosServicio.ActiveViewIndex = -1
        Me.crvIngresosServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvIngresosServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvIngresosServicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvIngresosServicio.Location = New System.Drawing.Point(13, 13)
        Me.crvIngresosServicio.Name = "crvIngresosServicio"
        Me.crvIngresosServicio.ShowCloseButton = False
        Me.crvIngresosServicio.ShowCopyButton = False
        Me.crvIngresosServicio.ShowGroupTreeButton = False
        Me.crvIngresosServicio.ShowLogo = False
        Me.crvIngresosServicio.ShowRefreshButton = False
        Me.crvIngresosServicio.Size = New System.Drawing.Size(775, 461)
        Me.crvIngresosServicio.TabIndex = 0
        Me.crvIngresosServicio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'IngresosPorServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 486)
        Me.Controls.Add(Me.crvIngresosServicio)
        Me.Name = "IngresosPorServicio"
        Me.Text = "Informe de Ingresos por Servicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvIngresosServicio As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

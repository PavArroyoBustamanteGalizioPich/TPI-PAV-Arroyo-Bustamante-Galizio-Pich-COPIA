<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteOrdenTrabajo
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
        Me.txtIdOrden = New System.Windows.Forms.TextBox()
        Me.lblIdOrden = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.reporteOrden = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'txtIdOrden
        '
        Me.txtIdOrden.Location = New System.Drawing.Point(114, 37)
        Me.txtIdOrden.Name = "txtIdOrden"
        Me.txtIdOrden.Size = New System.Drawing.Size(76, 20)
        Me.txtIdOrden.TabIndex = 0
        '
        'lblIdOrden
        '
        Me.lblIdOrden.AutoSize = True
        Me.lblIdOrden.Location = New System.Drawing.Point(13, 37)
        Me.lblIdOrden.Name = "lblIdOrden"
        Me.lblIdOrden.Size = New System.Drawing.Size(90, 13)
        Me.lblIdOrden.TabIndex = 1
        Me.lblIdOrden.Text = "Id Orden Trabajo:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(226, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'reporteOrden
        '
        Me.reporteOrden.ActiveViewIndex = -1
        Me.reporteOrden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reporteOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporteOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.reporteOrden.Location = New System.Drawing.Point(12, 63)
        Me.reporteOrden.Name = "reporteOrden"
        Me.reporteOrden.ShowCloseButton = False
        Me.reporteOrden.ShowGroupTreeButton = False
        Me.reporteOrden.ShowLogo = False
        Me.reporteOrden.Size = New System.Drawing.Size(733, 365)
        Me.reporteOrden.TabIndex = 3
        Me.reporteOrden.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReporteOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 440)
        Me.Controls.Add(Me.reporteOrden)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblIdOrden)
        Me.Controls.Add(Me.txtIdOrden)
        Me.Name = "ReporteOrdenTrabajo"
        Me.Text = "ReporteOrdenTrabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdOrden As System.Windows.Forms.TextBox
    Friend WithEvents lblIdOrden As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents reporteOrden As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

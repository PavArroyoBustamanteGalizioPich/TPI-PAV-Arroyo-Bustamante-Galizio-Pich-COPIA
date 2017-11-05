<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresosMensuales
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtAnioDesde = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAnioHasta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crvIngresosMensuales = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(289, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtAnioDesde
        '
        Me.txtAnioDesde.Location = New System.Drawing.Point(72, 11)
        Me.txtAnioDesde.Name = "txtAnioDesde"
        Me.txtAnioDesde.Size = New System.Drawing.Size(62, 20)
        Me.txtAnioDesde.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Año Desde:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtAnioHasta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtAnioDesde)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 42)
        Me.Panel1.TabIndex = 4
        '
        'txtAnioHasta
        '
        Me.txtAnioHasta.Location = New System.Drawing.Point(221, 11)
        Me.txtAnioHasta.Name = "txtAnioHasta"
        Me.txtAnioHasta.Size = New System.Drawing.Size(62, 20)
        Me.txtAnioHasta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Año Hasta:"
        '
        'crvIngresosMensuales
        '
        Me.crvIngresosMensuales.ActiveViewIndex = -1
        Me.crvIngresosMensuales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvIngresosMensuales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvIngresosMensuales.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvIngresosMensuales.Location = New System.Drawing.Point(13, 62)
        Me.crvIngresosMensuales.Name = "crvIngresosMensuales"
        Me.crvIngresosMensuales.ShowGroupTreeButton = False
        Me.crvIngresosMensuales.ShowLogo = False
        Me.crvIngresosMensuales.ShowRefreshButton = False
        Me.crvIngresosMensuales.Size = New System.Drawing.Size(802, 293)
        Me.crvIngresosMensuales.TabIndex = 5
        Me.crvIngresosMensuales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'IngresosMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 367)
        Me.Controls.Add(Me.crvIngresosMensuales)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IngresosMensuales"
        Me.Text = "IngresosMensuales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtAnioDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAnioHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crvIngresosMensuales As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

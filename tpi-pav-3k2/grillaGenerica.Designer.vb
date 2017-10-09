<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrillaGenerica
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
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.lblCriterioBusqueda = New System.Windows.Forms.Label()
        Me.cbCriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AllowUserToOrderColumns = True
        Me.dgvBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(13, 55)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(510, 386)
        Me.dgvBusqueda.TabIndex = 0
        '
        'lblCriterioBusqueda
        '
        Me.lblCriterioBusqueda.AutoSize = True
        Me.lblCriterioBusqueda.Location = New System.Drawing.Point(13, 24)
        Me.lblCriterioBusqueda.Name = "lblCriterioBusqueda"
        Me.lblCriterioBusqueda.Size = New System.Drawing.Size(61, 13)
        Me.lblCriterioBusqueda.TabIndex = 1
        Me.lblCriterioBusqueda.Text = "Buscar por:"
        '
        'cbCriterioBusqueda
        '
        Me.cbCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterioBusqueda.FormattingEnabled = True
        Me.cbCriterioBusqueda.Location = New System.Drawing.Point(80, 16)
        Me.cbCriterioBusqueda.Name = "cbCriterioBusqueda"
        Me.cbCriterioBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.cbCriterioBusqueda.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(207, 17)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtBusqueda.TabIndex = 3
        '
        'GrillaGenerica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 453)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cbCriterioBusqueda)
        Me.Controls.Add(Me.lblCriterioBusqueda)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Name = "GrillaGenerica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "grillaGenerica"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents lblCriterioBusqueda As System.Windows.Forms.Label
    Friend WithEvents cbCriterioBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
End Class

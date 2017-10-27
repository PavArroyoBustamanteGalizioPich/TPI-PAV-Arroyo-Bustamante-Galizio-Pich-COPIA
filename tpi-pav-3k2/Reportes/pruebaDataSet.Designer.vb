<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pruebaDataSet
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dgvOrden = New System.Windows.Forms.DataGridView()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(143, 16)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 1
        '
        'dgvOrden
        '
        Me.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrden.Location = New System.Drawing.Point(39, 92)
        Me.dgvOrden.Name = "dgvOrden"
        Me.dgvOrden.Size = New System.Drawing.Size(907, 91)
        Me.dgvOrden.TabIndex = 2
        '
        'dgvDetalles
        '
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Location = New System.Drawing.Point(39, 197)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.Size = New System.Drawing.Size(827, 123)
        Me.dgvDetalles.TabIndex = 3
        '
        'pruebaDataSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 332)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.dgvOrden)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Button1)
        Me.Name = "pruebaDataSet"
        Me.Text = "pruebaDataSet"
        CType(Me.dgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents dgvOrden As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
End Class

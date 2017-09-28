<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTipoDocumento
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNvoTipoDoc = New System.Windows.Forms.Button()
        Me.txtDescripTipoDoc = New System.Windows.Forms.TextBox()
        Me.lblDescripTipoDoc = New System.Windows.Forms.Label()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.txtIdTipoDoc = New System.Windows.Forms.TextBox()
        Me.lblIdTipoDoc = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(94, 126)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNvoTipoDoc
        '
        Me.btnNvoTipoDoc.Location = New System.Drawing.Point(12, 126)
        Me.btnNvoTipoDoc.Name = "btnNvoTipoDoc"
        Me.btnNvoTipoDoc.Size = New System.Drawing.Size(75, 23)
        Me.btnNvoTipoDoc.TabIndex = 6
        Me.btnNvoTipoDoc.Text = "Nuevo"
        Me.btnNvoTipoDoc.UseVisualStyleBackColor = True
        '
        'txtDescripTipoDoc
        '
        Me.txtDescripTipoDoc.Location = New System.Drawing.Point(120, 75)
        Me.txtDescripTipoDoc.Multiline = True
        Me.txtDescripTipoDoc.Name = "txtDescripTipoDoc"
        Me.txtDescripTipoDoc.Size = New System.Drawing.Size(111, 43)
        Me.txtDescripTipoDoc.TabIndex = 3
        '
        'lblDescripTipoDoc
        '
        Me.lblDescripTipoDoc.AutoSize = True
        Me.lblDescripTipoDoc.Location = New System.Drawing.Point(12, 83)
        Me.lblDescripTipoDoc.Name = "lblDescripTipoDoc"
        Me.lblDescripTipoDoc.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripTipoDoc.TabIndex = 12
        Me.lblDescripTipoDoc.Text = "Descripción:"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New System.Drawing.Point(120, 42)
        Me.txtTipoDoc.MaxLength = 10
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDoc.TabIndex = 2
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(12, 50)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDoc.TabIndex = 10
        Me.lblTipoDoc.Text = "Tipo Documento:"
        '
        'txtIdTipoDoc
        '
        Me.txtIdTipoDoc.Location = New System.Drawing.Point(120, 9)
        Me.txtIdTipoDoc.MaxLength = 3
        Me.txtIdTipoDoc.Name = "txtIdTipoDoc"
        Me.txtIdTipoDoc.Size = New System.Drawing.Size(48, 20)
        Me.txtIdTipoDoc.TabIndex = 0
        '
        'lblIdTipoDoc
        '
        Me.lblIdTipoDoc.AutoSize = True
        Me.lblIdTipoDoc.Location = New System.Drawing.Point(12, 17)
        Me.lblIdTipoDoc.Name = "lblIdTipoDoc"
        Me.lblIdTipoDoc.Size = New System.Drawing.Size(101, 13)
        Me.lblIdTipoDoc.TabIndex = 8
        Me.lblIdTipoDoc.Text = "Id Tipo Documento:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(176, 125)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(176, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ACTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNvoTipoDoc)
        Me.Controls.Add(Me.txtDescripTipoDoc)
        Me.Controls.Add(Me.lblDescripTipoDoc)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.txtIdTipoDoc)
        Me.Controls.Add(Me.lblIdTipoDoc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Tipo Documento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNvoTipoDoc As System.Windows.Forms.Button
    Friend WithEvents txtDescripTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripTipoDoc As System.Windows.Forms.Label
    Friend WithEvents txtTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents txtIdTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblIdTipoDoc As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class

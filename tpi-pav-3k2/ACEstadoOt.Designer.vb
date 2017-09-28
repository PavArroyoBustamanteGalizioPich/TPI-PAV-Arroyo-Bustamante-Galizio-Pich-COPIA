<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACEstadoOt
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
        Me.lblIdEstado = New System.Windows.Forms.Label()
        Me.txtIdEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblDescripEstado = New System.Windows.Forms.Label()
        Me.txtDescripEstado = New System.Windows.Forms.TextBox()
        Me.btnNvoEstado = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdEstado
        '
        Me.lblIdEstado.AutoSize = True
        Me.lblIdEstado.Location = New System.Drawing.Point(13, 13)
        Me.lblIdEstado.Name = "lblIdEstado"
        Me.lblIdEstado.Size = New System.Drawing.Size(55, 13)
        Me.lblIdEstado.TabIndex = 0
        Me.lblIdEstado.Text = "Id Estado:"
        '
        'txtIdEstado
        '
        Me.txtIdEstado.Location = New System.Drawing.Point(80, 5)
        Me.txtIdEstado.MaxLength = 3
        Me.txtIdEstado.Name = "txtIdEstado"
        Me.txtIdEstado.Size = New System.Drawing.Size(48, 20)
        Me.txtIdEstado.TabIndex = 1
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(13, 46)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(80, 38)
        Me.txtEstado.MaxLength = 20
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(111, 20)
        Me.txtEstado.TabIndex = 3
        '
        'lblDescripEstado
        '
        Me.lblDescripEstado.AutoSize = True
        Me.lblDescripEstado.Location = New System.Drawing.Point(13, 79)
        Me.lblDescripEstado.Name = "lblDescripEstado"
        Me.lblDescripEstado.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripEstado.TabIndex = 4
        Me.lblDescripEstado.Text = "Descripción:"
        '
        'txtDescripEstado
        '
        Me.txtDescripEstado.Location = New System.Drawing.Point(80, 71)
        Me.txtDescripEstado.Multiline = True
        Me.txtDescripEstado.Name = "txtDescripEstado"
        Me.txtDescripEstado.Size = New System.Drawing.Size(111, 63)
        Me.txtDescripEstado.TabIndex = 5
        '
        'btnNvoEstado
        '
        Me.btnNvoEstado.Location = New System.Drawing.Point(12, 140)
        Me.btnNvoEstado.Name = "btnNvoEstado"
        Me.btnNvoEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnNvoEstado.TabIndex = 6
        Me.btnNvoEstado.Text = "Nuevo"
        Me.btnNvoEstado.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(93, 140)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(175, 139)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ACEstadoOt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 175)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNvoEstado)
        Me.Controls.Add(Me.txtDescripEstado)
        Me.Controls.Add(Me.lblDescripEstado)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtIdEstado)
        Me.Controls.Add(Me.lblIdEstado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ACEstadoOt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Orden de Trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdEstado As System.Windows.Forms.Label
    Friend WithEvents txtIdEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripEstado As System.Windows.Forms.Label
    Friend WithEvents txtDescripEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnNvoEstado As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class

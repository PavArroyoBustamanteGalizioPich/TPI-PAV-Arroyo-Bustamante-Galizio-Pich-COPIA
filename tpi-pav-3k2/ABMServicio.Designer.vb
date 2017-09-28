<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMServicio
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
        Me.lblIdServicio = New System.Windows.Forms.Label()
        Me.txtIdServicio = New System.Windows.Forms.TextBox()
        Me.lblRepRequerido = New System.Windows.Forms.Label()
        Me.txtDescripServ = New System.Windows.Forms.TextBox()
        Me.lblDescripServ = New System.Windows.Forms.Label()
        Me.txtGarantiaServ = New System.Windows.Forms.TextBox()
        Me.lblGarantiaServ = New System.Windows.Forms.Label()
        Me.txtCostoServicio = New System.Windows.Forms.TextBox()
        Me.lblCostoServicio = New System.Windows.Forms.Label()
        Me.txtNombreServicio = New System.Windows.Forms.TextBox()
        Me.lblNombreServ = New System.Windows.Forms.Label()
        Me.cbRepRequerido = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.chkEstadoServicio = New System.Windows.Forms.CheckBox()
        Me.lblFechaBaja = New System.Windows.Forms.Label()
        Me.txtFechaBaja = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIdServicio
        '
        Me.lblIdServicio.AutoSize = True
        Me.lblIdServicio.Location = New System.Drawing.Point(14, 13)
        Me.lblIdServicio.Name = "lblIdServicio"
        Me.lblIdServicio.Size = New System.Drawing.Size(60, 13)
        Me.lblIdServicio.TabIndex = 20
        Me.lblIdServicio.Text = "Id Servicio:"
        '
        'txtIdServicio
        '
        Me.txtIdServicio.Location = New System.Drawing.Point(127, 6)
        Me.txtIdServicio.MaxLength = 4
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.Size = New System.Drawing.Size(48, 20)
        Me.txtIdServicio.TabIndex = 1
        '
        'lblRepRequerido
        '
        Me.lblRepRequerido.AutoSize = True
        Me.lblRepRequerido.Location = New System.Drawing.Point(14, 183)
        Me.lblRepRequerido.Name = "lblRepRequerido"
        Me.lblRepRequerido.Size = New System.Drawing.Size(103, 13)
        Me.lblRepRequerido.TabIndex = 25
        Me.lblRepRequerido.Text = "Repuesto requerido:"
        '
        'txtDescripServ
        '
        Me.txtDescripServ.Location = New System.Drawing.Point(127, 114)
        Me.txtDescripServ.Multiline = True
        Me.txtDescripServ.Name = "txtDescripServ"
        Me.txtDescripServ.Size = New System.Drawing.Size(271, 55)
        Me.txtDescripServ.TabIndex = 6
        '
        'lblDescripServ
        '
        Me.lblDescripServ.AutoSize = True
        Me.lblDescripServ.Location = New System.Drawing.Point(14, 123)
        Me.lblDescripServ.Name = "lblDescripServ"
        Me.lblDescripServ.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripServ.TabIndex = 24
        Me.lblDescripServ.Text = "Descripción:"
        '
        'txtGarantiaServ
        '
        Me.txtGarantiaServ.Location = New System.Drawing.Point(127, 87)
        Me.txtGarantiaServ.MaxLength = 3
        Me.txtGarantiaServ.Name = "txtGarantiaServ"
        Me.txtGarantiaServ.Size = New System.Drawing.Size(48, 20)
        Me.txtGarantiaServ.TabIndex = 5
        '
        'lblGarantiaServ
        '
        Me.lblGarantiaServ.AutoSize = True
        Me.lblGarantiaServ.Location = New System.Drawing.Point(14, 94)
        Me.lblGarantiaServ.Name = "lblGarantiaServ"
        Me.lblGarantiaServ.Size = New System.Drawing.Size(52, 13)
        Me.lblGarantiaServ.TabIndex = 23
        Me.lblGarantiaServ.Text = "Garantía:"
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.Location = New System.Drawing.Point(127, 57)
        Me.txtCostoServicio.MaxLength = 8
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(48, 20)
        Me.txtCostoServicio.TabIndex = 4
        '
        'lblCostoServicio
        '
        Me.lblCostoServicio.AutoSize = True
        Me.lblCostoServicio.Location = New System.Drawing.Point(14, 66)
        Me.lblCostoServicio.Name = "lblCostoServicio"
        Me.lblCostoServicio.Size = New System.Drawing.Size(52, 13)
        Me.lblCostoServicio.TabIndex = 22
        Me.lblCostoServicio.Text = "Costo ($):"
        '
        'txtNombreServicio
        '
        Me.txtNombreServicio.Location = New System.Drawing.Point(127, 31)
        Me.txtNombreServicio.MaxLength = 80
        Me.txtNombreServicio.Name = "txtNombreServicio"
        Me.txtNombreServicio.Size = New System.Drawing.Size(271, 20)
        Me.txtNombreServicio.TabIndex = 3
        '
        'lblNombreServ
        '
        Me.lblNombreServ.AutoSize = True
        Me.lblNombreServ.Location = New System.Drawing.Point(14, 39)
        Me.lblNombreServ.Name = "lblNombreServ"
        Me.lblNombreServ.Size = New System.Drawing.Size(88, 13)
        Me.lblNombreServ.TabIndex = 21
        Me.lblNombreServ.Text = "Nombre Servicio:"
        '
        'cbRepRequerido
        '
        Me.cbRepRequerido.FormattingEnabled = True
        Me.cbRepRequerido.Location = New System.Drawing.Point(127, 175)
        Me.cbRepRequerido.Name = "cbRepRequerido"
        Me.cbRepRequerido.Size = New System.Drawing.Size(271, 21)
        Me.cbRepRequerido.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 302)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(93, 302)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(174, 302)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'chkEstadoServicio
        '
        Me.chkEstadoServicio.AutoSize = True
        Me.chkEstadoServicio.Location = New System.Drawing.Point(127, 202)
        Me.chkEstadoServicio.Name = "chkEstadoServicio"
        Me.chkEstadoServicio.Size = New System.Drawing.Size(56, 17)
        Me.chkEstadoServicio.TabIndex = 8
        Me.chkEstadoServicio.Text = "Activo"
        Me.chkEstadoServicio.UseVisualStyleBackColor = True
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.AutoSize = True
        Me.lblFechaBaja.Location = New System.Drawing.Point(17, 233)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaBaja.TabIndex = 26
        Me.lblFechaBaja.Text = "Fecha Baja:"
        '
        'txtFechaBaja
        '
        Me.txtFechaBaja.Location = New System.Drawing.Point(127, 225)
        Me.txtFechaBaja.Mask = "00/00/0000"
        Me.txtFechaBaja.Name = "txtFechaBaja"
        Me.txtFechaBaja.Size = New System.Drawing.Size(66, 20)
        Me.txtFechaBaja.TabIndex = 18
        Me.txtFechaBaja.ValidatingType = GetType(Date)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(256, 301)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(181, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(17, 202)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 27
        Me.lblEstado.Text = "Estado:"
        '
        'ABMServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 337)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtFechaBaja)
        Me.Controls.Add(Me.lblFechaBaja)
        Me.Controls.Add(Me.chkEstadoServicio)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbRepRequerido)
        Me.Controls.Add(Me.txtNombreServicio)
        Me.Controls.Add(Me.lblNombreServ)
        Me.Controls.Add(Me.txtCostoServicio)
        Me.Controls.Add(Me.lblCostoServicio)
        Me.Controls.Add(Me.txtGarantiaServ)
        Me.Controls.Add(Me.lblGarantiaServ)
        Me.Controls.Add(Me.txtDescripServ)
        Me.Controls.Add(Me.lblDescripServ)
        Me.Controls.Add(Me.lblRepRequerido)
        Me.Controls.Add(Me.txtIdServicio)
        Me.Controls.Add(Me.lblIdServicio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestión de Servicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdServicio As System.Windows.Forms.Label
    Friend WithEvents txtIdServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblRepRequerido As System.Windows.Forms.Label
    Friend WithEvents txtDescripServ As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripServ As System.Windows.Forms.Label
    Friend WithEvents txtGarantiaServ As System.Windows.Forms.TextBox
    Friend WithEvents lblGarantiaServ As System.Windows.Forms.Label
    Friend WithEvents txtCostoServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoServicio As System.Windows.Forms.Label
    Friend WithEvents txtNombreServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreServ As System.Windows.Forms.Label
    Friend WithEvents cbRepRequerido As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents chkEstadoServicio As System.Windows.Forms.CheckBox
    Friend WithEvents lblFechaBaja As System.Windows.Forms.Label
    Friend WithEvents txtFechaBaja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
End Class

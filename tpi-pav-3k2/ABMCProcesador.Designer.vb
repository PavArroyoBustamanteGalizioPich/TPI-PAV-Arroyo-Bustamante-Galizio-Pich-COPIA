<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCProcesador
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
        Me.panelProcesador = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblGhz = New System.Windows.Forms.Label()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.lblFrecuencia = New System.Windows.Forms.Label()
        Me.txtCantCore = New System.Windows.Forms.TextBox()
        Me.lblCantCore = New System.Windows.Forms.Label()
        Me.txtModelProc = New System.Windows.Forms.TextBox()
        Me.lblModelProc = New System.Windows.Forms.Label()
        Me.cbMarcaProc = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtIdProc = New System.Windows.Forms.TextBox()
        Me.lblIdProc = New System.Windows.Forms.Label()
        Me.panelBotonera = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.panelProcesador.SuspendLayout()
        Me.panelBotonera.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelProcesador
        '
        Me.panelProcesador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProcesador.Controls.Add(Me.btnBuscar)
        Me.panelProcesador.Controls.Add(Me.lblGhz)
        Me.panelProcesador.Controls.Add(Me.txtFrecuencia)
        Me.panelProcesador.Controls.Add(Me.lblFrecuencia)
        Me.panelProcesador.Controls.Add(Me.txtCantCore)
        Me.panelProcesador.Controls.Add(Me.lblCantCore)
        Me.panelProcesador.Controls.Add(Me.txtModelProc)
        Me.panelProcesador.Controls.Add(Me.lblModelProc)
        Me.panelProcesador.Controls.Add(Me.cbMarcaProc)
        Me.panelProcesador.Controls.Add(Me.lblMarca)
        Me.panelProcesador.Controls.Add(Me.txtIdProc)
        Me.panelProcesador.Controls.Add(Me.lblIdProc)
        Me.panelProcesador.Location = New System.Drawing.Point(12, 13)
        Me.panelProcesador.Name = "panelProcesador"
        Me.panelProcesador.Size = New System.Drawing.Size(359, 177)
        Me.panelProcesador.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(169, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblGhz
        '
        Me.lblGhz.AutoSize = True
        Me.lblGhz.Location = New System.Drawing.Point(302, 124)
        Me.lblGhz.Name = "lblGhz"
        Me.lblGhz.Size = New System.Drawing.Size(34, 13)
        Me.lblGhz.TabIndex = 11
        Me.lblGhz.Text = "(GHz)"
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(252, 116)
        Me.txtFrecuencia.MaxLength = 5
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(43, 20)
        Me.txtFrecuencia.TabIndex = 5
        '
        'lblFrecuencia
        '
        Me.lblFrecuencia.AutoSize = True
        Me.lblFrecuencia.Location = New System.Drawing.Point(182, 124)
        Me.lblFrecuencia.Name = "lblFrecuencia"
        Me.lblFrecuencia.Size = New System.Drawing.Size(63, 13)
        Me.lblFrecuencia.TabIndex = 9
        Me.lblFrecuencia.Text = "Frecuencia:"
        '
        'txtCantCore
        '
        Me.txtCantCore.Location = New System.Drawing.Point(114, 116)
        Me.txtCantCore.MaxLength = 3
        Me.txtCantCore.Name = "txtCantCore"
        Me.txtCantCore.Size = New System.Drawing.Size(61, 20)
        Me.txtCantCore.TabIndex = 4
        '
        'lblCantCore
        '
        Me.lblCantCore.AutoSize = True
        Me.lblCantCore.Location = New System.Drawing.Point(7, 124)
        Me.lblCantCore.Name = "lblCantCore"
        Me.lblCantCore.Size = New System.Drawing.Size(94, 13)
        Me.lblCantCore.TabIndex = 12
        Me.lblCantCore.Text = "Cantidad Núcleos:"
        '
        'txtModelProc
        '
        Me.txtModelProc.Location = New System.Drawing.Point(90, 76)
        Me.txtModelProc.MaxLength = 45
        Me.txtModelProc.Name = "txtModelProc"
        Me.txtModelProc.Size = New System.Drawing.Size(213, 20)
        Me.txtModelProc.TabIndex = 3
        '
        'lblModelProc
        '
        Me.lblModelProc.AutoSize = True
        Me.lblModelProc.Location = New System.Drawing.Point(7, 84)
        Me.lblModelProc.Name = "lblModelProc"
        Me.lblModelProc.Size = New System.Drawing.Size(45, 13)
        Me.lblModelProc.TabIndex = 11
        Me.lblModelProc.Text = "Modelo:"
        '
        'cbMarcaProc
        '
        Me.cbMarcaProc.FormattingEnabled = True
        Me.cbMarcaProc.Location = New System.Drawing.Point(90, 40)
        Me.cbMarcaProc.Name = "cbMarcaProc"
        Me.cbMarcaProc.Size = New System.Drawing.Size(121, 21)
        Me.cbMarcaProc.TabIndex = 2
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(7, 49)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 13)
        Me.lblMarca.TabIndex = 10
        Me.lblMarca.Text = "Marca:"
        '
        'txtIdProc
        '
        Me.txtIdProc.Location = New System.Drawing.Point(90, 11)
        Me.txtIdProc.MaxLength = 10
        Me.txtIdProc.Name = "txtIdProc"
        Me.txtIdProc.Size = New System.Drawing.Size(73, 20)
        Me.txtIdProc.TabIndex = 0
        '
        'lblIdProc
        '
        Me.lblIdProc.AutoSize = True
        Me.lblIdProc.Location = New System.Drawing.Point(7, 18)
        Me.lblIdProc.Name = "lblIdProc"
        Me.lblIdProc.Size = New System.Drawing.Size(79, 13)
        Me.lblIdProc.TabIndex = 9
        Me.lblIdProc.Text = "Id Procesador: "
        '
        'panelBotonera
        '
        Me.panelBotonera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotonera.Controls.Add(Me.btnCancelar)
        Me.panelBotonera.Controls.Add(Me.btnNuevo)
        Me.panelBotonera.Controls.Add(Me.btnGuardar)
        Me.panelBotonera.Location = New System.Drawing.Point(13, 196)
        Me.panelBotonera.Name = "panelBotonera"
        Me.panelBotonera.Size = New System.Drawing.Size(358, 38)
        Me.panelBotonera.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(170, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(7, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(88, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ABMCProcesador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 246)
        Me.Controls.Add(Me.panelBotonera)
        Me.Controls.Add(Me.panelProcesador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMCProcesador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion procesadores"
        Me.panelProcesador.ResumeLayout(False)
        Me.panelProcesador.PerformLayout()
        Me.panelBotonera.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelProcesador As System.Windows.Forms.Panel
    Friend WithEvents cbMarcaProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtIdProc As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProc As System.Windows.Forms.Label
    Friend WithEvents panelBotonera As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblGhz As System.Windows.Forms.Label
    Friend WithEvents txtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents lblFrecuencia As System.Windows.Forms.Label
    Friend WithEvents txtCantCore As System.Windows.Forms.TextBox
    Friend WithEvents lblCantCore As System.Windows.Forms.Label
    Friend WithEvents txtModelProc As System.Windows.Forms.TextBox
    Friend WithEvents lblModelProc As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class

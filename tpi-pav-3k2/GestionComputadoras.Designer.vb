<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionComputadoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionComputadoras))
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.cbPcsRegistradas = New System.Windows.Forms.ComboBox()
        Me.btnMostrarPcs = New System.Windows.Forms.Button()
        Me.lblCompusCliente = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.gbDatosPc = New System.Windows.Forms.GroupBox()
        Me.chkEstadoPc = New System.Windows.Forms.CheckBox()
        Me.txtFechaBajaPc = New System.Windows.Forms.MaskedTextBox()
        Me.lblFechaBajPc = New System.Windows.Forms.Label()
        Me.cbModeloProc = New System.Windows.Forms.ComboBox()
        Me.lblModeloProc = New System.Windows.Forms.Label()
        Me.cbMarcaProc = New System.Windows.Forms.ComboBox()
        Me.lblMarcaProc = New System.Windows.Forms.Label()
        Me.lblGB = New System.Windows.Forms.Label()
        Me.txtCapAlm = New System.Windows.Forms.TextBox()
        Me.lblCapAlmac = New System.Windows.Forms.Label()
        Me.txtCantMemoria = New System.Windows.Forms.TextBox()
        Me.lblCantMemoria = New System.Windows.Forms.Label()
        Me.cbTipoMemoria = New System.Windows.Forms.ComboBox()
        Me.lblTipoMemoria = New System.Windows.Forms.Label()
        Me.cbTipoPc = New System.Windows.Forms.ComboBox()
        Me.lblTipoCompu = New System.Windows.Forms.Label()
        Me.txtNroCompu = New System.Windows.Forms.TextBox()
        Me.lblNroPc = New System.Windows.Forms.Label()
        Me.panelBotonera = New System.Windows.Forms.Panel()
        Me.btnCancelarPc = New System.Windows.Forms.Button()
        Me.btnGuardarPc = New System.Windows.Forms.Button()
        Me.btnActualizarPc = New System.Windows.Forms.Button()
        Me.btnBuscarPc = New System.Windows.Forms.Button()
        Me.btnNuevaPc = New System.Windows.Forms.Button()
        Me.gbDatosCliente.SuspendLayout()
        Me.gbDatosPc.SuspendLayout()
        Me.panelBotonera.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatosCliente.Controls.Add(Me.cbPcsRegistradas)
        Me.gbDatosCliente.Controls.Add(Me.btnMostrarPcs)
        Me.gbDatosCliente.Controls.Add(Me.lblCompusCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblNombre)
        Me.gbDatosCliente.Controls.Add(Me.txtNombre)
        Me.gbDatosCliente.Controls.Add(Me.lblApellido)
        Me.gbDatosCliente.Controls.Add(Me.txtApellido)
        Me.gbDatosCliente.Controls.Add(Me.txtNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.lblNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.cbTipoDoc)
        Me.gbDatosCliente.Controls.Add(Me.lblTipoDoc)
        Me.gbDatosCliente.Location = New System.Drawing.Point(13, 13)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(639, 98)
        Me.gbDatosCliente.TabIndex = 0
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos Cliente"
        '
        'cbPcsRegistradas
        '
        Me.cbPcsRegistradas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPcsRegistradas.FormattingEnabled = True
        Me.cbPcsRegistradas.Location = New System.Drawing.Point(422, 59)
        Me.cbPcsRegistradas.Name = "cbPcsRegistradas"
        Me.cbPcsRegistradas.Size = New System.Drawing.Size(80, 21)
        Me.cbPcsRegistradas.TabIndex = 24
        '
        'btnMostrarPcs
        '
        Me.btnMostrarPcs.Location = New System.Drawing.Point(508, 58)
        Me.btnMostrarPcs.Name = "btnMostrarPcs"
        Me.btnMostrarPcs.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarPcs.TabIndex = 23
        Me.btnMostrarPcs.Text = "Mostrar Pcs"
        Me.btnMostrarPcs.UseVisualStyleBackColor = True
        '
        'lblCompusCliente
        '
        Me.lblCompusCliente.AutoSize = True
        Me.lblCompusCliente.Location = New System.Drawing.Point(328, 68)
        Me.lblCompusCliente.Name = "lblCompusCliente"
        Me.lblCompusCliente.Size = New System.Drawing.Size(87, 13)
        Me.lblCompusCliente.TabIndex = 21
        Me.lblCompusCliente.Text = "Pcs Registradas:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(60, 62)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 18
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(167, 69)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 19
        Me.lblApellido.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(221, 62)
        Me.txtApellido.MaxLength = 20
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 20
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(312, 22)
        Me.txtNroDocumento.MaxLength = 11
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(62, 20)
        Me.txtNroDocumento.TabIndex = 15
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(221, 28)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDocumento.TabIndex = 14
        Me.lblNroDocumento.Text = "Nro Documento:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(101, 21)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(113, 21)
        Me.cbTipoDoc.TabIndex = 13
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(6, 29)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDoc.TabIndex = 12
        Me.lblTipoDoc.Text = "Tipo Documento:"
        '
        'gbDatosPc
        '
        Me.gbDatosPc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatosPc.Controls.Add(Me.chkEstadoPc)
        Me.gbDatosPc.Controls.Add(Me.txtFechaBajaPc)
        Me.gbDatosPc.Controls.Add(Me.lblFechaBajPc)
        Me.gbDatosPc.Controls.Add(Me.cbModeloProc)
        Me.gbDatosPc.Controls.Add(Me.lblModeloProc)
        Me.gbDatosPc.Controls.Add(Me.cbMarcaProc)
        Me.gbDatosPc.Controls.Add(Me.lblMarcaProc)
        Me.gbDatosPc.Controls.Add(Me.lblGB)
        Me.gbDatosPc.Controls.Add(Me.txtCapAlm)
        Me.gbDatosPc.Controls.Add(Me.lblCapAlmac)
        Me.gbDatosPc.Controls.Add(Me.txtCantMemoria)
        Me.gbDatosPc.Controls.Add(Me.lblCantMemoria)
        Me.gbDatosPc.Controls.Add(Me.cbTipoMemoria)
        Me.gbDatosPc.Controls.Add(Me.lblTipoMemoria)
        Me.gbDatosPc.Controls.Add(Me.cbTipoPc)
        Me.gbDatosPc.Controls.Add(Me.lblTipoCompu)
        Me.gbDatosPc.Controls.Add(Me.txtNroCompu)
        Me.gbDatosPc.Controls.Add(Me.lblNroPc)
        Me.gbDatosPc.Location = New System.Drawing.Point(13, 137)
        Me.gbDatosPc.Name = "gbDatosPc"
        Me.gbDatosPc.Size = New System.Drawing.Size(639, 147)
        Me.gbDatosPc.TabIndex = 1
        Me.gbDatosPc.TabStop = False
        Me.gbDatosPc.Text = "Datos Computadora"
        '
        'chkEstadoPc
        '
        Me.chkEstadoPc.AutoSize = True
        Me.chkEstadoPc.Location = New System.Drawing.Point(572, 120)
        Me.chkEstadoPc.Name = "chkEstadoPc"
        Me.chkEstadoPc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkEstadoPc.Size = New System.Drawing.Size(56, 17)
        Me.chkEstadoPc.TabIndex = 31
        Me.chkEstadoPc.Text = "Activo"
        Me.chkEstadoPc.UseVisualStyleBackColor = True
        '
        'txtFechaBajaPc
        '
        Me.txtFechaBajaPc.Location = New System.Drawing.Point(502, 114)
        Me.txtFechaBajaPc.Mask = "00/00/0000"
        Me.txtFechaBajaPc.Name = "txtFechaBajaPc"
        Me.txtFechaBajaPc.Size = New System.Drawing.Size(64, 20)
        Me.txtFechaBajaPc.TabIndex = 30
        Me.txtFechaBajaPc.ValidatingType = GetType(Date)
        '
        'lblFechaBajPc
        '
        Me.lblFechaBajPc.AutoSize = True
        Me.lblFechaBajPc.Location = New System.Drawing.Point(431, 121)
        Me.lblFechaBajPc.Name = "lblFechaBajPc"
        Me.lblFechaBajPc.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaBajPc.TabIndex = 29
        Me.lblFechaBajPc.Text = "Fecha Baja:"
        '
        'cbModeloProc
        '
        Me.cbModeloProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModeloProc.FormattingEnabled = True
        Me.cbModeloProc.Location = New System.Drawing.Point(269, 70)
        Me.cbModeloProc.Name = "cbModeloProc"
        Me.cbModeloProc.Size = New System.Drawing.Size(214, 21)
        Me.cbModeloProc.TabIndex = 28
        '
        'lblModeloProc
        '
        Me.lblModeloProc.AutoSize = True
        Me.lblModeloProc.Location = New System.Drawing.Point(192, 79)
        Me.lblModeloProc.Name = "lblModeloProc"
        Me.lblModeloProc.Size = New System.Drawing.Size(70, 13)
        Me.lblModeloProc.TabIndex = 27
        Me.lblModeloProc.Text = "Modelo Proc:"
        '
        'cbMarcaProc
        '
        Me.cbMarcaProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarcaProc.FormattingEnabled = True
        Me.cbMarcaProc.Location = New System.Drawing.Point(106, 71)
        Me.cbMarcaProc.Name = "cbMarcaProc"
        Me.cbMarcaProc.Size = New System.Drawing.Size(80, 21)
        Me.cbMarcaProc.TabIndex = 26
        '
        'lblMarcaProc
        '
        Me.lblMarcaProc.AutoSize = True
        Me.lblMarcaProc.Location = New System.Drawing.Point(6, 79)
        Me.lblMarcaProc.Name = "lblMarcaProc"
        Me.lblMarcaProc.Size = New System.Drawing.Size(97, 13)
        Me.lblMarcaProc.TabIndex = 25
        Me.lblMarcaProc.Text = "Marca Procesador:"
        '
        'lblGB
        '
        Me.lblGB.AutoSize = True
        Me.lblGB.Location = New System.Drawing.Point(396, 121)
        Me.lblGB.Name = "lblGB"
        Me.lblGB.Size = New System.Drawing.Size(28, 13)
        Me.lblGB.TabIndex = 20
        Me.lblGB.Text = "(GB)"
        '
        'txtCapAlm
        '
        Me.txtCapAlm.Location = New System.Drawing.Point(324, 115)
        Me.txtCapAlm.MaxLength = 5
        Me.txtCapAlm.Name = "txtCapAlm"
        Me.txtCapAlm.Size = New System.Drawing.Size(65, 20)
        Me.txtCapAlm.TabIndex = 19
        '
        'lblCapAlmac
        '
        Me.lblCapAlmac.AutoSize = True
        Me.lblCapAlmac.Location = New System.Drawing.Point(176, 122)
        Me.lblCapAlmac.Name = "lblCapAlmac"
        Me.lblCapAlmac.Size = New System.Drawing.Size(141, 13)
        Me.lblCapAlmac.TabIndex = 18
        Me.lblCapAlmac.Text = "Capacidad almacenamiento:"
        '
        'txtCantMemoria
        '
        Me.txtCantMemoria.Location = New System.Drawing.Point(112, 115)
        Me.txtCantMemoria.MaxLength = 4
        Me.txtCantMemoria.Name = "txtCantMemoria"
        Me.txtCantMemoria.Size = New System.Drawing.Size(57, 20)
        Me.txtCantMemoria.TabIndex = 17
        '
        'lblCantMemoria
        '
        Me.lblCantMemoria.AutoSize = True
        Me.lblCantMemoria.Location = New System.Drawing.Point(6, 122)
        Me.lblCantMemoria.Name = "lblCantMemoria"
        Me.lblCantMemoria.Size = New System.Drawing.Size(99, 13)
        Me.lblCantMemoria.TabIndex = 16
        Me.lblCantMemoria.Text = "Cant. Memoria:(GB)"
        '
        'cbTipoMemoria
        '
        Me.cbTipoMemoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMemoria.FormattingEnabled = True
        Me.cbTipoMemoria.Location = New System.Drawing.Point(405, 24)
        Me.cbTipoMemoria.Name = "cbTipoMemoria"
        Me.cbTipoMemoria.Size = New System.Drawing.Size(78, 21)
        Me.cbTipoMemoria.TabIndex = 15
        '
        'lblTipoMemoria
        '
        Me.lblTipoMemoria.AutoSize = True
        Me.lblTipoMemoria.Location = New System.Drawing.Point(324, 31)
        Me.lblTipoMemoria.Name = "lblTipoMemoria"
        Me.lblTipoMemoria.Size = New System.Drawing.Size(74, 13)
        Me.lblTipoMemoria.TabIndex = 14
        Me.lblTipoMemoria.Text = "Tipo Memoria:"
        '
        'cbTipoPc
        '
        Me.cbTipoPc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPc.FormattingEnabled = True
        Me.cbTipoPc.Location = New System.Drawing.Point(217, 24)
        Me.cbTipoPc.Name = "cbTipoPc"
        Me.cbTipoPc.Size = New System.Drawing.Size(100, 21)
        Me.cbTipoPc.TabIndex = 13
        '
        'lblTipoCompu
        '
        Me.lblTipoCompu.AutoSize = True
        Me.lblTipoCompu.Location = New System.Drawing.Point(163, 32)
        Me.lblTipoCompu.Name = "lblTipoCompu"
        Me.lblTipoCompu.Size = New System.Drawing.Size(47, 13)
        Me.lblTipoCompu.TabIndex = 12
        Me.lblTipoCompu.Text = "Tipo Pc:"
        '
        'txtNroCompu
        '
        Me.txtNroCompu.Location = New System.Drawing.Point(106, 25)
        Me.txtNroCompu.MaxLength = 8
        Me.txtNroCompu.Name = "txtNroCompu"
        Me.txtNroCompu.Size = New System.Drawing.Size(50, 20)
        Me.txtNroCompu.TabIndex = 11
        '
        'lblNroPc
        '
        Me.lblNroPc.AutoSize = True
        Me.lblNroPc.Location = New System.Drawing.Point(6, 33)
        Me.lblNroPc.Name = "lblNroPc"
        Me.lblNroPc.Size = New System.Drawing.Size(93, 13)
        Me.lblNroPc.TabIndex = 10
        Me.lblNroPc.Text = "Nro Computadora:"
        '
        'panelBotonera
        '
        Me.panelBotonera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotonera.Controls.Add(Me.btnCancelarPc)
        Me.panelBotonera.Controls.Add(Me.btnGuardarPc)
        Me.panelBotonera.Controls.Add(Me.btnActualizarPc)
        Me.panelBotonera.Controls.Add(Me.btnBuscarPc)
        Me.panelBotonera.Controls.Add(Me.btnNuevaPc)
        Me.panelBotonera.Location = New System.Drawing.Point(13, 290)
        Me.panelBotonera.Name = "panelBotonera"
        Me.panelBotonera.Size = New System.Drawing.Size(638, 60)
        Me.panelBotonera.TabIndex = 2
        '
        'btnCancelarPc
        '
        Me.btnCancelarPc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPc.Image = CType(resources.GetObject("btnCancelarPc.Image"), System.Drawing.Image)
        Me.btnCancelarPc.Location = New System.Drawing.Point(569, 1)
        Me.btnCancelarPc.Name = "btnCancelarPc"
        Me.btnCancelarPc.Size = New System.Drawing.Size(65, 58)
        Me.btnCancelarPc.TabIndex = 4
        Me.btnCancelarPc.UseVisualStyleBackColor = True
        '
        'btnGuardarPc
        '
        Me.btnGuardarPc.Image = CType(resources.GetObject("btnGuardarPc.Image"), System.Drawing.Image)
        Me.btnGuardarPc.Location = New System.Drawing.Point(75, 1)
        Me.btnGuardarPc.Name = "btnGuardarPc"
        Me.btnGuardarPc.Size = New System.Drawing.Size(65, 58)
        Me.btnGuardarPc.TabIndex = 3
        Me.btnGuardarPc.UseVisualStyleBackColor = True
        '
        'btnActualizarPc
        '
        Me.btnActualizarPc.Image = CType(resources.GetObject("btnActualizarPc.Image"), System.Drawing.Image)
        Me.btnActualizarPc.Location = New System.Drawing.Point(217, 1)
        Me.btnActualizarPc.Name = "btnActualizarPc"
        Me.btnActualizarPc.Size = New System.Drawing.Size(65, 58)
        Me.btnActualizarPc.TabIndex = 2
        Me.btnActualizarPc.UseVisualStyleBackColor = True
        '
        'btnBuscarPc
        '
        Me.btnBuscarPc.Image = CType(resources.GetObject("btnBuscarPc.Image"), System.Drawing.Image)
        Me.btnBuscarPc.Location = New System.Drawing.Point(146, 1)
        Me.btnBuscarPc.Name = "btnBuscarPc"
        Me.btnBuscarPc.Size = New System.Drawing.Size(65, 58)
        Me.btnBuscarPc.TabIndex = 1
        Me.btnBuscarPc.UseVisualStyleBackColor = True
        '
        'btnNuevaPc
        '
        Me.btnNuevaPc.Image = CType(resources.GetObject("btnNuevaPc.Image"), System.Drawing.Image)
        Me.btnNuevaPc.Location = New System.Drawing.Point(3, 1)
        Me.btnNuevaPc.Name = "btnNuevaPc"
        Me.btnNuevaPc.Size = New System.Drawing.Size(65, 58)
        Me.btnNuevaPc.TabIndex = 0
        Me.btnNuevaPc.UseVisualStyleBackColor = True
        '
        'GestionComputadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 361)
        Me.Controls.Add(Me.panelBotonera)
        Me.Controls.Add(Me.gbDatosPc)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionComputadoras"
        Me.Text = "Gestión de Computadoras"
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.gbDatosPc.ResumeLayout(False)
        Me.gbDatosPc.PerformLayout()
        Me.panelBotonera.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatosPc As System.Windows.Forms.GroupBox
    Friend WithEvents panelBotonera As System.Windows.Forms.Panel
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents btnMostrarPcs As System.Windows.Forms.Button
    Friend WithEvents lblCompusCliente As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCantMemoria As System.Windows.Forms.TextBox
    Friend WithEvents lblCantMemoria As System.Windows.Forms.Label
    Friend WithEvents cbTipoMemoria As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoMemoria As System.Windows.Forms.Label
    Friend WithEvents cbTipoPc As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCompu As System.Windows.Forms.Label
    Friend WithEvents txtNroCompu As System.Windows.Forms.TextBox
    Friend WithEvents lblNroPc As System.Windows.Forms.Label
    Friend WithEvents lblGB As System.Windows.Forms.Label
    Friend WithEvents txtCapAlm As System.Windows.Forms.TextBox
    Friend WithEvents lblCapAlmac As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPc As System.Windows.Forms.Button
    Friend WithEvents btnNuevaPc As System.Windows.Forms.Button
    Friend WithEvents btnCancelarPc As System.Windows.Forms.Button
    Friend WithEvents btnGuardarPc As System.Windows.Forms.Button
    Friend WithEvents btnActualizarPc As System.Windows.Forms.Button
    Friend WithEvents chkEstadoPc As System.Windows.Forms.CheckBox
    Friend WithEvents txtFechaBajaPc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaBajPc As System.Windows.Forms.Label
    Friend WithEvents cbModeloProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblModeloProc As System.Windows.Forms.Label
    Friend WithEvents cbMarcaProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarcaProc As System.Windows.Forms.Label
    Friend WithEvents cbPcsRegistradas As System.Windows.Forms.ComboBox
End Class

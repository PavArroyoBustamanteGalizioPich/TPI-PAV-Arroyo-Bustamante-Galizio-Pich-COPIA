<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestionClientes))
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnActualizarCli = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.chkBajaCliente = New System.Windows.Forms.CheckBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFechaBaja = New System.Windows.Forms.MaskedTextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblFechaBaja = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtFechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNroCliente = New System.Windows.Forms.Label()
        Me.gbDatosComputadora = New System.Windows.Forms.GroupBox()
        Me.lblGB = New System.Windows.Forms.Label()
        Me.txtCapAlm = New System.Windows.Forms.TextBox()
        Me.lblCapAlmac = New System.Windows.Forms.Label()
        Me.cbModeloProc = New System.Windows.Forms.ComboBox()
        Me.lblModeloProc = New System.Windows.Forms.Label()
        Me.txtCantMemoria = New System.Windows.Forms.TextBox()
        Me.lblCantMemoria = New System.Windows.Forms.Label()
        Me.cbTipoMemoria = New System.Windows.Forms.ComboBox()
        Me.lblTipoMemoria = New System.Windows.Forms.Label()
        Me.cbMarcaProc = New System.Windows.Forms.ComboBox()
        Me.lblMarcaProc = New System.Windows.Forms.Label()
        Me.cbTipoPc = New System.Windows.Forms.ComboBox()
        Me.lblTipoCompu = New System.Windows.Forms.Label()
        Me.txtNroCompu = New System.Windows.Forms.TextBox()
        Me.lblNroPc = New System.Windows.Forms.Label()
        Me.panelBotones.SuspendLayout()
        Me.gbDatosCliente.SuspendLayout()
        Me.gbDatosComputadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBotones
        '
        Me.panelBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotones.Controls.Add(Me.btnActualizarCli)
        Me.panelBotones.Controls.Add(Me.btnCancelar)
        Me.panelBotones.Controls.Add(Me.btnBuscar)
        Me.panelBotones.Controls.Add(Me.btnGuardar)
        Me.panelBotones.Controls.Add(Me.btnNuevoCliente)
        Me.panelBotones.Location = New System.Drawing.Point(13, 13)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(759, 73)
        Me.panelBotones.TabIndex = 0
        '
        'btnActualizarCli
        '
        Me.btnActualizarCli.Image = CType(resources.GetObject("btnActualizarCli.Image"), System.Drawing.Image)
        Me.btnActualizarCli.Location = New System.Drawing.Point(143, 4)
        Me.btnActualizarCli.Name = "btnActualizarCli"
        Me.btnActualizarCli.Size = New System.Drawing.Size(64, 64)
        Me.btnActualizarCli.TabIndex = 5
        Me.btnActualizarCli.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(284, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 64)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(73, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 64)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(213, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 64)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Image = CType(resources.GetObject("btnNuevoCliente.Image"), System.Drawing.Image)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(3, 4)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(64, 64)
        Me.btnNuevoCliente.TabIndex = 0
        Me.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.chkBajaCliente)
        Me.gbDatosCliente.Controls.Add(Me.lblNombre)
        Me.gbDatosCliente.Controls.Add(Me.txtNombre)
        Me.gbDatosCliente.Controls.Add(Me.txtFechaBaja)
        Me.gbDatosCliente.Controls.Add(Me.lblApellido)
        Me.gbDatosCliente.Controls.Add(Me.lblFechaBaja)
        Me.gbDatosCliente.Controls.Add(Me.txtApellido)
        Me.gbDatosCliente.Controls.Add(Me.txtFechaAlta)
        Me.gbDatosCliente.Controls.Add(Me.lblTelefono)
        Me.gbDatosCliente.Controls.Add(Me.lblFechaAlta)
        Me.gbDatosCliente.Controls.Add(Me.txtTelefono)
        Me.gbDatosCliente.Controls.Add(Me.txtEmail)
        Me.gbDatosCliente.Controls.Add(Me.lblEmail)
        Me.gbDatosCliente.Controls.Add(Me.txtNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.lblNroDocumento)
        Me.gbDatosCliente.Controls.Add(Me.cbTipoDoc)
        Me.gbDatosCliente.Controls.Add(Me.lblTipoDoc)
        Me.gbDatosCliente.Controls.Add(Me.TextBox1)
        Me.gbDatosCliente.Controls.Add(Me.lblNroCliente)
        Me.gbDatosCliente.Location = New System.Drawing.Point(13, 93)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(759, 121)
        Me.gbDatosCliente.TabIndex = 1
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos Cliente"
        '
        'chkBajaCliente
        '
        Me.chkBajaCliente.AutoSize = True
        Me.chkBajaCliente.Location = New System.Drawing.Point(284, 76)
        Me.chkBajaCliente.Name = "chkBajaCliente"
        Me.chkBajaCliente.Size = New System.Drawing.Size(56, 17)
        Me.chkBajaCliente.TabIndex = 18
        Me.chkBajaCliente.Text = "Activo"
        Me.chkBajaCliente.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(60, 40)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtFechaBaja
        '
        Me.txtFechaBaja.Enabled = False
        Me.txtFechaBaja.Location = New System.Drawing.Point(212, 73)
        Me.txtFechaBaja.Mask = "00/00/0000"
        Me.txtFechaBaja.Name = "txtFechaBaja"
        Me.txtFechaBaja.Size = New System.Drawing.Size(65, 20)
        Me.txtFechaBaja.TabIndex = 17
        Me.txtFechaBaja.ValidatingType = GetType(Date)
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(167, 47)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido:"
        '
        'lblFechaBaja
        '
        Me.lblFechaBaja.AutoSize = True
        Me.lblFechaBaja.Location = New System.Drawing.Point(144, 80)
        Me.lblFechaBaja.Name = "lblFechaBaja"
        Me.lblFechaBaja.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaBaja.TabIndex = 16
        Me.lblFechaBaja.Text = "Fecha Baja:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(221, 40)
        Me.txtApellido.MaxLength = 20
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 5
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Enabled = False
        Me.txtFechaAlta.Location = New System.Drawing.Point(81, 73)
        Me.txtFechaAlta.Mask = "00/00/0000"
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Size = New System.Drawing.Size(56, 20)
        Me.txtFechaAlta.TabIndex = 15
        Me.txtFechaAlta.ValidatingType = GetType(Date)
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(328, 47)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.Location = New System.Drawing.Point(13, 80)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(61, 13)
        Me.lblFechaAlta.TabIndex = 14
        Me.lblFechaAlta.Text = "Fecha Alta:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(387, 40)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(584, 40)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(492, 47)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(86, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "e-mail (opcional):"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(450, 14)
        Me.txtNroDocumento.MaxLength = 11
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(62, 20)
        Me.txtNroDocumento.TabIndex = 11
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(358, 22)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDocumento.TabIndex = 10
        Me.lblNroDocumento.Text = "Nro Documento:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(238, 14)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(113, 21)
        Me.cbTipoDoc.TabIndex = 9
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(143, 22)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDoc.TabIndex = 8
        Me.lblTipoDoc.Text = "Tipo Documento:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 14)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblNroCliente
        '
        Me.lblNroCliente.AutoSize = True
        Me.lblNroCliente.Location = New System.Drawing.Point(7, 22)
        Me.lblNroCliente.Name = "lblNroCliente"
        Me.lblNroCliente.Size = New System.Drawing.Size(62, 13)
        Me.lblNroCliente.TabIndex = 0
        Me.lblNroCliente.Text = "Nro Cliente:"
        '
        'gbDatosComputadora
        '
        Me.gbDatosComputadora.Controls.Add(Me.lblGB)
        Me.gbDatosComputadora.Controls.Add(Me.txtCapAlm)
        Me.gbDatosComputadora.Controls.Add(Me.lblCapAlmac)
        Me.gbDatosComputadora.Controls.Add(Me.cbModeloProc)
        Me.gbDatosComputadora.Controls.Add(Me.lblModeloProc)
        Me.gbDatosComputadora.Controls.Add(Me.txtCantMemoria)
        Me.gbDatosComputadora.Controls.Add(Me.lblCantMemoria)
        Me.gbDatosComputadora.Controls.Add(Me.cbTipoMemoria)
        Me.gbDatosComputadora.Controls.Add(Me.lblTipoMemoria)
        Me.gbDatosComputadora.Controls.Add(Me.cbMarcaProc)
        Me.gbDatosComputadora.Controls.Add(Me.lblMarcaProc)
        Me.gbDatosComputadora.Controls.Add(Me.cbTipoPc)
        Me.gbDatosComputadora.Controls.Add(Me.lblTipoCompu)
        Me.gbDatosComputadora.Controls.Add(Me.txtNroCompu)
        Me.gbDatosComputadora.Controls.Add(Me.lblNroPc)
        Me.gbDatosComputadora.Location = New System.Drawing.Point(13, 232)
        Me.gbDatosComputadora.Name = "gbDatosComputadora"
        Me.gbDatosComputadora.Size = New System.Drawing.Size(759, 187)
        Me.gbDatosComputadora.TabIndex = 2
        Me.gbDatosComputadora.TabStop = False
        Me.gbDatosComputadora.Text = "Datos Computadora"
        '
        'lblGB
        '
        Me.lblGB.AutoSize = True
        Me.lblGB.Location = New System.Drawing.Point(714, 72)
        Me.lblGB.Name = "lblGB"
        Me.lblGB.Size = New System.Drawing.Size(28, 13)
        Me.lblGB.TabIndex = 14
        Me.lblGB.Text = "(GB)"
        '
        'txtCapAlm
        '
        Me.txtCapAlm.Location = New System.Drawing.Point(642, 64)
        Me.txtCapAlm.MaxLength = 5
        Me.txtCapAlm.Name = "txtCapAlm"
        Me.txtCapAlm.Size = New System.Drawing.Size(65, 20)
        Me.txtCapAlm.TabIndex = 13
        '
        'lblCapAlmac
        '
        Me.lblCapAlmac.AutoSize = True
        Me.lblCapAlmac.Location = New System.Drawing.Point(494, 72)
        Me.lblCapAlmac.Name = "lblCapAlmac"
        Me.lblCapAlmac.Size = New System.Drawing.Size(141, 13)
        Me.lblCapAlmac.TabIndex = 12
        Me.lblCapAlmac.Text = "Capacidad almacenamiento:"
        '
        'cbModeloProc
        '
        Me.cbModeloProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModeloProc.FormattingEnabled = True
        Me.cbModeloProc.Location = New System.Drawing.Point(273, 64)
        Me.cbModeloProc.Name = "cbModeloProc"
        Me.cbModeloProc.Size = New System.Drawing.Size(214, 21)
        Me.cbModeloProc.TabIndex = 11
        '
        'lblModeloProc
        '
        Me.lblModeloProc.AutoSize = True
        Me.lblModeloProc.Location = New System.Drawing.Point(196, 72)
        Me.lblModeloProc.Name = "lblModeloProc"
        Me.lblModeloProc.Size = New System.Drawing.Size(70, 13)
        Me.lblModeloProc.TabIndex = 10
        Me.lblModeloProc.Text = "Modelo Proc:"
        '
        'txtCantMemoria
        '
        Me.txtCantMemoria.Location = New System.Drawing.Point(600, 23)
        Me.txtCantMemoria.MaxLength = 4
        Me.txtCantMemoria.Name = "txtCantMemoria"
        Me.txtCantMemoria.Size = New System.Drawing.Size(57, 20)
        Me.txtCantMemoria.TabIndex = 9
        '
        'lblCantMemoria
        '
        Me.lblCantMemoria.AutoSize = True
        Me.lblCantMemoria.Location = New System.Drawing.Point(494, 30)
        Me.lblCantMemoria.Name = "lblCantMemoria"
        Me.lblCantMemoria.Size = New System.Drawing.Size(99, 13)
        Me.lblCantMemoria.TabIndex = 8
        Me.lblCantMemoria.Text = "Cant. Memoria:(GB)"
        '
        'cbTipoMemoria
        '
        Me.cbTipoMemoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMemoria.FormattingEnabled = True
        Me.cbTipoMemoria.Location = New System.Drawing.Point(409, 22)
        Me.cbTipoMemoria.Name = "cbTipoMemoria"
        Me.cbTipoMemoria.Size = New System.Drawing.Size(78, 21)
        Me.cbTipoMemoria.TabIndex = 7
        '
        'lblTipoMemoria
        '
        Me.lblTipoMemoria.AutoSize = True
        Me.lblTipoMemoria.Location = New System.Drawing.Point(328, 30)
        Me.lblTipoMemoria.Name = "lblTipoMemoria"
        Me.lblTipoMemoria.Size = New System.Drawing.Size(74, 13)
        Me.lblTipoMemoria.TabIndex = 6
        Me.lblTipoMemoria.Text = "Tipo Memoria:"
        '
        'cbMarcaProc
        '
        Me.cbMarcaProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarcaProc.FormattingEnabled = True
        Me.cbMarcaProc.Location = New System.Drawing.Point(110, 64)
        Me.cbMarcaProc.Name = "cbMarcaProc"
        Me.cbMarcaProc.Size = New System.Drawing.Size(80, 21)
        Me.cbMarcaProc.TabIndex = 5
        '
        'lblMarcaProc
        '
        Me.lblMarcaProc.AutoSize = True
        Me.lblMarcaProc.Location = New System.Drawing.Point(10, 72)
        Me.lblMarcaProc.Name = "lblMarcaProc"
        Me.lblMarcaProc.Size = New System.Drawing.Size(97, 13)
        Me.lblMarcaProc.TabIndex = 4
        Me.lblMarcaProc.Text = "Marca Procesador:"
        '
        'cbTipoPc
        '
        Me.cbTipoPc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPc.FormattingEnabled = True
        Me.cbTipoPc.Location = New System.Drawing.Point(221, 22)
        Me.cbTipoPc.Name = "cbTipoPc"
        Me.cbTipoPc.Size = New System.Drawing.Size(100, 21)
        Me.cbTipoPc.TabIndex = 3
        '
        'lblTipoCompu
        '
        Me.lblTipoCompu.AutoSize = True
        Me.lblTipoCompu.Location = New System.Drawing.Point(167, 30)
        Me.lblTipoCompu.Name = "lblTipoCompu"
        Me.lblTipoCompu.Size = New System.Drawing.Size(47, 13)
        Me.lblTipoCompu.TabIndex = 2
        Me.lblTipoCompu.Text = "Tipo Pc:"
        '
        'txtNroCompu
        '
        Me.txtNroCompu.Location = New System.Drawing.Point(110, 23)
        Me.txtNroCompu.MaxLength = 8
        Me.txtNroCompu.Name = "txtNroCompu"
        Me.txtNroCompu.Size = New System.Drawing.Size(50, 20)
        Me.txtNroCompu.TabIndex = 1
        '
        'lblNroPc
        '
        Me.lblNroPc.AutoSize = True
        Me.lblNroPc.Location = New System.Drawing.Point(10, 30)
        Me.lblNroPc.Name = "lblNroPc"
        Me.lblNroPc.Size = New System.Drawing.Size(93, 13)
        Me.lblNroPc.TabIndex = 0
        Me.lblNroPc.Text = "Nro Computadora:"
        '
        'gestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 438)
        Me.Controls.Add(Me.gbDatosComputadora)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Controls.Add(Me.panelBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "gestionClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Clientes"
        Me.panelBotones.ResumeLayout(False)
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.gbDatosComputadora.ResumeLayout(False)
        Me.gbDatosComputadora.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelBotones As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents gbDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCliente As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtFechaBaja As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaBaja As System.Windows.Forms.Label
    Friend WithEvents txtFechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaAlta As System.Windows.Forms.Label
    Friend WithEvents gbDatosComputadora As System.Windows.Forms.GroupBox
    Friend WithEvents lblNroPc As System.Windows.Forms.Label
    Friend WithEvents cbMarcaProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarcaProc As System.Windows.Forms.Label
    Friend WithEvents cbTipoPc As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCompu As System.Windows.Forms.Label
    Friend WithEvents txtNroCompu As System.Windows.Forms.TextBox
    Friend WithEvents txtCantMemoria As System.Windows.Forms.TextBox
    Friend WithEvents lblCantMemoria As System.Windows.Forms.Label
    Friend WithEvents cbTipoMemoria As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoMemoria As System.Windows.Forms.Label
    Friend WithEvents cbModeloProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblModeloProc As System.Windows.Forms.Label
    Friend WithEvents lblGB As System.Windows.Forms.Label
    Friend WithEvents txtCapAlm As System.Windows.Forms.TextBox
    Friend WithEvents lblCapAlmac As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarCli As System.Windows.Forms.Button
    Friend WithEvents chkBajaCliente As System.Windows.Forms.CheckBox
End Class

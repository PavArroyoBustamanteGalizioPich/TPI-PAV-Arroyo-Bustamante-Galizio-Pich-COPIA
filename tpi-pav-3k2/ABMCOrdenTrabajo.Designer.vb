<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCOrdenTrabajo
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarRepuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarTipoDeRepuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarTipoDePcMemoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarEstadosDeOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarTiposDeDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProcesadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbDatosCliOT = New System.Windows.Forms.GroupBox()
        Me.btnNuevaPcOt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNuevoCliOT = New System.Windows.Forms.Button()
        Me.btnBuscarCliOT = New System.Windows.Forms.Button()
        Me.txtNroDocCliOT = New System.Windows.Forms.TextBox()
        Me.lblNroDocBuscCliOT = New System.Windows.Forms.Label()
        Me.cbTipoDocOT = New System.Windows.Forms.ComboBox()
        Me.lblTipoDocBuscCliOT = New System.Windows.Forms.Label()
        Me.gbDatosOT = New System.Windows.Forms.GroupBox()
        Me.panelDatosNvaOt = New System.Windows.Forms.Panel()
        Me.panelCierre = New System.Windows.Forms.Panel()
        Me.btnAniadirCobroOt = New System.Windows.Forms.Button()
        Me.txtNroCobroOt = New System.Windows.Forms.TextBox()
        Me.lblNroCobroOt = New System.Windows.Forms.Label()
        Me.btnCalcularMontoOt = New System.Windows.Forms.Button()
        Me.txtMontoOt = New System.Windows.Forms.TextBox()
        Me.lblMontoOt = New System.Windows.Forms.Label()
        Me.txtFechaReparacion = New System.Windows.Forms.MaskedTextBox()
        Me.lblFechaReparacionOt = New System.Windows.Forms.Label()
        Me.gbAniadirServicios = New System.Windows.Forms.GroupBox()
        Me.txtTipoRepRequerido = New System.Windows.Forms.TextBox()
        Me.lblRepuestoRequerido = New System.Windows.Forms.Label()
        Me.cbRepuestoOt = New System.Windows.Forms.ComboBox()
        Me.lblRepuestoOt = New System.Windows.Forms.Label()
        Me.btnAniadirServicioOt = New System.Windows.Forms.Button()
        Me.cbCantidadServicioOt = New System.Windows.Forms.ComboBox()
        Me.lvlCantidadServiciosOt = New System.Windows.Forms.Label()
        Me.cbServiciosOt = New System.Windows.Forms.ComboBox()
        Me.lblServicioOt = New System.Windows.Forms.Label()
        Me.gbListadoRepuestos = New System.Windows.Forms.GroupBox()
        Me.lvRepuestosOt = New System.Windows.Forms.ListView()
        Me.colRepuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidadRepuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubTotalRepuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbListadoServiciosOt = New System.Windows.Forms.GroupBox()
        Me.lvServiciosOt = New System.Windows.Forms.ListView()
        Me.colServicios = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubTot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelDatosOt = New System.Windows.Forms.Panel()
        Me.txtDescrFallaOt = New System.Windows.Forms.TextBox()
        Me.lblDescripcionFallaOt = New System.Windows.Forms.Label()
        Me.cbEstadoOt = New System.Windows.Forms.ComboBox()
        Me.lblEstadoOt = New System.Windows.Forms.Label()
        Me.txtFechaRecepcionOt = New System.Windows.Forms.MaskedTextBox()
        Me.lblFechaRecepción = New System.Windows.Forms.Label()
        Me.panelDatosPcOt = New System.Windows.Forms.Panel()
        Me.txtDescripcionPcOt = New System.Windows.Forms.TextBox()
        Me.lblDescripcionPcOt = New System.Windows.Forms.Label()
        Me.txtTipoPcOt = New System.Windows.Forms.TextBox()
        Me.lblTipoPcOT = New System.Windows.Forms.Label()
        Me.cbNroPcOt = New System.Windows.Forms.ComboBox()
        Me.lblNroPcOt = New System.Windows.Forms.Label()
        Me.panelDatosClienteOt = New System.Windows.Forms.Panel()
        Me.txtApellidoClienteOt = New System.Windows.Forms.TextBox()
        Me.lblApellidoClienteOt = New System.Windows.Forms.Label()
        Me.txtNombreCLienteOt = New System.Windows.Forms.TextBox()
        Me.lblNombreClienteOt = New System.Windows.Forms.Label()
        Me.txtNroClienteOt = New System.Windows.Forms.TextBox()
        Me.lblNroClienteOt = New System.Windows.Forms.Label()
        Me.panelBuscarOT = New System.Windows.Forms.Panel()
        Me.btnBuscarOT = New System.Windows.Forms.Button()
        Me.txtNroOT = New System.Windows.Forms.TextBox()
        Me.lblNroOt = New System.Windows.Forms.Label()
        Me.btnNvaOt = New System.Windows.Forms.Button()
        Me.btnActualizarOt = New System.Windows.Forms.Button()
        Me.btnGuardarOt = New System.Windows.Forms.Button()
        Me.btnCancelarOt = New System.Windows.Forms.Button()
        Me.panelBotoneraOt = New System.Windows.Forms.Panel()
        Me.GestionarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.gbDatosCliOT.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosOT.SuspendLayout()
        Me.panelDatosNvaOt.SuspendLayout()
        Me.panelCierre.SuspendLayout()
        Me.gbAniadirServicios.SuspendLayout()
        Me.gbListadoRepuestos.SuspendLayout()
        Me.gbListadoServiciosOt.SuspendLayout()
        Me.panelDatosOt.SuspendLayout()
        Me.panelDatosPcOt.SuspendLayout()
        Me.panelDatosClienteOt.SuspendLayout()
        Me.panelBuscarOT.SuspendLayout()
        Me.panelBotoneraOt.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.AdministrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarProveedoresToolStripMenuItem, Me.GestionarRepuestosToolStripMenuItem, Me.GestionarTipoDeRepuestosToolStripMenuItem, Me.GestionarServiciosToolStripMenuItem, Me.GestionarTipoDePcMemoriaToolStripMenuItem, Me.GestionarEstadosDeOTToolStripMenuItem, Me.GestionarTiposDeDocumentoToolStripMenuItem, Me.GestionarProcesadoresToolStripMenuItem, Me.GestionarClientesToolStripMenuItem})
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'GestionarProveedoresToolStripMenuItem
        '
        Me.GestionarProveedoresToolStripMenuItem.Name = "GestionarProveedoresToolStripMenuItem"
        Me.GestionarProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.GestionarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarProveedoresToolStripMenuItem.Text = "Gestionar Proveedores"
        '
        'GestionarRepuestosToolStripMenuItem
        '
        Me.GestionarRepuestosToolStripMenuItem.Name = "GestionarRepuestosToolStripMenuItem"
        Me.GestionarRepuestosToolStripMenuItem.ShortcutKeyDisplayString = "Alt + R"
        Me.GestionarRepuestosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.GestionarRepuestosToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarRepuestosToolStripMenuItem.Text = "Gestionar Repuestos"
        '
        'GestionarTipoDeRepuestosToolStripMenuItem
        '
        Me.GestionarTipoDeRepuestosToolStripMenuItem.Name = "GestionarTipoDeRepuestosToolStripMenuItem"
        Me.GestionarTipoDeRepuestosToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarTipoDeRepuestosToolStripMenuItem.Text = "Gestionar Tipo de Repuestos"
        '
        'GestionarServiciosToolStripMenuItem
        '
        Me.GestionarServiciosToolStripMenuItem.Name = "GestionarServiciosToolStripMenuItem"
        Me.GestionarServiciosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GestionarServiciosToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarServiciosToolStripMenuItem.Text = "Gestionar Servicios"
        '
        'GestionarTipoDePcMemoriaToolStripMenuItem
        '
        Me.GestionarTipoDePcMemoriaToolStripMenuItem.Name = "GestionarTipoDePcMemoriaToolStripMenuItem"
        Me.GestionarTipoDePcMemoriaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarTipoDePcMemoriaToolStripMenuItem.Text = "Gestionar Tipo de Pc/Memoria"
        '
        'GestionarEstadosDeOTToolStripMenuItem
        '
        Me.GestionarEstadosDeOTToolStripMenuItem.Name = "GestionarEstadosDeOTToolStripMenuItem"
        Me.GestionarEstadosDeOTToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarEstadosDeOTToolStripMenuItem.Text = "Gestionar Estados de OT"
        '
        'GestionarTiposDeDocumentoToolStripMenuItem
        '
        Me.GestionarTiposDeDocumentoToolStripMenuItem.Name = "GestionarTiposDeDocumentoToolStripMenuItem"
        Me.GestionarTiposDeDocumentoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarTiposDeDocumentoToolStripMenuItem.Text = "Gestionar Tipos de Documento"
        '
        'GestionarProcesadoresToolStripMenuItem
        '
        Me.GestionarProcesadoresToolStripMenuItem.Name = "GestionarProcesadoresToolStripMenuItem"
        Me.GestionarProcesadoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.GestionarProcesadoresToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarProcesadoresToolStripMenuItem.Text = "Gestionar Procesadores"
        '
        'gbDatosCliOT
        '
        Me.gbDatosCliOT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatosCliOT.Controls.Add(Me.btnNuevaPcOt)
        Me.gbDatosCliOT.Controls.Add(Me.DataGridView1)
        Me.gbDatosCliOT.Controls.Add(Me.btnNuevoCliOT)
        Me.gbDatosCliOT.Controls.Add(Me.btnBuscarCliOT)
        Me.gbDatosCliOT.Controls.Add(Me.txtNroDocCliOT)
        Me.gbDatosCliOT.Controls.Add(Me.lblNroDocBuscCliOT)
        Me.gbDatosCliOT.Controls.Add(Me.cbTipoDocOT)
        Me.gbDatosCliOT.Controls.Add(Me.lblTipoDocBuscCliOT)
        Me.gbDatosCliOT.Location = New System.Drawing.Point(0, 27)
        Me.gbDatosCliOT.Name = "gbDatosCliOT"
        Me.gbDatosCliOT.Size = New System.Drawing.Size(1084, 122)
        Me.gbDatosCliOT.TabIndex = 1
        Me.gbDatosCliOT.TabStop = False
        Me.gbDatosCliOT.Text = "Datos Cliente"
        '
        'btnNuevaPcOt
        '
        Me.btnNuevaPcOt.Location = New System.Drawing.Point(577, 10)
        Me.btnNuevaPcOt.Name = "btnNuevaPcOt"
        Me.btnNuevaPcOt.Size = New System.Drawing.Size(117, 23)
        Me.btnNuevaPcOt.TabIndex = 7
        Me.btnNuevaPcOt.Text = "Nueva computadora"
        Me.btnNuevaPcOt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 78)
        Me.DataGridView1.TabIndex = 6
        '
        'btnNuevoCliOT
        '
        Me.btnNuevoCliOT.Location = New System.Drawing.Point(489, 10)
        Me.btnNuevoCliOT.Name = "btnNuevoCliOT"
        Me.btnNuevoCliOT.Size = New System.Drawing.Size(82, 23)
        Me.btnNuevoCliOT.TabIndex = 5
        Me.btnNuevoCliOT.Text = "Nuevo Cliente"
        Me.btnNuevoCliOT.UseVisualStyleBackColor = True
        '
        'btnBuscarCliOT
        '
        Me.btnBuscarCliOT.Location = New System.Drawing.Point(386, 10)
        Me.btnBuscarCliOT.Name = "btnBuscarCliOT"
        Me.btnBuscarCliOT.Size = New System.Drawing.Size(95, 23)
        Me.btnBuscarCliOT.TabIndex = 4
        Me.btnBuscarCliOT.Text = "Buscar Cliente"
        Me.btnBuscarCliOT.UseVisualStyleBackColor = True
        '
        'txtNroDocCliOT
        '
        Me.txtNroDocCliOT.Location = New System.Drawing.Point(280, 13)
        Me.txtNroDocCliOT.MaxLength = 11
        Me.txtNroDocCliOT.Name = "txtNroDocCliOT"
        Me.txtNroDocCliOT.Size = New System.Drawing.Size(100, 20)
        Me.txtNroDocCliOT.TabIndex = 3
        '
        'lblNroDocBuscCliOT
        '
        Me.lblNroDocBuscCliOT.AutoSize = True
        Me.lblNroDocBuscCliOT.Location = New System.Drawing.Point(189, 16)
        Me.lblNroDocBuscCliOT.Name = "lblNroDocBuscCliOT"
        Me.lblNroDocBuscCliOT.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDocBuscCliOT.TabIndex = 2
        Me.lblNroDocBuscCliOT.Text = "Nro Documento:"
        '
        'cbTipoDocOT
        '
        Me.cbTipoDocOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocOT.FormattingEnabled = True
        Me.cbTipoDocOT.Location = New System.Drawing.Point(98, 13)
        Me.cbTipoDocOT.Name = "cbTipoDocOT"
        Me.cbTipoDocOT.Size = New System.Drawing.Size(87, 21)
        Me.cbTipoDocOT.TabIndex = 1
        '
        'lblTipoDocBuscCliOT
        '
        Me.lblTipoDocBuscCliOT.AutoSize = True
        Me.lblTipoDocBuscCliOT.Location = New System.Drawing.Point(6, 16)
        Me.lblTipoDocBuscCliOT.Name = "lblTipoDocBuscCliOT"
        Me.lblTipoDocBuscCliOT.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDocBuscCliOT.TabIndex = 0
        Me.lblTipoDocBuscCliOT.Text = "Tipo Documento:"
        '
        'gbDatosOT
        '
        Me.gbDatosOT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatosOT.AutoSize = True
        Me.gbDatosOT.BackColor = System.Drawing.SystemColors.Control
        Me.gbDatosOT.Controls.Add(Me.panelDatosNvaOt)
        Me.gbDatosOT.Controls.Add(Me.panelBuscarOT)
        Me.gbDatosOT.Location = New System.Drawing.Point(9, 156)
        Me.gbDatosOT.Name = "gbDatosOT"
        Me.gbDatosOT.Size = New System.Drawing.Size(1075, 398)
        Me.gbDatosOT.TabIndex = 2
        Me.gbDatosOT.TabStop = False
        Me.gbDatosOT.Text = "Orden de Trabajo"
        '
        'panelDatosNvaOt
        '
        Me.panelDatosNvaOt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatosNvaOt.Controls.Add(Me.panelCierre)
        Me.panelDatosNvaOt.Controls.Add(Me.gbAniadirServicios)
        Me.panelDatosNvaOt.Controls.Add(Me.gbListadoRepuestos)
        Me.panelDatosNvaOt.Controls.Add(Me.gbListadoServiciosOt)
        Me.panelDatosNvaOt.Controls.Add(Me.panelDatosOt)
        Me.panelDatosNvaOt.Controls.Add(Me.panelDatosPcOt)
        Me.panelDatosNvaOt.Controls.Add(Me.panelDatosClienteOt)
        Me.panelDatosNvaOt.Location = New System.Drawing.Point(7, 62)
        Me.panelDatosNvaOt.Name = "panelDatosNvaOt"
        Me.panelDatosNvaOt.Size = New System.Drawing.Size(1056, 317)
        Me.panelDatosNvaOt.TabIndex = 1
        '
        'panelCierre
        '
        Me.panelCierre.Controls.Add(Me.btnAniadirCobroOt)
        Me.panelCierre.Controls.Add(Me.txtNroCobroOt)
        Me.panelCierre.Controls.Add(Me.lblNroCobroOt)
        Me.panelCierre.Controls.Add(Me.btnCalcularMontoOt)
        Me.panelCierre.Controls.Add(Me.txtMontoOt)
        Me.panelCierre.Controls.Add(Me.lblMontoOt)
        Me.panelCierre.Controls.Add(Me.txtFechaReparacion)
        Me.panelCierre.Controls.Add(Me.lblFechaReparacionOt)
        Me.panelCierre.Location = New System.Drawing.Point(3, 253)
        Me.panelCierre.Name = "panelCierre"
        Me.panelCierre.Size = New System.Drawing.Size(678, 36)
        Me.panelCierre.TabIndex = 17
        '
        'btnAniadirCobroOt
        '
        Me.btnAniadirCobroOt.Location = New System.Drawing.Point(523, 1)
        Me.btnAniadirCobroOt.Name = "btnAniadirCobroOt"
        Me.btnAniadirCobroOt.Size = New System.Drawing.Size(91, 23)
        Me.btnAniadirCobroOt.TabIndex = 7
        Me.btnAniadirCobroOt.Text = "Añadir Cobro"
        Me.btnAniadirCobroOt.UseVisualStyleBackColor = True
        '
        'txtNroCobroOt
        '
        Me.txtNroCobroOt.Location = New System.Drawing.Point(474, 3)
        Me.txtNroCobroOt.MaxLength = 8
        Me.txtNroCobroOt.Name = "txtNroCobroOt"
        Me.txtNroCobroOt.Size = New System.Drawing.Size(43, 20)
        Me.txtNroCobroOt.TabIndex = 6
        '
        'lblNroCobroOt
        '
        Me.lblNroCobroOt.AutoSize = True
        Me.lblNroCobroOt.Location = New System.Drawing.Point(394, 9)
        Me.lblNroCobroOt.Name = "lblNroCobroOt"
        Me.lblNroCobroOt.Size = New System.Drawing.Size(73, 13)
        Me.lblNroCobroOt.TabIndex = 5
        Me.lblNroCobroOt.Text = "Nro de Cobro:"
        '
        'btnCalcularMontoOt
        '
        Me.btnCalcularMontoOt.Location = New System.Drawing.Point(313, 1)
        Me.btnCalcularMontoOt.Name = "btnCalcularMontoOt"
        Me.btnCalcularMontoOt.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularMontoOt.TabIndex = 4
        Me.btnCalcularMontoOt.Text = "Calcular"
        Me.btnCalcularMontoOt.UseVisualStyleBackColor = True
        '
        'txtMontoOt
        '
        Me.txtMontoOt.Location = New System.Drawing.Point(235, 3)
        Me.txtMontoOt.MaxLength = 10
        Me.txtMontoOt.Name = "txtMontoOt"
        Me.txtMontoOt.Size = New System.Drawing.Size(70, 20)
        Me.txtMontoOt.TabIndex = 3
        '
        'lblMontoOt
        '
        Me.lblMontoOt.AutoSize = True
        Me.lblMontoOt.Location = New System.Drawing.Point(192, 6)
        Me.lblMontoOt.Name = "lblMontoOt"
        Me.lblMontoOt.Size = New System.Drawing.Size(40, 13)
        Me.lblMontoOt.TabIndex = 2
        Me.lblMontoOt.Text = "Monto:"
        '
        'txtFechaReparacion
        '
        Me.txtFechaReparacion.Location = New System.Drawing.Point(121, 3)
        Me.txtFechaReparacion.Mask = "00/00/0000"
        Me.txtFechaReparacion.Name = "txtFechaReparacion"
        Me.txtFechaReparacion.Size = New System.Drawing.Size(64, 20)
        Me.txtFechaReparacion.TabIndex = 1
        Me.txtFechaReparacion.ValidatingType = GetType(Date)
        '
        'lblFechaReparacionOt
        '
        Me.lblFechaReparacionOt.AutoSize = True
        Me.lblFechaReparacionOt.Location = New System.Drawing.Point(4, 4)
        Me.lblFechaReparacionOt.Name = "lblFechaReparacionOt"
        Me.lblFechaReparacionOt.Size = New System.Drawing.Size(113, 13)
        Me.lblFechaReparacionOt.TabIndex = 0
        Me.lblFechaReparacionOt.Text = "Fecha de Reparación:"
        '
        'gbAniadirServicios
        '
        Me.gbAniadirServicios.Controls.Add(Me.txtTipoRepRequerido)
        Me.gbAniadirServicios.Controls.Add(Me.lblRepuestoRequerido)
        Me.gbAniadirServicios.Controls.Add(Me.cbRepuestoOt)
        Me.gbAniadirServicios.Controls.Add(Me.lblRepuestoOt)
        Me.gbAniadirServicios.Controls.Add(Me.btnAniadirServicioOt)
        Me.gbAniadirServicios.Controls.Add(Me.cbCantidadServicioOt)
        Me.gbAniadirServicios.Controls.Add(Me.lvlCantidadServiciosOt)
        Me.gbAniadirServicios.Controls.Add(Me.cbServiciosOt)
        Me.gbAniadirServicios.Controls.Add(Me.lblServicioOt)
        Me.gbAniadirServicios.Location = New System.Drawing.Point(3, 143)
        Me.gbAniadirServicios.Name = "gbAniadirServicios"
        Me.gbAniadirServicios.Size = New System.Drawing.Size(681, 104)
        Me.gbAniadirServicios.TabIndex = 15
        Me.gbAniadirServicios.TabStop = False
        Me.gbAniadirServicios.Text = "Añadir Servicios"
        '
        'txtTipoRepRequerido
        '
        Me.txtTipoRepRequerido.Location = New System.Drawing.Point(130, 48)
        Me.txtTipoRepRequerido.MaxLength = 20
        Me.txtTipoRepRequerido.Name = "txtTipoRepRequerido"
        Me.txtTipoRepRequerido.Size = New System.Drawing.Size(89, 20)
        Me.txtTipoRepRequerido.TabIndex = 8
        '
        'lblRepuestoRequerido
        '
        Me.lblRepuestoRequerido.AutoSize = True
        Me.lblRepuestoRequerido.Location = New System.Drawing.Point(7, 55)
        Me.lblRepuestoRequerido.Name = "lblRepuestoRequerido"
        Me.lblRepuestoRequerido.Size = New System.Drawing.Size(117, 13)
        Me.lblRepuestoRequerido.TabIndex = 7
        Me.lblRepuestoRequerido.Text = "Componente requerido:"
        '
        'cbRepuestoOt
        '
        Me.cbRepuestoOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRepuestoOt.FormattingEnabled = True
        Me.cbRepuestoOt.Location = New System.Drawing.Point(303, 48)
        Me.cbRepuestoOt.Name = "cbRepuestoOt"
        Me.cbRepuestoOt.Size = New System.Drawing.Size(266, 21)
        Me.cbRepuestoOt.TabIndex = 6
        '
        'lblRepuestoOt
        '
        Me.lblRepuestoOt.AutoSize = True
        Me.lblRepuestoOt.Location = New System.Drawing.Point(227, 55)
        Me.lblRepuestoOt.Name = "lblRepuestoOt"
        Me.lblRepuestoOt.Size = New System.Drawing.Size(70, 13)
        Me.lblRepuestoOt.TabIndex = 5
        Me.lblRepuestoOt.Text = "Componente:"
        '
        'btnAniadirServicioOt
        '
        Me.btnAniadirServicioOt.Location = New System.Drawing.Point(575, 46)
        Me.btnAniadirServicioOt.Name = "btnAniadirServicioOt"
        Me.btnAniadirServicioOt.Size = New System.Drawing.Size(75, 23)
        Me.btnAniadirServicioOt.TabIndex = 4
        Me.btnAniadirServicioOt.Text = "Añadir"
        Me.btnAniadirServicioOt.UseVisualStyleBackColor = True
        '
        'cbCantidadServicioOt
        '
        Me.cbCantidadServicioOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCantidadServicioOt.FormattingEnabled = True
        Me.cbCantidadServicioOt.Location = New System.Drawing.Point(426, 13)
        Me.cbCantidadServicioOt.Name = "cbCantidadServicioOt"
        Me.cbCantidadServicioOt.Size = New System.Drawing.Size(44, 21)
        Me.cbCantidadServicioOt.TabIndex = 3
        '
        'lvlCantidadServiciosOt
        '
        Me.lvlCantidadServiciosOt.AutoSize = True
        Me.lvlCantidadServiciosOt.Location = New System.Drawing.Point(370, 21)
        Me.lvlCantidadServiciosOt.Name = "lvlCantidadServiciosOt"
        Me.lvlCantidadServiciosOt.Size = New System.Drawing.Size(52, 13)
        Me.lvlCantidadServiciosOt.TabIndex = 2
        Me.lvlCantidadServiciosOt.Text = "Cantidad:"
        '
        'cbServiciosOt
        '
        Me.cbServiciosOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiciosOt.FormattingEnabled = True
        Me.cbServiciosOt.Location = New System.Drawing.Point(61, 13)
        Me.cbServiciosOt.Name = "cbServiciosOt"
        Me.cbServiciosOt.Size = New System.Drawing.Size(303, 21)
        Me.cbServiciosOt.TabIndex = 1
        '
        'lblServicioOt
        '
        Me.lblServicioOt.AutoSize = True
        Me.lblServicioOt.Location = New System.Drawing.Point(7, 21)
        Me.lblServicioOt.Name = "lblServicioOt"
        Me.lblServicioOt.Size = New System.Drawing.Size(48, 13)
        Me.lblServicioOt.TabIndex = 0
        Me.lblServicioOt.Text = "Servicio:"
        '
        'gbListadoRepuestos
        '
        Me.gbListadoRepuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListadoRepuestos.Controls.Add(Me.lvRepuestosOt)
        Me.gbListadoRepuestos.Location = New System.Drawing.Point(712, 198)
        Me.gbListadoRepuestos.Name = "gbListadoRepuestos"
        Me.gbListadoRepuestos.Size = New System.Drawing.Size(338, 116)
        Me.gbListadoRepuestos.TabIndex = 14
        Me.gbListadoRepuestos.TabStop = False
        Me.gbListadoRepuestos.Text = "Listado de Repuestos"
        '
        'lvRepuestosOt
        '
        Me.lvRepuestosOt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvRepuestosOt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRepuesto, Me.colCantidadRepuesto, Me.colSubTotalRepuesto})
        Me.lvRepuestosOt.Location = New System.Drawing.Point(7, 20)
        Me.lvRepuestosOt.Name = "lvRepuestosOt"
        Me.lvRepuestosOt.Size = New System.Drawing.Size(325, 90)
        Me.lvRepuestosOt.TabIndex = 0
        Me.lvRepuestosOt.UseCompatibleStateImageBehavior = False
        Me.lvRepuestosOt.View = System.Windows.Forms.View.Details
        '
        'colRepuesto
        '
        Me.colRepuesto.Text = "Repuesto"
        Me.colRepuesto.Width = 200
        '
        'colCantidadRepuesto
        '
        Me.colCantidadRepuesto.Text = "Cantidad"
        '
        'colSubTotalRepuesto
        '
        Me.colSubTotalRepuesto.Text = "SubTotal"
        '
        'gbListadoServiciosOt
        '
        Me.gbListadoServiciosOt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListadoServiciosOt.Controls.Add(Me.lvServiciosOt)
        Me.gbListadoServiciosOt.Location = New System.Drawing.Point(712, 50)
        Me.gbListadoServiciosOt.Name = "gbListadoServiciosOt"
        Me.gbListadoServiciosOt.Size = New System.Drawing.Size(338, 142)
        Me.gbListadoServiciosOt.TabIndex = 13
        Me.gbListadoServiciosOt.TabStop = False
        Me.gbListadoServiciosOt.Text = "Listado de Servicios"
        '
        'lvServiciosOt
        '
        Me.lvServiciosOt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvServiciosOt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colServicios, Me.colCantidad, Me.colSubTot})
        Me.lvServiciosOt.Location = New System.Drawing.Point(7, 20)
        Me.lvServiciosOt.Name = "lvServiciosOt"
        Me.lvServiciosOt.Size = New System.Drawing.Size(331, 116)
        Me.lvServiciosOt.TabIndex = 0
        Me.lvServiciosOt.UseCompatibleStateImageBehavior = False
        Me.lvServiciosOt.View = System.Windows.Forms.View.Details
        '
        'colServicios
        '
        Me.colServicios.Text = "Servicios"
        Me.colServicios.Width = 200
        '
        'colCantidad
        '
        Me.colCantidad.Text = "Cantidad"
        Me.colCantidad.Width = 64
        '
        'colSubTot
        '
        Me.colSubTot.Text = "SubTotal"
        '
        'panelDatosOt
        '
        Me.panelDatosOt.Controls.Add(Me.txtDescrFallaOt)
        Me.panelDatosOt.Controls.Add(Me.lblDescripcionFallaOt)
        Me.panelDatosOt.Controls.Add(Me.cbEstadoOt)
        Me.panelDatosOt.Controls.Add(Me.lblEstadoOt)
        Me.panelDatosOt.Controls.Add(Me.txtFechaRecepcionOt)
        Me.panelDatosOt.Controls.Add(Me.lblFechaRecepción)
        Me.panelDatosOt.Location = New System.Drawing.Point(3, 50)
        Me.panelDatosOt.Name = "panelDatosOt"
        Me.panelDatosOt.Size = New System.Drawing.Size(681, 86)
        Me.panelDatosOt.TabIndex = 12
        '
        'txtDescrFallaOt
        '
        Me.txtDescrFallaOt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrFallaOt.Location = New System.Drawing.Point(477, 10)
        Me.txtDescrFallaOt.Multiline = True
        Me.txtDescrFallaOt.Name = "txtDescrFallaOt"
        Me.txtDescrFallaOt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrFallaOt.Size = New System.Drawing.Size(201, 73)
        Me.txtDescrFallaOt.TabIndex = 5
        '
        'lblDescripcionFallaOt
        '
        Me.lblDescripcionFallaOt.AutoSize = True
        Me.lblDescripcionFallaOt.Location = New System.Drawing.Point(370, 18)
        Me.lblDescripcionFallaOt.Name = "lblDescripcionFallaOt"
        Me.lblDescripcionFallaOt.Size = New System.Drawing.Size(100, 13)
        Me.lblDescripcionFallaOt.TabIndex = 4
        Me.lblDescripcionFallaOt.Text = "Descipción de falla:"
        '
        'cbEstadoOt
        '
        Me.cbEstadoOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoOt.FormattingEnabled = True
        Me.cbEstadoOt.Location = New System.Drawing.Point(256, 10)
        Me.cbEstadoOt.Name = "cbEstadoOt"
        Me.cbEstadoOt.Size = New System.Drawing.Size(108, 21)
        Me.cbEstadoOt.TabIndex = 3
        '
        'lblEstadoOt
        '
        Me.lblEstadoOt.AutoSize = True
        Me.lblEstadoOt.Location = New System.Drawing.Point(192, 18)
        Me.lblEstadoOt.Name = "lblEstadoOt"
        Me.lblEstadoOt.Size = New System.Drawing.Size(61, 13)
        Me.lblEstadoOt.TabIndex = 2
        Me.lblEstadoOt.Text = "Estado OT:"
        '
        'txtFechaRecepcionOt
        '
        Me.txtFechaRecepcionOt.Location = New System.Drawing.Point(120, 11)
        Me.txtFechaRecepcionOt.Mask = "00/00/0000"
        Me.txtFechaRecepcionOt.Name = "txtFechaRecepcionOt"
        Me.txtFechaRecepcionOt.Size = New System.Drawing.Size(64, 20)
        Me.txtFechaRecepcionOt.TabIndex = 1
        Me.txtFechaRecepcionOt.ValidatingType = GetType(Date)
        '
        'lblFechaRecepción
        '
        Me.lblFechaRecepción.AutoSize = True
        Me.lblFechaRecepción.Location = New System.Drawing.Point(7, 18)
        Me.lblFechaRecepción.Name = "lblFechaRecepción"
        Me.lblFechaRecepción.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaRecepción.TabIndex = 0
        Me.lblFechaRecepción.Text = "Fecha de Recepción:"
        '
        'panelDatosPcOt
        '
        Me.panelDatosPcOt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatosPcOt.Controls.Add(Me.txtDescripcionPcOt)
        Me.panelDatosPcOt.Controls.Add(Me.lblDescripcionPcOt)
        Me.panelDatosPcOt.Controls.Add(Me.txtTipoPcOt)
        Me.panelDatosPcOt.Controls.Add(Me.lblTipoPcOT)
        Me.panelDatosPcOt.Controls.Add(Me.cbNroPcOt)
        Me.panelDatosPcOt.Controls.Add(Me.lblNroPcOt)
        Me.panelDatosPcOt.Location = New System.Drawing.Point(459, 3)
        Me.panelDatosPcOt.Name = "panelDatosPcOt"
        Me.panelDatosPcOt.Size = New System.Drawing.Size(594, 40)
        Me.panelDatosPcOt.TabIndex = 11
        '
        'txtDescripcionPcOt
        '
        Me.txtDescripcionPcOt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionPcOt.Location = New System.Drawing.Point(361, 4)
        Me.txtDescripcionPcOt.Name = "txtDescripcionPcOt"
        Me.txtDescripcionPcOt.Size = New System.Drawing.Size(230, 20)
        Me.txtDescripcionPcOt.TabIndex = 5
        '
        'lblDescripcionPcOt
        '
        Me.lblDescripcionPcOt.AutoSize = True
        Me.lblDescripcionPcOt.Location = New System.Drawing.Point(291, 8)
        Me.lblDescripcionPcOt.Name = "lblDescripcionPcOt"
        Me.lblDescripcionPcOt.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcionPcOt.TabIndex = 4
        Me.lblDescripcionPcOt.Text = "Descripción:"
        '
        'txtTipoPcOt
        '
        Me.txtTipoPcOt.Location = New System.Drawing.Point(201, 4)
        Me.txtTipoPcOt.MaxLength = 15
        Me.txtTipoPcOt.Name = "txtTipoPcOt"
        Me.txtTipoPcOt.Size = New System.Drawing.Size(83, 20)
        Me.txtTipoPcOt.TabIndex = 3
        '
        'lblTipoPcOT
        '
        Me.lblTipoPcOT.AutoSize = True
        Me.lblTipoPcOT.Location = New System.Drawing.Point(152, 8)
        Me.lblTipoPcOT.Name = "lblTipoPcOT"
        Me.lblTipoPcOT.Size = New System.Drawing.Size(47, 13)
        Me.lblTipoPcOT.TabIndex = 2
        Me.lblTipoPcOT.Text = "Tipo Pc:"
        '
        'cbNroPcOt
        '
        Me.cbNroPcOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNroPcOt.FormattingEnabled = True
        Me.cbNroPcOt.Location = New System.Drawing.Point(99, 3)
        Me.cbNroPcOt.Name = "cbNroPcOt"
        Me.cbNroPcOt.Size = New System.Drawing.Size(47, 21)
        Me.cbNroPcOt.TabIndex = 1
        '
        'lblNroPcOt
        '
        Me.lblNroPcOt.AutoSize = True
        Me.lblNroPcOt.Location = New System.Drawing.Point(3, 8)
        Me.lblNroPcOt.Name = "lblNroPcOt"
        Me.lblNroPcOt.Size = New System.Drawing.Size(93, 13)
        Me.lblNroPcOt.TabIndex = 0
        Me.lblNroPcOt.Text = "Nro Computadora:"
        '
        'panelDatosClienteOt
        '
        Me.panelDatosClienteOt.Controls.Add(Me.txtApellidoClienteOt)
        Me.panelDatosClienteOt.Controls.Add(Me.lblApellidoClienteOt)
        Me.panelDatosClienteOt.Controls.Add(Me.txtNombreCLienteOt)
        Me.panelDatosClienteOt.Controls.Add(Me.lblNombreClienteOt)
        Me.panelDatosClienteOt.Controls.Add(Me.txtNroClienteOt)
        Me.panelDatosClienteOt.Controls.Add(Me.lblNroClienteOt)
        Me.panelDatosClienteOt.Location = New System.Drawing.Point(3, 3)
        Me.panelDatosClienteOt.Name = "panelDatosClienteOt"
        Me.panelDatosClienteOt.Size = New System.Drawing.Size(450, 40)
        Me.panelDatosClienteOt.TabIndex = 10
        '
        'txtApellidoClienteOt
        '
        Me.txtApellidoClienteOt.Location = New System.Drawing.Point(340, 4)
        Me.txtApellidoClienteOt.MaxLength = 20
        Me.txtApellidoClienteOt.Name = "txtApellidoClienteOt"
        Me.txtApellidoClienteOt.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoClienteOt.TabIndex = 5
        '
        'lblApellidoClienteOt
        '
        Me.lblApellidoClienteOt.AutoSize = True
        Me.lblApellidoClienteOt.Location = New System.Drawing.Point(288, 8)
        Me.lblApellidoClienteOt.Name = "lblApellidoClienteOt"
        Me.lblApellidoClienteOt.Size = New System.Drawing.Size(47, 13)
        Me.lblApellidoClienteOt.TabIndex = 4
        Me.lblApellidoClienteOt.Text = "Apellido:"
        '
        'txtNombreCLienteOt
        '
        Me.txtNombreCLienteOt.Location = New System.Drawing.Point(182, 4)
        Me.txtNombreCLienteOt.MaxLength = 20
        Me.txtNombreCLienteOt.Name = "txtNombreCLienteOt"
        Me.txtNombreCLienteOt.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCLienteOt.TabIndex = 3
        '
        'lblNombreClienteOt
        '
        Me.lblNombreClienteOt.AutoSize = True
        Me.lblNombreClienteOt.Location = New System.Drawing.Point(131, 8)
        Me.lblNombreClienteOt.Name = "lblNombreClienteOt"
        Me.lblNombreClienteOt.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreClienteOt.TabIndex = 2
        Me.lblNombreClienteOt.Text = "Nombre:"
        '
        'txtNroClienteOt
        '
        Me.txtNroClienteOt.Location = New System.Drawing.Point(70, 4)
        Me.txtNroClienteOt.MaxLength = 8
        Me.txtNroClienteOt.Name = "txtNroClienteOt"
        Me.txtNroClienteOt.Size = New System.Drawing.Size(54, 20)
        Me.txtNroClienteOt.TabIndex = 1
        '
        'lblNroClienteOt
        '
        Me.lblNroClienteOt.AutoSize = True
        Me.lblNroClienteOt.Location = New System.Drawing.Point(4, 8)
        Me.lblNroClienteOt.Name = "lblNroClienteOt"
        Me.lblNroClienteOt.Size = New System.Drawing.Size(62, 13)
        Me.lblNroClienteOt.TabIndex = 0
        Me.lblNroClienteOt.Text = "Nro Cliente:"
        '
        'panelBuscarOT
        '
        Me.panelBuscarOT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBuscarOT.Controls.Add(Me.btnBuscarOT)
        Me.panelBuscarOT.Controls.Add(Me.txtNroOT)
        Me.panelBuscarOT.Controls.Add(Me.lblNroOt)
        Me.panelBuscarOT.Location = New System.Drawing.Point(7, 20)
        Me.panelBuscarOT.Name = "panelBuscarOT"
        Me.panelBuscarOT.Size = New System.Drawing.Size(281, 35)
        Me.panelBuscarOT.TabIndex = 0
        '
        'btnBuscarOT
        '
        Me.btnBuscarOT.Location = New System.Drawing.Point(191, 2)
        Me.btnBuscarOT.Name = "btnBuscarOT"
        Me.btnBuscarOT.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarOT.TabIndex = 2
        Me.btnBuscarOT.Text = "Buscar"
        Me.btnBuscarOT.UseVisualStyleBackColor = True
        '
        'txtNroOT
        '
        Me.txtNroOT.Location = New System.Drawing.Point(121, 4)
        Me.txtNroOT.MaxLength = 6
        Me.txtNroOT.Name = "txtNroOT"
        Me.txtNroOT.Size = New System.Drawing.Size(64, 20)
        Me.txtNroOT.TabIndex = 1
        '
        'lblNroOt
        '
        Me.lblNroOt.AutoSize = True
        Me.lblNroOt.Location = New System.Drawing.Point(4, 8)
        Me.lblNroOt.Name = "lblNroOt"
        Me.lblNroOt.Size = New System.Drawing.Size(110, 13)
        Me.lblNroOt.TabIndex = 0
        Me.lblNroOt.Text = "Nro Orden de Trabajo"
        '
        'btnNvaOt
        '
        Me.btnNvaOt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNvaOt.Location = New System.Drawing.Point(3, 3)
        Me.btnNvaOt.Name = "btnNvaOt"
        Me.btnNvaOt.Size = New System.Drawing.Size(75, 23)
        Me.btnNvaOt.TabIndex = 1
        Me.btnNvaOt.Text = "Nueva Orden de Trabajo"
        Me.btnNvaOt.UseVisualStyleBackColor = True
        '
        'btnActualizarOt
        '
        Me.btnActualizarOt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActualizarOt.Location = New System.Drawing.Point(84, 3)
        Me.btnActualizarOt.Name = "btnActualizarOt"
        Me.btnActualizarOt.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarOt.TabIndex = 3
        Me.btnActualizarOt.Text = "Actualizar"
        Me.btnActualizarOt.UseVisualStyleBackColor = True
        '
        'btnGuardarOt
        '
        Me.btnGuardarOt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarOt.Location = New System.Drawing.Point(165, 3)
        Me.btnGuardarOt.Name = "btnGuardarOt"
        Me.btnGuardarOt.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarOt.TabIndex = 4
        Me.btnGuardarOt.Text = "Guardar"
        Me.btnGuardarOt.UseVisualStyleBackColor = True
        '
        'btnCancelarOt
        '
        Me.btnCancelarOt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelarOt.Location = New System.Drawing.Point(246, 3)
        Me.btnCancelarOt.Name = "btnCancelarOt"
        Me.btnCancelarOt.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarOt.TabIndex = 5
        Me.btnCancelarOt.Text = "Cancelar"
        Me.btnCancelarOt.UseVisualStyleBackColor = True
        '
        'panelBotoneraOt
        '
        Me.panelBotoneraOt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotoneraOt.Controls.Add(Me.btnCancelarOt)
        Me.panelBotoneraOt.Controls.Add(Me.btnActualizarOt)
        Me.panelBotoneraOt.Controls.Add(Me.btnGuardarOt)
        Me.panelBotoneraOt.Controls.Add(Me.btnNvaOt)
        Me.panelBotoneraOt.Location = New System.Drawing.Point(9, 541)
        Me.panelBotoneraOt.Name = "panelBotoneraOt"
        Me.panelBotoneraOt.Size = New System.Drawing.Size(1063, 26)
        Me.panelBotoneraOt.TabIndex = 3
        '
        'GestionarClientesToolStripMenuItem
        '
        Me.GestionarClientesToolStripMenuItem.Name = "GestionarClientesToolStripMenuItem"
        Me.GestionarClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.GestionarClientesToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.GestionarClientesToolStripMenuItem.Text = "Gestionar Clientes"
        '
        'ABMCOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1084, 579)
        Me.Controls.Add(Me.panelBotoneraOt)
        Me.Controls.Add(Me.gbDatosOT)
        Me.Controls.Add(Me.gbDatosCliOT)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ABMCOrdenTrabajo"
        Me.Text = "MEG Soluciones Informáticas - Ordenes de Trabajo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbDatosCliOT.ResumeLayout(False)
        Me.gbDatosCliOT.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosOT.ResumeLayout(False)
        Me.panelDatosNvaOt.ResumeLayout(False)
        Me.panelCierre.ResumeLayout(False)
        Me.panelCierre.PerformLayout()
        Me.gbAniadirServicios.ResumeLayout(False)
        Me.gbAniadirServicios.PerformLayout()
        Me.gbListadoRepuestos.ResumeLayout(False)
        Me.gbListadoServiciosOt.ResumeLayout(False)
        Me.panelDatosOt.ResumeLayout(False)
        Me.panelDatosOt.PerformLayout()
        Me.panelDatosPcOt.ResumeLayout(False)
        Me.panelDatosPcOt.PerformLayout()
        Me.panelDatosClienteOt.ResumeLayout(False)
        Me.panelDatosClienteOt.PerformLayout()
        Me.panelBuscarOT.ResumeLayout(False)
        Me.panelBuscarOT.PerformLayout()
        Me.panelBotoneraOt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents gbDatosCliOT As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoDocBuscCliOT As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoCliOT As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCliOT As System.Windows.Forms.Button
    Friend WithEvents txtNroDocCliOT As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDocBuscCliOT As System.Windows.Forms.Label
    Friend WithEvents cbTipoDocOT As System.Windows.Forms.ComboBox
    Friend WithEvents gbDatosOT As System.Windows.Forms.GroupBox
    Friend WithEvents panelBuscarOT As System.Windows.Forms.Panel
    Friend WithEvents txtNroOT As System.Windows.Forms.TextBox
    Friend WithEvents lblNroOt As System.Windows.Forms.Label
    Friend WithEvents btnNvaOt As System.Windows.Forms.Button
    Friend WithEvents btnBuscarOT As System.Windows.Forms.Button
    Friend WithEvents btnActualizarOt As System.Windows.Forms.Button
    Friend WithEvents btnGuardarOt As System.Windows.Forms.Button
    Friend WithEvents btnCancelarOt As System.Windows.Forms.Button
    Friend WithEvents panelBotoneraOt As System.Windows.Forms.Panel
    Friend WithEvents btnNuevaPcOt As System.Windows.Forms.Button
    Friend WithEvents panelDatosNvaOt As System.Windows.Forms.Panel
    Friend WithEvents panelCierre As System.Windows.Forms.Panel
    Friend WithEvents btnAniadirCobroOt As System.Windows.Forms.Button
    Friend WithEvents txtNroCobroOt As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCobroOt As System.Windows.Forms.Label
    Friend WithEvents btnCalcularMontoOt As System.Windows.Forms.Button
    Friend WithEvents txtMontoOt As System.Windows.Forms.TextBox
    Friend WithEvents lblMontoOt As System.Windows.Forms.Label
    Friend WithEvents txtFechaReparacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaReparacionOt As System.Windows.Forms.Label
    Friend WithEvents gbAniadirServicios As System.Windows.Forms.GroupBox
    Friend WithEvents btnAniadirServicioOt As System.Windows.Forms.Button
    Friend WithEvents cbCantidadServicioOt As System.Windows.Forms.ComboBox
    Friend WithEvents lvlCantidadServiciosOt As System.Windows.Forms.Label
    Friend WithEvents cbServiciosOt As System.Windows.Forms.ComboBox
    Friend WithEvents lblServicioOt As System.Windows.Forms.Label
    Friend WithEvents gbListadoRepuestos As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepuestosOt As System.Windows.Forms.ListView
    Friend WithEvents colRepuesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidadRepuesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSubTotalRepuesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbListadoServiciosOt As System.Windows.Forms.GroupBox
    Friend WithEvents lvServiciosOt As System.Windows.Forms.ListView
    Friend WithEvents colServicios As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSubTot As System.Windows.Forms.ColumnHeader
    Friend WithEvents panelDatosOt As System.Windows.Forms.Panel
    Friend WithEvents txtDescrFallaOt As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionFallaOt As System.Windows.Forms.Label
    Friend WithEvents cbEstadoOt As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstadoOt As System.Windows.Forms.Label
    Friend WithEvents txtFechaRecepcionOt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFechaRecepción As System.Windows.Forms.Label
    Friend WithEvents panelDatosPcOt As System.Windows.Forms.Panel
    Friend WithEvents txtDescripcionPcOt As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionPcOt As System.Windows.Forms.Label
    Friend WithEvents txtTipoPcOt As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoPcOT As System.Windows.Forms.Label
    Friend WithEvents cbNroPcOt As System.Windows.Forms.ComboBox
    Friend WithEvents lblNroPcOt As System.Windows.Forms.Label
    Friend WithEvents panelDatosClienteOt As System.Windows.Forms.Panel
    Friend WithEvents txtApellidoClienteOt As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidoClienteOt As System.Windows.Forms.Label
    Friend WithEvents txtNombreCLienteOt As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreClienteOt As System.Windows.Forms.Label
    Friend WithEvents txtNroClienteOt As System.Windows.Forms.TextBox
    Friend WithEvents lblNroClienteOt As System.Windows.Forms.Label
    Friend WithEvents txtTipoRepRequerido As System.Windows.Forms.TextBox
    Friend WithEvents lblRepuestoRequerido As System.Windows.Forms.Label
    Friend WithEvents cbRepuestoOt As System.Windows.Forms.ComboBox
    Friend WithEvents lblRepuestoOt As System.Windows.Forms.Label
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarRepuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarTipoDeRepuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarTipoDePcMemoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarEstadosDeOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarTiposDeDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarProcesadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

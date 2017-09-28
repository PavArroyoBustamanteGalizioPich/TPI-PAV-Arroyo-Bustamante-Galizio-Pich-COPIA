<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMTipoPc_Memoria
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
        Me.gbTipoMemoria = New System.Windows.Forms.GroupBox()
        Me.btnCancelarMem = New System.Windows.Forms.Button()
        Me.btnNvoTipoMem = New System.Windows.Forms.Button()
        Me.btnBuscarTMem = New System.Windows.Forms.Button()
        Me.btnGuardarMem = New System.Windows.Forms.Button()
        Me.txtDescrMemoria = New System.Windows.Forms.TextBox()
        Me.lblDescrTipoMem = New System.Windows.Forms.Label()
        Me.txtTipoMemoria = New System.Windows.Forms.TextBox()
        Me.lblTipoMemoria = New System.Windows.Forms.Label()
        Me.txtIdMemoria = New System.Windows.Forms.TextBox()
        Me.lblIdTipoMemoria = New System.Windows.Forms.Label()
        Me.gbTIpoPc = New System.Windows.Forms.GroupBox()
        Me.btnCancelarTPC = New System.Windows.Forms.Button()
        Me.btnNvoTipoPc = New System.Windows.Forms.Button()
        Me.btnBuscarTPc = New System.Windows.Forms.Button()
        Me.btnGuardarTpc = New System.Windows.Forms.Button()
        Me.txtDescrTPc = New System.Windows.Forms.TextBox()
        Me.lblDescrPc = New System.Windows.Forms.Label()
        Me.txtTipoPc = New System.Windows.Forms.TextBox()
        Me.lblTipoPc = New System.Windows.Forms.Label()
        Me.txtIdTipoPc = New System.Windows.Forms.TextBox()
        Me.lblidTipoPc = New System.Windows.Forms.Label()
        Me.gbTipoMemoria.SuspendLayout()
        Me.gbTIpoPc.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTipoMemoria
        '
        Me.gbTipoMemoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipoMemoria.Controls.Add(Me.btnCancelarMem)
        Me.gbTipoMemoria.Controls.Add(Me.btnNvoTipoMem)
        Me.gbTipoMemoria.Controls.Add(Me.btnBuscarTMem)
        Me.gbTipoMemoria.Controls.Add(Me.btnGuardarMem)
        Me.gbTipoMemoria.Controls.Add(Me.txtDescrMemoria)
        Me.gbTipoMemoria.Controls.Add(Me.lblDescrTipoMem)
        Me.gbTipoMemoria.Controls.Add(Me.txtTipoMemoria)
        Me.gbTipoMemoria.Controls.Add(Me.lblTipoMemoria)
        Me.gbTipoMemoria.Controls.Add(Me.txtIdMemoria)
        Me.gbTipoMemoria.Controls.Add(Me.lblIdTipoMemoria)
        Me.gbTipoMemoria.Location = New System.Drawing.Point(13, 13)
        Me.gbTipoMemoria.Name = "gbTipoMemoria"
        Me.gbTipoMemoria.Size = New System.Drawing.Size(410, 165)
        Me.gbTipoMemoria.TabIndex = 26
        Me.gbTipoMemoria.TabStop = False
        Me.gbTipoMemoria.Text = "Tipo Memoria"
        '
        'btnCancelarMem
        '
        Me.btnCancelarMem.Location = New System.Drawing.Point(330, 122)
        Me.btnCancelarMem.Name = "btnCancelarMem"
        Me.btnCancelarMem.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMem.TabIndex = 6
        Me.btnCancelarMem.Text = "Cancelar"
        Me.btnCancelarMem.UseVisualStyleBackColor = True
        '
        'btnNvoTipoMem
        '
        Me.btnNvoTipoMem.Location = New System.Drawing.Point(231, 20)
        Me.btnNvoTipoMem.Name = "btnNvoTipoMem"
        Me.btnNvoTipoMem.Size = New System.Drawing.Size(75, 23)
        Me.btnNvoTipoMem.TabIndex = 2
        Me.btnNvoTipoMem.Text = "Nuevo"
        Me.btnNvoTipoMem.UseVisualStyleBackColor = True
        '
        'btnBuscarTMem
        '
        Me.btnBuscarTMem.Location = New System.Drawing.Point(149, 20)
        Me.btnBuscarTMem.Name = "btnBuscarTMem"
        Me.btnBuscarTMem.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarTMem.TabIndex = 1
        Me.btnBuscarTMem.Text = "Buscar"
        Me.btnBuscarTMem.UseVisualStyleBackColor = True
        '
        'btnGuardarMem
        '
        Me.btnGuardarMem.Location = New System.Drawing.Point(248, 123)
        Me.btnGuardarMem.Name = "btnGuardarMem"
        Me.btnGuardarMem.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarMem.TabIndex = 5
        Me.btnGuardarMem.Text = "Guardar"
        Me.btnGuardarMem.UseVisualStyleBackColor = True
        '
        'txtDescrMemoria
        '
        Me.txtDescrMemoria.Location = New System.Drawing.Point(96, 92)
        Me.txtDescrMemoria.Multiline = True
        Me.txtDescrMemoria.Name = "txtDescrMemoria"
        Me.txtDescrMemoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrMemoria.Size = New System.Drawing.Size(141, 55)
        Me.txtDescrMemoria.TabIndex = 4
        '
        'lblDescrTipoMem
        '
        Me.lblDescrTipoMem.AutoSize = True
        Me.lblDescrTipoMem.Location = New System.Drawing.Point(7, 100)
        Me.lblDescrTipoMem.Name = "lblDescrTipoMem"
        Me.lblDescrTipoMem.Size = New System.Drawing.Size(66, 13)
        Me.lblDescrTipoMem.TabIndex = 22
        Me.lblDescrTipoMem.Text = "Descripción:"
        '
        'txtTipoMemoria
        '
        Me.txtTipoMemoria.Location = New System.Drawing.Point(96, 59)
        Me.txtTipoMemoria.MaxLength = 20
        Me.txtTipoMemoria.Name = "txtTipoMemoria"
        Me.txtTipoMemoria.Size = New System.Drawing.Size(95, 20)
        Me.txtTipoMemoria.TabIndex = 3
        '
        'lblTipoMemoria
        '
        Me.lblTipoMemoria.AutoSize = True
        Me.lblTipoMemoria.Location = New System.Drawing.Point(7, 67)
        Me.lblTipoMemoria.Name = "lblTipoMemoria"
        Me.lblTipoMemoria.Size = New System.Drawing.Size(74, 13)
        Me.lblTipoMemoria.TabIndex = 21
        Me.lblTipoMemoria.Text = "Tipo Memoria:"
        '
        'txtIdMemoria
        '
        Me.txtIdMemoria.Location = New System.Drawing.Point(96, 23)
        Me.txtIdMemoria.MaxLength = 3
        Me.txtIdMemoria.Name = "txtIdMemoria"
        Me.txtIdMemoria.Size = New System.Drawing.Size(46, 20)
        Me.txtIdMemoria.TabIndex = 0
        '
        'lblIdTipoMemoria
        '
        Me.lblIdTipoMemoria.AutoSize = True
        Me.lblIdTipoMemoria.Location = New System.Drawing.Point(7, 31)
        Me.lblIdTipoMemoria.Name = "lblIdTipoMemoria"
        Me.lblIdTipoMemoria.Size = New System.Drawing.Size(82, 13)
        Me.lblIdTipoMemoria.TabIndex = 20
        Me.lblIdTipoMemoria.Text = "Id tipo Memoria:"
        '
        'gbTIpoPc
        '
        Me.gbTIpoPc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTIpoPc.Controls.Add(Me.btnCancelarTPC)
        Me.gbTIpoPc.Controls.Add(Me.btnNvoTipoPc)
        Me.gbTIpoPc.Controls.Add(Me.btnBuscarTPc)
        Me.gbTIpoPc.Controls.Add(Me.btnGuardarTpc)
        Me.gbTIpoPc.Controls.Add(Me.txtDescrTPc)
        Me.gbTIpoPc.Controls.Add(Me.lblDescrPc)
        Me.gbTIpoPc.Controls.Add(Me.txtTipoPc)
        Me.gbTIpoPc.Controls.Add(Me.lblTipoPc)
        Me.gbTIpoPc.Controls.Add(Me.txtIdTipoPc)
        Me.gbTIpoPc.Controls.Add(Me.lblidTipoPc)
        Me.gbTIpoPc.Location = New System.Drawing.Point(13, 184)
        Me.gbTIpoPc.Name = "gbTIpoPc"
        Me.gbTIpoPc.Size = New System.Drawing.Size(410, 165)
        Me.gbTIpoPc.TabIndex = 27
        Me.gbTIpoPc.TabStop = False
        Me.gbTIpoPc.Text = "Tipo Pc"
        '
        'btnCancelarTPC
        '
        Me.btnCancelarTPC.Location = New System.Drawing.Point(330, 121)
        Me.btnCancelarTPC.Name = "btnCancelarTPC"
        Me.btnCancelarTPC.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarTPC.TabIndex = 13
        Me.btnCancelarTPC.Text = "Cancelar"
        Me.btnCancelarTPC.UseVisualStyleBackColor = True
        '
        'btnNvoTipoPc
        '
        Me.btnNvoTipoPc.Location = New System.Drawing.Point(235, 18)
        Me.btnNvoTipoPc.Name = "btnNvoTipoPc"
        Me.btnNvoTipoPc.Size = New System.Drawing.Size(75, 23)
        Me.btnNvoTipoPc.TabIndex = 9
        Me.btnNvoTipoPc.Text = "Nuevo"
        Me.btnNvoTipoPc.UseVisualStyleBackColor = True
        '
        'btnBuscarTPc
        '
        Me.btnBuscarTPc.Location = New System.Drawing.Point(153, 18)
        Me.btnBuscarTPc.Name = "btnBuscarTPc"
        Me.btnBuscarTPc.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarTPc.TabIndex = 8
        Me.btnBuscarTPc.Text = "Buscar"
        Me.btnBuscarTPc.UseVisualStyleBackColor = True
        '
        'btnGuardarTpc
        '
        Me.btnGuardarTpc.Location = New System.Drawing.Point(248, 121)
        Me.btnGuardarTpc.Name = "btnGuardarTpc"
        Me.btnGuardarTpc.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarTpc.TabIndex = 12
        Me.btnGuardarTpc.Text = "Guardar"
        Me.btnGuardarTpc.UseVisualStyleBackColor = True
        '
        'txtDescrTPc
        '
        Me.txtDescrTPc.Location = New System.Drawing.Point(100, 89)
        Me.txtDescrTPc.Multiline = True
        Me.txtDescrTPc.Name = "txtDescrTPc"
        Me.txtDescrTPc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrTPc.Size = New System.Drawing.Size(141, 55)
        Me.txtDescrTPc.TabIndex = 11
        '
        'lblDescrPc
        '
        Me.lblDescrPc.AutoSize = True
        Me.lblDescrPc.Location = New System.Drawing.Point(21, 97)
        Me.lblDescrPc.Name = "lblDescrPc"
        Me.lblDescrPc.Size = New System.Drawing.Size(66, 13)
        Me.lblDescrPc.TabIndex = 25
        Me.lblDescrPc.Text = "Descripción:"
        '
        'txtTipoPc
        '
        Me.txtTipoPc.Location = New System.Drawing.Point(100, 56)
        Me.txtTipoPc.MaxLength = 20
        Me.txtTipoPc.Name = "txtTipoPc"
        Me.txtTipoPc.Size = New System.Drawing.Size(95, 20)
        Me.txtTipoPc.TabIndex = 10
        '
        'lblTipoPc
        '
        Me.lblTipoPc.AutoSize = True
        Me.lblTipoPc.Location = New System.Drawing.Point(21, 64)
        Me.lblTipoPc.Name = "lblTipoPc"
        Me.lblTipoPc.Size = New System.Drawing.Size(48, 13)
        Me.lblTipoPc.TabIndex = 24
        Me.lblTipoPc.Text = "Tipo PC:"
        '
        'txtIdTipoPc
        '
        Me.txtIdTipoPc.Location = New System.Drawing.Point(100, 20)
        Me.txtIdTipoPc.MaxLength = 3
        Me.txtIdTipoPc.Name = "txtIdTipoPc"
        Me.txtIdTipoPc.Size = New System.Drawing.Size(46, 20)
        Me.txtIdTipoPc.TabIndex = 7
        '
        'lblidTipoPc
        '
        Me.lblidTipoPc.AutoSize = True
        Me.lblidTipoPc.Location = New System.Drawing.Point(21, 28)
        Me.lblidTipoPc.Name = "lblidTipoPc"
        Me.lblidTipoPc.Size = New System.Drawing.Size(55, 13)
        Me.lblidTipoPc.TabIndex = 23
        Me.lblidTipoPc.Text = "Id tipo Pc:"
        '
        'ABMTipoPc_Memoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 361)
        Me.Controls.Add(Me.gbTIpoPc)
        Me.Controls.Add(Me.gbTipoMemoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMTipoPc_Memoria"
        Me.Text = "Gestion Tipo PC/MEMORIA"
        Me.gbTipoMemoria.ResumeLayout(False)
        Me.gbTipoMemoria.PerformLayout()
        Me.gbTIpoPc.ResumeLayout(False)
        Me.gbTIpoPc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTipoMemoria As System.Windows.Forms.GroupBox
    Friend WithEvents gbTIpoPc As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarTMem As System.Windows.Forms.Button
    Friend WithEvents btnGuardarMem As System.Windows.Forms.Button
    Friend WithEvents txtDescrMemoria As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrTipoMem As System.Windows.Forms.Label
    Friend WithEvents txtTipoMemoria As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoMemoria As System.Windows.Forms.Label
    Friend WithEvents txtIdMemoria As System.Windows.Forms.TextBox
    Friend WithEvents lblIdTipoMemoria As System.Windows.Forms.Label
    Friend WithEvents btnBuscarTPc As System.Windows.Forms.Button
    Friend WithEvents btnGuardarTpc As System.Windows.Forms.Button
    Friend WithEvents txtDescrTPc As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrPc As System.Windows.Forms.Label
    Friend WithEvents txtTipoPc As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoPc As System.Windows.Forms.Label
    Friend WithEvents txtIdTipoPc As System.Windows.Forms.TextBox
    Friend WithEvents lblidTipoPc As System.Windows.Forms.Label
    Friend WithEvents btnNvoTipoMem As System.Windows.Forms.Button
    Friend WithEvents btnNvoTipoPc As System.Windows.Forms.Button
    Friend WithEvents btnCancelarMem As System.Windows.Forms.Button
    Friend WithEvents btnCancelarTPC As System.Windows.Forms.Button
End Class

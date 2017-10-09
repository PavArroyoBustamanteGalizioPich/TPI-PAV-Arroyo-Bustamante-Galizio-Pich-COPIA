Public Class OrdenTrabajoDto


    Private _idOrden As Int32
    Private _cliente As ClienteDto
    Private _fechaRecepcion As Date
    Private _fechaReparacion As Date
    Private _estado As Int32
    Private _computadora As ComputadoraDto
    Private _cobro As Int32
    Private _falla As String
    Private _monto As Decimal
    Private _serviciosAgregados As List(Of ServicioDto)
    Private _detalles As List(Of DetalleOrdenTrabajoDto)


    Property idOrden As Int32
        Get
            Return _idOrden
        End Get
        Set(value As Int32)
            _idOrden = value
        End Set
    End Property


    ' el monto en realidad deberia calcularse aca!!!!!!!!!
    '!!!!!!!!!!!!!!!!!!!!!!!!!!
    '!!!!!!!!!!!!!!!
    Property monto As Decimal
        Get
            Return _monto
        End Get
        Set(value As Decimal)
            _monto = value
        End Set
    End Property

    Property falla As String
        Get
            Return _falla
        End Get
        Set(value As String)
            _falla = value
        End Set
    End Property

    Property detalles As List(Of DetalleOrdenTrabajoDto)
        Get
            Return _detalles
        End Get
        Set(value As List(Of DetalleOrdenTrabajoDto))
            _detalles = value
        End Set
    End Property

    Property serviciosAgregados As List(Of ServicioDto)
        Get
            Return _serviciosAgregados
        End Get
        Set(value As List(Of ServicioDto))
            _serviciosAgregados = value
        End Set
    End Property
    Property fechaRecepcion As Date
        Get
            Return _fechaRecepcion
        End Get
        Set(value As Date)
            _fechaRecepcion = value
        End Set
    End Property

    Property fechaReparacion As Date
        Get
            Return _fechaReparacion
        End Get
        Set(value As Date)
            _fechaReparacion = value
        End Set
    End Property


    Property computadora As ComputadoraDto
        Get
            Return _computadora
        End Get
        Set(value As ComputadoraDto)
            _computadora = value
        End Set
    End Property

    Property cliente As ClienteDto
        Get
            Return _cliente
        End Get
        Set(value As ClienteDto)
            _cliente = value
        End Set
    End Property
    Property cobro As Int32
        Get
            Return _cobro
        End Get
        Set(value As Int32)
            _cobro = value
        End Set
    End Property

    Property estado As Int32
        Get
            Return _estado
        End Get
        Set(value As Int32)
            _estado = value
        End Set
    End Property


    Public Sub armarDetalles()

        _detalles = New List(Of DetalleOrdenTrabajoDto)

        For Each servicio As ServicioDto In _serviciosAgregados
            Dim detalle As New DetalleOrdenTrabajoDto

            detalle.id = Utilidades.sugerirId("detalleOrdenTrabajo", "idDetalleOrdenTrabajo")
            detalle.servicio = servicio.idServ
            detalle.montoUnitServicio = servicio.costoServicio

            If servicio.repuestoReq > 0 Then
                detalle.repuesto = servicio.repuesto.id
                detalle.montoUnitrepuesto = servicio.repuesto.calcularMonto()
            End If

            detalle.cantidad = servicio.cantidad

            _detalles.Add(detalle)

        Next

    End Sub


    Public Function calcularTotal() As Decimal
        _monto = 0
        For Each detalle As DetalleOrdenTrabajoDto In _detalles

            _monto = detalle.montoUnitServicio * detalle.cantidad

            If detalle.repuesto > 0 Then
                _monto += detalle.montoUnitrepuesto * detalle.cantidad
            End If


        Next
        Return _monto
    End Function

End Class

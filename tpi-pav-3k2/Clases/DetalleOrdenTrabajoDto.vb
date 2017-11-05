Public Class DetalleOrdenTrabajoDto

    Private _id As Int32
    Private _servicio As Int32
    Private _repuesto As Int32
    Private _cantidad As Int32
    Private _montoUnitServicio As Decimal
    Private _montoUnitRepuesto As Decimal

    Property id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property

    Property servicio As Int32
        Get
            Return _servicio
        End Get
        Set(value As Int32)
            _servicio = value
        End Set
    End Property

    Property repuesto As Int32
        Get
            Return _repuesto
        End Get
        Set(value As Int32)
            _repuesto = value
        End Set
    End Property

    Property cantidad As Int32
        Get
            Return _cantidad
        End Get
        Set(value As Int32)
            _cantidad = value
        End Set
    End Property

    Property montoUnitServicio As Decimal
        Get
            Return _montoUnitServicio
        End Get
        Set(value As Decimal)
            _montoUnitServicio = value
        End Set
    End Property

    Property montoUnitrepuesto As Decimal
        Get
            Return _montoUnitRepuesto
        End Get
        Set(value As Decimal)
            _montoUnitRepuesto = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean

        If Not obj.GetType = Me.GetType Then
            Return False

        End If

        Dim aux As DetalleOrdenTrabajoDto = CType(obj, DetalleOrdenTrabajoDto)
        If aux.servicio = Me.servicio Then
            Return True
        End If
        Return False

    End Function

    Private _cargado As Boolean
    Public Property cargado As Boolean
        Get
            Return _cargado
        End Get
        Set(ByVal value As Boolean)
            _cargado = value
        End Set
    End Property


End Class

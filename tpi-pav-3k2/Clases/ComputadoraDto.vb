Public Class ComputadoraDto

    Private _idComputadora As Int32
    Private _nroCliente As Int32
    Private _tipoPc As Int32
    Private _procesador As Int32
    Private _cantidadMemoria As Decimal
    Private _tipoMemoria As Int32
    Private _capacidadAlmacenamiento As Int32
    Private _fechaAlta As Date
    Private _fechaBaja As Date

    Public Property idComputadora As Int32
        Get
            Return _idComputadora
        End Get
        Set(value As Int32)
            _idComputadora = value
        End Set
    End Property

    Public Property nroCliente As Int32
        Get
            Return _nroCliente
        End Get
        Set(value As Int32)
            _nroCliente = value
        End Set
    End Property

    Public Property tipoPc As Int32
        Get
            Return _tipoPc
        End Get
        Set(value As Int32)
            _tipoPc = value
        End Set
    End Property

    Public Property tipoMemoria As Int32
        Get
            Return _tipoMemoria
        End Get
        Set(value As Int32)
            _tipoMemoria = value
        End Set
    End Property

    Public Property procesador As Int32
        Get
            Return _procesador
        End Get
        Set(value As Int32)
            _procesador = value
        End Set
    End Property

    Public Property capAlmacenamiento As Int32
        Get
            Return _capacidadAlmacenamiento
        End Get
        Set(value As Int32)
            _capacidadAlmacenamiento = value
        End Set
    End Property

    Public Property cantidadMemoria As Decimal
        Get
            Return _cantidadMemoria
        End Get
        Set(value As Decimal)
            _cantidadMemoria = value
        End Set
    End Property

    Public Property fechaAlta As Date
        Get
            Return _fechaAlta
        End Get
        Set(value As Date)
            _fechaAlta = value
        End Set
    End Property

    Public Property fechaBaja As Date
        Get
            Return _fechaBaja
        End Get
        Set(value As Date)
            _fechaBaja = value
        End Set
    End Property

End Class

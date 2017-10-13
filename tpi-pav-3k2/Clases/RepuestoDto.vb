Public Class RepuestoDto

    Private _id As Int32
    Private _descripcion As String
    Private _idMarca As Int32
    Private _nombreMarca As String
    Private _tipo As Int32
    Private _nombreTipo As String
    Private _proveedor As Int32
    Private _garantia As Int32
    Private _precioCompra As Single
    Private _porcentajeGanancia As Int32
    Private _fechaCompra As Date
    Private _cantidad As Int32
    Private _monto As Single


    Property id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
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

    Property idMarca As Int32
        Get
            Return _idMarca
        End Get
        Set(value As Int32)
            _idMarca = value
        End Set
    End Property

    Property tipo As Int32
        Get
            Return _tipo
        End Get
        Set(value As Int32)
            _tipo = value
        End Set
    End Property

    Property proveedor As Int32
        Get
            Return _proveedor
        End Get
        Set(value As Int32)
            _proveedor = value
        End Set
    End Property

    Property garantia As Int32
        Get
            Return _garantia
        End Get
        Set(value As Int32)
            _garantia = value
        End Set
    End Property

    Property porcentajeGanancia As Int32
        Get
            Return _porcentajeGanancia
        End Get
        Set(value As Int32)
            _porcentajeGanancia = value
        End Set
    End Property

    Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Property nombreTipo As String
        Get
            Return _nombreTipo
        End Get
        Set(value As String)
            _nombreTipo = value
        End Set
    End Property

    Property nombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            _nombreMarca = value
        End Set
    End Property

    Property precioCompra As Single
        Get
            Return _precioCompra
        End Get
        Set(value As Single)
            _precioCompra = value
        End Set
    End Property


    Property monto As Single
        Get
            Return _monto
        End Get
        Set(value As Single)
            _monto = value
        End Set
    End Property

    Property fechaCompra As Date
        Get
            Return _fechaCompra
        End Get
        Set(value As Date)
            _fechaCompra = value

        End Set
    End Property

    Public Function precioVenta() As Decimal
        Return _precioCompra * _porcentajeGanancia
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj.GetType() <> Me.GetType() Then
            Return False
        End If
        
        Dim rep = CType(obj, RepuestoDto)
        If rep.id = Me.id Then
            Return True
        End If

        Return False

    End Function

    Public Function calcularMonto() As Decimal

        _monto = precioCompra + (precioCompra * (porcentajeGanancia / 100))
        Return monto
    End Function

End Class

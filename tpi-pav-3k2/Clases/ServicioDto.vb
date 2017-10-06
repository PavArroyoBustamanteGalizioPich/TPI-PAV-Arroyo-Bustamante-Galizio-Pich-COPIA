Public Class ServicioDto

    Private idServicio As Int32
    Private nombreServicio As String
    Private detalle As String
    Private costo As Decimal
    Private garantia As Int32
    Private fechaBaja As Date
    Private repuestoRequerido As Int32
    'Private _nombreRepuesto As String
    Private _cantidad As Int32
    Private _repuesto As RepuestoDto


    Property idServ As Int32
        Get
            Return idServicio
        End Get
        Set(value As Int32)
            idServicio = value
        End Set
    End Property

    Property repuesto As RepuestoDto
        Get
            Return _repuesto
        End Get
        Set(value As RepuestoDto)
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
    Property nomServicio As String
        Get
            Return nombreServicio
        End Get
        Set(value As String)
            nombreServicio = value
        End Set
    End Property

    'Property nombreRepuesto As String
    ' Get
    ' Return _nombreRepuesto
    ' End Get
    ' Set(value As String)
    '     _nombreRepuesto = value
    ' End Set
    ' End Property

    Property detalleServicio As String
        Get
            Return detalle
        End Get
        Set(value As String)
            detalle = value
        End Set
    End Property

    Property costoServicio As Decimal
        Get
            Return costo
        End Get
        Set(value As Decimal)
            costo = value
        End Set
    End Property
    Property garantiaServicio As Int32
        Get
            Return garantia
        End Get
        Set(value As Int32)
            garantia = value
        End Set
    End Property

    Property repuestoReq As Int32
        Get
            Return repuestoRequerido
        End Get
        Set(value As Int32)
            repuestoRequerido = value
        End Set
    End Property

    Property fechaBajaServicio As Date
        Get
            Return fechaBaja
        End Get
        Set(value As Date)
            fechaBaja = value
        End Set
    End Property


    Public Overrides Function Equals(obj As Object) As Boolean
        If obj.GetType() <> Me.GetType() Then
            Return False
        End If

        Dim serv = CType(obj, ServicioDto)
        If serv.idServ = Me.idServ Then
            Return True
        End If

        Return False

    End Function

   

End Class

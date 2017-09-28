Public Class ServicioVo

    Private idServicio As Int32
    Private nombreServicio As String
    Private detalle As String
    Private costo As Single
    Private garantia As Int32
    Private fechaBaja As Date
    Private repuestoRequerido As Int32


    Property idServ As Int32
        Get
            Return idServicio
        End Get
        Set(value As Int32)
            idServicio = value
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

    Property detalleServicio As String
        Get
            Return detalle
        End Get
        Set(value As String)
            detalle = value
        End Set
    End Property

    Property costoServicio As Single
        Get
            Return costo
        End Get
        Set(value As Single)
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


End Class

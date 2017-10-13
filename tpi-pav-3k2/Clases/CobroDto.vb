Public Class CobroDto

    Private _id As Int32
    Private _fechaCobro As Date
    Private _monto As Single

    Property id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property

    Property fechaCobro As Date
        Get
            Return _fechaCobro
        End Get
        Set(value As Date)
            _fechaCobro = value
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

End Class

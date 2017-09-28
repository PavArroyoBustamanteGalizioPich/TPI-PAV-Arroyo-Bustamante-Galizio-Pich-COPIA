Public Class ProcesadorVo

    Private _idProcesador As Int32
    Private _modelo As String
    Private _frecuencia As Single
    Private _cantNucleos As Int32
    Private _idMarca As Int32
    Private _marca As String

    Property idProcesador As Int32
        Get
            Return _idProcesador
        End Get
        Set(value As Int32)
            _idProcesador = value
        End Set
    End Property

    Property modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Property fecuencia As Single
        Get
            Return _frecuencia
        End Get
        Set(value As Single)
            _frecuencia = value
        End Set
    End Property

    Property cantNucleos As Int32
        Get
            Return _cantNucleos
        End Get
        Set(value As Int32)
            _cantNucleos = value
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

    Property marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property





End Class

Public Class ComputadoraDto

    Private _idComputadora As Int32
    Private _nroCliente As Int32
    Private _tipoPc As Int32
    Private _nombreTipoPc As String
    Private _procesador As Int32
    Private _modeloProcesador As String
    Private _cantidadMemoria As Decimal
    Private _tipoMemoria As Int32
    Private _capacidadAlmacenamiento As Int32
    Private _fechaAlta As Date
    Private _fechaBaja As Date
    Private _marcaProcesador As Int32

    Public Property idComputadora As Int32
        Get
            Return _idComputadora
        End Get
        Set(value As Int32)
            _idComputadora = value
        End Set
    End Property

    Public Property nombreTipoPc As String
        Get
            Return _nombreTipoPc
        End Get
        Set(value As String)
            _nombreTipoPc = value
        End Set
    End Property

    Public Property modeloProcesador As String
        Get
            Return _modeloProcesador
        End Get
        Set(value As String)
            _modeloProcesador = value
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

    Public Property marcaProcesador As Int32
        Get
            Return _marcaProcesador
        End Get
        Set(value As Int32)
            _marcaProcesador = value
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

    Public Overrides Function toString() As String
        Dim cadena As New System.Text.StringBuilder

        If procesador <> 0 Then
            cadena.Append("Procesador: " & _modeloProcesador & "| ")
        Else : cadena.Append("Procesador: DESCONOCIDO |")
        End If
        If _cantidadMemoria <> 0 Then
            cadena.Append(" RAM: " & _cantidadMemoria & "GB |")
        Else : cadena.Append(" RAM: DESCONOCIDO ")
        End If

        If _capacidadAlmacenamiento <> 0 Then
            cadena.Append(" Almacenamiento: " & _capacidadAlmacenamiento & "GB")
        Else : cadena.Append(" Almacenamiento: DESCONOCIDO ")
        End If
        Return cadena.ToString()

    End Function

End Class

Public Class ClienteDto

    Private _idCliente As Int32
    Private _nombre As String
    Private _apellido As String
    Private _telefono As String
    Private _email As String
    Private _nroDocumento As String
    Private _tipoDocumento As Int32
    Private _fechaAlta As Date
    Private _fechaBaja As Date
    Private _computadoras As Int32()

    Public Sub New()
        fechaBaja = Nothing
    End Sub


    Public Property idCliente As Int32
        Get
            Return _idCliente
        End Get
        Set(value As Int32)
            _idCliente = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property nroDocumento As String
        Get
            Return _nroDocumento
        End Get
        Set(value As String)
            _nroDocumento = value
        End Set
    End Property

    Public Property tipoDocumento As Int32
        Get
            Return _tipoDocumento
        End Get
        Set(value As Int32)
            _tipoDocumento = value
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

    Public Property computadoras As Int32()
        Get
            Return _computadoras
        End Get
        Set(value As Int32())
            _computadoras = value
        End Set
    End Property

End Class

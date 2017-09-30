Public Class ProveedorDto

    Private _nroProveedor As Int32
    Private _razonSocial As String
    Private _cuit As String
    Private _telefono As String
    Private _fechaBaja As Date

    Public Sub New()
        _fechaBaja = Nothing
        _telefono = Nothing
    End Sub

    Public Property nroProveedor As Int32
        Get
            Return _nroProveedor
        End Get
        Set(ByVal value As Int32)
            _nroProveedor = value
        End Set
    End Property

    Public Property razonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(ByVal value As String)
            _razonSocial = value
        End Set
    End Property

    Public Property cuit As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            _cuit = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property fechaBaja As Date
        Get
            Return _fechaBaja
        End Get
        Set(ByVal value As Date)
            _fechaBaja = value
        End Set
    End Property


End Class

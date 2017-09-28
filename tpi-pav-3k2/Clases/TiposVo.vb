Public Class TiposVo

    Private idTipo As Int32
    Private tipo As String
    Private descripcion As String


    Property id As Int32
        Get
            Return idTipo
        End Get
        Set(value As Int32)
            idTipo = value
        End Set
    End Property

    Property nombreTipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property
    Property descripcionTipo As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property


End Class

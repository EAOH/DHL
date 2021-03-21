Public Class ECliente
    Private cliCodigo As Integer
    Private cliNombre, cliApellido, cliIdentidad, cliTelefono, cliCorreo, cliDireccion As String

    Public Property CliCodigo1 As Integer
        Get
            Return cliCodigo
        End Get
        Set(value As Integer)
            cliCodigo = value
        End Set
    End Property

    Public Property CliNombre1 As String
        Get
            Return cliNombre
        End Get
        Set(value As String)
            cliNombre = value
        End Set
    End Property

    Public Property CliApellido1 As String
        Get
            Return cliApellido
        End Get
        Set(value As String)
            cliApellido = value
        End Set
    End Property

    Public Property CliIdentidad1 As String
        Get
            Return cliIdentidad
        End Get
        Set(value As String)
            cliIdentidad = value
        End Set
    End Property

    Public Property CliTelefono1 As String
        Get
            Return cliTelefono
        End Get
        Set(value As String)
            cliTelefono = value
        End Set
    End Property

    Public Property CliCorreo1 As String
        Get
            Return cliCorreo
        End Get
        Set(value As String)
            cliCorreo = value
        End Set
    End Property

    Public Property CliDireccion1 As String
        Get
            Return cliDireccion
        End Get
        Set(value As String)
            cliDireccion = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(cliCodigo As Integer, cliNombre As String, cliApellido As String, cliIdentidad As String, cliTelefono As String, cliCorreo As String, cliDireccion As String)
        Me.cliCodigo = cliCodigo
        Me.cliNombre = cliNombre
        Me.cliApellido = cliApellido
        Me.cliIdentidad = cliIdentidad
        Me.cliTelefono = cliTelefono
        Me.cliCorreo = cliCorreo
        Me.cliDireccion = cliDireccion
    End Sub
End Class

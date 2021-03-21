Public Class EEmpleado
    Dim empCodigo As Integer
    Dim empNombre As String
    Dim empApellido As String
    Dim empIdentidad As String
    Dim empTelefono As String
    Dim empCorreo As String
    Dim empDireccion As String
    Dim empPuesto As String
    Dim empFechaIngreso As Date
    Dim empUsuario As String
    Dim empContraseña As String

    Public Property PempCodigo
        Get
            Return empCodigo
        End Get
        Set(value)
            empCodigo = value
        End Set
    End Property

    Public Property PempNombre
        Get
            Return empNombre
        End Get
        Set(value)
            empNombre = value
        End Set
    End Property

    Public Property PempApellido
        Get
            Return empApellido
        End Get
        Set(value)
            empApellido = value
        End Set
    End Property

    Public Property PempDireccion
        Get
            Return empDireccion
        End Get
        Set(value)
            empDireccion = value
        End Set
    End Property

    Public Property PempTelefono
        Get
            Return empTelefono
        End Get
        Set(value)
            empTelefono = value
        End Set
    End Property

    Public Property PempIdentidad
        Get
            Return empIdentidad
        End Get
        Set(value)
            empIdentidad = value
        End Set
    End Property

    Public Property PempCorreo
        Get
            Return empCorreo
        End Get
        Set(value)
            empCorreo = value
        End Set
    End Property

    Public Property PempPuesto
        Get
            Return empPuesto
        End Get
        Set(value)
            empPuesto = value
        End Set
    End Property

    Public Property PempFechaIngreso
        Get
            Return empFechaIngreso
        End Get
        Set(value)
            empFechaIngreso = value
        End Set
    End Property

    Public Property PempUsuario
        Get
            Return empUsuario
        End Get
        Set(value)
            empUsuario = value
        End Set
    End Property

    Public Property PempContraseña
        Get
            Return empContraseña
        End Get
        Set(value)
            empContraseña = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(empCodigo As Integer, empNombre As String, empApellido As String, empDirreccion As String, empTelefono As String, empIdentidad As String, empCorreo As String, empPuesto As String, empFechaIngreso As Date, empUsuario As String, empContraseña As String)
        PempCodigo = empCodigo
        PempNombre = empNombre
        PempApellido = empApellido
        PempDireccion = empDirreccion
        PempTelefono = empTelefono
        PempIdentidad = empIdentidad
        PempCorreo = empCorreo
        PempPuesto = empPuesto
        PempFechaIngreso = empFechaIngreso
        PempUsuario = empUsuario
        PempContraseña = empContraseña
    End Sub

End Class

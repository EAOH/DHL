Public Class EEnvios
    Private envCodigo, envDiasAlmacenados, cliCodigoE, cliCodigoR, empCodigo, paiCodigoD, zonCodigo, almCodigo As Integer
    Private envTipoServicio, envTipoPago, envDescripcion As String
    Private envPesoKG, envDimenciones As Double

    Public Sub New()
    End Sub

    Public Sub New(envCodigo As Integer, envDiasAlmacenados As Integer, cliCodigoE As Integer, cliCodigoR As Integer, empCodigo As Integer, paiCodigoD As Integer, zonCodigo As Integer, almCodigo As Integer, envTipoServicio As String, envTipoPago As String, envDescripcion As String, envPesoKG As Double, envDimenciones As Double)
        Me.envCodigo = envCodigo
        Me.envDiasAlmacenados = envDiasAlmacenados
        Me.cliCodigoE = cliCodigoE
        Me.cliCodigoR = cliCodigoR
        Me.empCodigo = empCodigo
        Me.paiCodigoD = paiCodigoD
        Me.zonCodigo = zonCodigo
        Me.almCodigo = almCodigo
        Me.envTipoServicio = envTipoServicio
        Me.envTipoPago = envTipoPago
        Me.envDescripcion = envDescripcion
        Me.envPesoKG = envPesoKG
        Me.envDimenciones = envDimenciones
    End Sub

    Public Property EnvCodigo1 As Integer
        Get
            Return envCodigo
        End Get
        Set(value As Integer)
            envCodigo = value
        End Set
    End Property

    Public Property EnvDiasAlmacenados1 As Integer
        Get
            Return envDiasAlmacenados
        End Get
        Set(value As Integer)
            envDiasAlmacenados = value
        End Set
    End Property

    Public Property CliCodigoE1 As Integer
        Get
            Return cliCodigoE
        End Get
        Set(value As Integer)
            cliCodigoE = value
        End Set
    End Property

    Public Property CliCodigoR1 As Integer
        Get
            Return cliCodigoR
        End Get
        Set(value As Integer)
            cliCodigoR = value
        End Set
    End Property

    Public Property EmpCodigo1 As Integer
        Get
            Return empCodigo
        End Get
        Set(value As Integer)
            empCodigo = value
        End Set
    End Property

    Public Property PaiCodigoD1 As Integer
        Get
            Return paiCodigoD
        End Get
        Set(value As Integer)
            paiCodigoD = value
        End Set
    End Property

    Public Property ZonCodigo1 As Integer
        Get
            Return zonCodigo
        End Get
        Set(value As Integer)
            zonCodigo = value
        End Set
    End Property

    Public Property AlmCodigo1 As Integer
        Get
            Return almCodigo
        End Get
        Set(value As Integer)
            almCodigo = value
        End Set
    End Property

    Public Property EnvTipoServicio1 As String
        Get
            Return envTipoServicio
        End Get
        Set(value As String)
            envTipoServicio = value
        End Set
    End Property

    Public Property EnvTipoPago1 As String
        Get
            Return envTipoPago
        End Get
        Set(value As String)
            envTipoPago = value
        End Set
    End Property

    Public Property EnvDescripcion1 As String
        Get
            Return envDescripcion
        End Get
        Set(value As String)
            envDescripcion = value
        End Set
    End Property

    Public Property EnvPesoKG1 As Double
        Get
            Return envPesoKG
        End Get
        Set(value As Double)
            envPesoKG = value
        End Set
    End Property

    Public Property EnvDimenciones1 As Double
        Get
            Return envDimenciones
        End Get
        Set(value As Double)
            envDimenciones = value
        End Set
    End Property
End Class

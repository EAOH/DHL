Public Class EAlmacenaje
    Private almCodigo, almDiasmin, almDiasMAX As Integer
    Private almTipoCagar, almTipo, almCiudad As String
    Private almTramoInicial, almTramoFinal, almPesomin, almPesoMax, almCostoFijo As Double

    Public Sub New()
    End Sub

    Public Sub New(almCodigo As Integer, almDiasmin As Integer, almDiasMAX As Integer, almTipoCagar As String, almTipo As String,
                   almCiudad As String, almTramoInicial As Double, almTramoFinal As Double, almPesomin As Double, almPesoMax As Double,
                   almCostoFijo As Double)
        Me.almCodigo = almCodigo
        Me.almDiasmin = almDiasmin
        Me.almDiasMAX = almDiasMAX
        Me.almTipoCagar = almTipoCagar
        Me.almTipo = almTipo
        Me.almCiudad = almCiudad
        Me.almTramoInicial = almTramoInicial
        Me.almTramoFinal = almTramoFinal
        Me.almPesomin = almPesomin
        Me.almPesoMax = almPesoMax
        Me.almCostoFijo = almCostoFijo
    End Sub

    Public Property AlmCodigo1 As Integer
        Get
            Return almCodigo
        End Get
        Set(value As Integer)
            almCodigo = value
        End Set
    End Property

    Public Property AlmDiasmin1 As Integer
        Get
            Return almDiasmin
        End Get
        Set(value As Integer)
            almDiasmin = value
        End Set
    End Property

    Public Property AlmDiasMAX1 As Integer
        Get
            Return almDiasMAX
        End Get
        Set(value As Integer)
            almDiasMAX = value
        End Set
    End Property

    Public Property AlmTipoCagar1 As String
        Get
            Return almTipoCagar
        End Get
        Set(value As String)
            almTipoCagar = value
        End Set
    End Property

    Public Property AlmTipo1 As String
        Get
            Return almTipo
        End Get
        Set(value As String)
            almTipo = value
        End Set
    End Property

    Public Property AlmCiudad1 As String
        Get
            Return almCiudad
        End Get
        Set(value As String)
            almCiudad = value
        End Set
    End Property

    Public Property AlmTramoInicial1 As Double
        Get
            Return almTramoInicial
        End Get
        Set(value As Double)
            almTramoInicial = value
        End Set
    End Property

    Public Property AlmTramoFinal1 As Double
        Get
            Return almTramoFinal
        End Get
        Set(value As Double)
            almTramoFinal = value
        End Set
    End Property

    Public Property AlmPesomin1 As Double
        Get
            Return almPesomin
        End Get
        Set(value As Double)
            almPesomin = value
        End Set
    End Property

    Public Property AlmPesoMax1 As Double
        Get
            Return almPesoMax
        End Get
        Set(value As Double)
            almPesoMax = value
        End Set
    End Property

    Public Property AlmCostoFijo1 As Double
        Get
            Return almCostoFijo
        End Get
        Set(value As Double)
            almCostoFijo = value
        End Set
    End Property
End Class

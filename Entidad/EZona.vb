Public Class EZona
    Private zonCodigo As Integer
    Private zonPeso, zon1, zon2, zon3, zon4, zon5, zon6, zon7 As Double
    Private zonTipo, zonCiudad As String

    Public Sub New()
    End Sub

    Public Sub New(zonCodigo As Integer, zonPeso As Double, zon1 As Double, zon2 As Double, zon3 As Double, zon4 As Double, zon5 As Double, zon6 As Double, zon7 As Double, zonTipo As String, zonCiudad As String)
        Me.zonCodigo = zonCodigo
        Me.zonPeso = zonPeso
        Me.zon1 = zon1
        Me.zon2 = zon2
        Me.zon3 = zon3
        Me.zon4 = zon4
        Me.zon5 = zon5
        Me.zon6 = zon6
        Me.zon7 = zon7
        Me.zonTipo = zonTipo
        Me.zonCiudad = zonCiudad
    End Sub

    Public Property ZonCodigo1 As Integer
        Get
            Return zonCodigo
        End Get
        Set(value As Integer)
            zonCodigo = value
        End Set
    End Property

    Public Property ZonPeso1 As Double
        Get
            Return zonPeso
        End Get
        Set(value As Double)
            zonPeso = value
        End Set
    End Property

    Public Property Zon11 As Double
        Get
            Return zon1
        End Get
        Set(value As Double)
            zon1 = value
        End Set
    End Property

    Public Property Zon21 As Double
        Get
            Return zon2
        End Get
        Set(value As Double)
            zon2 = value
        End Set
    End Property

    Public Property Zon31 As Double
        Get
            Return zon3
        End Get
        Set(value As Double)
            zon3 = value
        End Set
    End Property

    Public Property Zon41 As Double
        Get
            Return zon4
        End Get
        Set(value As Double)
            zon4 = value
        End Set
    End Property

    Public Property Zon51 As Double
        Get
            Return zon5
        End Get
        Set(value As Double)
            zon5 = value
        End Set
    End Property

    Public Property Zon61 As Double
        Get
            Return zon6
        End Get
        Set(value As Double)
            zon6 = value
        End Set
    End Property

    Public Property Zon71 As Double
        Get
            Return zon7
        End Get
        Set(value As Double)
            zon7 = value
        End Set
    End Property

    Public Property ZonTipo1 As String
        Get
            Return zonTipo
        End Get
        Set(value As String)
            zonTipo = value
        End Set
    End Property

    Public Property ZonCiudad1 As String
        Get
            Return zonCiudad
        End Get
        Set(value As String)
            zonCiudad = value
        End Set
    End Property
End Class

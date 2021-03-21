Public Class EOtrosGastos
    Private otgaCodigo As Integer
    Private otgaTipo, otgaDescripcion As String
    Private otgaFijo, otgaPorcentaje, otgaPeso As Double

    Public Sub New()
    End Sub

    Public Sub New(otgaCodigo As Integer, otgaCobramos As Integer, otgaTipo As String, otgaDescripcion As String, otgaFijo As Double, otgaPorcentaje As Double, otgaPeso As Double)
        Me.otgaCodigo = otgaCodigo
        Me.otgaTipo = otgaTipo
        Me.otgaDescripcion = otgaDescripcion
        Me.otgaFijo = otgaFijo
        Me.otgaPorcentaje = otgaPorcentaje
        Me.otgaPeso = otgaPeso
    End Sub

    Public Property OtgaCodigo1 As Integer
        Get
            Return otgaCodigo
        End Get
        Set(value As Integer)
            otgaCodigo = value
        End Set
    End Property

    Public Property OtgaTipo1 As String
        Get
            Return otgaTipo
        End Get
        Set(value As String)
            otgaTipo = value
        End Set
    End Property

    Public Property OtgaDescripcion1 As String
        Get
            Return otgaDescripcion
        End Get
        Set(value As String)
            otgaDescripcion = value
        End Set
    End Property

    Public Property OtgaFijo1 As Double
        Get
            Return otgaFijo
        End Get
        Set(value As Double)
            otgaFijo = value
        End Set
    End Property

    Public Property OtgaPorcentaje1 As Double
        Get
            Return otgaPorcentaje
        End Get
        Set(value As Double)
            otgaPorcentaje = value
        End Set
    End Property

    Public Property OtgaPeso1 As Double
        Get
            Return otgaPeso
        End Get
        Set(value As Double)
            otgaPeso = value
        End Set
    End Property
End Class

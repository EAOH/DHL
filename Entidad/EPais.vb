Public Class EPais
    Private paiCodigo, paiZona As Integer
    Private paiNombre As String
    Private paiEw, paie12, paie9, paiImportar As Boolean

    Public Sub New()
    End Sub

    Public Sub New(paiCodigo As Integer, paiZona As Integer, paiNombre As String, paiEw As Boolean, paie12 As Boolean, paie9 As Boolean, paiImportar As Boolean)
        Me.paiCodigo = paiCodigo
        Me.paiZona = paiZona
        Me.paiNombre = paiNombre
        Me.paiEw = paiEw
        Me.paie12 = paie12
        Me.paie9 = paie9
        Me.paiImportar = paiImportar
    End Sub

    Public Property PaiCodigo1 As Integer
        Get
            Return paiCodigo
        End Get
        Set(value As Integer)
            paiCodigo = value
        End Set
    End Property

    Public Property PaiZona1 As Integer
        Get
            Return paiZona
        End Get
        Set(value As Integer)
            paiZona = value
        End Set
    End Property

    Public Property PaiNombre1 As String
        Get
            Return paiNombre
        End Get
        Set(value As String)
            paiNombre = value
        End Set
    End Property

    Public Property PaiEw1 As Boolean
        Get
            Return paiEw
        End Get
        Set(value As Boolean)
            paiEw = value
        End Set
    End Property

    Public Property Paie121 As Boolean
        Get
            Return paie12
        End Get
        Set(value As Boolean)
            paie12 = value
        End Set
    End Property

    Public Property Paie91 As Boolean
        Get
            Return paie9
        End Get
        Set(value As Boolean)
            paie9 = value
        End Set
    End Property

    Public Property PaiImportar1 As Boolean
        Get
            Return paiImportar
        End Get
        Set(value As Boolean)
            paiImportar = value
        End Set
    End Property
End Class

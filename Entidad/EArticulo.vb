Public Class EArticulo
    Private artCodigo As Integer
    Private artDescripcion, artEstado As String

    Public Sub New()
    End Sub

    Public Sub New(artCodigo As Integer, artDescripcion As String, artEstado As String)
        Me.artCodigo = artCodigo
        Me.artDescripcion = artDescripcion
        Me.artEstado = artEstado
    End Sub

    Public Property ArtCodigo1 As Integer
        Get
            Return artCodigo
        End Get
        Set(value As Integer)
            artCodigo = value
        End Set
    End Property

    Public Property ArtDescripcion1 As String
        Get
            Return artDescripcion
        End Get
        Set(value As String)
            artDescripcion = value
        End Set
    End Property

    Public Property ArtEstado1 As String
        Get
            Return artEstado
        End Get
        Set(value As String)
            artEstado = value
        End Set
    End Property
End Class

Public Class EServicioEnvio
    Private otgaCodigo, envCodigo As Integer

    Public Sub New()
    End Sub

    Public Sub New(otgaCodigo As Integer, envCodigo As Integer)

        Me.otgaCodigo = otgaCodigo
        Me.envCodigo = envCodigo
    End Sub

    Public Property OtgaCodigo1 As Integer
        Get
            Return otgaCodigo
        End Get
        Set(value As Integer)
            otgaCodigo = value
        End Set
    End Property

    Public Property EnvCodigo1 As Integer
        Get
            Return envCodigo
        End Get
        Set(value As Integer)
            envCodigo = value
        End Set
    End Property
End Class

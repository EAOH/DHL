Imports System.Data.SqlClient
Public Class Conexion
    Protected Conectar As New SqlConnection
    Protected Function ConexionBD() As Boolean
        Try
            Conectar = New SqlConnection("data source=" & Procesos.Direccion & ";initial catalog=dbDHL;integrated security=true")
            Conectar.Open()
            Return True
        Catch evento As SqlException
            If (Procesos.Direccion = ".") Then
                Procesos.Direccion = ".\SQLEXPRESS"
                ConexionBD()
            Else
                MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End Try
        Return Nothing
    End Function

    Protected Function desconectar() As Boolean
        Try
            If (Conectar.State = ConnectionState.Open) Then
                Conectar.Close()
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


End Class

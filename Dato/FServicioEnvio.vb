Imports System.Data.SqlClient
Public Class FServicioEnvio
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar(Entidad As EServicioEnvio) As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sServiciosEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@envCodigo", Entidad.EnvCodigo1)
            If (comandos.ExecuteNonQuery) Then
                Dim tabla As New DataTable
                Dim adactador As New SqlDataAdapter(comandos)
                adactador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If

        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    'Insertar
    Public Function Insertar(tabla As EServicioEnvio) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iServicioEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@otgaCodigo", tabla.OtgaCodigo1)
            comandos.Parameters.AddWithValue("@envCodigo", tabla.EnvCodigo1)
            If (comandos.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconectar()

        End Try

    End Function
    'Eliminar
    Public Function Eliminar(tabla As EServicioEnvio) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eServicioEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@otgaCodigo", tabla.OtgaCodigo1)
            comandos.Parameters.AddWithValue("@envCodigo", tabla.EnvCodigo1)
            If (comandos.ExecuteNonQuery) Then
                Return True
            Else
                Return False
            End If
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconectar()

        End Try

    End Function
End Class

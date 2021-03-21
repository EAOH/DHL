Imports System.Data.SqlClient
Public Class FZona
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sZona")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
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
    Public Function Insertar(tabla As EZona) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iZona")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@zonPesoKG", tabla.ZonPeso1)
            comandos.Parameters.AddWithValue("@zon1", tabla.Zon11)
            comandos.Parameters.AddWithValue("@zon2", tabla.Zon21)
            comandos.Parameters.AddWithValue("@zon3", tabla.Zon31)
            comandos.Parameters.AddWithValue("@zon4", tabla.Zon41)
            comandos.Parameters.AddWithValue("@zon5", tabla.Zon51)
            comandos.Parameters.AddWithValue("@zon6", tabla.Zon61)
            comandos.Parameters.AddWithValue("@zon7", tabla.Zon71)
            comandos.Parameters.AddWithValue("@zonTipo", tabla.ZonTipo1)
            comandos.Parameters.AddWithValue("@zonCiudad", tabla.ZonCiudad1)
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

    'Actualizar
    Public Function Actualizar(tabla As EZona) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aZona")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@zonCodigo", tabla.ZonCodigo1)
            comandos.Parameters.AddWithValue("@zonPesoKG", tabla.ZonPeso1)
            comandos.Parameters.AddWithValue("@zon1", tabla.Zon11)
            comandos.Parameters.AddWithValue("@zon2", tabla.Zon21)
            comandos.Parameters.AddWithValue("@zon3", tabla.Zon31)
            comandos.Parameters.AddWithValue("@zon4", tabla.Zon41)
            comandos.Parameters.AddWithValue("@zon5", tabla.Zon51)
            comandos.Parameters.AddWithValue("@zon6", tabla.Zon61)
            comandos.Parameters.AddWithValue("@zon7", tabla.Zon71)
            comandos.Parameters.AddWithValue("@zonTipo", tabla.ZonTipo1)
            comandos.Parameters.AddWithValue("@zonCiudad", tabla.ZonCiudad1)
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
    Public Function Eliminar(tabla As EZona) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eZona")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@zonCodigo", tabla.ZonCodigo1)
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

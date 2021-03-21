Imports System.Data.SqlClient
Public Class FEnvios
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sEnvio")
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
    Public Function Insertar(tabla As EEnvios) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@envTipoServicio", tabla.EnvTipoServicio1)
            comandos.Parameters.AddWithValue("@envTipoPago", tabla.EnvTipoPago1)
            comandos.Parameters.AddWithValue("@envDescripcion", tabla.EnvDescripcion1)
            comandos.Parameters.AddWithValue("@envPesoKG", tabla.EnvPesoKG1)
            comandos.Parameters.AddWithValue("@envDimenciones", tabla.EnvDimenciones1)
            comandos.Parameters.AddWithValue("@envDiasAlmacenados", tabla.EnvDiasAlmacenados1)
            comandos.Parameters.AddWithValue("@cliCodigoE", tabla.CliCodigoE1)
            comandos.Parameters.AddWithValue("@cliCodigoR", tabla.CliCodigoR1)
            comandos.Parameters.AddWithValue("@empCodigo", tabla.EmpCodigo1)
            comandos.Parameters.AddWithValue("@paiCodigoD", tabla.PaiCodigoD1)
            comandos.Parameters.AddWithValue("@zonCodigo", tabla.ZonCodigo1)
            comandos.Parameters.AddWithValue("@almCodigo", tabla.AlmCodigo1)
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
    Public Function Actualizar(tabla As EEnvios) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@envCodigo", tabla.EnvCodigo1)
            comandos.Parameters.AddWithValue("@envTipoServicio", tabla.EnvTipoServicio1)
            comandos.Parameters.AddWithValue("@envTipoPago", tabla.EnvTipoPago1)
            comandos.Parameters.AddWithValue("@envDescripcion", tabla.EnvDescripcion1)
            comandos.Parameters.AddWithValue("@envPesoKG", tabla.EnvPesoKG1)
            comandos.Parameters.AddWithValue("@envDimenciones", tabla.EnvDimenciones1)
            comandos.Parameters.AddWithValue("@envDiasAlmacenados", tabla.EnvDiasAlmacenados1)
            comandos.Parameters.AddWithValue("@cliCodigoE", tabla.CliCodigoE1)
            comandos.Parameters.AddWithValue("@cliCodigoR", tabla.CliCodigoR1)
            comandos.Parameters.AddWithValue("@empCodigo", tabla.EmpCodigo1)
            comandos.Parameters.AddWithValue("@paiCodigoD", tabla.PaiCodigoD1)
            comandos.Parameters.AddWithValue("@zonCodigo", tabla.ZonCodigo1)
            comandos.Parameters.AddWithValue("@almCodigo", tabla.AlmCodigo1)
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
    Public Function Eliminar(tabla As EEnvios) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
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

    Public Sub EliminarTodo(tabla As EEnvios)
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eEnvioServicioEnvio")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@envCodigo", tabla.EnvCodigo1)
            comandos.ExecuteNonQuery()
        Catch evento As SqlException
            MsgBox(evento.Message, MsgBoxStyle.Critical, "Error")
        Finally
            desconectar()
        End Try

    End Sub
End Class

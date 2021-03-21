Imports System.Data.SqlClient
Public Class FCliente
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sCliente")
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
    Public Function Insertar(tabla As ECliente) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iCliente")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@cliNombre", tabla.CliNombre1)
            comandos.Parameters.AddWithValue("@cliApellido", tabla.CliApellido1)
            comandos.Parameters.AddWithValue("@cliIdentidad", tabla.CliIdentidad1)
            comandos.Parameters.AddWithValue("@cliTelefono", tabla.CliTelefono1)
            comandos.Parameters.AddWithValue("@cliCorreo", tabla.CliCorreo1)
            comandos.Parameters.AddWithValue("@cliDireccion", tabla.CliDireccion1)
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
    Public Function Actualizar(tabla As ECliente) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aCliente")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@cliCodigo", tabla.CliCodigo1)
            comandos.Parameters.AddWithValue("@cliNombre", tabla.CliNombre1)
            comandos.Parameters.AddWithValue("@cliApellido", tabla.CliApellido1)
            comandos.Parameters.AddWithValue("@cliIdentidad", tabla.CliIdentidad1)
            comandos.Parameters.AddWithValue("@cliTelefono", tabla.CliTelefono1)
            comandos.Parameters.AddWithValue("@cliCorreo", tabla.CliCorreo1)
            comandos.Parameters.AddWithValue("@cliDireccion", tabla.CliDireccion1)

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
    Public Function Eliminar(tabla As ECliente) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eCliente")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@cliCodigo", tabla.CliCodigo1)

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

Imports System.Data.SqlClient
Public Class FPais
    Inherits Conexion
    Dim comandos As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_sPais")
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
    Public Function Insertar(tabla As EPais) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iPais")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@paiNombre", tabla.PaiNombre1)
            comandos.Parameters.AddWithValue("@paiZona", tabla.PaiZona1)
            comandos.Parameters.AddWithValue("@paiEW", tabla.PaiEw1)
            comandos.Parameters.AddWithValue("@paie12", tabla.Paie121)
            comandos.Parameters.AddWithValue("@paie9", tabla.Paie91)
            comandos.Parameters.AddWithValue("@paiImportar", tabla.PaiImportar1)
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
    Public Function Actualizar(tabla As EPais) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aPais")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@paiCodigo", tabla.PaiCodigo1)
            comandos.Parameters.AddWithValue("@paiNombre", tabla.PaiNombre1)
            comandos.Parameters.AddWithValue("@paiZona", tabla.PaiZona1)
            comandos.Parameters.AddWithValue("@paiEW", tabla.PaiEw1)
            comandos.Parameters.AddWithValue("@paie12", tabla.Paie121)
            comandos.Parameters.AddWithValue("@paie9", tabla.Paie91)
            comandos.Parameters.AddWithValue("@paiImportar", tabla.PaiImportar1)

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
    Public Function Eliminar(tabla As EPais) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_ePais")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@paiCodigo", tabla.PaiCodigo1)

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

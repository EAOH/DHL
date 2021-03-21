Imports System.Data.SqlClient
Public Class FArticulo
    Inherits Conexion
    Dim comandos As New SqlCommand

    'Mostrar
    Public Function Mostrar() As DataTable
        Try
            'Conectar
            ConexionBD()
            'Proceso almacenado
            comandos = New SqlCommand("SP_sArticulos")
            'dictando la ejecucion del proceso almacenado
            comandos.CommandType = CommandType.StoredProcedure
            'conectar con base de datos
            comandos.Connection = Conectar
            'Verificar que pudo ejecutar el proceso
            If (comandos.ExecuteNonQuery) Then
                'Declacarion de data table y sqldata adapter para tranferir los datos
                Dim tabla As New DataTable
                Dim adactador As New SqlDataAdapter(comandos)
                'Dasladando los datos de la BD a tabla 
                adactador.Fill(tabla)
                'Retornar tabla
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
    Public Function Insertar(tabla As EArticulo) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_iArticulos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@artDescripcion", tabla.ArtDescripcion1)
            comandos.Parameters.AddWithValue("@artEstado", tabla.ArtEstado1)
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
    Public Function Actualizar(tabla As EArticulo) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_aArticulos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@artCodigo", tabla.ArtCodigo1)
            comandos.Parameters.AddWithValue("@artDescripcion", tabla.ArtDescripcion1)
            comandos.Parameters.AddWithValue("@artEstado", tabla.ArtEstado1)

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
    Public Function Eliminar(tabla As EArticulo) As Boolean
        Try
            ConexionBD()
            comandos = New SqlCommand("SP_eArticulos")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = Conectar
            comandos.Parameters.AddWithValue("@artCodigo", tabla.ArtCodigo1)

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

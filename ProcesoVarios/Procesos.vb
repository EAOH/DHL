Module Procesos
    Public Direccion As String = "."

    Public Function ValidarDouble(Caracter As Char, Texto As String) As Double
        Dim VF As Boolean 'Booleano
        'Inicio de la primera validacion
        If (Char.IsDigit(Caracter) Or Char.IsControl(Caracter) Or Caracter = ".") Then
            'Inicio de la segunda validacion
            If (Texto = "" And Caracter = ".") Then
                VF = True
                MsgBox("No puede ingresar un punto decimal si no ha ingresado un numero primero", MsgBoxStyle.Information, "Orden")
            Else
                VF = False
            End If
            '   Fin de la segunda validacion
        Else
            VF = True
            MsgBox("El dato que ingreso no coresponde al tipo de dato necesario", MsgBoxStyle.Information, "Solo numeros")
        End If
        'Fin de la primer validacion
        'Inicio de la tercera validacion
        If (Texto.Length > 1 And Caracter = ".") Then
            For index = 0 To Texto.Length - 1
                If (Texto.Chars(index) = Caracter) Then
                    VF = True
                    MsgBox("No puede ingresar 2 puntos en este campo", MsgBoxStyle.Information, "Solo un punto")
                End If
            Next
        End If
        'Fin de la tercera validacion
        'Retorno del booleano
        Return VF
    End Function

    Public Function Textopunto(texto As String) As String
        If (texto <> "") Then
            'Primera validacion
            If (texto.Chars(0) = ".") Then
                texto = 0 & texto
            End If
            'Segunda validacion
            If (texto.Chars(texto.Length - 1) = ".") Then
                texto = texto & 0
            End If
        Else
        End If
        Return texto
    End Function

    Public Function ValidarString(Caracter As Char) As Double
        Dim VF As Boolean
        If (Char.IsControl(Caracter) Or Char.IsLetter(Caracter) Or Caracter = " ") Then
            VF = False
        Else
            VF = True
            MsgBox("El dato que esta tratando de ingresar no coresponde al tipo de dato solicitado", MsgBoxStyle.Information, "Solo letras")
        End If
        Return VF
    End Function

    Public Function ValidarInteger(caracter As Char) As Boolean
        Dim VF As Boolean
        If (Char.IsControl(caracter) Or Char.IsDigit(caracter)) Then
            VF = False
        Else
            VF = True
            MsgBox("Lo que esta tratando de ingresar no es acorde al dato solicitado", MsgBoxStyle.Information, "Solo numeros")
        End If
        Return VF
    End Function
End Module

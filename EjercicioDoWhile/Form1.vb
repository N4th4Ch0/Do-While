Public Class Form1

    Private Sub btnEjecuta_Click(sender As Object, e As EventArgs) Handles btnEjecuta.Click


        Dim numero As Integer
        numero = txtNum.Text

        If numero >= 1 And numero <= 5 Then

            Do
                Select Case numero

                    Case 1

                        MessageBox.Show("Texto aleatorio 1")

                    Case 2

                        MessageBox.Show("Buenas Noches")

                    Case 3

                        MessageBox.Show("Hola cara de cola")

                    Case 4

                        MessageBox.Show("T amo mas que ayer")

                    Case 5

                        MessageBox.Show("¡Programa cerrado!")
                        Me.Close()

                    Case Else

                        MessageBox.Show("Error número no válido. Inténtalo de nuevo.")

                End Select

            Loop While numero < 1 Or numero > 5

        Else

            MessageBox.Show("ERROR, EL DATO INGRESADO ES INCORRECTO")

        End If

        txtNum.Text = ""
        txtNum.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Ingrese un numero del 1 al 5")

    End Sub
End Class

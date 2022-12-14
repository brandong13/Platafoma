Public Class login_aspirantes
    Private Sub generar_ficha_Click(sender As Object, e As EventArgs) Handles generar_ficha.Click
        registro_aspirantes.Show()

    End Sub

    Private Sub sesion_asp_Click(sender As Object, e As EventArgs) Handles sesion_asp.Click
        Try
            If Aspirante(no_solicitud.Text) = True Then
                Dim contrase As String = aspirante_contra(contraseña_asp.Text)
                If contrase.Equals(contraseña_asp.Text) = True Then
                    'se manda a llamar el siguiente formulario
                    Menu_aspirante.ShowDialog()
                    Me.Close()
                    no_solicitud.Text = ""
                    contraseña_asp.Text = ""
                Else
                    MsgBox("Contraseña Invalida")
                    no_solicitud.Text = ""
                    'contraseña_alum.Text = ""
                End If
            Else
                MsgBox("El Usuario: " + no_solicitud.Text + " no se encuentra registrado")
                no_solicitud.Text = ""
                contraseña_asp.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub login_aspirantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirLogin()
    End Sub
End Class
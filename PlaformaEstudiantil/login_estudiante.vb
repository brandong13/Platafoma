Public Class login_estudiante
    Private Sub login_estudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirLogin()
        'no_control.Text = ""
        'contraseña_alum.Text = ""
        'Sesion.Enabled = False
    End Sub

    Private Sub Sesion_Click(sender As Object, e As EventArgs) Handles Sesion.Click
        Try
            If alumno(no_control.Text) = True Then
                Dim contra As String = alumno_contra(contraseña_alum.Text)
                If contra.Equals(contraseña_alum.Text) = True Then
                    'se manda a llamar el siguiente formulario
                    Menu_estudiante.ShowDialog()
                    Me.Close()
                    no_control.Text = ""
                    contraseña_alum.Text = ""
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                    no_control.Text = ""
                    'contraseña_alum.Text = ""
                End If
            Else
                MsgBox("El Usuario: " + no_control.Text + " no se encuentra registrado")
                no_control.Text = ""
                contraseña_alum.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub no_control_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar números")
        End If
    End Sub

End Class
Public Class registro_aspirantes



    Private Sub registro_aspirantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlataformaDataSetAsp.Aspirantes'. 
        Me.AspirantesTableAdapter.Fill(Me.PlataformaDataSetAsp.Aspirantes)
        abrirLogin()
        llenarComboBoxEspecialidad(especialidad_asp)
        llenarComboBoxGenero(genero_asp)
        Dim obj As New BaseDeDatos
        no_control_asp.Text = obj.generarCodigo()
    End Sub

    Private Sub registro_asp_Click(sender As Object, e As EventArgs) Handles registro_asp.Click
        Try
            Me.AspirantesTableAdapter.registrar_asp(no_control_asp.Text, nombre_asp.Text, paterno_asp.Text, materno_asp.Text, genero_asp.Text, direccion_asp.Text, telefono_asp.Text, correo_asp.Text, date_asp.Text, contraseña_asp.Text, especialidad_asp.Text)
            Me.AspirantesTableAdapter.Fill(Me.PlataformaDataSetAsp.Aspirantes)
            'If no_control_asp.Text.Equals("") = False And nombre_asp.Text.Equals("") = False And paterno_asp.Text.Equals("") = False And materno_asp.Text.Equals("") = False And genero_asp.Text.Equals("") = False And direccion_asp.Text.Equals("") = False And telefono_asp.Text.Equals("") = False And correo_asp.Text.Equals("") = False And contraseña_asp.Text.Equals("") = False And especialidad_asp.Text.Equals("") = False Then
            'End If
            MsgBox("Se agrego nuevo registro ")
            no_control_asp.Text = ""
            nombre_asp.Text = ""
            paterno_asp.Text = ""
            materno_asp.Text = ""
            genero_asp.Text = ""
            direccion_asp.Text = ""
            telefono_asp.Text = ""
            correo_asp.Text = ""
            date_asp.Text = ""
            contraseña_asp.Text = ""
            especialidad_asp.Text = ""

        Catch ex As Exception
            MsgBox("Completar los campos faltantes")
        End Try
    End Sub

    Private Sub telefono_asp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefono_asp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MsgBox("Solo puede digitar números")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_aspirantes.Show()
        'Me.Close()
    End Sub

End Class
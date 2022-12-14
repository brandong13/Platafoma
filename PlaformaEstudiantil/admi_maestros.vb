Public Class admi_maestros
    Private Sub admi_maestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirLogin()
        llenarComboBoxMaterias(id_materia1)
        llenarComboBoxMaterias(id_materia2)
        llenarComboBoxMaterias(id_materia3)
        llenarComboBoxHorario(horario1)
        llenarComboBoxHorario(horario2)
        llenarComboBoxHorario(horario3)
    End Sub

End Class
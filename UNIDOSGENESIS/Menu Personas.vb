Public Class Menu_Personas
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        My.Forms.Menu_Personas.Close()
        My.Forms.Ingresar_Persona.Show()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        My.Forms.Menu_Personas.Close()
        My.Forms.Modificar_datosde_persona.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        My.Forms.Menu_Personas.Close()

        My.Forms.Eliminar_Personas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        My.Forms.Menu_Personas.Close()
        My.Forms.menua.Show()
    End Sub
End Class
Public Class Eliminar_Personas
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Eliminar_Personas.Close()

        My.Forms.Menu_Personas.Show()
    End Sub
End Class
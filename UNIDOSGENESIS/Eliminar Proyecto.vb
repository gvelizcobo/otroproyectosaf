Public Class Eliminar_Proyecto
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Eliminar_Proyecto.Close()
        My.Forms.Menu_Proyectos.Show()
    End Sub
End Class
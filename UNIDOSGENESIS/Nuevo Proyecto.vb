Public Class Nuevo_Proyecto
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Nuevo_Proyecto.Close()
        My.Forms.Menu_Proyectos.Show()
    End Sub
End Class
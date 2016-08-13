Public Class Modificar_Proyecto
    Private Sub btnmvolver_Click(sender As Object, e As EventArgs) Handles btnmvolver.Click
        My.Forms.Modificar_Proyecto.Close()
        My.Forms.Menu_Proyectos.Show()
    End Sub
End Class
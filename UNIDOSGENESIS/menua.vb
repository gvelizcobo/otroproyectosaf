Public Class menua
    Private Sub btnfinanzas_Click(sender As Object, e As EventArgs) Handles btnfinanzas.Click
        My.Forms.menua.Close()
        My.Forms.Finanzas.Show()
    End Sub

    Private Sub btnpersonas_Click(sender As Object, e As EventArgs) Handles btnpersonas.Click
        My.Forms.menua.Close()
        My.Forms.Menu_Personas.Show()
    End Sub

    Private Sub btnmovimientos_Click(sender As Object, e As EventArgs) Handles btnmovimientos.Click
        My.Forms.menua.Close()
        My.Forms.Menu_Movimientos.Show()
    End Sub

    Private Sub btnproyectos_Click(sender As Object, e As EventArgs) Handles btnproyectos.Click
        My.Forms.menua.Close()
        My.Forms.Menu_Proyectos.Show()
    End Sub

    Private Sub btndepartamentos_Click(sender As Object, e As EventArgs) Handles btndepartamentos.Click
        My.Forms.menua.Close()
        My.Forms.Menu_Departamento.Show()
    End Sub

    Private Sub btncerrarsecion_Click(sender As Object, e As EventArgs) Handles btncerrarsecion.Click
        My.Forms.menua.Close()
        My.Forms.login.Show()
        Application.Restart()
    End Sub
End Class
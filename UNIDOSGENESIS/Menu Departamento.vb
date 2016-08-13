Public Class Menu_Departamento
    Private Sub btnnvodpto_Click(sender As Object, e As EventArgs) Handles btnnvodpto.Click
        My.Forms.Menu_Departamento.Close()
        My.Forms.Nuevo_Departamento.Show()
    End Sub

    Private Sub btnmdpto_Click(sender As Object, e As EventArgs) Handles btnmdpto.Click
        My.Forms.Nuevo_Proyecto.Close()
        
    End Sub
End Class
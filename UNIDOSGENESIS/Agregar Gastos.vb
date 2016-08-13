Public Class Agregar_Gastos
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        My.Forms.Agregar_Gastos.Close()
        My.Forms.Gastos.Show()
    End Sub
End Class
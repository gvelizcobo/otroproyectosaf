Public Class Gastos
    Private Sub btnagregarg_Click(sender As Object, e As EventArgs) Handles btnagregarg.Click
        My.Forms.Gastos.Close()
        My.Forms.Agregar_Gastos.Show()
    End Sub

    Private Sub btnsalirg_Click(sender As Object, e As EventArgs) Handles btnsalirg.Click
        My.Forms.Gastos.Close()
        My.Forms.Menu_Movimientos.Show()
    End Sub
End Class
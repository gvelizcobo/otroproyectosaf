Public Class Menu_Movimientos
    Private Sub btningresos_Click(sender As Object, e As EventArgs) Handles btningresos.Click
        My.Forms.Menu_Movimientos.Close()
        My.Forms.Ingresos.Show()
    End Sub

    Private Sub btngastos_Click(sender As Object, e As EventArgs) Handles btnsaldo.Click
        My.Forms.Menu_Movimientos.Close()
        My.Forms.Saldo.Show()
    End Sub

    Private Sub btnsaldos_Click(sender As Object, e As EventArgs) Handles btngastos.Click
        My.Forms.Menu_Movimientos.Close()
        My.Forms.Gastos.Show()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        My.Forms.Menu_Movimientos.Close()
        My.Forms.menua.Show()
    End Sub
End Class
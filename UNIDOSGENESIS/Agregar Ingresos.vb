Public Class Agregar_Ingresos
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha.ValueChanged

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        My.Forms.Agregar_Ingresos.Close()
        My.Forms.Ingresos.Show()
    End Sub
End Class
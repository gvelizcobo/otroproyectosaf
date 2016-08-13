Imports System.Data.SqlClient

Public Class Ingresos
    Private Sub btnagregari_Click(sender As Object, e As EventArgs) Handles btnagregari.Click
        My.Forms.Ingresos.Close()
        My.Forms.Agregar_Ingresos.Show()
    End Sub

    Private Sub btnsaliri_Click(sender As Object, e As EventArgs) Handles btnsaliri.Click
        My.Forms.Ingresos.Close()
        My.Forms.Menu_Movimientos.Show()
    End Sub

    Private Sub Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet1.MOVIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.MOVIMIENTOTableAdapter.Fill(Me.UNIDOSDataSet1.MOVIMIENTO)

    End Sub
    Private Sub btneliminari_Click(sender As Object, e As EventArgs) Handles btneliminari.Click
        Dim SqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
        SqlConn.Open()
        Dim IngresosTableAdapter As New SqlDataAdapter
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            eliminarfilas(dgvingresos.CurrentRow.Cells(0).Value)
        End If
        IngresosTableAdapter.Fill(Me.IngresosDataSet.ingresos)
    End Sub

    Private Function IngresosDataSet() As Object
        Throw New NotImplementedException()
    End Function
    Private Sub eliminarfilas(value As Object)
        Dim laConnection As New SqlConnection
        laConnection.Open()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
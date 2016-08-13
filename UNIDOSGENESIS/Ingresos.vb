Imports System.Data.SqlClient

Public Class Ingresos
    Private txtmovimien As Object
    Private txtmovimientoi As Object

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
        Dim sqlcmd As New SqlCommand

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader

        Dim r As Boolean = reader.HasRows()
        If r = True Then
            sqlcmd.Connection = SqlConn
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "eliminarmovimiento"
            sqlcmd.Parameters.Add(New SqlParameter("@movimientoid", SqlDbType.VarChar, 50)).Value = dgvingresos.Text

            Dim readerr As SqlDataReader = sqlcmd.ExecuteReader()
        End If
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            End If
    End Sub



    Try
            laConnection.Open()
            Dim objetolector As SqlDataReader = elcmd.ExecuteReader()
            MessageBox.Show("Registro eliminado exitosamente", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            objetolector.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            laConnection.Close()

        End Try
    End Sub
End Class
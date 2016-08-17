Imports System.Data.SqlClient
Public Class Movimientos
    Dim fv As New SqlConnection(My.Settings.UNIDOSConnectionString)

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet3.MOVIMIENTO' Puede moverla o quitarla según sea necesario.
        Me.MOVIMIENTOTableAdapter1.Fill(Me.UNIDOSDataSet3.MOVIMIENTO)
        mostrar()

    End Sub
    Sub mostrar()

    End Sub

    Private Sub btnmsaldo_Click(sender As Object, e As EventArgs) Handles btnmsaldo.Click
        My.Forms.Movimientos.Close()
        My.Forms.Saldo.Show()
    End Sub

    Private Sub btnmsalir_Click(sender As Object, e As EventArgs) Handles btnmsalir.Click
        My.Forms.Movimientos.Close()
        My.Forms.menua.Show()
    End Sub

    Private Sub btnmagregar_Click(sender As Object, e As EventArgs) Handles btnmagregar.Click
        Try


            If String.IsNullOrEmpty(txtmovimiento.Text) Or String.IsNullOrEmpty(cbmtipo.Text) Or String.IsNullOrEmpty(cbmsubtipo.Text) Or
                String.IsNullOrEmpty(dtpfecha.Text) Or String.IsNullOrEmpty(txtdetalle.Text) Or String.IsNullOrEmpty(txtmonto.Text) Then

                MessageBox.Show("Favor llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "Verificartransaccion"

                sqlcmd.Parameters.Add(New SqlParameter("@Parameter1", SqlDbType.VarChar, 50)).Value = txtmovimiento.Text


                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("Su transaccion ya ha sido registrada ")

                    txtmovimiento.Text = ""
                    cbmtipo.Text = ""
                    cbmsubtipo.Text = ""
                    dtpfecha.Text = ""
                    txtdetalle.Text = ""
                    txtmonto.Text = ""


                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "INGRESOMOVIMIENTO"
                    sqlcmdd.Parameters.Add(New SqlParameter("@movimiento", SqlDbType.VarChar, 50)).Value = txtmovimiento.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cbmtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@subtipo", SqlDbType.VarChar, 50)).Value = cbmsubtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@fecha", SqlDbType.Date)).Value = dtpfecha.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@detalle", SqlDbType.VarChar, 50)).Value = txtdetalle.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@monto", SqlDbType.Int)).Value = txtmonto.Text



                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("La transaccion fue registrado de manera exitosa")

                    txtmovimiento.Text = ""
                    cbmtipo.Text = ""
                    cbmsubtipo.Text = ""
                    dtpfecha.Text = ""
                    txtdetalle.Text = ""
                    txtmonto.Text = ""

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub btnmeliminar_Click(sender As Object, e As EventArgs) Handles btnmeliminar.Click

    End Sub

    Private Sub btnmbuscar_Click(sender As Object, e As EventArgs) Handles btnmbuscar.Click




    End Sub
End Class
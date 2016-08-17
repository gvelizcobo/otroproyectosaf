Imports System.Data.SqlClient
Public Class Eliminar_Personas
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Eliminar_Personas.Close()
        My.Forms.Menu_Personas.Show()
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
        sqlConn.Open()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "validar_cedula1"
        sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.VarChar, 50)).Value = txtced.Text

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader

        Dim r As Boolean = reader.HasRows()
        If r = True Then
            Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            connexion.Open()

            Dim sqlcmdd As New SqlCommand
            sqlcmdd.Connection = connexion
            sqlcmdd.CommandType = CommandType.StoredProcedure
            sqlcmdd.CommandText = "eliminarusuario"
            sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.VarChar, 50)).Value = txtced.Text

            Dim readerr As SqlDataReader = sqlcmd.ExecuteReader()

            MsgBox("Usuario Eliminado")
        Else

            MsgBox("Usuario no Encontrado")
        End If



    End Sub
End Class
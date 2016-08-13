Imports System.Data.SqlClient
Public Class login
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
        sqlConn.Open()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "consultarusuario"
        sqlcmd.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.VarChar, 50)).Value = txtusuario.Text
        sqlcmd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.VarChar, 50)).Value = txtcedula.Text

        Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                If Trim(reader.GetString(3)) = "Voluntario" Then
                    Me.Hide()
                    menuv.Show()
                ElseIf Trim(reader.GetString(3)) = "Responsable" Then
                    Me.Hide()
                    menua.Show()
                End If

            Loop
        Else
            MsgBox("Verificar usuario", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
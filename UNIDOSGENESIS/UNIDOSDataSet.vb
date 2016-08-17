Partial Class UNIDOSDataSet
    Partial Public Class MOVIMIENTODataTable
        Private Sub MOVIMIENTODataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Forma_de_pagoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub MOVIMIENTODataTable_MOVIMIENTORowChanging(sender As Object, e As MOVIMIENTORowChangeEvent) Handles Me.MOVIMIENTORowChanging

        End Sub

    End Class
End Class

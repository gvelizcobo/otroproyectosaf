<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Departamento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btneliminardpto = New System.Windows.Forms.Button()
        Me.btnmdpto = New System.Windows.Forms.Button()
        Me.btnnvodpto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(60, 187)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(164, 23)
        Me.btnvolver.TabIndex = 7
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btneliminardpto
        '
        Me.btneliminardpto.Location = New System.Drawing.Point(60, 141)
        Me.btneliminardpto.Name = "btneliminardpto"
        Me.btneliminardpto.Size = New System.Drawing.Size(164, 23)
        Me.btneliminardpto.TabIndex = 6
        Me.btneliminardpto.Text = "Eliminar departamento"
        Me.btneliminardpto.UseVisualStyleBackColor = True
        '
        'btnmdpto
        '
        Me.btnmdpto.Location = New System.Drawing.Point(60, 94)
        Me.btnmdpto.Name = "btnmdpto"
        Me.btnmdpto.Size = New System.Drawing.Size(164, 23)
        Me.btnmdpto.TabIndex = 5
        Me.btnmdpto.Text = "Modificar datos departamento"
        Me.btnmdpto.UseVisualStyleBackColor = True
        '
        'btnnvodpto
        '
        Me.btnnvodpto.Location = New System.Drawing.Point(60, 51)
        Me.btnnvodpto.Name = "btnnvodpto"
        Me.btnnvodpto.Size = New System.Drawing.Size(164, 23)
        Me.btnnvodpto.TabIndex = 4
        Me.btnnvodpto.Text = "Nuevo departamento"
        Me.btnnvodpto.UseVisualStyleBackColor = True
        '
        'Menu_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminardpto)
        Me.Controls.Add(Me.btnmdpto)
        Me.Controls.Add(Me.btnnvodpto)
        Me.Name = "Menu_Departamento"
        Me.Text = "Menu_Departamento"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents btneliminardpto As Button
    Friend WithEvents btnmdpto As Button
    Friend WithEvents btnnvodpto As Button
End Class

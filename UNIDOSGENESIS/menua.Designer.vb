<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menua
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
        Me.btnpersonas = New System.Windows.Forms.Button()
        Me.btnfinanzas = New System.Windows.Forms.Button()
        Me.btndepartamentos = New System.Windows.Forms.Button()
        Me.btnmovimientos = New System.Windows.Forms.Button()
        Me.btnproyectos = New System.Windows.Forms.Button()
        Me.btncerrarsecion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpersonas
        '
        Me.btnpersonas.Location = New System.Drawing.Point(139, 51)
        Me.btnpersonas.Name = "btnpersonas"
        Me.btnpersonas.Size = New System.Drawing.Size(75, 23)
        Me.btnpersonas.TabIndex = 0
        Me.btnpersonas.Text = "Personas"
        Me.btnpersonas.UseVisualStyleBackColor = True
        '
        'btnfinanzas
        '
        Me.btnfinanzas.Location = New System.Drawing.Point(139, 103)
        Me.btnfinanzas.Name = "btnfinanzas"
        Me.btnfinanzas.Size = New System.Drawing.Size(75, 23)
        Me.btnfinanzas.TabIndex = 1
        Me.btnfinanzas.Text = "Finanzas"
        Me.btnfinanzas.UseVisualStyleBackColor = True
        '
        'btndepartamentos
        '
        Me.btndepartamentos.Location = New System.Drawing.Point(139, 152)
        Me.btndepartamentos.Name = "btndepartamentos"
        Me.btndepartamentos.Size = New System.Drawing.Size(95, 23)
        Me.btndepartamentos.TabIndex = 2
        Me.btndepartamentos.Text = "Departamentos"
        Me.btndepartamentos.UseVisualStyleBackColor = True
        '
        'btnmovimientos
        '
        Me.btnmovimientos.Location = New System.Drawing.Point(271, 51)
        Me.btnmovimientos.Name = "btnmovimientos"
        Me.btnmovimientos.Size = New System.Drawing.Size(75, 23)
        Me.btnmovimientos.TabIndex = 3
        Me.btnmovimientos.Text = "Movimientos"
        Me.btnmovimientos.UseVisualStyleBackColor = True
        '
        'btnproyectos
        '
        Me.btnproyectos.Location = New System.Drawing.Point(271, 103)
        Me.btnproyectos.Name = "btnproyectos"
        Me.btnproyectos.Size = New System.Drawing.Size(75, 23)
        Me.btnproyectos.TabIndex = 4
        Me.btnproyectos.Text = "Proyectos"
        Me.btnproyectos.UseVisualStyleBackColor = True
        '
        'btncerrarsecion
        '
        Me.btncerrarsecion.Location = New System.Drawing.Point(271, 152)
        Me.btncerrarsecion.Name = "btncerrarsecion"
        Me.btncerrarsecion.Size = New System.Drawing.Size(100, 23)
        Me.btncerrarsecion.TabIndex = 5
        Me.btncerrarsecion.Text = "Cerrar Sesion"
        Me.btncerrarsecion.UseVisualStyleBackColor = True
        '
        'menua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 210)
        Me.Controls.Add(Me.btncerrarsecion)
        Me.Controls.Add(Me.btnproyectos)
        Me.Controls.Add(Me.btnmovimientos)
        Me.Controls.Add(Me.btndepartamentos)
        Me.Controls.Add(Me.btnfinanzas)
        Me.Controls.Add(Me.btnpersonas)
        Me.Name = "menua"
        Me.Text = "menua"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpersonas As Button
    Friend WithEvents btnfinanzas As Button
    Friend WithEvents btndepartamentos As Button
    Friend WithEvents btnmovimientos As Button
    Friend WithEvents btnproyectos As Button
    Friend WithEvents btncerrarsecion As Button
End Class

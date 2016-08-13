<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Proyectos
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
        Me.btneliminarproyecto = New System.Windows.Forms.Button()
        Me.btnmodificarproyecto = New System.Windows.Forms.Button()
        Me.btnnuevoproyecto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(82, 189)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(120, 23)
        Me.btnvolver.TabIndex = 7
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btneliminarproyecto
        '
        Me.btneliminarproyecto.Location = New System.Drawing.Point(82, 141)
        Me.btneliminarproyecto.Name = "btneliminarproyecto"
        Me.btneliminarproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btneliminarproyecto.TabIndex = 6
        Me.btneliminarproyecto.Text = "Eliminar proyecto"
        Me.btneliminarproyecto.UseVisualStyleBackColor = True
        '
        'btnmodificarproyecto
        '
        Me.btnmodificarproyecto.Location = New System.Drawing.Point(82, 95)
        Me.btnmodificarproyecto.Name = "btnmodificarproyecto"
        Me.btnmodificarproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btnmodificarproyecto.TabIndex = 5
        Me.btnmodificarproyecto.Text = "Modificar proyecto"
        Me.btnmodificarproyecto.UseVisualStyleBackColor = True
        '
        'btnnuevoproyecto
        '
        Me.btnnuevoproyecto.Location = New System.Drawing.Point(82, 49)
        Me.btnnuevoproyecto.Name = "btnnuevoproyecto"
        Me.btnnuevoproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btnnuevoproyecto.TabIndex = 4
        Me.btnnuevoproyecto.Text = "Nuevo proyecto"
        Me.btnnuevoproyecto.UseVisualStyleBackColor = True
        '
        'Menu_Proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminarproyecto)
        Me.Controls.Add(Me.btnmodificarproyecto)
        Me.Controls.Add(Me.btnnuevoproyecto)
        Me.Name = "Menu_Proyectos"
        Me.Text = "Menu_Proyectos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents btneliminarproyecto As Button
    Friend WithEvents btnmodificarproyecto As Button
    Friend WithEvents btnnuevoproyecto As Button
End Class

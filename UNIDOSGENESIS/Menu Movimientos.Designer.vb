<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Movimientos
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
        Me.btningresos = New System.Windows.Forms.Button()
        Me.btngastos = New System.Windows.Forms.Button()
        Me.btnsaldo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btningresos
        '
        Me.btningresos.Location = New System.Drawing.Point(108, 78)
        Me.btningresos.Name = "btningresos"
        Me.btningresos.Size = New System.Drawing.Size(75, 23)
        Me.btningresos.TabIndex = 0
        Me.btningresos.Text = "Ingresos"
        Me.btningresos.UseVisualStyleBackColor = True
        '
        'btngastos
        '
        Me.btngastos.Location = New System.Drawing.Point(108, 127)
        Me.btngastos.Name = "btngastos"
        Me.btngastos.Size = New System.Drawing.Size(75, 23)
        Me.btngastos.TabIndex = 1
        Me.btngastos.Text = "Gastos"
        Me.btngastos.UseVisualStyleBackColor = True
        '
        'btnsaldo
        '
        Me.btnsaldo.Location = New System.Drawing.Point(108, 174)
        Me.btnsaldo.Name = "btnsaldo"
        Me.btnsaldo.Size = New System.Drawing.Size(75, 23)
        Me.btnsaldo.TabIndex = 2
        Me.btnsaldo.Text = "Saldo"
        Me.btnsaldo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestion de Movimientos"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(108, 221)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 0
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Menu_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsaldo)
        Me.Controls.Add(Me.btngastos)
        Me.Controls.Add(Me.btningresos)
        Me.Name = "Menu_Movimientos"
        Me.Text = "Menu_Movimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btningresos As Button
    Friend WithEvents btngastos As Button
    Friend WithEvents btnsaldo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsalir As Button
End Class

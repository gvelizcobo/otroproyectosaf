﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finanzas
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
        Me.txtvolver = New System.Windows.Forms.Button()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.btnnvoproy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtvolver
        '
        Me.txtvolver.Location = New System.Drawing.Point(80, 166)
        Me.txtvolver.Name = "txtvolver"
        Me.txtvolver.Size = New System.Drawing.Size(125, 23)
        Me.txtvolver.TabIndex = 5
        Me.txtvolver.Text = "Volver"
        Me.txtvolver.UseVisualStyleBackColor = True
        '
        'btnreportes
        '
        Me.btnreportes.Location = New System.Drawing.Point(80, 115)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(125, 23)
        Me.btnreportes.TabIndex = 4
        Me.btnreportes.Text = "Reportes"
        Me.btnreportes.UseVisualStyleBackColor = True
        '
        'btnnvoproy
        '
        Me.btnnvoproy.Location = New System.Drawing.Point(80, 72)
        Me.btnnvoproy.Name = "btnnvoproy"
        Me.btnnvoproy.Size = New System.Drawing.Size(125, 23)
        Me.btnnvoproy.TabIndex = 3
        Me.btnnvoproy.Text = "Nuevo proyecto"
        Me.btnnvoproy.UseVisualStyleBackColor = True
        '
        'Finanzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtvolver)
        Me.Controls.Add(Me.btnreportes)
        Me.Controls.Add(Me.btnnvoproy)
        Me.Name = "Finanzas"
        Me.Text = "Finanzas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtvolver As Button
    Friend WithEvents btnreportes As Button
    Friend WithEvents btnnvoproy As Button
End Class

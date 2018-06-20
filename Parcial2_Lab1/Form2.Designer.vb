<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.grClientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        CType(Me.grClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(18, 19)
        Me.opt1.Margin = New System.Windows.Forms.Padding(2)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(111, 17)
        Me.opt1.TabIndex = 0
        Me.opt1.TabStop = True
        Me.opt1.Text = "Todos los Clientes"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(18, 49)
        Me.opt2.Margin = New System.Windows.Forms.Padding(2)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(154, 17)
        Me.opt2.TabIndex = 1
        Me.opt2.TabStop = True
        Me.opt2.Text = "Clientes entre 20 y 30 Años"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(386, 19)
        Me.cmdConsultar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(74, 30)
        Me.cmdConsultar.TabIndex = 2
        Me.cmdConsultar.Text = "&Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'grClientes
        '
        Me.grClientes.AllowUserToAddRows = False
        Me.grClientes.AllowUserToDeleteRows = False
        Me.grClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.grClientes.Location = New System.Drawing.Point(9, 83)
        Me.grClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.grClientes.Name = "grClientes"
        Me.grClientes.ReadOnly = True
        Me.grClientes.RowHeadersVisible = False
        Me.grClientes.RowTemplate.Height = 24
        Me.grClientes.Size = New System.Drawing.Size(553, 297)
        Me.grClientes.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Edad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Plan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Médico"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nutricionista"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Masajes"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Importe"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(481, 19)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(74, 30)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "&Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 390)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.grClientes)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.opt2)
        Me.Controls.Add(Me.opt1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Eco GYM - Consultas"
        CType(Me.grClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents grClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
End Class

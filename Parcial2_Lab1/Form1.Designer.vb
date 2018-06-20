<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMasajes = New System.Windows.Forms.CheckBox()
        Me.chkNutricionista = New System.Windows.Forms.CheckBox()
        Me.chkMedico = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.cmbPlan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.optContado = New System.Windows.Forms.RadioButton()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdConsultas = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMasajes)
        Me.GroupBox1.Controls.Add(Me.chkNutricionista)
        Me.GroupBox1.Controls.Add(Me.chkMedico)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 158)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 148)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'chkMasajes
        '
        Me.chkMasajes.AutoSize = True
        Me.chkMasajes.Location = New System.Drawing.Point(17, 115)
        Me.chkMasajes.Margin = New System.Windows.Forms.Padding(2)
        Me.chkMasajes.Name = "chkMasajes"
        Me.chkMasajes.Size = New System.Drawing.Size(96, 17)
        Me.chkMasajes.TabIndex = 2
        Me.chkMasajes.Text = "Incluir Masajes"
        Me.chkMasajes.UseVisualStyleBackColor = True
        '
        'chkNutricionista
        '
        Me.chkNutricionista.AutoSize = True
        Me.chkNutricionista.Location = New System.Drawing.Point(17, 76)
        Me.chkNutricionista.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNutricionista.Name = "chkNutricionista"
        Me.chkNutricionista.Size = New System.Drawing.Size(115, 17)
        Me.chkNutricionista.TabIndex = 1
        Me.chkNutricionista.Text = "Incluir Nutricionista"
        Me.chkNutricionista.UseVisualStyleBackColor = True
        '
        'chkMedico
        '
        Me.chkMedico.AutoSize = True
        Me.chkMedico.Location = New System.Drawing.Point(17, 36)
        Me.chkMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.chkMedico.Name = "chkMedico"
        Me.chkMedico.Size = New System.Drawing.Size(133, 17)
        Me.chkMedico.TabIndex = 0
        Me.chkMedico.Text = "Incluir Servicio Médico"
        Me.chkMedico.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 21)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(210, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(80, 61)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(54, 20)
        Me.txtEdad.TabIndex = 5
        '
        'cmbPlan
        '
        Me.cmbPlan.FormattingEnabled = True
        Me.cmbPlan.Items.AddRange(New Object() {"Plan Libre", "Plan Básico", "Plan Fitness", "Plan Pilates"})
        Me.cmbPlan.Location = New System.Drawing.Point(80, 103)
        Me.cmbPlan.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPlan.Name = "cmbPlan"
        Me.cmbPlan.Size = New System.Drawing.Size(179, 21)
        Me.cmbPlan.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.opt2)
        Me.GroupBox2.Controls.Add(Me.optContado)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 310)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(265, 101)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(17, 68)
        Me.opt2.Margin = New System.Windows.Forms.Padding(2)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(109, 17)
        Me.opt2.TabIndex = 1
        Me.opt2.TabStop = True
        Me.opt2.Text = "Tarjeta de Crédito"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'optContado
        '
        Me.optContado.AutoSize = True
        Me.optContado.Location = New System.Drawing.Point(17, 30)
        Me.optContado.Margin = New System.Windows.Forms.Padding(2)
        Me.optContado.Name = "optContado"
        Me.optContado.Size = New System.Drawing.Size(157, 17)
        Me.optContado.TabIndex = 0
        Me.optContado.TabStop = True
        Me.optContado.Text = "Contado/Debito Automatico"
        Me.optContado.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(320, 21)
        Me.cmdGrabar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(73, 33)
        Me.cmdGrabar.TabIndex = 8
        Me.cmdGrabar.Text = "&Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdConsultas
        '
        Me.cmdConsultas.Location = New System.Drawing.Point(320, 76)
        Me.cmdConsultas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdConsultas.Name = "cmdConsultas"
        Me.cmdConsultas.Size = New System.Drawing.Size(73, 33)
        Me.cmdConsultas.TabIndex = 9
        Me.cmdConsultas.Text = "&Consultas"
        Me.cmdConsultas.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(320, 132)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(73, 33)
        Me.cmdLimpiar.TabIndex = 10
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 436)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(80, 434)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(76, 20)
        Me.txtImporte.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 474)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdConsultas)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbPlan)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eco GYM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMasajes As System.Windows.Forms.CheckBox
    Friend WithEvents chkNutricionista As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedico As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents cmbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents optContado As System.Windows.Forms.RadioButton
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdConsultas As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox

End Class

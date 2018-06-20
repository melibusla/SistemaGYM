Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        InicializarVec()
    End Sub
    Private Sub cmdConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultas.Click
        Dim f As Form2
        f = New Form2
        f.Show()
    End Sub

    Private Sub txtEdad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub Inicializar()
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtImporte.Text = ""
        cmbPlan.SelectedIndex = 0
        chkMedico.Checked = False
        chkNutricionista.Checked = False
        optContado.Checked = True
        cmdGrabar.Enabled = False
    End Sub

    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click
        Inicializar()
    End Sub

    Private Sub cmbPlan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPlan.SelectedIndexChanged
        If cmbPlan.SelectedIndex = 3 Then
            chkMasajes.Enabled = True
        Else
            chkMasajes.Enabled = False
            chkMasajes.Checked = False
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        ValidarDatos()
    End Sub

    Private Sub txtEdad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEdad.TextChanged
        ValidarDatos()
    End Sub
    Private Function ValidarDatos() As Boolean
        Dim Validar As Boolean = False
        Dim nombre As String = txtNombre.Text
        Dim edad As Integer = Val(txtEdad.Text)

        If nombre.Length > 3 And (edad >= 18 And edad <= 80) Then
            Validar = True
            cmdGrabar.Enabled = True
        Else
            cmdGrabar.Enabled = False
        End If

        Return Validar
    End Function

    Private Sub cmdGrabar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGrabar.Click
        Dim total As Decimal = 0

        Select Case cmbPlan.SelectedIndex
            Case 0 : total = PLIBRE
            Case 1 : total = PBASICO
            Case 2 : total = PFITNESS
            Case 3 : total = PPILATES
        End Select

        If chkNutricionista.Checked Then
            total = total + NUTRI
        End If
        If chkMedico.Checked Then
            total = total + MEDICO
        End If
        If chkMasajes.Checked Then
            total = total + MASAJE
        End If

        If optContado.Checked Then
            total = total - (total * DTO / 100)
        Else
            total = total + (total * RECARGO / 100)
        End If

        txtImporte.Text = Format(total, "0.00")
        If MessageBox.Show("El importe total por mes es: " & "$" & Format(total, "0.00") & "  " & "Desea registrar sus datos?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If pos < MAXIMO Then
                Clientes(pos).Nombre = txtNombre.Text
                Clientes(pos).Edad = Val(txtEdad.Text)
                Clientes(pos).Plan = cmbPlan.SelectedItem
                Clientes(pos).Importe = Format(total, "0.00")
                If chkMedico.Checked Then
                    Clientes(pos).Medico = True
                End If
                If chkMasajes.Checked Then
                    Clientes(pos).Masajes = True
                End If
                If chkNutricionista.Checked Then
                    Clientes(pos).Nutricionista = True
                End If
                pos = pos + 1
            Else
                MessageBox.Show("Ya no hay lugares libres.")
            End If
            MessageBox.Show("Sus Datos han sido guardados.")
            Inicializar()
        Else
            MessageBox.Show("No se registraron sus datos.")
            Inicializar()
        End If
    End Sub
End Class

Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grClientes.Rows.Clear()
        opt1.Checked = True

    End Sub

    Private Sub cmdConsultar_Click(sender As System.Object, e As System.EventArgs) Handles cmdConsultar.Click
        Dim i As Integer
        Dim opcionMed As String
        Dim opcionNutri As String
        Dim opcionMasajes As String

        grClientes.Rows.Clear()
        'mostrar todos
        If opt1.Checked Then

            For i = 0 To pos
                If Clientes(i).Medico = True Then
                    opcionMed = "Si"
                Else
                    opcionMed = "NO"
                End If
                If Clientes(i).Nutricionista = True Then
                    opcionNutri = "Si"
                Else
                    opcionNutri = "NO"
                End If
                If Clientes(i).Masajes = True Then
                    opcionMasajes = "Si"
                Else
                    opcionMasajes = "NO"
                End If

                grClientes.Rows.Add(Clientes(i).Nombre, Clientes(i).Edad.ToString, Clientes(i).Plan, opcionMed, opcionNutri, opcionMasajes, Clientes(i).Importe)
            Next

        Else
            '20 y 30
            For i = 0 To pos
                If Clientes(i).Edad >= 20 And Clientes(i).Edad <= 30 Then
                    If Clientes(i).Medico = True Then
                        opcionMed = "Si"
                    Else
                        opcionMed = "NO"
                    End If
                    If Clientes(i).Nutricionista = True Then
                        opcionNutri = "Si"
                    Else
                        opcionNutri = "NO"
                    End If
                    If Clientes(i).Masajes = True Then
                        opcionMasajes = "Si"
                    Else
                        opcionMasajes = "NO"
                    End If

                    grClientes.Rows.Add(Clientes(i).Nombre, Clientes(i).Edad.ToString, Clientes(i).Plan, opcionMed, opcionNutri, opcionMasajes, Clientes(i).Importe)

                End If
            Next
        End If
    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
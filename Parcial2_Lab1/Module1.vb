Module Module1
    'Módulo de código para la aplicación
    Public Structure Datos
        Dim Nombre As String
        Dim Edad As Integer
        Dim Plan As String
        Dim Medico As Boolean
        Dim Nutricionista As Boolean
        Dim Masajes As Boolean
        Dim Importe As Decimal
    End Structure

    Public Const MAXIMO As Integer = 99
    Public Const PLIBRE As Integer = 800
    Public Const PBASICO As Integer = 450
    Public Const PFITNESS As Integer = 500
    Public Const PPILATES As Integer = 600
    Public Const MEDICO As Integer = 150
    Public Const NUTRI As Integer = 100
    Public Const MASAJE As Integer = 150
    Public Const DTO As Integer = 20
    Public Const RECARGO As Integer = 5

    Public Clientes(MAXIMO) As Datos
    Public pos As Integer

    Public Sub InicializarVec()
        Dim i As Integer
        For i = 0 To MAXIMO
            Clientes(i).Nombre = ""
            Clientes(i).Edad = 0
            Clientes(i).Plan = ""
            Clientes(i).Medico = False
            Clientes(i).Nutricionista = False
            Clientes(i).Masajes = False
            Clientes(i).Importe = 0
        Next
    End Sub

End Module

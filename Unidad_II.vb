Imports MySql.Data.MySqlClient
Imports MyProyect.My.Resources
Imports System.Reflection
Imports System.Resources
Public Class Unidad_II

    Dim Porcentaje As Integer
    Dim Cont As Integer = 1


    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        ProgressBar1.Increment(10)
        Porcentaje = Porcentaje + 10
        Mostrar.Text = Porcentaje

        Call Insertar()

        Cont += 1
        Dim recurso As String
        recurso = "Img" & Cont
        Dim rm As New ResourceManager("MyProyect.Resources", Assembly.GetExecutingAssembly())
        Dim Screen As Bitmap
        'Screen = (rm.GetObject(recurso))
        Screen = DirectCast(rm.GetObject(recurso), Bitmap)
        PictureBox1.Image = Screen

        If (Cont = 6) Then
            Siguiente.Visible = False
        End If
        If (Cont > 1) Then
            Anterior.Visible = True
        End If
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        ProgressBar1.Increment(-10)
        Porcentaje = Porcentaje - 10
        Mostrar.Text = Porcentaje

        Call Insertar()

        Cont -= 1

        Dim recurso As String
        recurso = "Img" & Cont
        Dim rm As New ResourceManager("MyProyect.Resources", Assembly.GetExecutingAssembly())
        Dim Screen As Bitmap
        'Screen = (rm.GetObject(recurso))
        Screen = DirectCast(rm.GetObject(recurso), Bitmap)
        PictureBox1.Image = Screen
        If (Cont = 1) Then
            Anterior.Visible = False
        End If
        If (Cont < 6) Then
            Siguiente.Visible = True
        End If
    End Sub
    Private Sub Insertar()
        Dim JConexion As New MySqlConnection
        Dim Nombre = Transfer.Nombre

        JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"

        JConexion.Open()
        Dim JCommand As New MySqlCommand("UPDATE alumnos SET Progreso = '" & Me.Mostrar.Text & "' WHERE (`IdAlumno` = '" & Nombre & "');", JConexion)
        JCommand.ExecuteNonQuery()

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Unidad_II_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Cont = 1) Then
            Anterior.Visible = False
        End If
    End Sub
End Class
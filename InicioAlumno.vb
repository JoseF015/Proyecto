Imports MySql.Data.MySqlClient
Imports MyProyect.My.Resources
Imports System.Reflection
Imports System.Resources
Public Class InicioAlumno

    Dim Porcentaje As Integer
    Dim Cont As Integer = 1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ProgressBar1.Increment(20)
        Porcentaje += 20
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
            Button2.Visible = False
            Button4.Visible = True
        End If
        If (Cont > 1) Then
            Button1.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Increment(-20)
        Porcentaje -= 20
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
            Button1.Visible = False
        End If
        If (Cont < 6) Then
            Button2.Visible = True
            Button4.Visible = False
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub InicioAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Visible = False

        If (Cont = 1) Then
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Examen.Show()
        MenuAlumno.Visible = False
        Me.Hide()
    End Sub
End Class
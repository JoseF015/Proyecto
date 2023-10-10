Imports System.Resources
Imports System.Reflection
Public Class Prueba
    Dim Cont As Integer = 1

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Cont += 1
        Dim recurso As String
        recurso = "Img" & Cont
        Dim rm As New ResourceManager("MyProyect.Resources", Assembly.GetExecutingAssembly())
        Dim Screen As Bitmap
        'Screen = (rm.GetObject(recurso))
        Screen = DirectCast(rm.GetObject(recurso), Bitmap)
        PictureBox4.Image = Screen

        If (Cont = 6) Then
            PictureBox2.Visible = False
        End If
        If (Cont > 1) Then
            PictureBox3.Visible = True
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Cont -= 1
        Dim recurso As String
        recurso = "Img" & Cont
        Dim rm As New ResourceManager("MyProyect.Resources", Assembly.GetExecutingAssembly())
        Dim Screen As Bitmap
        'Screen = (rm.GetObject(recurso))
        Screen = DirectCast(rm.GetObject(recurso), Bitmap)
        PictureBox4.Image = Screen
        If (Cont = 1) Then
            PictureBox3.Visible = False
        End If
        If (Cont < 6) Then
            PictureBox2.Visible = True
        End If

    End Sub
End Class
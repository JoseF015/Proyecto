Imports MySql.Data.MySqlClient

Public Class Examen

    Private Sub ExamenI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuAlumno.Visible = False
        Label42.Text = TimeOfDay
        Label41.Text = DateString

    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click

        Dim Cal As Double = 0

        If (R1.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R2.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R3.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R4.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R5.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R6.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R7.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R8.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R9.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R10.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R11.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R12.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R13.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R14.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R15.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R16.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R17.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        If (R18.SelectedIndex = 2) Then
            Cal += 0.5
        End If

        If (R19.SelectedIndex = 0) Then
            Cal += 0.5
        End If

        If (R20.SelectedIndex = 1) Then
            Cal += 0.5
        End If

        Calificación.Text = Cal

        Call Insertar()

        'Application.Exit()
    End Sub
    Private Sub Insertar()
        Dim JConexion As New MySqlConnection
        Dim Nombre = Transfer.Nombre

        JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"

        JConexion.Open()
        Dim JCommand As New MySqlCommand("UPDATE alumnos SET CalificacionU1 = '" & Me.Calificación.Text & "' WHERE (`IdAlumno` = '" & Nombre & "');", JConexion)
        JCommand.ExecuteNonQuery()
        Dim JCommand2 As New MySqlCommand("UPDATE `mydb`.`alumnos` SET `FechaExamen1` = '" & Me.Label41.Text & "' WHERE (IdAlumno='" & Nombre & "');", JConexion)
        JCommand2.ExecuteNonQuery()

    End Sub
End Class
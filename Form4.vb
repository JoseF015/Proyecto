Imports MySql.Data.MySqlClient
Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim JConexion As New MySqlConnection
        Dim JDataAdapter As MySqlDataAdapter
        Dim JSetData As New DataSet
        Dim JSql As String


        JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"
        JSql = " SELECT * FROM alumnos"
        JConexion.Open()
        JDataAdapter = New MySqlDataAdapter(JSql, JConexion)
        JSetData.Clear()
        JDataAdapter.Fill(JSetData, "alumnos")

        Me.DataGridView1.DataSource = JSetData.Tables("alumnos")


    End Sub

    Private Sub Asistencia_Click(sender As Object, e As EventArgs) Handles Asistencia.Click
        Dim JConexion As New MySqlConnection
        Dim JDataAdapter As MySqlDataAdapter
        Dim JSetData As New DataSet
        Dim JSql As String


        JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"
        JSql = " SELECT * FROM asistencia"
        JConexion.Open()
        JDataAdapter = New MySqlDataAdapter(JSql, JConexion)
        JSetData.Clear()
        JDataAdapter.Fill(JSetData, "asistencia")

        Me.DataGridView1.DataSource = JSetData.Tables("asistencia")
    End Sub
End Class
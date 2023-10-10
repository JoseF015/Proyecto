Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (ExisteUsuario(UsuarioA.Text, PassA.Text)) Then
            Me.Hide()
            MenuAlumno.Show()
        End If

        Transfer.Nombre = UsuarioA.Text

    End Sub
    Function ExisteUsuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim JConexion As New MySqlConnection
        Dim JDataAdapter As MySqlDataAdapter
        Dim JSetData As New DataSet
        Dim JSql As String
        Dim JSwitch As Boolean = False

        Try
            JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"
            JSql = " SELECT * FROM alumnos WHERE IdAlumno='" & usuario & "' and Password='" & password & "' "
            JConexion.Open()
            JDataAdapter = New MySqlDataAdapter(JSql, JConexion)
            JSetData.Clear()
            JDataAdapter.Fill(JSetData, "alumnos")

            If (JSetData.Tables("alumnos").Rows.Count() <> 0) Then

                'JConexion.Open()
                Dim JCommand As New MySqlCommand("INSERT INTO `asistencia` (`IdAlumno`,`Nombre`, `AMaterno`, `APaterno`,`Grupo`,`Horario`) SELECT `IdAlumno`,`Nombre`, `AMaterno`, `APaterno`, `Grupo`, `Horario` FROM `alumnos` WHERE (IdAlumno='" & usuario & "');", JConexion)
                Dim JCommand2 As New MySqlCommand("UPDATE `mydb`.`asistencia` SET `Fecha` = '" & Me.Label5.Text & "',`Hora` = '" & Me.Label4.Text & "' WHERE (IdAlumno='" & usuario & "');", JConexion)
                JCommand.ExecuteNonQuery()
                JCommand2.ExecuteNonQuery()

                MessageBox.Show("Bienvenido al sistema", "Sistema")

                JSwitch = True

            Else
                MessageBox.Show("Datos no validos", "Sistema")
                UsuarioA.Text = ""
                PassA.Text = ""
                JSwitch = False

            End If


        Catch ex As Exception

        End Try


        Return JSwitch

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
        Label5.Text = DateString

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
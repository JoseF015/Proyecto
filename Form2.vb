Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (ExisteUsuario(UsuarioM.Text, PassM.Text)) Then
            Me.Hide()
            Form4.Show()
        End If
    End Sub

    Function ExisteUsuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim JConexion As New MySqlConnection
        Dim JDataAdapter As MySqlDataAdapter
        Dim JSetData As New DataSet
        Dim JSql As String
        Dim JSwitch As Boolean = False

        Try
            JConexion.ConnectionString = " server=localhost;database=mydb;user id=root;password=Pa$$w0rd;"
            JSql = " SELECT * FROM maestros WHERE IdMaestro ='" & usuario & "' and Password ='" & password & "' "
            JConexion.Open()
            JDataAdapter = New MySqlDataAdapter(JSql, JConexion)
            JSetData.Clear()
            JDataAdapter.Fill(JSetData, "maestros")

            If (JSetData.Tables("maestros").Rows.Count() <> 0) Then
                MessageBox.Show("Bienvenido al sistema", "Sistema")

                JSwitch = True

            Else
                MessageBox.Show("Datos no validos", "Sistema")
                UsuarioM.Text = ""
                PassM.Text = ""
                JSwitch = False

            End If


        Catch ex As Exception

        End Try


        Return JSwitch

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
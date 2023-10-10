Public Class MenuAlumno
    Private Sub MenuAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSub()
    End Sub

    Private Sub hideSub()
        SubU1.Visible = False
        SubU2.Visible = False
        SubU3.Visible = False
        SubU4.Visible = False
        SubU5.Visible = False
        SubU6.Visible = False
    End Sub

    Private Sub showSub(submenu As Panel)

        If submenu.Visible = False Then
            hideSub()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub Unidad1_Click(sender As Object, e As EventArgs) Handles Unidad1.Click
        showSub(SubU1)
    End Sub

    Private Sub Unidad2_Click(sender As Object, e As EventArgs) Handles Unidad2.Click
        showSub(SubU2)
    End Sub

    Private Sub Unidad3_Click(sender As Object, e As EventArgs) Handles Unidad3.Click
        showSub(SubU3)
    End Sub

    Private Sub Unidad4_Click(sender As Object, e As EventArgs) Handles Unidad4.Click
        showSub(SubU4)
    End Sub

    Private Sub Unidad5_Click(sender As Object, e As EventArgs) Handles Unidad5.Click
        showSub(SubU5)
    End Sub

    Private Sub Unidad6_Click(sender As Object, e As EventArgs) Handles Unidad6.Click
        showSub(SubU6)
    End Sub
    Private formActual As Form = Nothing
    Private Sub openForm(otherForm As Form)
        If formActual IsNot Nothing Then formActual.Close()
        formActual = otherForm
        otherForm.TopLevel = False
        otherForm.FormBorderStyle = FormBorderStyle.None
        otherForm.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(otherForm)
        PanelContenedor.Tag = otherForm
        otherForm.BringToFront()
        otherForm.Show()

    End Sub

    Private Sub Tema1U1_Click(sender As Object, e As EventArgs) Handles Tema1U1.Click
        openForm(New InicioAlumno())
    End Sub

    Private Sub Tema1U2_Click(sender As Object, e As EventArgs) Handles Tema1U2.Click
        openForm(New Unidad_II())
    End Sub

    Private Sub Tema1U3_Click(sender As Object, e As EventArgs) Handles Tema1U3.Click
        openForm(New Unidad_III())
    End Sub

    Private Sub Tema1U4_Click(sender As Object, e As EventArgs) Handles Tema1U4.Click
        openForm(New Unidad_IV())
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub
End Class
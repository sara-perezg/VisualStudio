Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBPassword.PasswordChar = "*"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtBPassword.Text = "" Or txtBName.Text = "" Then
            MsgBox("Tiene que rellenar todos los campos")
        Else
            MsgBox("Perfil actualizado correctamente!")
        End If

    End Sub
End Class

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

        Dim edad As Long = DateDiff(DateInterval.Year, dtpDate.Value, Date.Now)

        If edad < 18 Then
            MsgBox("Error el usuario tiene que ser mayor de edad")
        End If


    End Sub

    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click
        ofd.Filter = "JPG | *.jpg; *.png"
        Dim eleccion As Integer = ofd.ShowDialog(Me)
        If eleccion = DialogResult.OK Then
            pbImage.Image = System.Drawing.Image.FromFile(ofd.FileName)
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class

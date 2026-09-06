Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing

Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer

        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukan dalam bentuk angka")
            txtNilai.Focus()
            Return
        End If

        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Masukan Nilai 0 sampai 100")
            txtNilai.Focus()
            Return
        End If

        If nilai <= 50 Then
            picImage.Image = System.Drawing.Image.FromFile("Assets\tsukasa-dance.gif")
        ElseIf nilai <= 70 Then
            picImage.Image = System.Drawing.Image.FromFile("Assets\img1.png")
        Else
            picImage.Image = System.Drawing.Image.FromFile("Assets\img2.png")

        End If
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub
End Class

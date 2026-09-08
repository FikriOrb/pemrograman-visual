Public Class Login
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

        If cmbRole.Text = "Manager" Then
            picLogo.Image = Image.FromFile(Application.StartupPath & "\Assets\manager.png")

        ElseIf cmbRole.Text = "Staff" Then
            picLogo.Image = Image.FromFile(Application.StartupPath & "\Assets\staff.png")

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Nama As String = txtNama.Text().ToLower()
        Dim Nim As String = txtNim.Text()
        Dim Role As String = cmbRole.SelectedItem.ToString()

        If Nama = "fikri" AndAlso Nim = "241712027" AndAlso Role = "Manager" Then
            txtNama.Clear()
            txtNim.Clear()
            Pajak.Show()
            Me.Hide()
        ElseIf Nama = "yuzaki" AndAlso Nim = "241712028" AndAlso Role = "Staff" Then
            txtNama.Clear()
            txtNim.Clear()
            Pajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Akun Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        MessageBox.Show("Login berhasil")


    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

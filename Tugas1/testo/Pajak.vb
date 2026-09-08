Public Class Pajak
    Private Sub Pajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim pendapatan As Double
        Dim pajak As Double

        pendapatan = Val(txtNilai.Text)

        If pendapatan > 100000000 Then
            pajak = pendapatan * 0.3

        ElseIf pendapatan > 30000000 Then
            pajak = pendapatan * 0.2

        ElseIf pendapatan > 5000000 Then
            pajak = pendapatan * 0.1

        Else
            pajak = 0
        End If

        MessageBox.Show("Pajak yang harus dibayar = Rp. " & pajak.ToString("N0"))

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
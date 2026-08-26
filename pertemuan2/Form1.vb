Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tampilkan_Click(sender As Object, e As EventArgs) Handles tampilkan.Click
        MessageBox.Show("Hello!" & vbCrLf &
            "Nama: " & nama.Text & vbCrLf &
            "NIM: " & nim.Text & vbCrLf &
            "KOM : " & kom.Text
        )
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        nama.Clear()
        nim.Clear()
        kom.Clear()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class

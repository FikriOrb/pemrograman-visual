<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        nama = New TextBox()
        nim = New TextBox()
        Label2 = New Label()
        kom = New TextBox()
        Label3 = New Label()
        keluar = New Button()
        tampilkan = New Button()
        hapus = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(127, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' nama
        ' 
        nama.Location = New Point(216, 66)
        nama.Name = "nama"
        nama.Size = New Size(219, 27)
        nama.TabIndex = 1
        ' 
        ' nim
        ' 
        nim.Location = New Point(217, 122)
        nim.Name = "nim"
        nim.Size = New Size(218, 27)
        nim.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(127, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' kom
        ' 
        kom.Location = New Point(217, 182)
        kom.Name = "kom"
        kom.Size = New Size(218, 27)
        kom.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(127, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 4
        Label3.Text = "KOM"
        ' 
        ' keluar
        ' 
        keluar.Location = New Point(272, 296)
        keluar.Name = "keluar"
        keluar.Size = New Size(94, 29)
        keluar.TabIndex = 6
        keluar.Text = "Keluar"
        keluar.UseVisualStyleBackColor = True
        ' 
        ' tampilkan
        ' 
        tampilkan.Location = New Point(168, 242)
        tampilkan.Name = "tampilkan"
        tampilkan.Size = New Size(94, 29)
        tampilkan.TabIndex = 7
        tampilkan.Text = "Tampilkan"
        tampilkan.UseVisualStyleBackColor = True
        ' 
        ' hapus
        ' 
        hapus.Location = New Point(370, 242)
        hapus.Name = "hapus"
        hapus.Size = New Size(94, 29)
        hapus.TabIndex = 8
        hapus.Text = "Hapus"
        hapus.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(hapus)
        Controls.Add(tampilkan)
        Controls.Add(keluar)
        Controls.Add(kom)
        Controls.Add(Label3)
        Controls.Add(nim)
        Controls.Add(Label2)
        Controls.Add(nama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents nim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents kom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents keluar As Button
    Friend WithEvents tampilkan As Button
    Friend WithEvents hapus As Button

End Class

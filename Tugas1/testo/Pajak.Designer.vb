<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblPajak1 = New Label()
        lblPajak2 = New Label()
        lblPajak3 = New Label()
        txtNilai = New TextBox()
        lblMasukkan = New Label()
        lblRp = New Label()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblPajak1
        ' 
        lblPajak1.AutoSize = True
        lblPajak1.Location = New Point(228, 65)
        lblPajak1.Name = "lblPajak1"
        lblPajak1.Size = New Size(268, 20)
        lblPajak1.TabIndex = 0
        lblPajak1.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblPajak2
        ' 
        lblPajak2.AutoSize = True
        lblPajak2.Location = New Point(228, 121)
        lblPajak2.Name = "lblPajak2"
        lblPajak2.Size = New Size(268, 20)
        lblPajak2.TabIndex = 1
        lblPajak2.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblPajak3
        ' 
        lblPajak3.AutoSize = True
        lblPajak3.Location = New Point(228, 179)
        lblPajak3.Name = "lblPajak3"
        lblPajak3.Size = New Size(284, 20)
        lblPajak3.TabIndex = 2
        lblPajak3.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(269, 266)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(182, 27)
        txtNilai.TabIndex = 3
        ' 
        ' lblMasukkan
        ' 
        lblMasukkan.AutoSize = True
        lblMasukkan.Location = New Point(283, 232)
        lblMasukkan.Name = "lblMasukkan"
        lblMasukkan.Size = New Size(149, 20)
        lblMasukkan.TabIndex = 4
        lblMasukkan.Text = "Masukan Pendapatan"
        ' 
        ' lblRp
        ' 
        lblRp.AutoSize = True
        lblRp.Location = New Point(233, 266)
        lblRp.Name = "lblRp"
        lblRp.Size = New Size(30, 20)
        lblRp.TabIndex = 5
        lblRp.Text = "Rp."
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(198, 321)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(428, 321)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Pajak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(lblRp)
        Controls.Add(lblMasukkan)
        Controls.Add(txtNilai)
        Controls.Add(lblPajak3)
        Controls.Add(lblPajak2)
        Controls.Add(lblPajak1)
        Name = "Pajak"
        Text = "Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPajak1 As Label
    Friend WithEvents lblPajak2 As Label
    Friend WithEvents lblPajak3 As Label
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents lblMasukkan As Label
    Friend WithEvents lblRp As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class

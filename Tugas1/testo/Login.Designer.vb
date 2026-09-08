<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        picLogo = New PictureBox()
        btnLogin = New Button()
        lblRole = New Label()
        lblNama = New Label()
        lblNim = New Label()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNim = New TextBox()
        Label1 = New Label()
        btnKeluar = New Button()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(322, 23)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(125, 125)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(259, 366)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(231, 183)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(231, 245)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(231, 309)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(37, 20)
        lblNim.TabIndex = 4
        lblNim.Text = "NIM"
        ' 
        ' cmbRole
        ' 
        cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbRole.Location = New Point(321, 180)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(322, 238)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 27)
        txtNama.TabIndex = 6
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(322, 302)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 27)
        txtNim.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(802, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 8
        Label1.Text = "Label1"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(404, 366)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 9
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(Label1)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(btnLogin)
        Controls.Add(picLogo)
        Name = "Login"
        Text = "Login"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKeluar As Button

End Class

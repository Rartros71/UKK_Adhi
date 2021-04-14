<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 21)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(147, 199)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(263, 20)
        Me.txtnama.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Nama Siswa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FontAwesome", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 27)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Register Siswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 352)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1138, 271)
        Me.DataGridView1.TabIndex = 72
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(720, 313)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(78, 23)
        Me.btnbatal.TabIndex = 71
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(639, 313)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(78, 23)
        Me.btnhapus.TabIndex = 70
        Me.btnhapus.Text = "Delete"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.Location = New System.Drawing.Point(558, 313)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(78, 23)
        Me.btnubah.TabIndex = 69
        Me.btnubah.Text = "Edit"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(477, 313)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(78, 23)
        Me.btnsimpan.TabIndex = 68
        Me.btnsimpan.Text = "Save"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(135, 316)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(336, 20)
        Me.txtcari.TabIndex = 67
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(147, 169)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(263, 20)
        Me.txtpass.TabIndex = 66
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(147, 137)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(263, 20)
        Me.txtuser.TabIndex = 65
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(147, 103)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "ID Siswa"
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegister"
        Me.Text = "FrmRegister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

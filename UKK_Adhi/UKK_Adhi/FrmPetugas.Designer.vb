<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPetugas
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
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txthak = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnt = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(145, 208)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(263, 20)
        Me.txtnama.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Nama Petugas"
        '
        'txthak
        '
        Me.txthak.FormattingEnabled = True
        Me.txthak.Items.AddRange(New Object() {"Admin", "Operator"})
        Me.txthak.Location = New System.Drawing.Point(145, 237)
        Me.txthak.Name = "txthak"
        Me.txthak.Size = New System.Drawing.Size(113, 21)
        Me.txthak.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FontAwesome", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(91, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 27)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Petugas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 361)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1138, 271)
        Me.DataGridView1.TabIndex = 53
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(718, 322)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(78, 23)
        Me.btnbatal.TabIndex = 52
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(637, 322)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(78, 23)
        Me.btnhapus.TabIndex = 51
        Me.btnhapus.Text = "Delete"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.Location = New System.Drawing.Point(556, 322)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(78, 23)
        Me.btnubah.TabIndex = 50
        Me.btnubah.Text = "Edit"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnt
        '
        Me.btnt.Location = New System.Drawing.Point(259, 112)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(34, 23)
        Me.btnt.TabIndex = 49
        Me.btnt.Text = "+"
        Me.btnt.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(475, 322)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(78, 23)
        Me.btnsimpan.TabIndex = 48
        Me.btnsimpan.Text = "Save"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(133, 325)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(336, 20)
        Me.txtcari.TabIndex = 47
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(145, 178)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(263, 20)
        Me.txtpass.TabIndex = 46
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(145, 146)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(263, 20)
        Me.txtuser.TabIndex = 45
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(145, 112)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Hak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "ID"
        '
        'FrmPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txthak)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnt)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPetugas"
        Me.Text = "FrmPetugas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txthak As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnt As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKelas
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
        Me.txtkls = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtahli = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btntspp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtkls
        '
        Me.txtkls.Location = New System.Drawing.Point(254, 101)
        Me.txtkls.Name = "txtkls"
        Me.txtkls.ReadOnly = True
        Me.txtkls.Size = New System.Drawing.Size(133, 20)
        Me.txtkls.TabIndex = 0
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(254, 149)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(173, 20)
        Me.txtnama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kompetensi Keahlian"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1155, 277)
        Me.DataGridView1.TabIndex = 8
        '
        'txtahli
        '
        Me.txtahli.FormattingEnabled = True
        Me.txtahli.Items.AddRange(New Object() {"RPL", "MM", "TKJ", "BDP", "OTKP"})
        Me.txtahli.Location = New System.Drawing.Point(254, 198)
        Me.txtahli.Name = "txtahli"
        Me.txtahli.Size = New System.Drawing.Size(173, 21)
        Me.txtahli.TabIndex = 92
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("FontAwesome", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = ""
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(567, 329)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(71, 23)
        Me.btnbatal.TabIndex = 90
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(490, 329)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(71, 23)
        Me.btnhapus.TabIndex = 89
        Me.btnhapus.Text = "Delete"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(413, 329)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(71, 23)
        Me.btnedit.TabIndex = 88
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(336, 329)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(71, 23)
        Me.btnsimpan.TabIndex = 87
        Me.btnsimpan.Text = "Save"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(89, 329)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(211, 20)
        Me.txtcari.TabIndex = 86
        '
        'btntspp
        '
        Me.btntspp.Location = New System.Drawing.Point(393, 99)
        Me.btntspp.Name = "btntspp"
        Me.btntspp.Size = New System.Drawing.Size(34, 23)
        Me.btntspp.TabIndex = 93
        Me.btntspp.Text = "+"
        Me.btntspp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kompetensi Keahlian"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(125, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 24)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Data Kelas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(78, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 27)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = ""
        '
        'FrmKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btntspp)
        Me.Controls.Add(Me.txtahli)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmKelas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtkls As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtahli As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btntspp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class

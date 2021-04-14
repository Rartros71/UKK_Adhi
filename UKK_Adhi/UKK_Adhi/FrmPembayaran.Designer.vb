<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembayaran
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtspp = New System.Windows.Forms.TextBox()
        Me.txtjml = New System.Windows.Forms.TextBox()
        Me.txtnisn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btntbayar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tglbayar = New System.Windows.Forms.DateTimePicker()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txttampil = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(830, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Tekan S"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(419, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Tekan N"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(419, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Tekan P"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "ID SPP"
        '
        'txtspp
        '
        Me.txtspp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtspp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtspp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspp.Location = New System.Drawing.Point(634, 97)
        Me.txtspp.Name = "txtspp"
        Me.txtspp.Size = New System.Drawing.Size(190, 22)
        Me.txtspp.TabIndex = 81
        '
        'txtjml
        '
        Me.txtjml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjml.Location = New System.Drawing.Point(634, 136)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.ReadOnly = True
        Me.txtjml.Size = New System.Drawing.Size(190, 22)
        Me.txtjml.TabIndex = 80
        '
        'txtnisn
        '
        Me.txtnisn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtnisn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtnisn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnisn.Location = New System.Drawing.Point(215, 173)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(198, 22)
        Me.txtnisn.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("FontAwesome", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = ""
        '
        'btntbayar
        '
        Me.btntbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntbayar.Location = New System.Drawing.Point(422, 96)
        Me.btntbayar.Name = "btntbayar"
        Me.btntbayar.Size = New System.Drawing.Size(34, 21)
        Me.btntbayar.TabIndex = 77
        Me.btntbayar.Text = "+"
        Me.btntbayar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(766, 305)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(78, 23)
        Me.btnbatal.TabIndex = 76
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(682, 305)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(78, 23)
        Me.btnhapus.TabIndex = 75
        Me.btnhapus.Text = "Delete"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(598, 305)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(78, 23)
        Me.btnedit.TabIndex = 74
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(514, 305)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(78, 23)
        Me.btnsimpan.TabIndex = 73
        Me.btnsimpan.Text = "Save"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1155, 298)
        Me.DataGridView1.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "NISN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Jumlah Bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Tanggal Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ID Petugas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "ID Pembayaran"
        '
        'tglbayar
        '
        Me.tglbayar.Location = New System.Drawing.Point(215, 217)
        Me.tglbayar.Name = "tglbayar"
        Me.tglbayar.Size = New System.Drawing.Size(133, 20)
        Me.tglbayar.TabIndex = 66
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(107, 305)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(349, 20)
        Me.txtcari.TabIndex = 65
        '
        'txtid
        '
        Me.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(215, 135)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(198, 22)
        Me.txtid.TabIndex = 64
        '
        'txtbayar
        '
        Me.txtbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.Location = New System.Drawing.Point(215, 96)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.ReadOnly = True
        Me.txtbayar.Size = New System.Drawing.Size(198, 22)
        Me.txtbayar.TabIndex = 63
        '
        'txttampil
        '
        Me.txttampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampil.Location = New System.Drawing.Point(833, 136)
        Me.txttampil.Name = "txttampil"
        Me.txttampil.ReadOnly = True
        Me.txttampil.Size = New System.Drawing.Size(190, 22)
        Me.txttampil.TabIndex = 86
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(850, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(75, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 27)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(122, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 24)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Data Pembayaran"
        '
        'FrmPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttampil)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtspp)
        Me.Controls.Add(Me.txtjml)
        Me.Controls.Add(Me.txtnisn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btntbayar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tglbayar)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtbayar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPembayaran"
        Me.Text = "FrmPembayaran"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtspp As System.Windows.Forms.TextBox
    Friend WithEvents txtjml As System.Windows.Forms.TextBox
    Friend WithEvents txtnisn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btntbayar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tglbayar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents txttampil As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class

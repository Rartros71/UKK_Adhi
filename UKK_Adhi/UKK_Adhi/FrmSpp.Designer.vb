<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSpp
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
        Me.txtnominal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btntspp = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtspp = New System.Windows.Forms.TextBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txttampil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnominal
        '
        Me.txtnominal.Location = New System.Drawing.Point(155, 180)
        Me.txtnominal.Name = "txtnominal"
        Me.txtnominal.Size = New System.Drawing.Size(227, 20)
        Me.txtnominal.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Nominal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("FontAwesome", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = ""
        '
        'btntspp
        '
        Me.btntspp.Location = New System.Drawing.Point(388, 101)
        Me.btntspp.Name = "btntspp"
        Me.btntspp.Size = New System.Drawing.Size(34, 20)
        Me.btntspp.TabIndex = 80
        Me.btntspp.Text = "+"
        Me.btntspp.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(784, 298)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(91, 23)
        Me.btnbatal.TabIndex = 79
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(687, 298)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(91, 23)
        Me.btnhapus.TabIndex = 78
        Me.btnhapus.Text = "Delete"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(590, 298)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(91, 23)
        Me.btnedit.TabIndex = 77
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(493, 298)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(91, 23)
        Me.btnsimpan.TabIndex = 76
        Me.btnsimpan.Text = "Save"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1155, 298)
        Me.DataGridView1.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Tahun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "ID SPP"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(155, 300)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(227, 20)
        Me.txtcari.TabIndex = 72
        '
        'txtspp
        '
        Me.txtspp.Location = New System.Drawing.Point(155, 102)
        Me.txtspp.Name = "txtspp"
        Me.txtspp.ReadOnly = True
        Me.txtspp.Size = New System.Drawing.Size(227, 20)
        Me.txtspp.TabIndex = 71
        '
        'txttahun
        '
        Me.txttahun.Location = New System.Drawing.Point(155, 140)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(227, 20)
        Me.txttahun.TabIndex = 84
        '
        'txttampil
        '
        Me.txttampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampil.Location = New System.Drawing.Point(394, 180)
        Me.txttampil.Name = "txttampil"
        Me.txttampil.ReadOnly = True
        Me.txttampil.Size = New System.Drawing.Size(190, 22)
        Me.txttampil.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(77, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 27)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(122, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 24)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "SPP"
        '
        'FrmSpp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 644)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttampil)
        Me.Controls.Add(Me.txttahun)
        Me.Controls.Add(Me.txtnominal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btntspp)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtspp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSpp"
        Me.Text = "FrmSpp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnominal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btntspp As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents txtspp As System.Windows.Forms.TextBox
    Friend WithEvents txttahun As System.Windows.Forms.TextBox
    Friend WithEvents txttampil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

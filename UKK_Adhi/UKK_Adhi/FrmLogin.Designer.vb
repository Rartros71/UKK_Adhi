<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnmasuk = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("FontAwesome", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(18, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("FontAwesome", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(18, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 21)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = ""
        '
        'btnmasuk
        '
        Me.btnmasuk.BackColor = System.Drawing.Color.Transparent
        Me.btnmasuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasuk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnmasuk.Location = New System.Drawing.Point(27, 228)
        Me.btnmasuk.Name = "btnmasuk"
        Me.btnmasuk.Size = New System.Drawing.Size(190, 23)
        Me.btnmasuk.TabIndex = 33
        Me.btnmasuk.Text = "Login"
        Me.btnmasuk.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Transparent
        Me.btnbatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbatal.Location = New System.Drawing.Point(26, 257)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(191, 23)
        Me.btnbatal.TabIndex = 34
        Me.btnbatal.Text = "Cancel"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "X"
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.White
        Me.txtpass.Location = New System.Drawing.Point(48, 173)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(194, 17)
        Me.txtpass.TabIndex = 35
        Me.txtpass.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.White
        Me.txtuser.Location = New System.Drawing.Point(52, 115)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(194, 17)
        Me.txtuser.TabIndex = 36
        Me.txtuser.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(22, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(22, 194)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("FontAwesome", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(99, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 27)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(90, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Sign In"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(244, 335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnmasuk)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.txtpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnmasuk As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

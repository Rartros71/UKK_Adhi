Imports System.Data.SqlClient
Public Class FrmLogin
    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btnmasuk_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs)
        bersih()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub btnmasuk_Click_1(sender As Object, e As EventArgs) Handles btnmasuk.Click
        Try
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
            cmd.Connection = cn
            cn.Open()
            cmd.CommandText = "SELECT * FROM petugas WHERE username ='" & txtuser.Text &
                "' AND password ='" & txtpass.Text & "'"
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd("hak") = "Admin" Then
                    FrmMenu.Show()
                ElseIf rd("hak") = "Operator" Then
                    FrmMenu.petugas.Hide()
                    FrmMenu.Label5.Hide()
                    FrmMenu.Label3.Hide()
                    FrmMenu.Label9.Hide()
                    FrmMenu.Label7.Hide()
                    FrmMenu.Label10.Hide()
                    FrmMenu.Label6.Hide()
                    FrmMenu.Label4.Hide()
                    FrmMenu.Label19.Hide()
                    FrmMenu.Label20.Hide()
                    FrmPembayaran.Button1.Hide()
                    FrmMenu.Show()
                ElseIf rd("hak") = "Siswa" Then
                    FrmMenu.petugas.Hide()
                    FrmMenu.Label5.Hide()
                    FrmMenu.Label3.Hide()
                    FrmMenu.Label9.Hide()
                    FrmMenu.Label7.Hide()
                    FrmMenu.Label10.Hide()
                    FrmMenu.Label6.Hide()
                    FrmMenu.Label4.Hide()
                    FrmMenu.Label8.Hide()
                    FrmMenu.Label11.Hide()
                    FrmMenu.Label19.Hide()
                    FrmMenu.Label20.Hide()
                    FrmMenu.Show()
                Else
                    MsgBox("Nama Pengguna dan kata Sandi tidak tersedia", MsgBoxStyle.Information)
                    txtuser.Text = ""
                    txtpass.Text = ""
                End If
                FrmMenu.lbpass.Text = (rd("nama_petugas"))
                FrmMenu.lbhak.Text = (rd("hak"))
            End If
            rd.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan " & ex.Message)
        End Try
        

    End Sub

    Private Sub txtuser_MouseEnter(sender As Object, e As EventArgs) Handles txtuser.MouseEnter
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtuser_MouseLeave(sender As Object, e As EventArgs) Handles txtuser.MouseLeave
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtpass.MouseEnter
        If txtpass.Text = "Password" Then
            txtpass.Text = ""
            txtpass.PasswordChar = "*"
            txtpass.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtpass_MouseLeave(sender As Object, e As EventArgs) Handles txtpass.MouseLeave
        If txtpass.Text = "" Then
            txtpass.Text = "Password"
            txtpass.PasswordChar = "*"
            txtpass.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub btnbatal_Click_1(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Hide()
        FrmAwalan.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
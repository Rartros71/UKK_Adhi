Imports System.Data.SqlClient
Public Class FrmLoginsiswa
    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub
    Private Sub FrmLoginsiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End

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

    Private Sub btnmasuk_Click(sender As Object, e As EventArgs) Handles btnmasuk.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        If txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Silahkan Isi Username/Password")
        Else
            cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
            cmd.Connection = cn
            cn.Open()
            cmd.CommandText = "SELECT * FROM tbsiswa WHERE username ='" & txtuser.Text & "'AND password ='" & txtpass.Text & "' "
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Username/password Salah")
            Else
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
            End If
        End If
        FrmMenu.lbpass.Text = (rd("nama_siswa"))
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Hide()
        FrmAwalan.Show()
    End Sub
End Class
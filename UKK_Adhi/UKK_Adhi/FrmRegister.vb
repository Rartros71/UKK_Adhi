Imports System.Data.SqlClient
Public Class FrmRegister
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tbsiswa"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Username"
        DataGridView1.Columns(2).HeaderText = "Password"
        DataGridView1.Columns(3).HeaderText = "Nama Siswa"



        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 280
        DataGridView1.Columns(3).Width = 280

    End Sub
    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id FROM tbsiswa"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "S-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "S-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtnama.Text = ""
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txtuser.Text = "" Then
            MessageBox.Show("Username wajib diisi, tidak boleh dikosongkan")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Password wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama wajib diisi, tidak boleh dikosongkan")
        ElseIf txtuser.Text <> "" And txtpass.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO tbsiswa VALUES ('" & txtid.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txtnama.Text & "') "
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txtuser.Text = "" Then
            MessageBox.Show("Username wajib diisi, tidak boleh dikosongkan")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Password wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama wajib diisi, tidak boleh dikosongkan")
        ElseIf txtuser.Text <> "" And txtpass.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE tbsiswa SET username ='" & txtuser.Text & "' , password ='" & txtpass.Text & "' , nama_siswa ='" & txtnama.Text & "' WHERE id_siswa ='" & txtid.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Di ubah", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM tbsiswa WHERE id_siswa = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data barang Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
        bersih()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tbsiswa WHERE id_siswa LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%' OR password LIKE '%" & txtcari.Text & "%' OR nama_siswa LIKE '%" & txtcari.Text & "%' "
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtuser.Text = DataGridView1.SelectedCells(1).Value
        txtpass.Text = DataGridView1.SelectedCells(2).Value
        txtnama.Text = DataGridView1.SelectedCells(3).Value
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kodeotomatis()

    End Sub
End Class
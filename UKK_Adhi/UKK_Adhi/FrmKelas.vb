Imports System.Data.SqlClient
Public Class FrmKelas
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kelas"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Kelas"
        DataGridView1.Columns(1).HeaderText = "Nama Kelas"
        DataGridView1.Columns(2).HeaderText = "Kompetensi Keahlian"

        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 280

    End Sub
    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_kelas FROM kelas"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_kelas").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkls.Text = "IK-0" + Trim(Str(kodeauto))
            Case 2 : txtkls.Text = "IK-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub
    Sub bersih()
        txtnama.Text = ""
        txtnama.Text = ""
        txtahli.Text = ""
    End Sub

    Private Sub FrmKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkls.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Kelas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtahli.Text = "" Then
            MessageBox.Show("Jurusan wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkls.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO kelas VALUES ('" & txtkls.Text & "','" & txtnama.Text & "','" & txtahli.Text & "') "
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtkls.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Kelas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtahli.Text = "" Then
            MessageBox.Show("Jurusan wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkls.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE kelas SET  nama_kelas ='" & txtnama.Text & "' , kompetensi_keahlian ='" & txtahli.Text & "' WHERE id_kelas ='" & txtkls.Text & "'"
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
        cmd.CommandText = "DELETE FROM kelas WHERE id_kelas = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
        bersih()
    End Sub

    Private Sub btntspp_Click(sender As Object, e As EventArgs) Handles btntspp.Click
        kodeotomatis()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kelas WHERE id_kelas LIKE '%" & txtcari.Text & "%' OR nama_kelas LIKE '%" & txtcari.Text & "%' OR kompetensi_keahlian LIKE '%" & txtcari.Text & "%' "
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkls.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtahli.Text = DataGridView1.SelectedCells(2).Value
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub
End Class

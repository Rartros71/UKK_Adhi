Imports System.Data.SqlClient
Public Class FrmHistory
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pembayaran"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Pembayaran"
        DataGridView1.Columns(1).HeaderText = "ID Petugas"
        DataGridView1.Columns(2).HeaderText = "NISN"
        DataGridView1.Columns(3).HeaderText = "Tanggal Bayar"
        DataGridView1.Columns(4).HeaderText = "ID SPP"
        DataGridView1.Columns(5).HeaderText = "Jumlah Bayar"


        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 280
        DataGridView1.Columns(3).Width = 280
        DataGridView1.Columns(4).Width = 280
        DataGridView1.Columns(5).Width = 280
    End Sub
    Private Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pembayaran WHERE id_pembayaran LIKE '%" & txtcari.Text & "%' OR id_petugas LIKE '%" & txtcari.Text & "%' OR nisn LIKE '%" & txtcari.Text & "%' OR tgl_bayar LIKE '%" & txtcari.Text & "%' OR id_spp LIKE '%" & txtcari.Text & "%' OR jumlah_bayar LIKE '%" & txtcari.Text & "%'  "
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
End Class
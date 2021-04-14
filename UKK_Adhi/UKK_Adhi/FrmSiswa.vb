Imports System.Data.SqlClient
Public Class FrmSiswa
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM siswa"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "NISN"
        DataGridView1.Columns(1).HeaderText = "NIS"
        DataGridView1.Columns(2).HeaderText = "Nama"
        DataGridView1.Columns(3).HeaderText = "ID Kelas"
        DataGridView1.Columns(4).HeaderText = "Alamat"
        DataGridView1.Columns(5).HeaderText = "No Telepon"
        DataGridView1.Columns(6).HeaderText = "ID SPP"



        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 280
        DataGridView1.Columns(3).Width = 280
        DataGridView1.Columns(4).Width = 280
        DataGridView1.Columns(5).Width = 280
        DataGridView1.Columns(6).Width = 280

    End Sub
    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS nisn FROM siswa"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("nisn").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtnisn.Text = "NISN-0" + Trim(Str(kodeauto))
            Case 2 : txtnisn.Text = "NISN-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub
    Sub relasi()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM kelas", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtkls.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtkls.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub
    Sub relasi2()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM spp", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtspp.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtspp.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub
    Sub bersih()
        txtnisn.Text = ""
        txtnis.Text = ""
        txtnama.Text = ""
        txtkls.Text = ""
        txtalmt.Text = ""
        txttlp.Text = ""
        txtspp.Text = ""
    End Sub

    Private Sub FrmSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
        relasi()
        relasi2()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnisn.Text = "" Then
            MessageBox.Show("ID Pembayaran wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnis.Text = "" Then
            MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("NISN wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkls.Text = "" Then
            MessageBox.Show("Tanggal Bayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtalmt.Text = "" Then
            MessageBox.Show("Bulan Dibayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txttlp.Text = "" Then
            MessageBox.Show("Tahun Dibayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text = "" Then
            MessageBox.Show("ID SPP wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnisn.Text <> "" And txtnis.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO siswa VALUES ('" & txtnisn.Text & "','" & txtnis.Text & "','" & txtnama.Text & "','" & txtkls.Text & "','" & txtalmt.Text & "','" & txttlp.Text & "','" & txtspp.Text & "') "
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtnisn.Text = "" Then
            MessageBox.Show("ID Pembayaran wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnis.Text = "" Then
            MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("NISN wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkls.Text = "" Then
            MessageBox.Show("Tanggal Bayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtalmt.Text = "" Then
            MessageBox.Show("Bulan Dibayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txttlp.Text = "" Then
            MessageBox.Show("Tahun Dibayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text = "" Then
            MessageBox.Show("ID SPP wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnisn.Text <> "" And txtnis.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE siswa SET  nis ='" & txtnis.Text & "' , nama ='" & txtnama.Text & "' , id_kelas ='" & txtkls.Text & "', alamat ='" & txtalmt.Text & "', no_telp ='" & txttlp.Text & "', id_spp ='" & txtspp.Text & "' WHERE nisn ='" & txtnisn.Text & "'"
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
        cmd.CommandText = "DELETE FROM siswa WHERE nisn = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM siswa WHERE nisn LIKE '%" & txtcari.Text & "%' OR nis LIKE '%" & txtcari.Text & "%' OR nama LIKE '%" & txtcari.Text & "%' OR id_kelas LIKE '%" & txtcari.Text & "%' OR alamat LIKE '%" & txtcari.Text & "%' OR no_telp LIKE '%" & txtcari.Text & "%' OR id_spp LIKE '%" & txtcari.Text & "%' "

        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtnisn.Text = DataGridView1.SelectedCells(0).Value
        txtnis.Text = DataGridView1.SelectedCells(1).Value
        txtnama.Text = DataGridView1.SelectedCells(2).Value
        txtkls.Text = DataGridView1.SelectedCells(3).Value
        txtalmt.Text = DataGridView1.SelectedCells(4).Value
        txttlp.Text = DataGridView1.SelectedCells(5).Value
        txtspp.Text = DataGridView1.SelectedCells(6).Value
    End Sub

    Private Sub txtspp_TextChanged(sender As Object, e As EventArgs) Handles txtspp.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM spp WHERE id_spp ='" & txtspp.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtkls_TextChanged(sender As Object, e As EventArgs) Handles txtkls.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kelas WHERE id_kelas ='" & txtkls.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub btntnisn_Click(sender As Object, e As EventArgs) Handles btntnisn.Click
        kodeotomatis()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lapsiswa As New FrmLaporanS
        lapsiswa.TopLevel = False
        FrmMenu.Panel_menu.Controls.Add(lapsiswa)
        lapsiswa.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class FrmPembayaran
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
    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_pembayaran FROM pembayaran"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_pembayaran").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtbayar.Text = "IP-00" + Trim(Str(kodeauto))
            Case 2 : txtbayar.Text = "IP-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub
    Sub relasi()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM petugas", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid.AutoCompleteCustomSource.Add(r.Item(0).ToString)
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
    Sub relasi3()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM siswa", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtnisn.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtnisn.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub
    Sub bersih()
        txtbayar.Text = ""
        txtid.Text = ""
        txtnisn.Text = ""
        tglbayar.Text = ""
        txtspp.Text = ""
        txtjml.Text = ""
    End Sub

    Private Sub FrmPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
        relasi()
        relasi2()
        relasi3()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtbayar.Text = "" Then
            MessageBox.Show("ID Pembayaran wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid.Text = "" Then
            MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnisn.Text = "" Then
            MessageBox.Show("NISN wajib diisi, tidak boleh dikosongkan")
        ElseIf tglbayar.Text = "" Then
            MessageBox.Show("Tanggal Bayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text = "" Then
            MessageBox.Show("ID SPP wajib diisi, tidak boleh dikosongkan")
        ElseIf txtjml.Text = "" Then
            MessageBox.Show("Jumlah Bayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtbayar.Text <> "" And txtid.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO pembayaran VALUES ('" & txtbayar.Text & "','" & txtid.Text & "','" & txtnisn.Text & "','" & tglbayar.Text & "','" & txtspp.Text & "','" & txtjml.Text & "') "
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtbayar.Text = "" Then
            MessageBox.Show("ID Pembayaran wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid.Text = "" Then
            MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnisn.Text = "" Then
            MessageBox.Show("NISN wajib diisi, tidak boleh dikosongkan")
        ElseIf tglbayar.Text = "" Then
            MessageBox.Show("Tanggal Dibayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text = "" Then
            MessageBox.Show("ID SPP wajib diisi, tidak boleh dikosongkan")
        ElseIf txtjml.Text = "" Then
            MessageBox.Show("Jumlah Bayar wajib diisi, tidak boleh dikosongkan")
        ElseIf txtbayar.Text <> "" And txtid.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE pembayaran SET  id_petugas ='" & txtid.Text & "' , nisn ='" & txtnisn.Text & "' , tgl_bayar ='" & tglbayar.Text & "',  id_spp ='" & txtspp.Text & "', jumlah_bayar ='" & txtjml.Text & "' WHERE id_pembayaran ='" & txtbayar.Text & "'"
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
        cmd.CommandText = "DELETE FROM pembayaran WHERE id_pembayaran = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
        bersih()
    End Sub

    Private Sub btntbayar_Click(sender As Object, e As EventArgs) Handles btntbayar.Click
        kodeotomatis()
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

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtbayar.Text = DataGridView1.SelectedCells(0).Value
        txtid.Text = DataGridView1.SelectedCells(1).Value
        txtnisn.Text = DataGridView1.SelectedCells(2).Value
        tglbayar.Text = DataGridView1.SelectedCells(3).Value
        txtspp.Text = DataGridView1.SelectedCells(4).Value
        txtjml.Text = DataGridView1.SelectedCells(5).Value
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM petugas WHERE id_petugas ='" & txtid.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtspp_TextChanged(sender As Object, e As EventArgs) Handles txtspp.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM spp WHERE id_spp ='" & txtspp.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        If rd.Read() Then
            txtjml.Text = rd("nominal")
        End If
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtnisn_TextChanged(sender As Object, e As EventArgs) Handles txtnisn.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM siswa WHERE nisn ='" & txtnisn.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtjml_TextChanged(sender As Object, e As EventArgs) Handles txtjml.TextChanged
        Try
            Dim a As Integer
            a = txtjml.Text
            txttampil.Text = "Rp" + FormatNumber(a, 2, , , TriState.True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttampil_TextChanged(sender As Object, e As EventArgs) Handles txttampil.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lapbarang As New FrmLaporan
        lapbarang.TopLevel = False
        FrmMenu.Panel_menu.Controls.Add(lapbarang)
        lapbarang.Show()
    End Sub
End Class
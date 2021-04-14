Imports System.Data.SqlClient
Public Class FrmSpp
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM spp"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID SPP"
        DataGridView1.Columns(1).HeaderText = "Tahun"
        DataGridView1.Columns(2).HeaderText = "Nominal"

        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 280

    End Sub
    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_spp FROM spp"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_spp").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtspp.Text = "SPP-0" + Trim(Str(kodeauto))
            Case 2 : txtspp.Text = "SPP-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub
    Sub bersih()
        txtspp.Text = ""
        txttahun.Text = ""
        txtnominal.Text = ""
    End Sub

    Private Sub FrmSpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-ICP7L1O\SQLEXPRESS;Initial Catalog=db_UKK_Adhi;Integrated Security=True"
        tampildata()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtspp.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txttahun.Text = "" Then
            MessageBox.Show("Tahun wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnominal.Text = "" Then
            MessageBox.Show("Nominal wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text <> "" And txttahun.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO spp VALUES ('" & txtspp.Text & "','" & txttahun.Text & "','" & txtnominal.Text & "') "
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtspp.Text = "" Then
            MessageBox.Show("ID wajib diisi, tidak boleh dikosongkan")
        ElseIf txttahun.Text = "" Then
            MessageBox.Show("Tahun wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnominal.Text = "" Then
            MessageBox.Show("Nominal wajib diisi, tidak boleh dikosongkan")
        ElseIf txtspp.Text <> "" And txtnominal.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE spp SET  tahun ='" & txttahun.Text & "' , nominal ='" & txtnominal.Text & "' WHERE id_spp ='" & txtspp.Text & "'"
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
        cmd.CommandText = "DELETE FROM spp WHERE id_spp = '" + id + "'"
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
        cmd.CommandText = "SELECT * FROM spp WHERE id_spp LIKE '%" & txtcari.Text & "%' OR tahun LIKE '%" & txtcari.Text & "%' OR nominal LIKE '%" & txtcari.Text & "%' "
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtspp.Text = DataGridView1.SelectedCells(0).Value
        txttahun.Text = DataGridView1.SelectedCells(1).Value
        txtnominal.Text = DataGridView1.SelectedCells(2).Value
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtnominal_TextChanged(sender As Object, e As EventArgs) Handles txtnominal.TextChanged
        Try
            Dim a As Integer
            a = txtnominal.Text
            txttampil.Text = "Rp" + FormatNumber(a, 2, , , TriState.True)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttampil_TextChanged(sender As Object, e As EventArgs) Handles txttampil.TextChanged

    End Sub
End Class
Public Class FrmMenu

  

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim barang As New FrmSpp
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub petugas_Click(sender As Object, e As EventArgs) Handles petugas.Click
        Dim barang As New FrmPetugas
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim barang As New FrmKelas
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim barang As New FrmSiswa
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        Dim barang As New FrmLaporan
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim barang As New FrmPembayaran
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim barang As New FrmSpp
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label12.Text = Format(Now, "dd/MM/yyyy")
        Label13.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim barang As New FrmHistory
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim barang As New FrmBantuan
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Dim barang As New FrmRegister
        barang.TopLevel = False
        Panel_menu.Controls.Add(barang)
        Panel2.Hide()
        barang.Show()
    End Sub
End Class
Public Class frm_dua
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_kerja", conec)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_kerja")
        dtgrid.DataSource = DS.Tables("tb_kerja")
        dtgrid.Enabled = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmsatu.Show()
        Me.Hide()
    End Sub

    Private Sub dtgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrid.CellContentClick

    End Sub
End Class
Public Class frmdata
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_kerja", conec)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_kerja")
        DataGridView1.DataSource = DS.Tables("tb_kerja")
        DataGridView1.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmsatu.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
End Class
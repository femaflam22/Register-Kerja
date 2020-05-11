Public Class frmsatu
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        frmmasuk.Show()
        Me.Hide()
    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click
        frmliat.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class

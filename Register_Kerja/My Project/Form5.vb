Public Class frmliat
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles username.OnValueChanged

    End Sub

    Private Sub frmliat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmsatu.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Username & Password berupa NIS")
    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        If username.Text = "11907154" And pw.Text = "11907154" Then
            frm_dua.Show()
            Me.Hide()
        ElseIf username.Text = "11907154" And pw.Text = "" Then
            MsgBox("Password yang anda masukkan salah")
        ElseIf username.Text = "" And pw.Text = "11907154" Then
            MsgBox("Username yang anda masukkan salah")
        Else
            MsgBox("Silahkah isi terlebih dahulu username dan password nya")

        End If

    End Sub
End Class
Public Class frmmasuk
    Dim total As Integer
    Dim sqlnya As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_kerja", conec)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_kerja")
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conec
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox7.Enabled = False
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox6.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox6.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
        TextBox7.Text = TextBox1.Text
        TextBox10.Text = total
        If TextBox6.Text >= 320 Then
            Panel8.BackColor = Color.Green
        Else
            Panel8.BackColor = Color.Red
        End If

        If TextBox1.Text >= 80 Then
            Panel2.BackColor = Color.Green
        Else
            Panel2.BackColor = Color.Red
        End If
        If TextBox2.Text >= 80 Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If
        If TextBox3.Text >= 80 Then
            Panel4.BackColor = Color.Green
        Else
            Panel4.BackColor = Color.Red
        End If
        If TextBox4.Text >= 80 Then
            Panel5.BackColor = Color.Green
        Else
            Panel5.BackColor = Color.Red
        End If
        If TextBox5.Text >= 80 Then
            Panel6.BackColor = Color.Green
        Else
            Panel6.BackColor = Color.Red
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            total += 1
            TextBox10.Text = total
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox10.Enabled = False
    End Sub

    Private Sub frmmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmsatu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlnya = "insert into tb_kerja (Nama,NoDaftar,Tanggal,CheckBox,Nilai,Sertifikat,BidangAhli)values('" & TextBox8.Text & "','" & TextBox9.Text & "','" & DateTimePicker1.Text & "','" & TextBox10.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox1.Text & "')"
        Call jalan()
        MsgBox("Data berhasil tesimpan")
        Call panggildata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmliat.Show()
        Me.Hide()

    End Sub
End Class
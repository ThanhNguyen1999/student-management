﻿Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Đăng_ký_môn_học' table. You can move, or remove it, as needed.
        Me.Đăng_ký_môn_họcTableAdapter.Fill(Me.SinhVIenDataSet.Đăng_ký_môn_học)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = txttk.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Sinh_viên' table. You can move, or remove it, as needed.
        Me.Sinh_viênTableAdapter1.Fill(Me.SinhVIenDataSet.Sinh_viên)



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ComboBox2.Text = txttk.Text







    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Danh_sách_lớp_môn_học' table. You can move, or remove it, as needed.
        Me.Danh_sách_lớp_môn_họcTableAdapter.Fill(Me.SinhVIenDataSet.Danh_sách_lớp_môn_học)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = txttk.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
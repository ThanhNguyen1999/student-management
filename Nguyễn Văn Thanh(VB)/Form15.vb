Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Danh_sách_lớp_môn_học' table. You can move, or remove it, as needed.
        Me.Danh_sách_lớp_môn_họcTableAdapter.Fill(Me.SinhVIenDataSet.Danh_sách_lớp_môn_học)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ListView10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView10.SelectedIndexChanged

    End Sub
End Class
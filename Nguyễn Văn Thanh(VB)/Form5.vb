Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Danh_sách_lớp_môn_học' table. You can move, or remove it, as needed.
        Me.Danh_sách_lớp_môn_họcTableAdapter.Fill(Me.SinhVIenDataSet.Danh_sách_lớp_môn_học)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DanhSáchLớpMônHọcBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DanhSáchLớpMônHọcBindingSource.MoveLast()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DanhSáchLớpMônHọcBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DanhSáchLớpMônHọcBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo SaveErr
        DanhSáchLớpMônHọcBindingSource.EndEdit()
        Danh_sách_lớp_môn_họcTableAdapter.Update(SinhVIenDataSet.Danh_sách_lớp_môn_học)
        MessageBox.Show(" Đã lưu thành công")
SaveErr:
        Exit Sub

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DanhSáchLớpMônHọcBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DanhSáchLớpMônHọcBindingSource.AddNew()

    End Sub
End Class
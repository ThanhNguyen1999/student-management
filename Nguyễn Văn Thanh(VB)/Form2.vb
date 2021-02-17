Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Quản_Lý_Khoa' table. You can move, or remove it, as needed.
        Me.Quản_Lý_KhoaTableAdapter.Fill(Me.SinhVIenDataSet.Quản_Lý_Khoa)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        QuảnLýKhoaBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        QuảnLýKhoaBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        QuảnLýKhoaBindingSource.EndEdit()
        Quản_Lý_KhoaTableAdapter.Update(SinhVIenDataSet.Quản_Lý_Khoa)
        MessageBox.Show(" Đã lưu thành công")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
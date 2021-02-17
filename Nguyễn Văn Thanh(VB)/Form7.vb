Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Quản_Lý_Lớp' table. You can move, or remove it, as needed.
        Me.Quản_Lý_LớpTableAdapter.Fill(Me.SinhVIenDataSet.Quản_Lý_Lớp)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        QuảnLýLớpBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        QuảnLýLớpBindingSource.MoveLast()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QuảnLýLớpBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        QuảnLýLớpBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        QuảnLýLớpBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo SaveErr
        QuảnLýLớpBindingSource.EndEdit()
        Quản_Lý_LớpTableAdapter.Update(SinhVIenDataSet.Quản_Lý_Lớp)


        MessageBox.Show(" Đã lưu thành công")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        QuảnLýLớpBindingSource.RemoveCurrent()

    End Sub
End Class
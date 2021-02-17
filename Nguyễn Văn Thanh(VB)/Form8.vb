Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Đăng_ký_môn_học' table. You can move, or remove it, as needed.
        Me.Đăng_ký_môn_họcTableAdapter.Fill(Me.SinhVIenDataSet.Đăng_ký_môn_học)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ĐăngKýMônHọcBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ĐăngKýMônHọcBindingSource.MoveFirst()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ĐăngKýMônHọcBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ĐăngKýMônHọcBindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ĐăngKýMônHọcBindingSource.MoveLast()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ĐăngKýMônHọcBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo SaveErr
        ĐăngKýMônHọcBindingSource.EndEdit()
        Đăng_ký_môn_họcTableAdapter.Update(SinhVIenDataSet.Đăng_ký_môn_học)
        MessageBox.Show(" Đã lưu thành công")
SaveErr:
        Exit Sub
    End Sub
End Class
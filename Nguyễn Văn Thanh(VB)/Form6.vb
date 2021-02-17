Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Môn_Học' table. You can move, or remove it, as needed.
        Me.Môn_HọcTableAdapter.Fill(Me.SinhVIenDataSet.Môn_Học)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MônHọcBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MônHọcBindingSource.MoveLast()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MônHọcBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MônHọcBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MônHọcBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error GoTo SaveErr
        MônHọcBindingSource.EndEdit()
        Môn_HọcTableAdapter.Update(SinhVIenDataSet.Môn_Học)

        MessageBox.Show(" Đã lưu thành công")
SaveErr:
        Exit Sub

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MônHọcBindingSource.RemoveCurrent()

    End Sub
End Class
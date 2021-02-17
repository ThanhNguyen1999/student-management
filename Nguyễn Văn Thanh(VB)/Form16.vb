Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Quản_Lý_Khoa' table. You can move, or remove it, as needed.
        Me.Quản_Lý_KhoaTableAdapter.Fill(Me.SinhVIenDataSet.Quản_Lý_Khoa)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ListView11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView11.SelectedIndexChanged

    End Sub
End Class
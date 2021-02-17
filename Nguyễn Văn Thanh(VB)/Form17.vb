Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Quản_Lý_Lớp' table. You can move, or remove it, as needed.
        Me.Quản_Lý_LớpTableAdapter.Fill(Me.SinhVIenDataSet.Quản_Lý_Lớp)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
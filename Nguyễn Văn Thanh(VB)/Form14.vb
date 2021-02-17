Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Môn_Học' table. You can move, or remove it, as needed.
        Me.Môn_HọcTableAdapter.Fill(Me.SinhVIenDataSet.Môn_Học)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
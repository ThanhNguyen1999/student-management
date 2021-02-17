Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinhVIenDataSet.Sinh_viên' table. You can move, or remove it, as needed.
        Me.Sinh_viênTableAdapter1.Fill(Me.SinhVIenDataSet.Sinh_viên)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Sinh_viênTableAdapter.FillBy(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.Sinh_viên)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If GioiTinhDataGridViewTextBoxColumn.DataGridView.DataSource = -1 Then
            GioiTinhDataGridViewTextBoxColumn.DataGridView.DataSource = "nam"
        End If






    End Sub
End Class
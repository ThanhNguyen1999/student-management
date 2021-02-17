Public Class TestTK2
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Nguyễn_Văn_Thanh_Access__BackupDataSet.Sinh_viên' table. You can move, or remove it, as needed.
        Me.Sinh_viênTableAdapter.Fill(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.Sinh_viên)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SinhViênBindingSource.Filter = "(MaSV LIKE '" & txt.Text & "')" &
                "OR (MaLop LIKE '" & txt.Text & "') OR(HoTen LIKE '" & txt.Text & "')" &
                "OR (DiaChi LIKE '" & txt.Text & "') OR ( SoDT LIKE '" & txt.Text & "')"

        If txt.Text = SinhViênBindingSource.Filter Then
            txt.Text = Text


        End If




    End Sub
End Class
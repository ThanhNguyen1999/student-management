Public Class TestTK
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Nguyễn_Văn_Thanh_Access__BackupDataSet.Sinh_viên' table. You can move, or remove it, as needed.
        Me.Sinh_viênTableAdapter.Fill(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.Sinh_viên)
        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        Me.reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SearchErr
        If txt.Text = "" Then
            Call notFound()

            Exit Sub
        Else

            Dim cantFine As String = txt.Text
            Me.dgvFill()
            SinhViênBindingSource.Filter = "(Convert(MaSV, ' System.String') LIKE '" & txt.Text & "')" &
                "OR (MaLop LIKE '" & txt.Text & "') OR(HoTen LIKE '" & txt.Text & "')" &
                "OR (DiaChi LIKE '" & txt.Text & "') OR ( SoDT LIKE '" & txt.Text & "')"

            If SinhViênBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = SinhViênBindingSource

                End With
            End If

            Me.notFound()

            MsgBox(" --> Loi cmnr")

            SinhViênBindingSource.Filter = Nothing
            With DataGridView1
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = SinhViênBindingSource


            End With



        End If

SearchErr:

ErrExit:
        Exit Sub

        MsgBox("Error ")
        Resume ErrExit

    End Sub

    Private Sub reset()
        Dim txtS As TextBox = txt
        With txtS
            .Text = ""
            .Select()
            .BackColor = Color.LightCyan

        End With
        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgv1 As DataGridView = DataGridView1
        With dgv1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

        End With


    End Sub

    Private Sub dgvFill()
        txt.BackColor = Color.LightBlue

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim Mydgv1 As DataGridView = DataGridView1
        With Mydgv1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

        End With
    End Sub

    Private Sub notFound()
        Dim txtS As TextBox = txt
        With txtS
            .BackColor = Color.White
            .Select()
            .SelectAll()


        End With

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgv As DataGridView = DataGridView1
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White

        End With
    End Sub
End Class
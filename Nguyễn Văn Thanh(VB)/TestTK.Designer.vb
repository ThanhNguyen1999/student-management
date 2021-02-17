<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestTK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__BackupDataSet()
        Me.SinhViênBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sinh_viênTableAdapter = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Sinh_viênTableAdapter()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SinhVienĐăngKýMônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Đăng_ký_môn_họcTableAdapter = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Đăng_ký_môn_họcTableAdapter()
        Me.SoDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVienĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.MaLopDataGridViewTextBoxColumn, Me.HoTenDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.SoDTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SinhViênBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(702, 186)
        Me.DataGridView1.TabIndex = 0
        '
        '_Nguyễn_Văn_Thanh_Access__BackupDataSet
        '
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.DataSetName = "_Nguyễn_Văn_Thanh_Access__BackupDataSet"
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinhViênBindingSource
        '
        Me.SinhViênBindingSource.DataMember = "Sinh viên"
        Me.SinhViênBindingSource.DataSource = Me._Nguyễn_Văn_Thanh_Access__BackupDataSet
        '
        'Sinh_viênTableAdapter
        '
        Me.Sinh_viênTableAdapter.ClearBeforeFill = True
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(59, 331)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(502, 29)
        Me.txt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(623, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tìm kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SinhVienĐăngKýMônHọcBindingSource
        '
        Me.SinhVienĐăngKýMônHọcBindingSource.DataMember = "SinhVienĐăng ký môn học"
        Me.SinhVienĐăngKýMônHọcBindingSource.DataSource = Me.SinhViênBindingSource
        '
        'Đăng_ký_môn_họcTableAdapter
        '
        Me.Đăng_ký_môn_họcTableAdapter.ClearBeforeFill = True
        '
        'SoDTDataGridViewTextBoxColumn
        '
        Me.SoDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.HeaderText = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.Name = "SoDTDataGridViewTextBoxColumn"
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        '
        'HoTenDataGridViewTextBoxColumn
        '
        Me.HoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.HeaderText = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.Name = "HoTenDataGridViewTextBoxColumn"
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVienĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _Nguyễn_Văn_Thanh_Access__BackupDataSet As _Nguyễn_Văn_Thanh_Access__BackupDataSet
    Friend WithEvents SinhViênBindingSource As BindingSource
    Friend WithEvents Sinh_viênTableAdapter As _Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Sinh_viênTableAdapter
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SinhVienĐăngKýMônHọcBindingSource As BindingSource
    Friend WithEvents Đăng_ký_môn_họcTableAdapter As _Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Đăng_ký_môn_họcTableAdapter
    Friend WithEvents MaLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

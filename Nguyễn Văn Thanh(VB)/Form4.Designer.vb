<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NguyễnVănThanhAccessBackupCopyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet()
        Me.SinhViênBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NguyễnVănThanhAccessBackupDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__BackupDataSet()
        Me.Sinh_viênTableAdapter = New Nguyễn_Văn_Thanh_VB_._Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Sinh_viênTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.SinhViênBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sinh_viênTableAdapter1 = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Sinh_viênTableAdapter()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NguyễnVănThanhAccessBackupCopyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NguyễnVănThanhAccessBackupDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhViênBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.MaLopDataGridViewTextBoxColumn, Me.HoTenDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.SoDTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SinhViênBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(26, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(775, 327)
        Me.DataGridView1.TabIndex = 0
        '
        'NguyễnVănThanhAccessBackupCopyDataSetBindingSource
        '
        Me.NguyễnVănThanhAccessBackupCopyDataSetBindingSource.DataSource = Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet
        Me.NguyễnVănThanhAccessBackupCopyDataSetBindingSource.Position = 0
        '
        '_Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet
        '
        Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet.DataSetName = "_Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet"
        Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinhViênBindingSource
        '
        Me.SinhViênBindingSource.DataMember = "Sinh viên"
        Me.SinhViênBindingSource.DataSource = Me.NguyễnVănThanhAccessBackupDataSetBindingSource
        '
        'NguyễnVănThanhAccessBackupDataSetBindingSource
        '
        Me.NguyễnVănThanhAccessBackupDataSetBindingSource.DataSource = Me._Nguyễn_Văn_Thanh_Access__BackupDataSet
        Me.NguyễnVănThanhAccessBackupDataSetBindingSource.Position = 0
        '
        '_Nguyễn_Văn_Thanh_Access__BackupDataSet
        '
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.DataSetName = "_Nguyễn_Văn_Thanh_Access__BackupDataSet"
        Me._Nguyễn_Văn_Thanh_Access__BackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sinh_viênTableAdapter
        '
        Me.Sinh_viênTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Danh Sách Sinh Viên Đã Đăng Kí"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(3, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(819, 88)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(699, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(3, 107)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(17, 331)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(807, 107)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(17, 331)
        Me.ListView3.TabIndex = 5
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(3, 438)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(821, 19)
        Me.ListView4.TabIndex = 6
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(844, 25)
        Me.FillByToolStrip.TabIndex = 7
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SinhViênBindingSource1
        '
        Me.SinhViênBindingSource1.DataMember = "Sinh viên"
        Me.SinhViênBindingSource1.DataSource = Me.SinhVIenDataSet
        '
        'Sinh_viênTableAdapter1
        '
        Me.Sinh_viênTableAdapter1.ClearBeforeFill = True
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        Me.MaLopDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoTenDataGridViewTextBoxColumn
        '
        Me.HoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.HeaderText = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.Name = "HoTenDataGridViewTextBoxColumn"
        Me.HoTenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoDTDataGridViewTextBoxColumn
        '
        Me.SoDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.HeaderText = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.Name = "SoDTDataGridViewTextBoxColumn"
        Me.SoDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 477)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NguyễnVănThanhAccessBackupCopyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NguyễnVănThanhAccessBackupDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Nguyễn_Văn_Thanh_Access__BackupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhViênBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NguyễnVănThanhAccessBackupDataSetBindingSource As BindingSource
    Friend WithEvents _Nguyễn_Văn_Thanh_Access__BackupDataSet As _Nguyễn_Văn_Thanh_Access__BackupDataSet
    Friend WithEvents SinhViênBindingSource As BindingSource
    Friend WithEvents Sinh_viênTableAdapter As _Nguyễn_Văn_Thanh_Access__BackupDataSetTableAdapters.Sinh_viênTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents NguyễnVănThanhAccessBackupCopyDataSetBindingSource As BindingSource
    Friend WithEvents _Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet As _Nguyễn_Văn_Thanh_Access__Backup___CopyDataSet
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents SinhViênBindingSource1 As BindingSource
    Friend WithEvents Sinh_viênTableAdapter1 As SinhVIenDataSetTableAdapters.Sinh_viênTableAdapter
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

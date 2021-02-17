<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.MaNganhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LopQLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhoaHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamNhapHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiSoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuảnLýLớpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Quản_Lý_LớpTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Quản_Lý_LớpTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ListView6 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuảnLýLớpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNganhDataGridViewTextBoxColumn, Me.MaLopDataGridViewTextBoxColumn, Me.LopQLDataGridViewTextBoxColumn, Me.KhoaHocDataGridViewTextBoxColumn, Me.NamNhapHocDataGridViewTextBoxColumn, Me.SiSoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuảnLýLớpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNganhDataGridViewTextBoxColumn
        '
        Me.MaNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.Name = "MaNganhDataGridViewTextBoxColumn"
        Me.MaNganhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        Me.MaLopDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LopQLDataGridViewTextBoxColumn
        '
        Me.LopQLDataGridViewTextBoxColumn.DataPropertyName = "LopQL"
        Me.LopQLDataGridViewTextBoxColumn.HeaderText = "LopQL"
        Me.LopQLDataGridViewTextBoxColumn.Name = "LopQLDataGridViewTextBoxColumn"
        Me.LopQLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KhoaHocDataGridViewTextBoxColumn
        '
        Me.KhoaHocDataGridViewTextBoxColumn.DataPropertyName = "KhoaHoc"
        Me.KhoaHocDataGridViewTextBoxColumn.HeaderText = "KhoaHoc"
        Me.KhoaHocDataGridViewTextBoxColumn.Name = "KhoaHocDataGridViewTextBoxColumn"
        Me.KhoaHocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamNhapHocDataGridViewTextBoxColumn
        '
        Me.NamNhapHocDataGridViewTextBoxColumn.DataPropertyName = "NamNhapHoc"
        Me.NamNhapHocDataGridViewTextBoxColumn.HeaderText = "NamNhapHoc"
        Me.NamNhapHocDataGridViewTextBoxColumn.Name = "NamNhapHocDataGridViewTextBoxColumn"
        Me.NamNhapHocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SiSoDataGridViewTextBoxColumn
        '
        Me.SiSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo"
        Me.SiSoDataGridViewTextBoxColumn.HeaderText = "SiSo"
        Me.SiSoDataGridViewTextBoxColumn.Name = "SiSoDataGridViewTextBoxColumn"
        Me.SiSoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuảnLýLớpBindingSource
        '
        Me.QuảnLýLớpBindingSource.DataMember = "Quản Lý Lớp"
        Me.QuảnLýLớpBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Quản_Lý_LớpTableAdapter
        '
        Me.Quản_Lý_LớpTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(429, 42)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Danh Sách Quản Lý Lớp"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(584, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 31)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(13, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(676, 75)
        Me.ListView1.TabIndex = 47
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(13, 392)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(686, 21)
        Me.ListView2.TabIndex = 48
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(12, 94)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(518, 31)
        Me.ListView3.TabIndex = 49
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(536, 94)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(45, 31)
        Me.ListView4.TabIndex = 50
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(12, 146)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(16, 240)
        Me.ListView5.TabIndex = 51
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(683, 94)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(16, 292)
        Me.ListView6.TabIndex = 52
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(701, 419)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuảnLýLớpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents QuảnLýLớpBindingSource As BindingSource
    Friend WithEvents Quản_Lý_LớpTableAdapter As SinhVIenDataSetTableAdapters.Quản_Lý_LớpTableAdapter
    Friend WithEvents MaNganhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LopQLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KhoaHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamNhapHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SiSoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListView5 As ListView
    Friend WithEvents ListView6 As ListView
End Class

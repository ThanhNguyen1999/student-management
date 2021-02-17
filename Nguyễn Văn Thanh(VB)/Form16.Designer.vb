<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.TenNganhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuảnLýKhoaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Quản_Lý_KhoaTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Quản_Lý_KhoaTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ListView7 = New System.Windows.Forms.ListView()
        Me.ListView8 = New System.Windows.Forms.ListView()
        Me.ListView9 = New System.Windows.Forms.ListView()
        Me.ListView10 = New System.Windows.Forms.ListView()
        Me.ListView11 = New System.Windows.Forms.ListView()
        Me.ListView12 = New System.Windows.Forms.ListView()
        Me.ListView13 = New System.Windows.Forms.ListView()
        Me.ListView14 = New System.Windows.Forms.ListView()
        Me.ListView15 = New System.Windows.Forms.ListView()
        Me.ListView16 = New System.Windows.Forms.ListView()
        Me.ListView17 = New System.Windows.Forms.ListView()
        Me.ListView18 = New System.Windows.Forms.ListView()
        Me.ListView19 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuảnLýKhoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNganhDataGridViewTextBoxColumn, Me.TenNganhDataGridViewTextBoxColumn, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuảnLýKhoaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(447, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNganhDataGridViewTextBoxColumn
        '
        Me.MaNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.Name = "MaNganhDataGridViewTextBoxColumn"
        Me.MaNganhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenNganhDataGridViewTextBoxColumn
        '
        Me.TenNganhDataGridViewTextBoxColumn.DataPropertyName = "TenNganh"
        Me.TenNganhDataGridViewTextBoxColumn.HeaderText = "TenNganh"
        Me.TenNganhDataGridViewTextBoxColumn.Name = "TenNganhDataGridViewTextBoxColumn"
        Me.TenNganhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
        Me.TenKhoaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuảnLýKhoaBindingSource
        '
        Me.QuảnLýKhoaBindingSource.DataMember = "Quản Lý Khoa"
        Me.QuảnLýKhoaBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Quản_Lý_KhoaTableAdapter
        '
        Me.Quản_Lý_KhoaTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Danh Sách Quản Lý Khoa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(17, 273)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(483, 135)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(17, 150)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(483, 12)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(17, 97)
        Me.ListView3.TabIndex = 5
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(12, 291)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(233, 10)
        Me.ListView4.TabIndex = 6
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(267, 291)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(233, 10)
        Me.ListView5.TabIndex = 7
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(35, 119)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(233, 10)
        Me.ListView6.TabIndex = 8
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(244, 76)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(233, 10)
        Me.ListView7.TabIndex = 9
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(244, 99)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(24, 10)
        Me.ListView8.TabIndex = 10
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'ListView9
        '
        Me.ListView9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView9.Location = New System.Drawing.Point(30, 12)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(130, 10)
        Me.ListView9.TabIndex = 11
        Me.ListView9.UseCompatibleStateImageBehavior = False
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(166, 12)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(18, 10)
        Me.ListView10.TabIndex = 12
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView11
        '
        Me.ListView11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView11.Location = New System.Drawing.Point(190, 12)
        Me.ListView11.Name = "ListView11"
        Me.ListView11.Size = New System.Drawing.Size(18, 10)
        Me.ListView11.TabIndex = 13
        Me.ListView11.UseCompatibleStateImageBehavior = False
        '
        'ListView12
        '
        Me.ListView12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView12.Location = New System.Drawing.Point(214, 12)
        Me.ListView12.Name = "ListView12"
        Me.ListView12.Size = New System.Drawing.Size(18, 10)
        Me.ListView12.TabIndex = 14
        Me.ListView12.UseCompatibleStateImageBehavior = False
        '
        'ListView13
        '
        Me.ListView13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView13.Location = New System.Drawing.Point(244, 12)
        Me.ListView13.Name = "ListView13"
        Me.ListView13.Size = New System.Drawing.Size(45, 10)
        Me.ListView13.TabIndex = 15
        Me.ListView13.UseCompatibleStateImageBehavior = False
        '
        'ListView14
        '
        Me.ListView14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView14.Location = New System.Drawing.Point(295, 12)
        Me.ListView14.Name = "ListView14"
        Me.ListView14.Size = New System.Drawing.Size(18, 10)
        Me.ListView14.TabIndex = 16
        Me.ListView14.UseCompatibleStateImageBehavior = False
        '
        'ListView15
        '
        Me.ListView15.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView15.Location = New System.Drawing.Point(319, 12)
        Me.ListView15.Name = "ListView15"
        Me.ListView15.Size = New System.Drawing.Size(18, 10)
        Me.ListView15.TabIndex = 17
        Me.ListView15.UseCompatibleStateImageBehavior = False
        '
        'ListView16
        '
        Me.ListView16.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView16.Location = New System.Drawing.Point(459, 12)
        Me.ListView16.Name = "ListView16"
        Me.ListView16.Size = New System.Drawing.Size(18, 10)
        Me.ListView16.TabIndex = 18
        Me.ListView16.UseCompatibleStateImageBehavior = False
        '
        'ListView17
        '
        Me.ListView17.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView17.Location = New System.Drawing.Point(422, 12)
        Me.ListView17.Name = "ListView17"
        Me.ListView17.Size = New System.Drawing.Size(18, 10)
        Me.ListView17.TabIndex = 19
        Me.ListView17.UseCompatibleStateImageBehavior = False
        '
        'ListView18
        '
        Me.ListView18.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView18.Location = New System.Drawing.Point(387, 12)
        Me.ListView18.Name = "ListView18"
        Me.ListView18.Size = New System.Drawing.Size(18, 10)
        Me.ListView18.TabIndex = 20
        Me.ListView18.UseCompatibleStateImageBehavior = False
        '
        'ListView19
        '
        Me.ListView19.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView19.Location = New System.Drawing.Point(353, 12)
        Me.ListView19.Name = "ListView19"
        Me.ListView19.Size = New System.Drawing.Size(18, 10)
        Me.ListView19.TabIndex = 21
        Me.ListView19.UseCompatibleStateImageBehavior = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(505, 308)
        Me.Controls.Add(Me.ListView19)
        Me.Controls.Add(Me.ListView18)
        Me.Controls.Add(Me.ListView17)
        Me.Controls.Add(Me.ListView16)
        Me.Controls.Add(Me.ListView15)
        Me.Controls.Add(Me.ListView14)
        Me.Controls.Add(Me.ListView13)
        Me.Controls.Add(Me.ListView12)
        Me.Controls.Add(Me.ListView11)
        Me.Controls.Add(Me.ListView10)
        Me.Controls.Add(Me.ListView9)
        Me.Controls.Add(Me.ListView8)
        Me.Controls.Add(Me.ListView7)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuảnLýKhoaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents QuảnLýKhoaBindingSource As BindingSource
    Friend WithEvents Quản_Lý_KhoaTableAdapter As SinhVIenDataSetTableAdapters.Quản_Lý_KhoaTableAdapter
    Friend WithEvents MaNganhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNganhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListView5 As ListView
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ListView7 As ListView
    Friend WithEvents ListView8 As ListView
    Friend WithEvents ListView9 As ListView
    Friend WithEvents ListView10 As ListView
    Friend WithEvents ListView11 As ListView
    Friend WithEvents ListView12 As ListView
    Friend WithEvents ListView13 As ListView
    Friend WithEvents ListView14 As ListView
    Friend WithEvents ListView15 As ListView
    Friend WithEvents ListView16 As ListView
    Friend WithEvents ListView17 As ListView
    Friend WithEvents ListView18 As ListView
    Friend WithEvents ListView19 As ListView
End Class

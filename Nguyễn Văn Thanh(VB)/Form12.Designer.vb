<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuảnLýLớpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNganhDataGridViewTextBoxColumn, Me.MaLopDataGridViewTextBoxColumn, Me.LopQLDataGridViewTextBoxColumn, Me.KhoaHocDataGridViewTextBoxColumn, Me.NamNhapHocDataGridViewTextBoxColumn, Me.SiSoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuảnLýLớpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(60, 225)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNganhDataGridViewTextBoxColumn
        '
        Me.MaNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.Name = "MaNganhDataGridViewTextBoxColumn"
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        '
        'LopQLDataGridViewTextBoxColumn
        '
        Me.LopQLDataGridViewTextBoxColumn.DataPropertyName = "LopQL"
        Me.LopQLDataGridViewTextBoxColumn.HeaderText = "LopQL"
        Me.LopQLDataGridViewTextBoxColumn.Name = "LopQLDataGridViewTextBoxColumn"
        '
        'KhoaHocDataGridViewTextBoxColumn
        '
        Me.KhoaHocDataGridViewTextBoxColumn.DataPropertyName = "KhoaHoc"
        Me.KhoaHocDataGridViewTextBoxColumn.HeaderText = "KhoaHoc"
        Me.KhoaHocDataGridViewTextBoxColumn.Name = "KhoaHocDataGridViewTextBoxColumn"
        '
        'NamNhapHocDataGridViewTextBoxColumn
        '
        Me.NamNhapHocDataGridViewTextBoxColumn.DataPropertyName = "NamNhapHoc"
        Me.NamNhapHocDataGridViewTextBoxColumn.HeaderText = "NamNhapHoc"
        Me.NamNhapHocDataGridViewTextBoxColumn.Name = "NamNhapHocDataGridViewTextBoxColumn"
        '
        'SiSoDataGridViewTextBoxColumn
        '
        Me.SiSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo"
        Me.SiSoDataGridViewTextBoxColumn.HeaderText = "SiSo"
        Me.SiSoDataGridViewTextBoxColumn.Name = "SiSoDataGridViewTextBoxColumn"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(363, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Sĩ Số"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýLớpBindingSource, "SiSo", True))
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(492, 171)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(86, 29)
        Me.TextBox6.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(316, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Năm Nhập Học"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýLớpBindingSource, "NamNhapHoc", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(492, 133)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(86, 29)
        Me.TextBox5.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Khóa Học"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýLớpBindingSource, "KhoaHoc", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(492, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(86, 29)
        Me.TextBox4.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tên Lớp"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýLớpBindingSource, "LopQL", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(185, 174)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 29)
        Me.TextBox3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Mã Lớp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Mã Ngành"
        '
        'txttk
        '
        Me.txttk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.QuảnLýLớpBindingSource, "MaLop", True))
        Me.txttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttk.Location = New System.Drawing.Point(306, 454)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(130, 29)
        Me.txttk.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Tìm Kiếm theo Mã Lớp"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.QuảnLýLớpBindingSource
        Me.ComboBox1.DisplayMember = "MaLop"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(185, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(562, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Tìm Kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(597, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 30)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýLớpBindingSource, "MaNganh", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(185, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 29)
        Me.TextBox1.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(429, 42)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Danh Sách Quản Lý Lớp"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 52)
        Me.ListView1.TabIndex = 47
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(12, 225)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(42, 52)
        Me.ListView2.TabIndex = 48
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(12, 297)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(42, 134)
        Me.ListView3.TabIndex = 49
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(708, 379)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(42, 52)
        Me.ListView4.TabIndex = 50
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(708, 225)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(42, 136)
        Me.ListView5.TabIndex = 51
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(624, 70)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(164, 88)
        Me.ListView6.TabIndex = 52
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(757, 164)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(31, 136)
        Me.ListView7.TabIndex = 53
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(757, 326)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(31, 136)
        Me.ListView8.TabIndex = 54
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'ListView9
        '
        Me.ListView9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView9.Location = New System.Drawing.Point(12, 449)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(42, 35)
        Me.ListView9.TabIndex = 55
        Me.ListView9.UseCompatibleStateImageBehavior = False
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(12, 70)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(31, 136)
        Me.ListView10.TabIndex = 56
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView11
        '
        Me.ListView11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView11.Location = New System.Drawing.Point(12, 212)
        Me.ListView11.Name = "ListView11"
        Me.ListView11.Size = New System.Drawing.Size(374, 10)
        Me.ListView11.TabIndex = 57
        Me.ListView11.UseCompatibleStateImageBehavior = False
        '
        'ListView12
        '
        Me.ListView12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView12.Location = New System.Drawing.Point(244, 74)
        Me.ListView12.Name = "ListView12"
        Me.ListView12.Size = New System.Drawing.Size(374, 10)
        Me.ListView12.TabIndex = 58
        Me.ListView12.UseCompatibleStateImageBehavior = False
        '
        'ListView13
        '
        Me.ListView13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView13.Location = New System.Drawing.Point(377, 437)
        Me.ListView13.Name = "ListView13"
        Me.ListView13.Size = New System.Drawing.Size(374, 10)
        Me.ListView13.TabIndex = 59
        Me.ListView13.UseCompatibleStateImageBehavior = False
        '
        'ListView14
        '
        Me.ListView14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView14.Location = New System.Drawing.Point(43, 489)
        Me.ListView14.Name = "ListView14"
        Me.ListView14.Size = New System.Drawing.Size(374, 10)
        Me.ListView14.TabIndex = 60
        Me.ListView14.UseCompatibleStateImageBehavior = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 504)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form12"
        Me.Text = "Form12"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SinhViênBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Thong = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sinh_viênTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Sinh_viênTableAdapter()
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
        Me.ListView15 = New System.Windows.Forms.ListView()
        Me.ListView16 = New System.Windows.Forms.ListView()
        Me.ListView17 = New System.Windows.Forms.ListView()
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Thong.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "MaSV", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(156, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 29)
        Me.TextBox1.TabIndex = 1
        '
        'SinhViênBindingSource
        '
        Me.SinhViênBindingSource.DataMember = "Sinh viên"
        Me.SinhViênBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mã Lớp"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "MaLop", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(156, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 29)
        Me.TextBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Họ và tên"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "HoTen", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(156, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 29)
        Me.TextBox3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Ngày sinh"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "NgaySinh", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(156, 151)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(183, 29)
        Me.TextBox4.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Địa chỉ"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "DiaChi", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(454, 103)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(143, 29)
        Me.TextBox5.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Số ĐT"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "SoDT", True))
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(454, 153)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(143, 29)
        Me.TextBox6.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(139, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Trước"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(19, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Đầu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(255, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 30)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Sau"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(139, 224)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 30)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Cuối"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(255, 224)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 30)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Thêm"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(359, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 30)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Lưu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(484, 224)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 30)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Xóa"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Thong
        '
        Me.Thong.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Thong.Controls.Add(Me.ComboBox1)
        Me.Thong.Controls.Add(Me.Label5)
        Me.Thong.Controls.Add(Me.Button1)
        Me.Thong.Controls.Add(Me.Button8)
        Me.Thong.Controls.Add(Me.Button7)
        Me.Thong.Controls.Add(Me.Button6)
        Me.Thong.Controls.Add(Me.Button5)
        Me.Thong.Controls.Add(Me.Button4)
        Me.Thong.Controls.Add(Me.Button3)
        Me.Thong.Controls.Add(Me.Button2)
        Me.Thong.Controls.Add(Me.Label7)
        Me.Thong.Controls.Add(Me.TextBox6)
        Me.Thong.Controls.Add(Me.Label6)
        Me.Thong.Controls.Add(Me.TextBox5)
        Me.Thong.Controls.Add(Me.Label4)
        Me.Thong.Controls.Add(Me.TextBox4)
        Me.Thong.Controls.Add(Me.Label3)
        Me.Thong.Controls.Add(Me.TextBox3)
        Me.Thong.Controls.Add(Me.Label2)
        Me.Thong.Controls.Add(Me.TextBox2)
        Me.Thong.Controls.Add(Me.Label1)
        Me.Thong.Controls.Add(Me.TextBox1)
        Me.Thong.Location = New System.Drawing.Point(15, 79)
        Me.Thong.Name = "Thong"
        Me.Thong.Size = New System.Drawing.Size(606, 271)
        Me.Thong.TabIndex = 35
        Me.Thong.TabStop = False
        Me.Thong.Text = "Thông Tin"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SinhViênBindingSource, "GioiTinh", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.ComboBox1.Location = New System.Drawing.Point(454, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 32)
        Me.ComboBox1.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Giới Tính"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(360, 188)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 30)
        Me.Button8.TabIndex = 35
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(660, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 262)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bảng Hiển Thị"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.MaLopDataGridViewTextBoxColumn, Me.HoTenDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.SoDTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SinhViênBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        '
        'HoTenDataGridViewTextBoxColumn
        '
        Me.HoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.HeaderText = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.Name = "HoTenDataGridViewTextBoxColumn"
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        '
        'SoDTDataGridViewTextBoxColumn
        '
        Me.SoDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.HeaderText = "SoDT"
        Me.SoDTDataGridViewTextBoxColumn.Name = "SoDTDataGridViewTextBoxColumn"
        '
        'Sinh_viênTableAdapter
        '
        Me.Sinh_viênTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(525, 42)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Cập Nhật Thông Tin Sinh Viên"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(11, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(610, 61)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(627, 12)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(39, 61)
        Me.ListView2.TabIndex = 39
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(672, 12)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(37, 61)
        Me.ListView3.TabIndex = 40
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(1184, 12)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(41, 61)
        Me.ListView4.TabIndex = 41
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(1137, 12)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(41, 61)
        Me.ListView5.TabIndex = 42
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(1090, 12)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(41, 61)
        Me.ListView6.TabIndex = 43
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(715, 12)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(60, 61)
        Me.ListView7.TabIndex = 44
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(781, 18)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(85, 42)
        Me.ListView8.TabIndex = 45
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'ListView9
        '
        Me.ListView9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView9.Location = New System.Drawing.Point(872, 12)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(41, 61)
        Me.ListView9.TabIndex = 46
        Me.ListView9.UseCompatibleStateImageBehavior = False
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(919, 18)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(85, 42)
        Me.ListView10.TabIndex = 47
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView11
        '
        Me.ListView11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView11.Location = New System.Drawing.Point(1010, 12)
        Me.ListView11.Name = "ListView11"
        Me.ListView11.Size = New System.Drawing.Size(74, 61)
        Me.ListView11.TabIndex = 48
        Me.ListView11.UseCompatibleStateImageBehavior = False
        '
        'ListView12
        '
        Me.ListView12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView12.Location = New System.Drawing.Point(627, 79)
        Me.ListView12.Name = "ListView12"
        Me.ListView12.Size = New System.Drawing.Size(27, 270)
        Me.ListView12.TabIndex = 49
        Me.ListView12.UseCompatibleStateImageBehavior = False
        '
        'ListView13
        '
        Me.ListView13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView13.Location = New System.Drawing.Point(15, 356)
        Me.ListView13.Name = "ListView13"
        Me.ListView13.Size = New System.Drawing.Size(1209, 10)
        Me.ListView13.TabIndex = 50
        Me.ListView13.UseCompatibleStateImageBehavior = False
        '
        'ListView14
        '
        Me.ListView14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView14.Location = New System.Drawing.Point(781, 71)
        Me.ListView14.Name = "ListView14"
        Me.ListView14.Size = New System.Drawing.Size(85, 10)
        Me.ListView14.TabIndex = 51
        Me.ListView14.UseCompatibleStateImageBehavior = False
        '
        'ListView15
        '
        Me.ListView15.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView15.Location = New System.Drawing.Point(919, 71)
        Me.ListView15.Name = "ListView15"
        Me.ListView15.Size = New System.Drawing.Size(85, 10)
        Me.ListView15.TabIndex = 52
        Me.ListView15.UseCompatibleStateImageBehavior = False
        '
        'ListView16
        '
        Me.ListView16.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView16.Location = New System.Drawing.Point(781, 2)
        Me.ListView16.Name = "ListView16"
        Me.ListView16.Size = New System.Drawing.Size(85, 10)
        Me.ListView16.TabIndex = 53
        Me.ListView16.UseCompatibleStateImageBehavior = False
        '
        'ListView17
        '
        Me.ListView17.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView17.Location = New System.Drawing.Point(919, 2)
        Me.ListView17.Name = "ListView17"
        Me.ListView17.Size = New System.Drawing.Size(85, 10)
        Me.ListView17.TabIndex = 54
        Me.ListView17.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1227, 370)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Thong)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SinhViênBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Thong.ResumeLayout(False)
        Me.Thong.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Thong As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents SinhViênBindingSource As BindingSource
    Friend WithEvents Sinh_viênTableAdapter As SinhVIenDataSetTableAdapters.Sinh_viênTableAdapter
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents ListView15 As ListView
    Friend WithEvents ListView16 As ListView
    Friend WithEvents ListView17 As ListView
End Class

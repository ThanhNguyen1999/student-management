<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.MaDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemQTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemKTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ĐăngKýMônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Đăng_ký_môn_họcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Đăng_ký_môn_họcTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ListView7 = New System.Windows.Forms.ListView()
        Me.ListView8 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDKDataGridViewTextBoxColumn, Me.MaSVDataGridViewTextBoxColumn, Me.MaLopDKDataGridViewTextBoxColumn, Me.DiemQTDataGridViewTextBoxColumn, Me.DiemKTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ĐăngKýMônHọcBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(75, 264)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'MaDKDataGridViewTextBoxColumn
        '
        Me.MaDKDataGridViewTextBoxColumn.DataPropertyName = "MaDK"
        Me.MaDKDataGridViewTextBoxColumn.HeaderText = "MaDK"
        Me.MaDKDataGridViewTextBoxColumn.Name = "MaDKDataGridViewTextBoxColumn"
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        '
        'MaLopDKDataGridViewTextBoxColumn
        '
        Me.MaLopDKDataGridViewTextBoxColumn.DataPropertyName = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.HeaderText = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.Name = "MaLopDKDataGridViewTextBoxColumn"
        '
        'DiemQTDataGridViewTextBoxColumn
        '
        Me.DiemQTDataGridViewTextBoxColumn.DataPropertyName = "DiemQT"
        Me.DiemQTDataGridViewTextBoxColumn.HeaderText = "DiemQT"
        Me.DiemQTDataGridViewTextBoxColumn.Name = "DiemQTDataGridViewTextBoxColumn"
        '
        'DiemKTDataGridViewTextBoxColumn
        '
        Me.DiemKTDataGridViewTextBoxColumn.DataPropertyName = "DiemKT"
        Me.DiemKTDataGridViewTextBoxColumn.HeaderText = "DiemKT"
        Me.DiemKTDataGridViewTextBoxColumn.Name = "DiemKTDataGridViewTextBoxColumn"
        '
        'ĐăngKýMônHọcBindingSource
        '
        Me.ĐăngKýMônHọcBindingSource.DataMember = "Đăng ký môn học"
        Me.ĐăngKýMônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Đăng_ký_môn_họcTableAdapter
        '
        Me.Đăng_ký_môn_họcTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(365, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Điểm Kết Thúc"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ĐăngKýMônHọcBindingSource, "DiemKT", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(521, 201)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 29)
        Me.TextBox4.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Điểm Quá Trình"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ĐăngKýMônHọcBindingSource, "DiemQT", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(521, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 29)
        Me.TextBox3.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Mã Lớp ĐK"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ĐăngKýMônHọcBindingSource, "MaLopDK", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 203)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(92, 29)
        Me.TextBox2.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txttk
        '
        Me.txttk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ĐăngKýMônHọcBindingSource, "MaSV", True))
        Me.txttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttk.Location = New System.Drawing.Point(251, 81)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(155, 29)
        Me.txttk.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(518, 42)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Danh Sách Đăng Ký Môn Học"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Tìm Theo Mã SV"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ĐăngKýMônHọcBindingSource
        Me.ComboBox1.DisplayMember = "MaSV"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(200, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(251, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 34)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Tìm Kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(499, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(53, 255)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(582, 171)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(12, 12)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(649, 63)
        Me.ListView2.TabIndex = 39
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(12, 111)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(233, 39)
        Me.ListView3.TabIndex = 40
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(428, 116)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(233, 39)
        Me.ListView4.TabIndex = 41
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(12, 156)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(40, 270)
        Me.ListView5.TabIndex = 42
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(641, 218)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(25, 208)
        Me.ListView6.TabIndex = 43
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(369, 235)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(266, 10)
        Me.ListView7.TabIndex = 44
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(58, 191)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(266, 10)
        Me.ListView8.TabIndex = 45
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 450)
        Me.Controls.Add(Me.ListView8)
        Me.Controls.Add(Me.ListView7)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.Name = "Form13"
        Me.Text = "Form13"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents ĐăngKýMônHọcBindingSource As BindingSource
    Friend WithEvents Đăng_ký_môn_họcTableAdapter As SinhVIenDataSetTableAdapters.Đăng_ký_môn_họcTableAdapter
    Friend WithEvents MaDKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaLopDKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemQTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemKTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListView5 As ListView
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ListView7 As ListView
    Friend WithEvents ListView8 As ListView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.MaLopDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LopMonHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HockyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DanhSáchLớpMônHọcBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.DanhSáchLớpMônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Danh_sách_lớp_môn_họcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Danh_sách_lớp_môn_họcTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLopDKDataGridViewTextBoxColumn, Me.MaMonDataGridViewTextBoxColumn, Me.LopMonHocDataGridViewTextBoxColumn, Me.NamHocDataGridViewTextBoxColumn, Me.HockyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DanhSáchLớpMônHọcBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(24, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(560, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'MaLopDKDataGridViewTextBoxColumn
        '
        Me.MaLopDKDataGridViewTextBoxColumn.DataPropertyName = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.HeaderText = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.Name = "MaLopDKDataGridViewTextBoxColumn"
        '
        'MaMonDataGridViewTextBoxColumn
        '
        Me.MaMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.HeaderText = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.Name = "MaMonDataGridViewTextBoxColumn"
        '
        'LopMonHocDataGridViewTextBoxColumn
        '
        Me.LopMonHocDataGridViewTextBoxColumn.DataPropertyName = "LopMonHoc"
        Me.LopMonHocDataGridViewTextBoxColumn.HeaderText = "LopMonHoc"
        Me.LopMonHocDataGridViewTextBoxColumn.Name = "LopMonHocDataGridViewTextBoxColumn"
        '
        'NamHocDataGridViewTextBoxColumn
        '
        Me.NamHocDataGridViewTextBoxColumn.DataPropertyName = "NamHoc"
        Me.NamHocDataGridViewTextBoxColumn.HeaderText = "NamHoc"
        Me.NamHocDataGridViewTextBoxColumn.Name = "NamHocDataGridViewTextBoxColumn"
        '
        'HockyDataGridViewTextBoxColumn
        '
        Me.HockyDataGridViewTextBoxColumn.DataPropertyName = "Hocky"
        Me.HockyDataGridViewTextBoxColumn.HeaderText = "Hocky"
        Me.HockyDataGridViewTextBoxColumn.Name = "HockyDataGridViewTextBoxColumn"
        '
        'DanhSáchLớpMônHọcBindingSource1
        '
        Me.DanhSáchLớpMônHọcBindingSource1.DataMember = "Danh sách lớp môn học"
        Me.DanhSáchLớpMônHọcBindingSource1.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DanhSáchLớpMônHọcBindingSource
        '
        Me.DanhSáchLớpMônHọcBindingSource.DataMember = "Danh sách lớp môn học"
        Me.DanhSáchLớpMônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'Danh_sách_lớp_môn_họcTableAdapter
        '
        Me.Danh_sách_lớp_môn_họcTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Học kỳ"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DanhSáchLớpMônHọcBindingSource1, "Hocky", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(458, 202)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 29)
        Me.TextBox5.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Năm Học"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DanhSáchLớpMônHọcBindingSource1, "NamHoc", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(458, 150)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 29)
        Me.TextBox4.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Lớp Môn Học"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DanhSáchLớpMônHọcBindingSource1, "LopMonHoc", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(162, 202)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 29)
        Me.TextBox3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã Môn"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DanhSáchLớpMônHọcBindingSource1, "MaMon", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(162, 155)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 29)
        Me.TextBox2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã Lớp ĐK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(437, 42)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Danh Sách Lớp Môn Học"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 503)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tìm Kiếm Theo Mã Lớp ĐK"
        '
        'txttk
        '
        Me.txttk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DanhSáchLớpMônHọcBindingSource, "MaLopDK", True))
        Me.txttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttk.Location = New System.Drawing.Point(275, 500)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(141, 29)
        Me.txttk.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(458, 501)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 29)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tìm Kiếm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(443, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 42)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Thoát"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DanhSáchLớpMônHọcBindingSource1
        Me.ComboBox1.DisplayMember = "MaLopDK"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(162, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 32)
        Me.ComboBox1.TabIndex = 27
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(24, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(568, 86)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(24, 107)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(37, 442)
        Me.ListView2.TabIndex = 29
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(275, 104)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(37, 442)
        Me.ListView3.TabIndex = 30
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(499, 104)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(37, 442)
        Me.ListView4.TabIndex = 31
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(139, 100)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(173, 39)
        Me.ListView5.TabIndex = 32
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(318, 186)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(173, 10)
        Me.ListView6.TabIndex = 33
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(85, 490)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(173, 10)
        Me.ListView7.TabIndex = 34
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(320, 535)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(173, 10)
        Me.ListView8.TabIndex = 35
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'ListView9
        '
        Me.ListView9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView9.Location = New System.Drawing.Point(85, 234)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(173, 10)
        Me.ListView9.TabIndex = 36
        Me.ListView9.UseCompatibleStateImageBehavior = False
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(408, 121)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(85, 10)
        Me.ListView10.TabIndex = 37
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView11
        '
        Me.ListView11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView11.Location = New System.Drawing.Point(582, 100)
        Me.ListView11.Name = "ListView11"
        Me.ListView11.Size = New System.Drawing.Size(10, 445)
        Me.ListView11.TabIndex = 38
        Me.ListView11.UseCompatibleStateImageBehavior = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(604, 561)
        Me.Controls.Add(Me.ListView10)
        Me.Controls.Add(Me.ListView9)
        Me.Controls.Add(Me.ListView8)
        Me.Controls.Add(Me.ListView7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView11)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents DanhSáchLớpMônHọcBindingSource As BindingSource
    Friend WithEvents Danh_sách_lớp_môn_họcTableAdapter As SinhVIenDataSetTableAdapters.Danh_sách_lớp_môn_họcTableAdapter
    Friend WithEvents MaLopDKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaMonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LopMonHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HockyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DanhSáchLớpMônHọcBindingSource1 As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
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
End Class

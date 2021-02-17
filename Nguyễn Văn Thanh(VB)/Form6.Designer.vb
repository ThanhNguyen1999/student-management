<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.MônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Môn_HọcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Môn_HọcTableAdapter()
        Me.MaMonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTinchiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ListView6 = New System.Windows.Forms.ListView()
        Me.ListView7 = New System.Windows.Forms.ListView()
        Me.ListView8 = New System.Windows.Forms.ListView()
        Me.ListView9 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMonDataGridViewTextBoxColumn, Me.TenMonDataGridViewTextBoxColumn, Me.SoTinchiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MônHọcBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(389, 246)
        Me.DataGridView1.TabIndex = 0
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MônHọcBindingSource
        '
        Me.MônHọcBindingSource.DataMember = "Môn Học"
        Me.MônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'Môn_HọcTableAdapter
        '
        Me.Môn_HọcTableAdapter.ClearBeforeFill = True
        '
        'MaMonDataGridViewTextBoxColumn
        '
        Me.MaMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.HeaderText = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.Name = "MaMonDataGridViewTextBoxColumn"
        '
        'TenMonDataGridViewTextBoxColumn
        '
        Me.TenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon"
        Me.TenMonDataGridViewTextBoxColumn.HeaderText = "TenMon"
        Me.TenMonDataGridViewTextBoxColumn.Name = "TenMonDataGridViewTextBoxColumn"
        '
        'SoTinchiDataGridViewTextBoxColumn
        '
        Me.SoTinchiDataGridViewTextBoxColumn.DataPropertyName = "SoTinchi"
        Me.SoTinchiDataGridViewTextBoxColumn.HeaderText = "SoTinchi"
        Me.SoTinchiDataGridViewTextBoxColumn.Name = "SoTinchiDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 30)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Trước"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(408, 57)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 30)
        Me.Button8.TabIndex = 43
        Me.Button8.Text = "Thoát"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(407, 380)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 30)
        Me.Button7.TabIndex = 42
        Me.Button7.Text = "Xóa"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(407, 344)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 30)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Lưu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(408, 308)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 30)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Thêm"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(408, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 30)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Cuối"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(406, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 30)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Sau"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(408, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Đầu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Mã Môn"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MônHọcBindingSource, "MaMon", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(113, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 29)
        Me.TextBox1.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Tên Môn"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MônHọcBindingSource, "TenMon", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(113, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 29)
        Me.TextBox2.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Số Tín Chỉ"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MônHọcBindingSource, "SoTinchi", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(339, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 29)
        Me.TextBox3.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(464, 42)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nhập Danh Sách Môn Học"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(-2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(508, 61)
        Me.ListView1.TabIndex = 51
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(459, 69)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(33, 355)
        Me.ListView2.TabIndex = 52
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(420, 69)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(33, 355)
        Me.ListView3.TabIndex = 53
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(12, 414)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(402, 10)
        Me.ListView4.TabIndex = 54
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(0, 68)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(403, 10)
        Me.ListView5.TabIndex = 55
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'ListView6
        '
        Me.ListView6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView6.Location = New System.Drawing.Point(-2, 81)
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(405, 72)
        Me.ListView6.TabIndex = 56
        Me.ListView6.UseCompatibleStateImageBehavior = False
        '
        'ListView7
        '
        Me.ListView7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView7.Location = New System.Drawing.Point(-1, 152)
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(404, 10)
        Me.ListView7.TabIndex = 57
        Me.ListView7.UseCompatibleStateImageBehavior = False
        '
        'ListView8
        '
        Me.ListView8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView8.Location = New System.Drawing.Point(1, 81)
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(402, 10)
        Me.ListView8.TabIndex = 58
        Me.ListView8.UseCompatibleStateImageBehavior = False
        '
        'ListView9
        '
        Me.ListView9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView9.Location = New System.Drawing.Point(-1, 168)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(10, 256)
        Me.ListView9.TabIndex = 59
        Me.ListView9.UseCompatibleStateImageBehavior = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(515, 428)
        Me.Controls.Add(Me.ListView9)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView6)
        Me.Controls.Add(Me.ListView7)
        Me.Controls.Add(Me.ListView8)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SinhVIenDataSet As SinhVIenDataSet
    Friend WithEvents MônHọcBindingSource As BindingSource
    Friend WithEvents Môn_HọcTableAdapter As SinhVIenDataSetTableAdapters.Môn_HọcTableAdapter
    Friend WithEvents MaMonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenMonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoTinchiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListView5 As ListView
    Friend WithEvents ListView6 As ListView
    Friend WithEvents ListView7 As ListView
    Friend WithEvents ListView8 As ListView
    Friend WithEvents ListView9 As ListView
End Class

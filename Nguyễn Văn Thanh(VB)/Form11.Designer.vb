<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuảnLýKhoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNganhDataGridViewTextBoxColumn, Me.TenNganhDataGridViewTextBoxColumn, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuảnLýKhoaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(416, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNganhDataGridViewTextBoxColumn
        '
        Me.MaNganhDataGridViewTextBoxColumn.DataPropertyName = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.HeaderText = "MaNganh"
        Me.MaNganhDataGridViewTextBoxColumn.Name = "MaNganhDataGridViewTextBoxColumn"
        '
        'TenNganhDataGridViewTextBoxColumn
        '
        Me.TenNganhDataGridViewTextBoxColumn.DataPropertyName = "TenNganh"
        Me.TenNganhDataGridViewTextBoxColumn.HeaderText = "TenNganh"
        Me.TenNganhDataGridViewTextBoxColumn.Name = "TenNganhDataGridViewTextBoxColumn"
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
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
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýKhoaBindingSource, "TenKhoa", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(179, 244)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(260, 29)
        Me.TextBox3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Khoa Quản Lý"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuảnLýKhoaBindingSource, "TenNganh", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(179, 198)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 29)
        Me.TextBox2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tên Ngành học"
        '
        'txttk
        '
        Me.txttk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.QuảnLýKhoaBindingSource, "MaNganh", True))
        Me.txttk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttk.Location = New System.Drawing.Point(257, 75)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(182, 29)
        Me.txttk.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã Ngành Học"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 42)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tìm Kiếm Quản Lý Khoa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tìm theo Mã Ngành Học"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.QuảnLýKhoaBindingSource
        Me.ComboBox1.DisplayMember = "MaNganh"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(179, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 32)
        Me.ComboBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(332, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 45)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Tìm Kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(332, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 36)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(12, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(444, 459)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 464)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form11"
        Me.Text = "Form11"
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
End Class

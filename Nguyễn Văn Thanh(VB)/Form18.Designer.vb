<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Me.ĐăngKýMônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Đăng_ký_môn_họcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Đăng_ký_môn_họcTableAdapter()
        Me.MaDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaLopDKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemQTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemKTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDKDataGridViewTextBoxColumn, Me.MaSVDataGridViewTextBoxColumn, Me.MaLopDKDataGridViewTextBoxColumn, Me.DiemQTDataGridViewTextBoxColumn, Me.DiemKTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ĐăngKýMônHọcBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ĐăngKýMônHọcBindingSource
        '
        Me.ĐăngKýMônHọcBindingSource.DataMember = "Đăng ký môn học"
        Me.ĐăngKýMônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'Đăng_ký_môn_họcTableAdapter
        '
        Me.Đăng_ký_môn_họcTableAdapter.ClearBeforeFill = True
        '
        'MaDKDataGridViewTextBoxColumn
        '
        Me.MaDKDataGridViewTextBoxColumn.DataPropertyName = "MaDK"
        Me.MaDKDataGridViewTextBoxColumn.HeaderText = "MaDK"
        Me.MaDKDataGridViewTextBoxColumn.Name = "MaDKDataGridViewTextBoxColumn"
        Me.MaDKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaLopDKDataGridViewTextBoxColumn
        '
        Me.MaLopDKDataGridViewTextBoxColumn.DataPropertyName = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.HeaderText = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.Name = "MaLopDKDataGridViewTextBoxColumn"
        Me.MaLopDKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiemQTDataGridViewTextBoxColumn
        '
        Me.DiemQTDataGridViewTextBoxColumn.DataPropertyName = "DiemQT"
        Me.DiemQTDataGridViewTextBoxColumn.HeaderText = "DiemQT"
        Me.DiemQTDataGridViewTextBoxColumn.Name = "DiemQTDataGridViewTextBoxColumn"
        Me.DiemQTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiemKTDataGridViewTextBoxColumn
        '
        Me.DiemKTDataGridViewTextBoxColumn.DataPropertyName = "DiemKT"
        Me.DiemKTDataGridViewTextBoxColumn.HeaderText = "DiemKT"
        Me.DiemKTDataGridViewTextBoxColumn.Name = "DiemKTDataGridViewTextBoxColumn"
        Me.DiemKTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(688, 42)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Danh Sách Sinh Viên Đăng Ký Môn Học"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(597, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 36)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(12, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(688, 77)
        Me.ListView1.TabIndex = 47
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(12, 251)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(688, 31)
        Me.ListView2.TabIndex = 48
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(582, 137)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(118, 108)
        Me.ListView3.TabIndex = 49
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(3, 95)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(10, 150)
        Me.ListView4.TabIndex = 50
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(707, 294)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form18"
        Me.Text = "Form18"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ĐăngKýMônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
End Class

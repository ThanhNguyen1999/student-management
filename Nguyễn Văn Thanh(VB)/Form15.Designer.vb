<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.DanhSáchLớpMônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Danh_sách_lớp_môn_họcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Danh_sách_lớp_môn_họcTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView10 = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLopDKDataGridViewTextBoxColumn, Me.MaMonDataGridViewTextBoxColumn, Me.LopMonHocDataGridViewTextBoxColumn, Me.NamHocDataGridViewTextBoxColumn, Me.HockyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DanhSáchLớpMônHọcBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'MaLopDKDataGridViewTextBoxColumn
        '
        Me.MaLopDKDataGridViewTextBoxColumn.DataPropertyName = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.HeaderText = "MaLopDK"
        Me.MaLopDKDataGridViewTextBoxColumn.Name = "MaLopDKDataGridViewTextBoxColumn"
        Me.MaLopDKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaMonDataGridViewTextBoxColumn
        '
        Me.MaMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.HeaderText = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.Name = "MaMonDataGridViewTextBoxColumn"
        Me.MaMonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LopMonHocDataGridViewTextBoxColumn
        '
        Me.LopMonHocDataGridViewTextBoxColumn.DataPropertyName = "LopMonHoc"
        Me.LopMonHocDataGridViewTextBoxColumn.HeaderText = "LopMonHoc"
        Me.LopMonHocDataGridViewTextBoxColumn.Name = "LopMonHocDataGridViewTextBoxColumn"
        Me.LopMonHocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamHocDataGridViewTextBoxColumn
        '
        Me.NamHocDataGridViewTextBoxColumn.DataPropertyName = "NamHoc"
        Me.NamHocDataGridViewTextBoxColumn.HeaderText = "NamHoc"
        Me.NamHocDataGridViewTextBoxColumn.Name = "NamHocDataGridViewTextBoxColumn"
        Me.NamHocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HockyDataGridViewTextBoxColumn
        '
        Me.HockyDataGridViewTextBoxColumn.DataPropertyName = "Hocky"
        Me.HockyDataGridViewTextBoxColumn.HeaderText = "Hocky"
        Me.HockyDataGridViewTextBoxColumn.Name = "HockyDataGridViewTextBoxColumn"
        Me.HockyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DanhSáchLớpMônHọcBindingSource
        '
        Me.DanhSáchLớpMônHọcBindingSource.DataMember = "Danh sách lớp môn học"
        Me.DanhSáchLớpMônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Danh_sách_lớp_môn_họcTableAdapter
        '
        Me.Danh_sách_lớp_môn_họcTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(437, 42)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Danh Sách Lớp Môn Học"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 37)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(12, 12)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(545, 86)
        Me.ListView10.TabIndex = 47
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(3, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(10, 330)
        Me.ListView1.TabIndex = 48
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(561, 351)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView10)
        Me.Name = "Form15"
        Me.Text = "Form15"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DanhSáchLớpMônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView10 As ListView
    Friend WithEvents ListView1 As ListView
End Class

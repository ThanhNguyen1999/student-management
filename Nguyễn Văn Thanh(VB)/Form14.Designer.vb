<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.MaMonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTinchiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MônHọcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhVIenDataSet = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSet()
        Me.Môn_HọcTableAdapter = New Nguyễn_Văn_Thanh_VB_.SinhVIenDataSetTableAdapters.Môn_HọcTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView10 = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListView5 = New System.Windows.Forms.ListView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MônHọcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMonDataGridViewTextBoxColumn, Me.TenMonDataGridViewTextBoxColumn, Me.SoTinchiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MônHọcBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(457, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'MaMonDataGridViewTextBoxColumn
        '
        Me.MaMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.HeaderText = "MaMon"
        Me.MaMonDataGridViewTextBoxColumn.Name = "MaMonDataGridViewTextBoxColumn"
        Me.MaMonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenMonDataGridViewTextBoxColumn
        '
        Me.TenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon"
        Me.TenMonDataGridViewTextBoxColumn.HeaderText = "TenMon"
        Me.TenMonDataGridViewTextBoxColumn.Name = "TenMonDataGridViewTextBoxColumn"
        Me.TenMonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoTinchiDataGridViewTextBoxColumn
        '
        Me.SoTinchiDataGridViewTextBoxColumn.DataPropertyName = "SoTinchi"
        Me.SoTinchiDataGridViewTextBoxColumn.HeaderText = "SoTinchi"
        Me.SoTinchiDataGridViewTextBoxColumn.Name = "SoTinchiDataGridViewTextBoxColumn"
        Me.SoTinchiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MônHọcBindingSource
        '
        Me.MônHọcBindingSource.DataMember = "Môn Học"
        Me.MônHọcBindingSource.DataSource = Me.SinhVIenDataSet
        '
        'SinhVIenDataSet
        '
        Me.SinhVIenDataSet.DataSetName = "SinhVIenDataSet"
        Me.SinhVIenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Môn_HọcTableAdapter
        '
        Me.Môn_HọcTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(464, 42)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nhập Danh Sách Môn Học"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView10
        '
        Me.ListView10.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView10.Location = New System.Drawing.Point(12, 12)
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(477, 76)
        Me.ListView10.TabIndex = 53
        Me.ListView10.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.Location = New System.Drawing.Point(3, 94)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(10, 296)
        Me.ListView1.TabIndex = 54
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView2.Location = New System.Drawing.Point(482, 94)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(10, 296)
        Me.ListView2.TabIndex = 55
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView3.Location = New System.Drawing.Point(3, 396)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(292, 10)
        Me.ListView3.TabIndex = 56
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView4.Location = New System.Drawing.Point(315, 396)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(84, 10)
        Me.ListView4.TabIndex = 57
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListView5
        '
        Me.ListView5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ListView5.Location = New System.Drawing.Point(408, 396)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(84, 10)
        Me.ListView5.TabIndex = 58
        Me.ListView5.UseCompatibleStateImageBehavior = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 421)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView10)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MônHọcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SinhVIenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView10 As ListView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListView5 As ListView
End Class

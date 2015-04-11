<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lsanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lsanpham))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmlsp = New System.Windows.Forms.TextBox()
        Me.txttlsp = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btntat = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(96, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Mã loại sãn phẩm :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên loại Sãn phẩm :"
        '
        'txtmlsp
        '
        Me.txtmlsp.Location = New System.Drawing.Point(102, 20)
        Me.txtmlsp.Name = "txtmlsp"
        Me.txtmlsp.Size = New System.Drawing.Size(138, 20)
        Me.txtmlsp.TabIndex = 2
        '
        'txttlsp
        '
        Me.txttlsp.Location = New System.Drawing.Point(102, 75)
        Me.txttlsp.Name = "txttlsp"
        Me.txttlsp.Size = New System.Drawing.Size(138, 20)
        Me.txttlsp.TabIndex = 3
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(3, 112)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(84, 112)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 5
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(165, 112)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 6
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(279, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 157)
        Me.DataGridView1.TabIndex = 7
        '
        'Timer1
        '
        '
        'btntat
        '
        Me.btntat.Location = New System.Drawing.Point(165, 154)
        Me.btntat.Name = "btntat"
        Me.btntat.Size = New System.Drawing.Size(75, 23)
        Me.btntat.TabIndex = 8
        Me.btntat.Text = "Tắt"
        Me.btntat.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(84, 154)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(75, 23)
        Me.btnload.TabIndex = 9
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'Lsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(629, 194)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btntat)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txttlsp)
        Me.Controls.Add(Me.txtmlsp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lsanpham"
        Me.Text = "Lsanpham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmlsp As System.Windows.Forms.TextBox
    Friend WithEvents txttlsp As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btntat As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class khachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(khachhang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmkh = New System.Windows.Forms.TextBox()
        Me.txttkh = New System.Windows.Forms.TextBox()
        Me.txtdc = New System.Windows.Forms.TextBox()
        Me.txtq = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btntat = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên khách hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Địa chỉ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quận :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số điện thoại :"
        '
        'txtmkh
        '
        Me.txtmkh.Location = New System.Drawing.Point(119, 15)
        Me.txtmkh.Name = "txtmkh"
        Me.txtmkh.Size = New System.Drawing.Size(185, 20)
        Me.txtmkh.TabIndex = 5
        '
        'txttkh
        '
        Me.txttkh.Location = New System.Drawing.Point(119, 41)
        Me.txttkh.Name = "txttkh"
        Me.txttkh.Size = New System.Drawing.Size(185, 20)
        Me.txttkh.TabIndex = 6
        '
        'txtdc
        '
        Me.txtdc.Location = New System.Drawing.Point(119, 66)
        Me.txtdc.Name = "txtdc"
        Me.txtdc.Size = New System.Drawing.Size(185, 20)
        Me.txtdc.TabIndex = 7
        '
        'txtq
        '
        Me.txtq.Location = New System.Drawing.Point(119, 92)
        Me.txtq.Name = "txtq"
        Me.txtq.Size = New System.Drawing.Size(185, 20)
        Me.txtq.TabIndex = 8
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(119, 122)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(185, 20)
        Me.txtsdt.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(321, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(465, 207)
        Me.DataGridView1.TabIndex = 10
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(67, 167)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 11
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(148, 167)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 12
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(229, 167)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 13
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(148, 196)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(75, 23)
        Me.btnload.TabIndex = 14
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btntat
        '
        Me.btntat.Location = New System.Drawing.Point(229, 196)
        Me.btntat.Name = "btntat"
        Me.btntat.Size = New System.Drawing.Size(75, 23)
        Me.btntat.TabIndex = 15
        Me.btntat.Text = "Tắt"
        Me.btntat.UseVisualStyleBackColor = True
        '
        'khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(798, 229)
        Me.Controls.Add(Me.btntat)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtq)
        Me.Controls.Add(Me.txtdc)
        Me.Controls.Add(Me.txttkh)
        Me.Controls.Add(Me.txtmkh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "khachhang"
        Me.Text = "khachhang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmkh As System.Windows.Forms.TextBox
    Friend WithEvents txttkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdc As System.Windows.Forms.TextBox
    Friend WithEvents txtq As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents btntat As System.Windows.Forms.Button
End Class

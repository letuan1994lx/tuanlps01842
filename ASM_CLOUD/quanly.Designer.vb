<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quanly))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmsp = New System.Windows.Forms.TextBox()
        Me.txtlsp = New System.Windows.Forms.TextBox()
        Me.txttsp = New System.Windows.Forms.TextBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.txtsltk = New System.Windows.Forms.TextBox()
        Me.txtdg = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btntat = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Loại sản phẩm :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên sản phẩm :"
        '
        'txtmsp
        '
        Me.txtmsp.Location = New System.Drawing.Point(105, 17)
        Me.txtmsp.Name = "txtmsp"
        Me.txtmsp.Size = New System.Drawing.Size(162, 20)
        Me.txtmsp.TabIndex = 3
        '
        'txtlsp
        '
        Me.txtlsp.Location = New System.Drawing.Point(105, 54)
        Me.txtlsp.Name = "txtlsp"
        Me.txtlsp.Size = New System.Drawing.Size(162, 20)
        Me.txtlsp.TabIndex = 4
        '
        'txttsp
        '
        Me.txttsp.Location = New System.Drawing.Point(105, 92)
        Me.txttsp.Name = "txttsp"
        Me.txttsp.Size = New System.Drawing.Size(162, 20)
        Me.txttsp.TabIndex = 5
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(105, 204)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 6
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(192, 204)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 8
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'txtsltk
        '
        Me.txtsltk.Location = New System.Drawing.Point(105, 161)
        Me.txtsltk.Name = "txtsltk"
        Me.txtsltk.Size = New System.Drawing.Size(162, 20)
        Me.txtsltk.TabIndex = 9
        '
        'txtdg
        '
        Me.txtdg.Location = New System.Drawing.Point(105, 126)
        Me.txtdg.Name = "txtdg"
        Me.txtdg.Size = New System.Drawing.Size(162, 20)
        Me.txtdg.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(295, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(549, 169)
        Me.DataGridView1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Đơn giá :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Số lượng tồn kho :"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(20, 204)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 14
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btntat
        '
        Me.btntat.Location = New System.Drawing.Point(192, 245)
        Me.btntat.Name = "btntat"
        Me.btntat.Size = New System.Drawing.Size(75, 23)
        Me.btntat.TabIndex = 15
        Me.btntat.Text = "Tắt"
        Me.btntat.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(105, 245)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(75, 23)
        Me.btnload.TabIndex = 16
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'quanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(851, 279)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btntat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdg)
        Me.Controls.Add(Me.txtsltk)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.txttsp)
        Me.Controls.Add(Me.txtlsp)
        Me.Controls.Add(Me.txtmsp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "quanly"
        Me.Text = "quanly"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmsp As System.Windows.Forms.TextBox
    Friend WithEvents txtlsp As System.Windows.Forms.TextBox
    Friend WithEvents txttsp As System.Windows.Forms.TextBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents txtsltk As System.Windows.Forms.TextBox
    Friend WithEvents txtdg As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btntat As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
End Class

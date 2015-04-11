<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.mnsmenu = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.SãnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnithoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BảnQuyềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsmenu
        '
        Me.mnsmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.BảnQuyềnToolStripMenuItem, Me.mnithoat})
        Me.mnsmenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsmenu.Name = "mnsmenu"
        Me.mnsmenu.Size = New System.Drawing.Size(546, 24)
        Me.mnsmenu.TabIndex = 0
        Me.mnsmenu.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLSP, Me.SãnPhẩmToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'mniLSP
        '
        Me.mniLSP.Name = "mniLSP"
        Me.mniLSP.Size = New System.Drawing.Size(151, 22)
        Me.mniLSP.Text = "Loại sản phẩm"
        '
        'SãnPhẩmToolStripMenuItem
        '
        Me.SãnPhẩmToolStripMenuItem.Name = "SãnPhẩmToolStripMenuItem"
        Me.SãnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SãnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'ThôngTinKháchHàngToolStripMenuItem
        '
        Me.ThôngTinKháchHàngToolStripMenuItem.Name = "ThôngTinKháchHàngToolStripMenuItem"
        Me.ThôngTinKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ThôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinNhânViênToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'ThôngTinNhânViênToolStripMenuItem
        '
        Me.ThôngTinNhânViênToolStripMenuItem.Name = "ThôngTinNhânViênToolStripMenuItem"
        Me.ThôngTinNhânViênToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ThôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên"
        '
        'mnithoat
        '
        Me.mnithoat.Name = "mnithoat"
        Me.mnithoat.Size = New System.Drawing.Size(50, 20)
        Me.mnithoat.Text = "Thoát"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.PictureBox1.Image = Global.ASM_CLOUD.My.Resources.Resources.Leader_512
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(546, 238)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BảnQuyềnToolStripMenuItem
        '
        Me.BảnQuyềnToolStripMenuItem.Name = "BảnQuyềnToolStripMenuItem"
        Me.BảnQuyềnToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BảnQuyềnToolStripMenuItem.Text = "Bản quyền"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(546, 277)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnsmenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "main"
        Me.mnsmenu.ResumeLayout(False)
        Me.mnsmenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnithoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniLSP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SãnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BảnQuyềnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdangnhap))
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(36, 31)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(35, 13)
        Me.lbluser.TabIndex = 0
        Me.lbluser.Text = "User :"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(12, 69)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(59, 13)
        Me.lblpass.TabIndex = 1
        Me.lblpass.Text = "Password :"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(77, 24)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(156, 20)
        Me.txtuser.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(77, 62)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(156, 20)
        Me.txtpass.TabIndex = 3
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(77, 101)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btndangnhap.TabIndex = 4
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(158, 101)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ASM_CLOUD.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(258, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 100)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(376, 134)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmdangnhap"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Đăng nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

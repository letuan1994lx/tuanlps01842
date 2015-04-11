Public Class main

    
   
    Private Sub mnithoat_Click(sender As Object, e As EventArgs) Handles mnithoat.Click
        End
    End Sub

    

    Private Sub SãnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SãnPhẩmToolStripMenuItem.Click
        quanly.Show()
        Me.Hide()
    End Sub

    Private Sub mniLSP_Click(sender As Object, e As EventArgs) Handles mniLSP.Click
        Lsanpham.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem.Click
        khachhang.Show()
        Me.Hide()
    End Sub
    Private Sub ThôngTinNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinNhânViênToolStripMenuItem.Click
        nhanvien.Show()
        Me.Hide()
    End Sub

    Private Sub BảnQuyềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BảnQuyềnToolStripMenuItem.Click
        nguong.Show()
    End Sub
End Class
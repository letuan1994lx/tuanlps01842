Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanly
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842"
    Private Sub quanly_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from sanpham", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmsp.Text = DataGridView1.Item(0, index).Value
        txtlsp.Text = DataGridView1.Item(1, index).Value
        txttsp.Text = DataGridView1.Item(2, index).Value
        txtdg.Text = DataGridView1.Item(3, index).Value
        txtsltk.Text = DataGridView1.Item(4, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        quanly_Load()
    End Sub
    'Sua
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click, btnsua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update sanpham set LoaiSP_MaLoaiSP = @LoaiSP_MaLoaiSP,TenSP = @TenSP,DonGia = @DonGia,SoLuongTonKho = @SoLuongTonKho where masp = @masp "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@masp", txtmsp.Text)
            com.Parameters.AddWithValue("@LoaiSP_MaLoaiSP", txtlsp.Text)
            com.Parameters.AddWithValue("@TenSP", txttsp.Text)
            com.Parameters.AddWithValue("@DonGia", txtdg.Text)
            com.Parameters.AddWithValue("@SoLuongTonKho", txtsltk.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        quanly_Load()
    End Sub

    


        
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Sanpham where masp = @masp"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@masp", txtmsp.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        quanly_Load()

    End Sub

    Private Sub btnthem_Click_1(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO sanpham ( MaSP,LoaiSP_MaLoaiSP,TenSP,DonGia,SoLuongTonKho)"
        query &= "Values(@MaSP,@LoaiSP_MaLoaiSP,@TenSP,@DonGia,@SoLuongTonKho)"
        Using conn As New SqlConnection("workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSP", txtmsp.Text)
                    .Parameters.AddWithValue("@LoaiSP_MaLoaiSP", txtlsp.Text)
                    .Parameters.AddWithValue("@TenSP", txttsp.Text)
                    .Parameters.AddWithValue("@DonGia", txtdg.Text)
                    .Parameters.AddWithValue("@SoLuongTonKho", txtsltk.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        quanly_Load()
    End Sub

    Private Sub btntat_Click(sender As Object, e As EventArgs) Handles btntat.Click
        Me.Close()
        main.Show()
    End Sub

   
    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        quanly_Load()
    End Sub

  
End Class
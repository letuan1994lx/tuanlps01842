Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class nhanvien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842"
    Private Sub nhanvien_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from nhanvien", KetNoi)
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
        txtmnv.Text = DataGridView1.Item(0, index).Value
        txttnv.Text = DataGridView1.Item(1, index).Value
        txtcv.Text = DataGridView1.Item(2, index).Value
        txtpb.Text = DataGridView1.Item(3, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO NhanVien( MaNV,TenNV,ChucVu,PhongBan)"
        query &= "Values(@MaNV,@TenNV,@ChucVu,@PhongBan)"
        Using conn As New SqlConnection("workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNV", txtmnv.Text)
                    .Parameters.AddWithValue("@TenNV", txttnv.Text)
                    .Parameters.AddWithValue("@ChucVu", txtcv.Text)
                    .Parameters.AddWithValue("@PhongBan", txtpb.Text)
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
        nhanvien_Load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  nhanvien where MaNV = @MaNV"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNV", txtmnv.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update nhanvien set TenNV = @TenNV,ChucVu = @ChucVu, PhongBan = @PhongBan where MaNV = @MaNV "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaNV", txtmnv.Text)
            com.Parameters.AddWithValue("@TenNV", txttnv.Text)
            com.Parameters.AddWithValue("@ChucVu", txtcv.Text)
            com.Parameters.AddWithValue("@PhongBan", txtpb.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        main.Show()
    End Sub

    
End Class
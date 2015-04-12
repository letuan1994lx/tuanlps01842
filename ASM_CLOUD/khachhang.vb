Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class khachhang
'Tạo biến cho kết nối với database của Sever' Đoạn code này đã thêm vô bỡi account Letuan1994
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842"
    Private Sub khachhang_load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from khachhang", KetNoi)
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
        txtmkh.Text = DataGridView1.Item(0, index).Value
        txttkh.Text = DataGridView1.Item(1, index).Value
        txtdc.Text = DataGridView1.Item(2, index).Value
        txtq.Text = DataGridView1.Item(3, index).Value
        txtsdt.Text = DataGridView1.Item(4, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_load()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        Dim query As String = String.Empty
        query &= "SET IDENTITY_INSERT khachhang ON;"
        query &= "INSERT INTO khachhang (MaKH,TenKH,DiaChi,Quan,SDT)"
        query &= "Values(@MaKH,@TenKH,@DiaChi,@Quan,@SDT)"
        query &= "SET IDENTITY_INSERT khachhang off;"
        Using conn As New SqlConnection("workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", txtmkh.Text)
                    .Parameters.AddWithValue("@TenKH", txttkh.Text)
                    .Parameters.AddWithValue("@DiaChi", txtdc.Text)
                    .Parameters.AddWithValue("@Quan", txtq.Text)
                    .Parameters.AddWithValue("@SDT", txtsdt.Text)
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
        khachhang_load()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " update khachhang set TenKH = @TenKH ,DiaChi = @DiaChi,Quan = @Quan,SDT= @SDT where MaKH = @MaKH "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaKH", txtmkh.Text)
            com.Parameters.AddWithValue("@TenKH", txttkh.Text)
            com.Parameters.AddWithValue("@DiaChi", txtdc.Text)
            com.Parameters.AddWithValue("@Quan", txtq.Text)
            com.Parameters.AddWithValue("@SDT", txtsdt.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_load()
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Khachhang where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtmkh.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_load()

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        khachhang_load()
    End Sub

    Private Sub btntat_Click(sender As Object, e As EventArgs) Handles btntat.Click
        Me.Close()
        main.Show()
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Lsanpham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842"
    Private Sub Lsanpham_load()
        Timer1.Enabled = True
        Timer1.Interval = 10000
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LoaiSP", KetNoi)
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
        txtmlsp.Text = DataGridView1.Item(0, index).Value
        txttlsp.Text = DataGridView1.Item(1, index).Value
        
    End Sub
    'Sửa
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update LoaiSP set TenLoaiSP = @TenLoaiSP where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaLoaiSP", txtmlsp.Text)
            com.Parameters.AddWithValue("@TenLoaiSP", txttlsp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Lsanpham_load()
    End Sub
    'XÓA
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  LoaiSP where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoaiSP", txtmlsp.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Lsanpham_load()
    End Sub
    'THêm
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO LoaiSP ( MaLoaiSP,TenLoaiSP)"
        query &= "Values(@MaLoaiSP,@TenLoaiSP)"
        Using conn As New SqlConnection("workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiSP", txtmlsp.Text)
                    .Parameters.AddWithValue("@TenLoaiSP", txttlsp.Text)
                    
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Lsanpham_load()
        
    End Sub

    Private Sub btntat_Click(sender As Object, e As EventArgs) Handles btntat.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Lsanpham_load()
    End Sub
End Class
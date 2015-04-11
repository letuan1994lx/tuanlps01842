Imports System.Data.SqlClient
Public Class frmdangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click

        Dim chuoiketnoi As String = "workstation id=tuanlps01842.mssql.somee.com;packet size=4096;user id=tuanlps01842;pwd=Letuan123;data source=tuanlps01842.mssql.somee.com;persist security info=False;initial catalog=tuanlps01842"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)

        Dim sqlAdapter As New SqlDataAdapter("select * from login where tendangnhap ='" & txtuser.Text & "' and password='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Chào mừng bạn đến với chương trình này")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Xin vui lòng nhập đúng thông tin")
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub

    
End Class

﻿Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class capnhatKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Ps03058QLBH.mssql.somee.com;packet size=4096;user id=thao2607_SQLLogin_1;pwd=ccx7hzc6js;data source=Ps03058QLBH.mssql.somee.com;persist security info=False;initial catalog=Ps03058QLBH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub capnhatKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged, txtSDT.TextChanged, txtEmail.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMAKH.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG where MAKH=N'" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                    btnXoa.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMAKH.Text = dgvKH.Item(0, click).Value
        txtTenKH.Text = dgvKH.Item(1, click).Value
        txtAdd.Text = dgvKH.Item(2, click).Value
        txtSDT.Text = dgvKH.Item(3, click).Value
        txtEmail.Text = dgvKH.Item(4, click).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMAKH.Focus()
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMAKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtAdd.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtEmail.Focus()
                        Else
                            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                            save.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
                            save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                            save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                            save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMAKH.Text = Nothing
                            txtTenKH.Text = Nothing
                            txtAdd.Text = Nothing
                            txtSDT.Text = Nothing
                            txtEmail.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMAKH.Focus()
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMAKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtAdd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txtTenKH.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMAKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

   

    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMAKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMAKH.Text = Nothing
                    txtTenKH.Text = Nothing
                    txtAdd.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEmail.Text = Nothing
                    txtMAKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class
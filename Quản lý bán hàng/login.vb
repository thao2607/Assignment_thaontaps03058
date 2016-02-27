Public Class login

    Private Sub passlbl_Click(sender As Object, e As EventArgs) Handles passlbl.Click

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username As String = usertxt.Text
        Dim password As String = passtxt.Text
        If username = "admin" Then
            MessageBox.Show("Chúc mừng đã đăng nhập thành công", "Ps03058: thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Start()
        Else
            MessageBox.Show("Sai thông tin đăng nhập", "Ps03058: Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub userlbl_Click(sender As Object, e As EventArgs) Handles userlbl.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(2)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Timer1.Stop()
            main.Show()
            Me.Hide()
        End If
        Label4.Text = ProgressBar2.Value & "%"
    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub
End Class

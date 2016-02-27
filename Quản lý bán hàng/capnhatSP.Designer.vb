<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capnhatSP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMALOAI = New System.Windows.Forms.TextBox()
        Me.txtTENLOAI = New System.Windows.Forms.TextBox()
        Me.txtSOLUONG = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã SP :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(28, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên SP :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(28, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã loại :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(28, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tên loại :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Teal
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(25, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Số lượng :"
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(106, 31)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(216, 20)
        Me.txtMASP.TabIndex = 7
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(106, 63)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(216, 20)
        Me.txtTENSP.TabIndex = 8
        '
        'txtMALOAI
        '
        Me.txtMALOAI.AcceptsReturn = True
        Me.txtMALOAI.Location = New System.Drawing.Point(106, 96)
        Me.txtMALOAI.Name = "txtMALOAI"
        Me.txtMALOAI.Size = New System.Drawing.Size(216, 20)
        Me.txtMALOAI.TabIndex = 9
        '
        'txtTENLOAI
        '
        Me.txtTENLOAI.Location = New System.Drawing.Point(106, 129)
        Me.txtTENLOAI.Name = "txtTENLOAI"
        Me.txtTENLOAI.Size = New System.Drawing.Size(216, 20)
        Me.txtTENLOAI.TabIndex = 10
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.Location = New System.Drawing.Point(106, 163)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Size = New System.Drawing.Size(216, 20)
        Me.txtSOLUONG.TabIndex = 13
        Me.txtSOLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Teal
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLoad.Location = New System.Drawing.Point(365, 31)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(91, 40)
        Me.btnLoad.TabIndex = 14
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnCapnhat
        '
        Me.btnCapnhat.BackColor = System.Drawing.Color.Teal
        Me.btnCapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapnhat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCapnhat.Location = New System.Drawing.Point(420, 87)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(91, 38)
        Me.btnCapnhat.TabIndex = 15
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Teal
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThem.Location = New System.Drawing.Point(481, 31)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(82, 40)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Teal
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnXoa.Location = New System.Drawing.Point(365, 145)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(82, 38)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(12, 217)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(551, 191)
        Me.dgvSanpham.TabIndex = 18
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Teal
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDong.Location = New System.Drawing.Point(481, 145)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 38)
        Me.btnDong.TabIndex = 19
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'capnhatSP
        '
        Me.AccessibleName = "dgvSanpham"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quản_lý_bán_hàng.My.Resources.Resources._81
        Me.ClientSize = New System.Drawing.Size(607, 420)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtSOLUONG)
        Me.Controls.Add(Me.txtTENLOAI)
        Me.Controls.Add(Me.txtMALOAI)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "capnhatSP"
        Me.Text = "Cập nhập thông tin sản phẩm"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents txtTENSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMALOAI As System.Windows.Forms.TextBox
    Friend WithEvents txtTENLOAI As System.Windows.Forms.TextBox
    Friend WithEvents txtSOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
    Friend WithEvents btnDong As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thongtinKH
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
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemkh = New System.Windows.Forms.DataGridView()
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã KH :"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(118, 44)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(199, 20)
        Me.txtMAKH.TabIndex = 3
        '
        'btnXem
        '
        Me.btnXem.AccessibleDescription = ""
        Me.btnXem.BackColor = System.Drawing.Color.Teal
        Me.btnXem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnXem.Location = New System.Drawing.Point(133, 89)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 36)
        Me.btnXem.TabIndex = 5
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = False
        '
        'btnXemall
        '
        Me.btnXemall.AccessibleDescription = ""
        Me.btnXemall.BackColor = System.Drawing.Color.Teal
        Me.btnXemall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXemall.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnXemall.Location = New System.Drawing.Point(259, 89)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(122, 36)
        Me.btnXemall.TabIndex = 5
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = False
        '
        'btnDong
        '
        Me.btnDong.AccessibleDescription = ""
        Me.btnDong.BackColor = System.Drawing.Color.Teal
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDong.Location = New System.Drawing.Point(431, 89)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 36)
        Me.btnDong.TabIndex = 5
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'dgvXemkh
        '
        Me.dgvXemkh.AllowUserToDeleteRows = False
        Me.dgvXemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemkh.Location = New System.Drawing.Point(3, 152)
        Me.dgvXemkh.Name = "dgvXemkh"
        Me.dgvXemkh.Size = New System.Drawing.Size(516, 207)
        Me.dgvXemkh.TabIndex = 6
        '
        'thongtinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quản_lý_bán_hàng.My.Resources.Resources._8
        Me.ClientSize = New System.Drawing.Size(529, 371)
        Me.Controls.Add(Me.dgvXemkh)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "thongtinKH"
        Me.Text = "Xem thông tin khách hàng"
        CType(Me.dgvXemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemkh As System.Windows.Forms.DataGridView
End Class

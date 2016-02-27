<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thongtinSP
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
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(32, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã SP :"
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(137, 42)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(216, 20)
        Me.txtMASP.TabIndex = 8
        '
        'btnXem
        '
        Me.btnXem.AccessibleDescription = ""
        Me.btnXem.BackColor = System.Drawing.Color.Teal
        Me.btnXem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnXem.Location = New System.Drawing.Point(128, 92)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 36)
        Me.btnXem.TabIndex = 9
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = False
        '
        'btnXemall
        '
        Me.btnXemall.AccessibleDescription = ""
        Me.btnXemall.BackColor = System.Drawing.Color.Teal
        Me.btnXemall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXemall.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnXemall.Location = New System.Drawing.Point(250, 92)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(122, 36)
        Me.btnXemall.TabIndex = 10
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = False
        '
        'btnDong
        '
        Me.btnDong.AccessibleDescription = ""
        Me.btnDong.BackColor = System.Drawing.Color.Teal
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDong.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDong.Location = New System.Drawing.Point(431, 92)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 36)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'dgvXemsp
        '
        Me.dgvXemsp.AllowUserToDeleteRows = False
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(3, 143)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(537, 254)
        Me.dgvXemsp.TabIndex = 12
        '
        'thongtinSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quản_lý_bán_hàng.My.Resources.Resources._8
        Me.ClientSize = New System.Drawing.Size(549, 400)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "thongtinSP"
        Me.Text = "Xem thông tin sản phẩm"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
End Class

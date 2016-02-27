<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Me.accountlbl = New System.Windows.Forms.Label()
        Me.userlbl = New System.Windows.Forms.Label()
        Me.passlbl = New System.Windows.Forms.Label()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'accountlbl
        '
        Me.accountlbl.AutoSize = True
        Me.accountlbl.BackColor = System.Drawing.Color.Teal
        Me.accountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.accountlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.accountlbl.Location = New System.Drawing.Point(250, 34)
        Me.accountlbl.Name = "accountlbl"
        Me.accountlbl.Size = New System.Drawing.Size(134, 37)
        Me.accountlbl.TabIndex = 0
        Me.accountlbl.Text = "Account"
        '
        'userlbl
        '
        Me.userlbl.AutoSize = True
        Me.userlbl.BackColor = System.Drawing.Color.Teal
        Me.userlbl.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.userlbl.Location = New System.Drawing.Point(161, 95)
        Me.userlbl.Name = "userlbl"
        Me.userlbl.Size = New System.Drawing.Size(123, 33)
        Me.userlbl.TabIndex = 1
        Me.userlbl.Text = "Username :"
        '
        'passlbl
        '
        Me.passlbl.AutoSize = True
        Me.passlbl.BackColor = System.Drawing.Color.Teal
        Me.passlbl.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.passlbl.Location = New System.Drawing.Point(163, 156)
        Me.passlbl.Name = "passlbl"
        Me.passlbl.Size = New System.Drawing.Size(121, 33)
        Me.passlbl.TabIndex = 2
        Me.passlbl.Text = "Password :"
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(325, 106)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(100, 20)
        Me.usertxt.TabIndex = 3
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(325, 167)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(100, 20)
        Me.passtxt.TabIndex = 4
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Teal
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.loginbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.loginbtn.Location = New System.Drawing.Point(169, 226)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(102, 35)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.Teal
        Me.cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelbtn.Location = New System.Drawing.Point(357, 227)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(90, 34)
        Me.cancelbtn.TabIndex = 6
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "username , password : admin"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(2, 384)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(594, 23)
        Me.ProgressBar2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(271, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 33)
        Me.Label4.TabIndex = 9
        '
        'Timer1
        '
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Quản_lý_bán_hàng.My.Resources.Resources._8
        Me.ClientSize = New System.Drawing.Size(608, 419)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.passlbl)
        Me.Controls.Add(Me.userlbl)
        Me.Controls.Add(Me.accountlbl)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents accountlbl As System.Windows.Forms.Label
    Friend WithEvents userlbl As System.Windows.Forms.Label
    Friend WithEvents passlbl As System.Windows.Forms.Label
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents loginbtn As System.Windows.Forms.Button
    Friend WithEvents cancelbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSecondName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(99, 488)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(177, 42)
        Me.BtnSubmit.TabIndex = 22
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(532, 488)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 42)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Login "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(273, 417)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(298, 26)
        Me.dtpDOB.TabIndex = 20
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(273, 363)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(180, 28)
        Me.cboGender.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(273, 294)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(262, 29)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 231)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(181, 29)
        Me.TextBox2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 497)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Have an account?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 422)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DOB"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(102, 298)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(65, 25)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.Text = "Email"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(99, 363)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(83, 25)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender"
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(102, 232)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(106, 25)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.Text = "Password"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(273, 115)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(181, 29)
        Me.txtFirstName.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "First Name"
        '
        'txtSecondName
        '
        Me.txtSecondName.Location = New System.Drawing.Point(273, 172)
        Me.txtSecondName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSecondName.Multiline = True
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(181, 29)
        Me.txtSecondName.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Second Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Register or login to continue"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 625)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSecondName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApplication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Plum
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 408)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 33)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Sales Record"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sales Summary"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASHBOARD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SALES SUMMARY"
        '
        'PanelContainer
        '
        Me.PanelContainer.Location = New System.Drawing.Point(203, 36)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(842, 408)
        Me.PanelContainer.TabIndex = 2
        '
        'MainApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 456)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainApplication"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

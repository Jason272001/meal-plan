<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblslip = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmding = New System.Windows.Forms.Button()
        Me.cmdcalo = New System.Windows.Forms.Button()
        Me.Txtcalo = New System.Windows.Forms.TextBox()
        Me.cboing = New System.Windows.Forms.ComboBox()
        Me.cbochoice = New System.Windows.Forms.ComboBox()
        Me.cmdorder = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(83, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(670, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the fresh online market store." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can see the several meals types.Yo" &
    "u can select any meal types." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calories    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingredients    :"
        '
        'lblslip
        '
        Me.lblslip.AutoSize = True
        Me.lblslip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblslip.Location = New System.Drawing.Point(808, 87)
        Me.lblslip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblslip.Name = "lblslip"
        Me.lblslip.Size = New System.Drawing.Size(235, 20)
        Me.lblslip.TabIndex = 3
        Me.lblslip.Text = "Slip will be displayed here "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.cmding)
        Me.GroupBox1.Controls.Add(Me.cmdcalo)
        Me.GroupBox1.Controls.Add(Me.Txtcalo)
        Me.GroupBox1.Controls.Add(Me.cboing)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbochoice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(600, 170)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecting Box "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 105)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(165, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price     :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(44, 114)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 16)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Choice     :"
        '
        'cmding
        '
        Me.cmding.Location = New System.Drawing.Point(365, 69)
        Me.cmding.Margin = New System.Windows.Forms.Padding(4)
        Me.cmding.Name = "cmding"
        Me.cmding.Size = New System.Drawing.Size(167, 28)
        Me.cmding.TabIndex = 4
        Me.cmding.Text = "Searching ingredients "
        Me.cmding.UseVisualStyleBackColor = True
        '
        'cmdcalo
        '
        Me.cmdcalo.Location = New System.Drawing.Point(365, 39)
        Me.cmdcalo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdcalo.Name = "cmdcalo"
        Me.cmdcalo.Size = New System.Drawing.Size(167, 28)
        Me.cmdcalo.TabIndex = 3
        Me.cmdcalo.Text = "Searching caloreis"
        Me.cmdcalo.UseVisualStyleBackColor = True
        '
        'Txtcalo
        '
        Me.Txtcalo.Location = New System.Drawing.Point(163, 39)
        Me.Txtcalo.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcalo.Name = "Txtcalo"
        Me.Txtcalo.Size = New System.Drawing.Size(132, 22)
        Me.Txtcalo.TabIndex = 2
        '
        'cboing
        '
        Me.cboing.FormattingEnabled = True
        Me.cboing.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboing.Location = New System.Drawing.Point(135, 71)
        Me.cboing.Margin = New System.Windows.Forms.Padding(4)
        Me.cboing.Name = "cboing"
        Me.cboing.Size = New System.Drawing.Size(160, 24)
        Me.cboing.TabIndex = 1
        '
        'cbochoice
        '
        Me.cbochoice.FormattingEnabled = True
        Me.cbochoice.Items.AddRange(New Object() {"Pasta with mushroom", "Baked chicken", "Mushroom jacket potatoes", "Mushroom and chicken Pizza", "Tomato Pasta", "Egg fried rice", "Chicken Pie", "Mushroom risotto", "Mushroom baked eggs", "Chicken potato salad"})
        Me.cbochoice.Location = New System.Drawing.Point(135, 105)
        Me.cbochoice.Margin = New System.Windows.Forms.Padding(4)
        Me.cbochoice.Name = "cbochoice"
        Me.cbochoice.Size = New System.Drawing.Size(160, 24)
        Me.cbochoice.TabIndex = 0
        '
        'cmdorder
        '
        Me.cmdorder.Location = New System.Drawing.Point(1096, 554)
        Me.cmdorder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdorder.Name = "cmdorder"
        Me.cmdorder.Size = New System.Drawing.Size(100, 28)
        Me.cmdorder.TabIndex = 5
        Me.cmdorder.Text = "Order"
        Me.cmdorder.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(153, 274)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(100, 28)
        Me.cmdsave.TabIndex = 6
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotal.Location = New System.Drawing.Point(284, 282)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(363, 20)
        Me.lbltotal.TabIndex = 7
        Me.lbltotal.Text = "Total meal and cost will be displayed here"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(644, 389)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 392)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Amount    :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1201, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 48)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(1169, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Meal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(176, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Meal From Cart"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(176, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1493, 628)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.cmdorder)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblslip)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblslip As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmding As Button
    Friend WithEvents cmdcalo As Button
    Friend WithEvents Txtcalo As TextBox
    Friend WithEvents cboing As ComboBox
    Friend WithEvents cbochoice As ComboBox
    Friend WithEvents cmdorder As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbltotal As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class

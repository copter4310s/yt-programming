<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_c = New System.Windows.Forms.Label()
        Me.lbl_f = New System.Windows.Forms.Label()
        Me.lbl_k = New System.Windows.Forms.Label()
        Me.lbl_r = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input: "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Location = New System.Drawing.Point(80, 33)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"°C", "°F", "K", "°R"})
        Me.ComboBox1.Location = New System.Drawing.Point(206, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_r)
        Me.GroupBox2.Controls.Add(Me.lbl_k)
        Me.GroupBox2.Controls.Add(Me.lbl_f)
        Me.GroupBox2.Controls.Add(Me.lbl_c)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'lbl_c
        '
        Me.lbl_c.AutoSize = True
        Me.lbl_c.Location = New System.Drawing.Point(61, 35)
        Me.lbl_c.Name = "lbl_c"
        Me.lbl_c.Size = New System.Drawing.Size(28, 15)
        Me.lbl_c.TabIndex = 0
        Me.lbl_c.Text = "- °C"
        '
        'lbl_f
        '
        Me.lbl_f.AutoSize = True
        Me.lbl_f.Location = New System.Drawing.Point(61, 94)
        Me.lbl_f.Name = "lbl_f"
        Me.lbl_f.Size = New System.Drawing.Size(26, 15)
        Me.lbl_f.TabIndex = 1
        Me.lbl_f.Text = "- °F"
        '
        'lbl_k
        '
        Me.lbl_k.AutoSize = True
        Me.lbl_k.Location = New System.Drawing.Point(203, 35)
        Me.lbl_k.Name = "lbl_k"
        Me.lbl_k.Size = New System.Drawing.Size(22, 15)
        Me.lbl_k.TabIndex = 2
        Me.lbl_k.Text = "- K"
        '
        'lbl_r
        '
        Me.lbl_r.AutoSize = True
        Me.lbl_r.Location = New System.Drawing.Point(203, 94)
        Me.lbl_r.Name = "lbl_r"
        Me.lbl_r.Size = New System.Drawing.Size(27, 15)
        Me.lbl_r.TabIndex = 3
        Me.lbl_r.Text = "- °R"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 292)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Convert"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_r As Label
    Friend WithEvents lbl_k As Label
    Friend WithEvents lbl_f As Label
    Friend WithEvents lbl_c As Label
End Class

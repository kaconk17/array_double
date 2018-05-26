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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nim = New System.Windows.Forms.TextBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Check_kurang = New System.Windows.Forms.CheckBox()
        Me.Check_lebih = New System.Windows.Forms.CheckBox()
        Me.Check_range = New System.Windows.Forms.CheckBox()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.Check_sama = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nim)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 89)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackgroundImage = CType(resources.GetObject("btn_simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.Color.Transparent
        Me.btn_simpan.Location = New System.Drawing.Point(191, 55)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(30, 28)
        Me.btn_simpan.TabIndex = 29
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(188, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NIM"
        '
        'txt_nim
        '
        Me.txt_nim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nim.Location = New System.Drawing.Point(146, 33)
        Me.txt_nim.Name = "txt_nim"
        Me.txt_nim.Size = New System.Drawing.Size(133, 20)
        Me.txt_nim.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.BackgroundImage = CType(resources.GetObject("btn_refresh.BackgroundImage"), System.Drawing.Image)
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Location = New System.Drawing.Point(284, 136)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(26, 28)
        Me.btn_refresh.TabIndex = 32
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.Transparent
        Me.btn_cari.BackgroundImage = CType(resources.GetObject("btn_cari.BackgroundImage"), System.Drawing.Image)
        Me.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cari.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_cari.Location = New System.Drawing.Point(239, 139)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(26, 23)
        Me.btn_cari.TabIndex = 31
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(36, 168)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(388, 236)
        Me.ListBox1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(33, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cari"
        '
        'txt_cari
        '
        Me.txt_cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cari.Location = New System.Drawing.Point(68, 142)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(60, 20)
        Me.txt_cari.TabIndex = 28
        '
        'Check_kurang
        '
        Me.Check_kurang.AutoSize = True
        Me.Check_kurang.Location = New System.Drawing.Point(69, 105)
        Me.Check_kurang.Name = "Check_kurang"
        Me.Check_kurang.Size = New System.Drawing.Size(81, 17)
        Me.Check_kurang.TabIndex = 34
        Me.Check_kurang.Text = "kurang Dari"
        Me.Check_kurang.UseVisualStyleBackColor = True
        '
        'Check_lebih
        '
        Me.Check_lebih.AutoSize = True
        Me.Check_lebih.Location = New System.Drawing.Point(156, 105)
        Me.Check_lebih.Name = "Check_lebih"
        Me.Check_lebih.Size = New System.Drawing.Size(74, 17)
        Me.Check_lebih.TabIndex = 35
        Me.Check_lebih.Text = "Lebih Dari"
        Me.Check_lebih.UseVisualStyleBackColor = True
        '
        'Check_range
        '
        Me.Check_range.AutoSize = True
        Me.Check_range.Location = New System.Drawing.Point(239, 105)
        Me.Check_range.Name = "Check_range"
        Me.Check_range.Size = New System.Drawing.Size(58, 17)
        Me.Check_range.TabIndex = 36
        Me.Check_range.Text = "Range"
        Me.Check_range.UseVisualStyleBackColor = True
        '
        'txt_max
        '
        Me.txt_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_max.Location = New System.Drawing.Point(163, 142)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(60, 20)
        Me.txt_max.TabIndex = 37
        '
        'Check_sama
        '
        Me.Check_sama.AutoSize = True
        Me.Check_sama.Location = New System.Drawing.Point(303, 105)
        Me.Check_sama.Name = "Check_sama"
        Me.Check_sama.Size = New System.Drawing.Size(89, 17)
        Me.Check_sama.TabIndex = 38
        Me.Check_sama.Text = "Samadengan"
        Me.Check_sama.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(134, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "To"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 415)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Check_sama)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.Check_range)
        Me.Controls.Add(Me.Check_lebih)
        Me.Controls.Add(Me.Check_kurang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cari)
        Me.Name = "Form1"
        Me.Text = "Dynamic Array"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nim As TextBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_cari As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Check_kurang As CheckBox
    Friend WithEvents Check_lebih As CheckBox
    Friend WithEvents Check_range As CheckBox
    Friend WithEvents txt_max As TextBox
    Friend WithEvents Check_sama As CheckBox
    Friend WithEvents Label3 As Label
End Class

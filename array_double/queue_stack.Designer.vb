<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class queue_stack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(queue_stack))
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Check_stack = New System.Windows.Forms.CheckBox()
        Me.Check_queue = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_simpan
        '
        Me.btn_simpan.BackgroundImage = CType(resources.GetObject("btn_simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.Color.Transparent
        Me.btn_simpan.Location = New System.Drawing.Point(180, 60)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(30, 28)
        Me.btn_simpan.TabIndex = 32
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(177, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(135, 38)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(133, 20)
        Me.txt_nama.TabIndex = 30
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(24, 173)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 236)
        Me.ListBox1.TabIndex = 33
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(257, 173)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(142, 236)
        Me.ListBox2.TabIndex = 34
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(186, 173)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(47, 23)
        Me.btn_next.TabIndex = 35
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.BackgroundImage = CType(resources.GetObject("btn_refresh.BackgroundImage"), System.Drawing.Image)
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Location = New System.Drawing.Point(186, 409)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(26, 28)
        Me.btn_refresh.TabIndex = 36
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(21, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Daftar Antrian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(254, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Telah Diproses"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Check_stack)
        Me.GroupBox1.Controls.Add(Me.Check_queue)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 100)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Metode"
        '
        'Check_stack
        '
        Me.Check_stack.AutoSize = True
        Me.Check_stack.Location = New System.Drawing.Point(23, 58)
        Me.Check_stack.Name = "Check_stack"
        Me.Check_stack.Size = New System.Drawing.Size(54, 17)
        Me.Check_stack.TabIndex = 40
        Me.Check_stack.Text = "Stack"
        Me.Check_stack.UseVisualStyleBackColor = True
        '
        'Check_queue
        '
        Me.Check_queue.AutoSize = True
        Me.Check_queue.Location = New System.Drawing.Point(23, 26)
        Me.Check_queue.Name = "Check_queue"
        Me.Check_queue.Size = New System.Drawing.Size(58, 17)
        Me.Check_queue.TabIndex = 39
        Me.Check_queue.Text = "Queue"
        Me.Check_queue.UseVisualStyleBackColor = True
        '
        'queue_stack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 458)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Name = "queue_stack"
        Me.Text = "Queue & Stack"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents Check_stack As CheckBox
    Public WithEvents Check_queue As CheckBox
End Class

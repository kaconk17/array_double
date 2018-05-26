<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class link_list
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(link_list))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.txt_index_insert = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nama_isert = New System.Windows.Forms.TextBox()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.txt_index_edit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_index_remove = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama_edit = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Check_tambah = New System.Windows.Forms.CheckBox()
        Me.txt_index = New System.Windows.Forms.Label()
        Me.Check_geser = New System.Windows.Forms.CheckBox()
        Me.Check_edit = New System.Windows.Forms.CheckBox()
        Me.Check_remove = New System.Windows.Forms.CheckBox()
        Me.Check_Insert = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_total = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_remove)
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_prev)
        Me.GroupBox1.Controls.Add(Me.txt_index_insert)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_nama_isert)
        Me.GroupBox1.Controls.Add(Me.btn_next)
        Me.GroupBox1.Controls.Add(Me.txt_index_edit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_index_remove)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nama_edit)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Check_tambah)
        Me.GroupBox1.Controls.Add(Me.txt_index)
        Me.GroupBox1.Controls.Add(Me.Check_geser)
        Me.GroupBox1.Controls.Add(Me.Check_edit)
        Me.GroupBox1.Controls.Add(Me.Check_remove)
        Me.GroupBox1.Controls.Add(Me.Check_Insert)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 216)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Metode"
        '
        'btn_remove
        '
        Me.btn_remove.BackgroundImage = CType(resources.GetObject("btn_remove.BackgroundImage"), System.Drawing.Image)
        Me.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.ForeColor = System.Drawing.Color.Transparent
        Me.btn_remove.Location = New System.Drawing.Point(139, 64)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(30, 28)
        Me.btn_remove.TabIndex = 69
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.BackgroundImage = CType(resources.GetObject("btn_insert.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_insert.ForeColor = System.Drawing.Color.Transparent
        Me.btn_insert.Location = New System.Drawing.Point(272, 143)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(30, 28)
        Me.btn_insert.TabIndex = 68
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.Color.Transparent
        Me.btn_edit.Location = New System.Drawing.Point(272, 103)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(30, 28)
        Me.btn_edit.TabIndex = 67
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.Location = New System.Drawing.Point(95, 179)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(47, 23)
        Me.btn_prev.TabIndex = 66
        Me.btn_prev.Text = "Prev"
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'txt_index_insert
        '
        Me.txt_index_insert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_index_insert.Location = New System.Drawing.Point(96, 148)
        Me.txt_index_insert.Name = "txt_index_insert"
        Me.txt_index_insert.Size = New System.Drawing.Size(37, 20)
        Me.txt_index_insert.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(100, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Index"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(174, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Nama"
        '
        'txt_nama_isert
        '
        Me.txt_nama_isert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama_isert.Location = New System.Drawing.Point(139, 148)
        Me.txt_nama_isert.Name = "txt_nama_isert"
        Me.txt_nama_isert.Size = New System.Drawing.Size(127, 20)
        Me.txt_nama_isert.TabIndex = 62
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(162, 179)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(47, 23)
        Me.btn_next.TabIndex = 47
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'txt_index_edit
        '
        Me.txt_index_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_index_edit.Location = New System.Drawing.Point(96, 109)
        Me.txt_index_edit.Name = "txt_index_edit"
        Me.txt_index_edit.Size = New System.Drawing.Size(37, 20)
        Me.txt_index_edit.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(100, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Index"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(174, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Nama"
        '
        'txt_index_remove
        '
        Me.txt_index_remove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_index_remove.Location = New System.Drawing.Point(96, 70)
        Me.txt_index_remove.Name = "txt_index_remove"
        Me.txt_index_remove.Size = New System.Drawing.Size(37, 20)
        Me.txt_index_remove.TabIndex = 52
        '
        'btn_simpan
        '
        Me.btn_simpan.BackgroundImage = CType(resources.GetObject("btn_simpan.BackgroundImage"), System.Drawing.Image)
        Me.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.Color.Transparent
        Me.btn_simpan.Location = New System.Drawing.Point(236, 23)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(30, 28)
        Me.btn_simpan.TabIndex = 58
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(145, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Nama"
        '
        'txt_nama_edit
        '
        Me.txt_nama_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama_edit.Location = New System.Drawing.Point(139, 109)
        Me.txt_nama_edit.Name = "txt_nama_edit"
        Me.txt_nama_edit.Size = New System.Drawing.Size(127, 20)
        Me.txt_nama_edit.TabIndex = 56
        '
        'txt_nama
        '
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(97, 29)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(133, 20)
        Me.txt_nama.TabIndex = 54
        '
        'Check_tambah
        '
        Me.Check_tambah.AutoSize = True
        Me.Check_tambah.Location = New System.Drawing.Point(25, 30)
        Me.Check_tambah.Name = "Check_tambah"
        Me.Check_tambah.Size = New System.Drawing.Size(65, 17)
        Me.Check_tambah.TabIndex = 55
        Me.Check_tambah.Text = "Tambah"
        Me.Check_tambah.UseVisualStyleBackColor = True
        '
        'txt_index
        '
        Me.txt_index.AutoSize = True
        Me.txt_index.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_index.Location = New System.Drawing.Point(100, 54)
        Me.txt_index.Name = "txt_index"
        Me.txt_index.Size = New System.Drawing.Size(33, 13)
        Me.txt_index.TabIndex = 53
        Me.txt_index.Text = "Index"
        '
        'Check_geser
        '
        Me.Check_geser.AutoSize = True
        Me.Check_geser.Location = New System.Drawing.Point(25, 183)
        Me.Check_geser.Name = "Check_geser"
        Me.Check_geser.Size = New System.Drawing.Size(54, 17)
        Me.Check_geser.TabIndex = 55
        Me.Check_geser.Text = "Geser"
        Me.Check_geser.UseVisualStyleBackColor = True
        '
        'Check_edit
        '
        Me.Check_edit.AutoSize = True
        Me.Check_edit.Location = New System.Drawing.Point(25, 110)
        Me.Check_edit.Name = "Check_edit"
        Me.Check_edit.Size = New System.Drawing.Size(44, 17)
        Me.Check_edit.TabIndex = 54
        Me.Check_edit.Text = "Edit"
        Me.Check_edit.UseVisualStyleBackColor = True
        '
        'Check_remove
        '
        Me.Check_remove.AutoSize = True
        Me.Check_remove.Location = New System.Drawing.Point(25, 71)
        Me.Check_remove.Name = "Check_remove"
        Me.Check_remove.Size = New System.Drawing.Size(66, 17)
        Me.Check_remove.TabIndex = 40
        Me.Check_remove.Text = "Remove"
        Me.Check_remove.UseVisualStyleBackColor = True
        '
        'Check_Insert
        '
        Me.Check_Insert.AutoSize = True
        Me.Check_Insert.Location = New System.Drawing.Point(25, 150)
        Me.Check_Insert.Name = "Check_Insert"
        Me.Check_Insert.Size = New System.Drawing.Size(52, 17)
        Me.Check_Insert.TabIndex = 39
        Me.Check_Insert.Text = "Insert"
        Me.Check_Insert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(260, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(31, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Daftar Nama"
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(30, 252)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(373, 210)
        Me.ListBox1.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(27, 470)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Total :"
        '
        'Label_total
        '
        Me.Label_total.AutoSize = True
        Me.Label_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_total.Location = New System.Drawing.Point(76, 470)
        Me.Label_total.Name = "Label_total"
        Me.Label_total.Size = New System.Drawing.Size(10, 13)
        Me.Label_total.TabIndex = 53
        Me.Label_total.Text = "-"
        '
        'link_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 492)
        Me.Controls.Add(Me.Label_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "link_list"
        Me.Text = "Linked List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents txt_index_insert As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nama_isert As TextBox
    Friend WithEvents btn_next As Button
    Friend WithEvents txt_index_edit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_index_remove As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_edit As TextBox
    Friend WithEvents txt_nama As TextBox
    Public WithEvents Check_tambah As CheckBox
    Friend WithEvents txt_index As Label
    Public WithEvents Check_geser As CheckBox
    Public WithEvents Check_edit As CheckBox
    Public WithEvents Check_remove As CheckBox
    Public WithEvents Check_Insert As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_total As Label
End Class

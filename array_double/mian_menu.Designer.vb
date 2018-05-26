<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mian_menu
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
        Me.btn_dynamic = New System.Windows.Forms.Button()
        Me.btn_queue = New System.Windows.Forms.Button()
        Me.btn_link = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_dynamic
        '
        Me.btn_dynamic.Location = New System.Drawing.Point(12, 50)
        Me.btn_dynamic.Name = "btn_dynamic"
        Me.btn_dynamic.Size = New System.Drawing.Size(75, 50)
        Me.btn_dynamic.TabIndex = 1
        Me.btn_dynamic.Text = "Dynamic Array"
        Me.btn_dynamic.UseVisualStyleBackColor = True
        '
        'btn_queue
        '
        Me.btn_queue.Location = New System.Drawing.Point(130, 50)
        Me.btn_queue.Name = "btn_queue"
        Me.btn_queue.Size = New System.Drawing.Size(75, 50)
        Me.btn_queue.TabIndex = 2
        Me.btn_queue.Text = "Queue Stack"
        Me.btn_queue.UseVisualStyleBackColor = True
        '
        'btn_link
        '
        Me.btn_link.Location = New System.Drawing.Point(246, 50)
        Me.btn_link.Name = "btn_link"
        Me.btn_link.Size = New System.Drawing.Size(75, 50)
        Me.btn_link.TabIndex = 3
        Me.btn_link.Text = "Linked List"
        Me.btn_link.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Struktur Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "117227017"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'mian_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 143)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_link)
        Me.Controls.Add(Me.btn_queue)
        Me.Controls.Add(Me.btn_dynamic)
        Me.Name = "mian_menu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_dynamic As Button
    Friend WithEvents btn_queue As Button
    Friend WithEvents btn_link As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

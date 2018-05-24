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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(343, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QueueToolStripMenuItem, Me.QueueToolStripMenuItem1, Me.LinkListToolStripMenuItem1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'QueueToolStripMenuItem
        '
        Me.QueueToolStripMenuItem.Name = "QueueToolStripMenuItem"
        Me.QueueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QueueToolStripMenuItem.Text = "Dynamic Array"
        '
        'QueueToolStripMenuItem1
        '
        Me.QueueToolStripMenuItem1.Name = "QueueToolStripMenuItem1"
        Me.QueueToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.QueueToolStripMenuItem1.Text = "Queue & Stack"
        '
        'LinkListToolStripMenuItem1
        '
        Me.LinkListToolStripMenuItem1.Name = "LinkListToolStripMenuItem1"
        Me.LinkListToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LinkListToolStripMenuItem1.Text = "Link List"
        '
        'mian_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 167)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mian_menu"
        Me.Text = "mian_menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LinkListToolStripMenuItem1 As ToolStripMenuItem
End Class

Public Class mian_menu
    Private Sub QueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueueToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LinkListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LinkListToolStripMenuItem1.Click
        link_list.Show()
    End Sub

    Private Sub QueueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QueueToolStripMenuItem1.Click
        queue_stack.Show()
    End Sub
End Class
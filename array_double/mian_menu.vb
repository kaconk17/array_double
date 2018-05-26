Public Class mian_menu


    Private Sub mian_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Date.Today
    End Sub

    Private Sub btn_dynamic_Click(sender As Object, e As EventArgs) Handles btn_dynamic.Click
        Form1.Show()
    End Sub

    Private Sub btn_queue_Click(sender As Object, e As EventArgs) Handles btn_queue.Click
        queue_stack.Show()
    End Sub

    Private Sub btn_link_Click(sender As Object, e As EventArgs) Handles btn_link.Click
        link_list.Show()
    End Sub
End Class
Public Class queue_stack
    Dim data_array() As String

    Dim counter As Integer = 0
    Private Sub queue_stack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim data_array(counter)
        Check_queue.CheckState = CheckState.Checked
    End Sub

    Private Sub Check_queue_CheckStateChanged(sender As Object, e As EventArgs)
        If Check_queue.CheckState = CheckState.Checked Then
            Check_stack.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Check_stack_CheckStateChanged(sender As Object, e As EventArgs)
        If Check_stack.CheckState = CheckState.Checked Then
            Check_queue.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If counter = 0 Then

            data_array(counter) = txt_nama.Text
            ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
            counter = counter + 1
            txt_nama.Text = ""
        Else
            ReDim Preserve data_array(UBound(data_array) + 1)
            data_array(counter) = txt_nama.Text
            ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
            counter = counter + 1
            txt_nama.Text = ""
        End If
    End Sub
    Sub refresh()
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1

            ListBox1.Items.Add((a + 1).ToString & " - " & data_array(a).ToString) 'menambahkan semua data dalam data_array kedalam listbox

        Next

    End Sub
    Sub next_queue()


        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        If max < 0 Then
            MsgBox("Data kosong", MsgBoxStyle.Critical)
        Else
            Dim temp As String
            ListBox2.Items.Add(data_array(0))
            For i As Integer = 1 To max
                temp = data_array(i)
                data_array(i - 1) = temp
            Next

            ReDim Preserve data_array(max - 1)
            counter = counter - 1
            refresh()
        End If

    End Sub
    Sub next_stack()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        If max < 0 Then
            MsgBox("Data kosong", MsgBoxStyle.Critical)
        Else
            'Dim temp As String
            ListBox2.Items.Add(data_array(max))


            ReDim Preserve data_array(max - 1)
            counter = counter - 1
            refresh()
        End If

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If Check_queue.CheckState = CheckState.Checked Then
            next_queue()
        Else
            next_stack()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh()
    End Sub
End Class
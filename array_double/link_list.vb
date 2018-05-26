Public Class link_list
    Dim data_array() As String

    Dim counter As Integer = 0
    Sub disable_txt()
        txt_index.Text = ""
        txt_index_edit.Text = ""
        txt_index_insert.Text = ""
        txt_index_remove.Text = ""
        txt_nama.Text = ""
        txt_nama_edit.Text = ""
        txt_nama_isert.Text = ""
        txt_index.Enabled = False
        txt_index_edit.Enabled = False
        txt_index_insert.Enabled = False
        txt_index_remove.Enabled = False
        txt_nama.Enabled = False
        txt_nama_edit.Enabled = False
        txt_nama_isert.Enabled = False
        btn_edit.Enabled = False
        btn_insert.Enabled = False
        btn_next.Enabled = False
        btn_prev.Enabled = False

        btn_remove.Enabled = False
        btn_simpan.Enabled = False
    End Sub
    Private Sub link_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim data_array(counter)
        disable_txt()
        Check_tambah.CheckState = CheckState.Checked
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_nama.Text = "" Then
            MsgBox("Nama belum diisi !!", MsgBoxStyle.Critical)
        Else
            If counter = 0 Then

                data_array(counter) = txt_nama.Text.ToString
                ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
                counter = counter + 1
                txt_nama.Text = ""
            Else
                ReDim Preserve data_array(UBound(data_array) + 1)
                data_array(counter) = txt_nama.Text.ToString
                ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
                counter = counter + 1
                txt_nama.Text = ""
            End If
        End If
    End Sub
    Sub refresh()
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1

            ListBox1.Items.Add((a + 1).ToString & " - " & data_array(a).ToString) 'menambahkan semua data dalam data_array kedalam listbox

        Next

    End Sub
    Sub remove_data()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim index As Integer = txt_index_remove.Text
        index = index - 1
        If max < 0 Then
            MsgBox("Data kosong", MsgBoxStyle.Critical)
        ElseIf index > max Or index < 0 Then
            MsgBox("Index salah !!", MsgBoxStyle.Critical)
        Else
            Dim temp As String

            For i As Integer = index To (max - 1)
                temp = data_array(i + 1)
                data_array(i) = temp
            Next

            ReDim Preserve data_array(max - 1)
            counter = counter - 1
            refresh()
        End If
    End Sub
    Sub edit_data()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim index As Integer = txt_index_edit.Text
        Dim nama As String = txt_nama_edit.Text
        index = index - 1
        If max < 0 Then
            MsgBox("Data kosong", MsgBoxStyle.Critical)
        ElseIf index > max Or index < 0 Then
            MsgBox("Index salah !!", MsgBoxStyle.Critical)
        Else



            data_array(index) = nama


            refresh()
        End If
    End Sub
    Sub insert_data()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim index As Integer = txt_index_insert.Text
        Dim nama As String = txt_nama_isert.Text
        index = index - 1
        If max < 0 Then
            MsgBox("Data kosong", MsgBoxStyle.Critical)
        ElseIf index > max Or index < 0 Then
            MsgBox("Index salah !!", MsgBoxStyle.Critical)
        Else
            Dim temp As String
            'Dim langkah As Integer = max - index
            ReDim Preserve data_array(max + 1)
            For i As Integer = max To index Step -1
                temp = data_array(i)
                data_array(i + 1) = temp
            Next
            data_array(index) = nama

            counter = counter + 1
            refresh()
        End If
    End Sub
    Sub geser()

    End Sub

    Private Sub Check_tambah_CheckedChanged(sender As Object, e As EventArgs) Handles Check_tambah.CheckedChanged
        If Check_tambah.CheckState = CheckState.Checked Then
            Check_edit.CheckState = CheckState.Unchecked
            Check_geser.CheckState = CheckState.Unchecked
            Check_Insert.CheckState = CheckState.Unchecked
            Check_remove.CheckState = CheckState.Unchecked
            disable_txt()
            txt_nama.Enabled = True
            btn_simpan.Enabled = True
        End If
    End Sub

    Private Sub Check_edit_CheckedChanged(sender As Object, e As EventArgs) Handles Check_edit.CheckedChanged
        If Check_edit.CheckState = CheckState.Checked Then
            Check_tambah.CheckState = CheckState.Unchecked
            Check_geser.CheckState = CheckState.Unchecked
            Check_Insert.CheckState = CheckState.Unchecked
            Check_remove.CheckState = CheckState.Unchecked
            disable_txt()
            txt_index_edit.Enabled = True
            txt_nama_edit.Enabled = True
            btn_edit.Enabled = True
        End If
    End Sub

    Private Sub Check_geser_CheckedChanged(sender As Object, e As EventArgs) Handles Check_geser.CheckedChanged
        If Check_geser.CheckState = CheckState.Checked Then
            Check_edit.CheckState = CheckState.Unchecked
            Check_tambah.CheckState = CheckState.Unchecked
            Check_Insert.CheckState = CheckState.Unchecked
            Check_remove.CheckState = CheckState.Unchecked
            disable_txt()
            btn_next.Enabled = True
            btn_prev.Enabled = True
        End If
    End Sub

    Private Sub Check_Insert_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Insert.CheckedChanged
        If Check_Insert.CheckState = CheckState.Checked Then
            Check_edit.CheckState = CheckState.Unchecked
            Check_geser.CheckState = CheckState.Unchecked
            Check_tambah.CheckState = CheckState.Unchecked
            Check_remove.CheckState = CheckState.Unchecked
            disable_txt()
            txt_index_insert.Enabled = True
            txt_nama_isert.Enabled = True
            btn_insert.Enabled = True
        End If
    End Sub

    Private Sub Check_remove_CheckedChanged(sender As Object, e As EventArgs) Handles Check_remove.CheckedChanged
        If Check_remove.CheckState = CheckState.Checked Then
            Check_edit.CheckState = CheckState.Unchecked
            Check_geser.CheckState = CheckState.Unchecked
            Check_Insert.CheckState = CheckState.Unchecked
            Check_tambah.CheckState = CheckState.Unchecked
            disable_txt()
            txt_index_remove.Enabled = True
            btn_remove.Enabled = True
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        remove_data()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit_data()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        insert_data()
    End Sub
End Class
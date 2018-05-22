Public Class Form1
    Dim data_array() As Single

    Dim counter As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim data_array(counter)
        Label3.Visible = False
        txt_max.Visible = False
        Check_sama.CheckState = CheckState.Checked
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If IsNumeric(txt_nim.Text) Then
            If counter = 0 Then

                data_array(counter) = txt_nim.Text
                ListBox1.Items.Add(data_array(counter))
                counter = counter + 1
                txt_nim.Text = ""
            Else
                ReDim Preserve data_array(UBound(data_array) + 1)
                data_array(counter) = txt_nim.Text
                ListBox1.Items.Add(data_array(counter))
                counter = counter + 1
                txt_nim.Text = ""
            End If
        Else
            MsgBox("Hanya masukkan data berupa angka !!", MsgBoxStyle.Critical)
        End If

    End Sub

    Sub cari_sama()
        Dim cari As Single = txt_cari.Text 'ambil data text yang dicari

        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim identif As Integer = 0
        ListBox1.Items.Clear()
        For i As Integer = 0 To max

            If cari = data_array(i) Then 'membandingkan data yang dicari dengan data pada array dalam format uppercase
                identif = identif + 1
                ListBox1.Items.Add(data_array(i)) 'menambahkan data yang sama dengan pencarian pada listbox

            End If

        Next
        If identif = 0 Then
            MsgBox("Data tidak ada", MsgBoxStyle.Critical)
        Else
            MsgBox("Ditemukan " + identif.ToString + " Data", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub cari_lebih()
        Dim cari As Single = txt_cari.Text 'ambil data text yang dicari

        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim identif As Integer = 0
        ListBox1.Items.Clear()
        For i As Integer = 0 To max

            If cari < data_array(i) Then 'membandingkan data yang dicari dengan data pada array dalam format uppercase
                identif = identif + 1
                ListBox1.Items.Add(data_array(i)) 'menambahkan data yang sama dengan pencarian pada listbox

            End If

        Next
        If identif = 0 Then
            MsgBox("Data tidak ada", MsgBoxStyle.Critical)
        Else
            MsgBox("Ditemukan " + identif.ToString + " Data", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub cari_kurang()
        Dim cari As Single = txt_cari.Text 'ambil data text yang dicari

        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim identif As Integer = 0
        ListBox1.Items.Clear()
        For i As Integer = 0 To max

            If cari > data_array(i) Then 'membandingkan data yang dicari dengan data pada array dalam format uppercase
                identif = identif + 1
                ListBox1.Items.Add(data_array(i)) 'menambahkan data yang sama dengan pencarian pada listbox

            End If

        Next
        If identif = 0 Then
            MsgBox("Data tidak ada", MsgBoxStyle.Critical)
        Else
            MsgBox("Ditemukan " + identif.ToString + " Data", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub cari_range()
        Dim cari As Single = txt_cari.Text 'ambil data text yang dicari
        Dim akhir As Single = txt_max.Text
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        Dim identif As Integer = 0
        ListBox1.Items.Clear()
        For i As Integer = 0 To max

            If cari < data_array(i) And akhir > data_array(i) Then 'membandingkan data yang dicari dengan data pada array dalam format uppercase
                identif = identif + 1
                ListBox1.Items.Add(data_array(i)) 'menambahkan data yang sama dengan pencarian pada listbox

            End If

        Next
        If identif = 0 Then
            MsgBox("Data tidak ada", MsgBoxStyle.Critical)
        Else
            MsgBox("Ditemukan " + identif.ToString + " Data", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Check_lebih_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_lebih.CheckStateChanged
        If Check_lebih.CheckState = CheckState.Checked Then
            Check_range.CheckState = CheckState.Unchecked


            Check_kurang.CheckState = CheckState.Unchecked

            Check_sama.CheckState = CheckState.Unchecked
            Label3.Visible = False
            txt_max.Visible = False

        End If
    End Sub

    Private Sub Check_range_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_range.CheckStateChanged
        If Check_range.CheckState = CheckState.Checked Then
            Check_kurang.CheckState = CheckState.Unchecked


            Check_lebih.CheckState = CheckState.Unchecked

            Check_sama.CheckState = CheckState.Unchecked
            Label3.Visible = True
            txt_max.Visible = True
        End If
    End Sub

    Private Sub Check_sama_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_sama.CheckStateChanged
        If Check_sama.CheckState = CheckState.Checked Then
            Check_range.CheckState = CheckState.Unchecked


            Check_lebih.CheckState = CheckState.Unchecked

            Check_kurang.CheckState = CheckState.Unchecked
            Label3.Visible = False
            txt_max.Visible = False
        End If
    End Sub

    Private Sub Check_kurang_CheckedChanged(sender As Object, e As EventArgs) Handles Check_kurang.CheckedChanged
        If Check_kurang.CheckState = CheckState.Checked Then
            Check_range.CheckState = CheckState.Unchecked


            Check_lebih.CheckState = CheckState.Unchecked

            Check_sama.CheckState = CheckState.Unchecked
            Label3.Visible = False
            txt_max.Visible = False
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        If Check_sama.CheckState = CheckState.Checked Then
            cari_sama()
        ElseIf Check_kurang.CheckState = CheckState.Checked Then
            cari_kurang()
        ElseIf Check_lebih.CheckState = CheckState.Checked Then
            cari_lebih()
        ElseIf Check_range.CheckState = CheckState.Checked Then
            cari_range()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1

            ListBox1.Items.Add(data_array(a).ToString) 'menambahkan semua data dalam data_array kedalam listbox

        Next
        txt_cari.Text = ""
        txt_max.Text = ""
    End Sub

    Private Sub txt_nim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nim.KeyPress

        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub
End Class

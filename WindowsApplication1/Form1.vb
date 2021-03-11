Public Class Form1
    Private Sub btnAdaug_Click(sender As Object, e As EventArgs) Handles btnAdaug.Click
        Dim denumire As String
        Do
            denumire = InputBox("Dati denumirea produsului", "Adaugare produs")
        Loop While denumire = " "
        ListBox1.Items.Add(denumire)
    End Sub

    Private Sub btnSterg_Click(sender As Object, e As EventArgs) Handles btnSterg.Click
        Dim indice As Integer
        indice = ListBox1.SelectedIndex
        If indice <> -1 Then
            Dim raspuns
            raspuns = MsgBox("Stergeti produsul " + ListBox1.Text + "?", MsgBoxStyle.YesNo, "Sterge produsul")
            If raspuns = MsgBoxResult.Yes Then
                ListBox1.Items.RemoveAt(indice)
            End If
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim indice As Integer
        Label1.Text = "Ati selectat " + ListBox1.SelectedItems.Count.ToString + " produse" + vbNewLine
        For indice = 0 To ListBox1.Items.Count - 1
            If ListBox1.GetSelected(indice) Then
                Label1.Text += ListBox1.Items(indice) + vbNewLine
            End If
        Next
    End Sub

    Private Sub btnInversare_Click(sender As Object, e As EventArgs) Handles btnInversare.Click
        Dim indice As Integer
        For indice = 0 To ListBox1.Items.Count - 1
            If ListBox1.GetSelected(indice) Then
                ListBox1.SetSelected(indice, False)
            Else
                ListBox1.SetSelected(indice, True)
            End If
        Next
        Call btnSelect_Click(sender, e)
    End Sub

    Private Sub btnStrglist_Click(sender As Object, e As EventArgs) Handles btnStrglist.Click
        Dim indice As Integer
        For indice = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(indice) Then
                ListBox1.Items.RemoveAt(indice)
            End If
        Next
    End Sub

    Private Sub btnStergtotL_Click(sender As Object, e As EventArgs) Handles btnStergtotL.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

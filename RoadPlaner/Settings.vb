Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KryptonComboBox1.Items.Add("Fr")
        KryptonComboBox1.Items.Add("En")
        KryptonComboBox1.Items.Add("Ar")
        HideAll()
    End Sub

    Private Sub HideAll()
        ApplicationS.Hide()
        Other.Hide()

    End Sub

    Dim SelTab As Integer

    Private Sub KryptonTreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles KryptonTreeView1.AfterSelect


        SelTab = KryptonTreeView1.SelectedNode.Index


        draw()

    End Sub

    Private Sub draw()

        If SelTab = 0 Then
            HideAll()
            ApplicationS.Show()


        End If

        If SelTab = 1 Then
            HideAll()
            Other.Show()


        End If
    End Sub


    Dim p As Point

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

        p.X = 178
        p.Y = VScrollBar1.Value * -3.55

        ApplicationS.Location = p
        Other.Location = p
    End Sub




End Class
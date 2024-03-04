Imports RoadLib
Imports RoadLib.Language

Public Class Settings
    Dim Scrol As Integer




    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KryptonComboBox1.Items.Add("En")
        KryptonComboBox1.Items.Add("Fr")
        KryptonComboBox1.Items.Add("Ar")
        HideAll()
        KryptonComboBox1.SelectedIndex = 0

        Dim LSetting = LanguageSettingGet()

        If LSetting = "Fr" Then
            KryptonComboBox1.SelectedIndex = 1
        ElseIf LSetting = "En" Then
            KryptonComboBox1.SelectedIndex = 0
        ElseIf LSetting = "Ar" Then
            KryptonComboBox1.SelectedIndex = 2
        End If



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
            Scrol = 0
        End If
        If SelTab = 1 Then
            HideAll()
            Other.Show()
            Scrol = 0
        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Scrol = VScrollBar1.Value
        Translate()

    End Sub

    Sub Translate()
        Dim P As Point
        P.X = 178
        P.Y = Scrol * -3.55

        ApplicationS.Location = P
        Other.Location = P
    End Sub

    Private Sub SaveB_Click(sender As Object, e As EventArgs) Handles SaveB.Click
        Dim Lang = KryptonComboBox1.SelectedItem.ToString

        If Lang <> LanguageSettingGet() Then
            LanguageSettingSet(Lang)
            MainW.Invalidate()
            Me.Dispose()
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub ApplicationS_MouseWheel(sender As Object, e As MouseEventArgs) Handles ApplicationS.MouseWheel
        If e.Delta > 0 And Scrol > 0 Then
            Scrol -= 5
            Translate()
            VScrollBar1.Value = Scrol
        ElseIf e.Delta < 0 And Scrol < 90 Then
            Scrol += 5
            Translate()
            VScrollBar1.Value = Scrol
        End If
    End Sub

    Private Sub Other_MouseWheel(sender As Object, e As MouseEventArgs) Handles Other.MouseWheel
        If e.Delta > 0 And Scrol > 0 Then
            Scrol -= 5
            Translate()
            VScrollBar1.Value = Scrol
        ElseIf e.Delta < 0 And Scrol < 90 Then
            Scrol += 5
            Translate()
            VScrollBar1.Value = Scrol
        End If
    End Sub
End Class
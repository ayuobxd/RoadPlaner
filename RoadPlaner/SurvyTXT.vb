Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports RoadLib
Imports RoadLib.Project
Public Class SurvyTXT
    Dim Scrol As Integer
    Dim FileNum As Integer
    Dim StartPos As Point

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Scrol = VScrollBar1.Value
        Translate()
    End Sub
    Sub Translate()
        Dim P As Point
        P.X = 0
        P.Y = Scrol * -3.8

        KryptonGroupBox1.Location = P

    End Sub
    Private Sub KryptonGroupBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles KryptonGroupBox1.MouseWheel
        If e.Delta > 0 And Scrol >= 5 Then
            Scrol -= 5
            Translate()
            VScrollBar1.Value = Scrol
        ElseIf e.Delta < 0 And Scrol < 90 Then
            Scrol += 5
            Translate()
            VScrollBar1.Value = Scrol
        End If
    End Sub


    Sub LoadPointTXT()
        Dim fd As OpenFileDialog = New OpenFileDialog()


        fd.Title = "Open File Dialog"

        fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim FileName As String
            FileName = fd.FileName
            Dim Stc As String = KryptonComboBox8.SelectedIndex
            FileNum += 1
            GetPoint(FileName, Stc, FileNum)

            StartPos.X = 9999999
            StartPos.Y = 9999999

            For Each c As PointTopo In project.ListPointTopo
                If c.X < StartPos.X Then
                    StartPos.X = CSng(c.X)

                End If
                If c.Y < StartPos.Y Then
                    StartPos.Y = CSng(c.Y)

                End If


            Next
            MainW.OffsetPan.X = -StartPos.X
            MainW.OffsetPan.Y = -StartPos.Y

            MainW.PictureBox1.Invalidate()
            Me.Dispose()
        End If
    End Sub

    Sub LoadComboBox()



        If LayerP.Count = 0 Then
            LayerP.Add(MainW.StrList(42))
        End If
        KryptonComboBox1.Items.Clear()
        For i = 0 To LayerP.Count - 1
            KryptonComboBox1.Items.Add(LayerP.Item(i))
        Next

        If LayerT.Count = 0 Then
            LayerT.Add(MainW.StrList(43))
        End If
        KryptonComboBox2.Items.Clear()
        For i = 0 To LayerT.Count - 1
            KryptonComboBox2.Items.Add(LayerT.Item(i))
        Next
        KryptonComboBox3.Items.Add(MainW.StrList(44))
        KryptonComboBox3.Items.Add(MainW.StrList(45))
        KryptonComboBox4.Items.Add(MainW.StrList(44))
        KryptonComboBox4.Items.Add(MainW.StrList(45))
        KryptonComboBox5.Items.Add(MainW.StrList(44))
        KryptonComboBox5.Items.Add(MainW.StrList(45))
        KryptonComboBox6.Items.Add(MainW.StrList(44))
        KryptonComboBox6.Items.Add(MainW.StrList(45))
        KryptonComboBox7.Items.Add(MainW.StrList(44))
        KryptonComboBox7.Items.Add(MainW.StrList(45))

        KryptonComboBox8.Items.Add("ID X Y Z Code")
        KryptonComboBox8.Items.Add("X Y Z Code")
        KryptonComboBox8.Items.Add("ID X Y Z")
        KryptonComboBox8.Items.Add("X Y Z")

        KryptonComboBox1.SelectedIndex = 0
        KryptonComboBox2.SelectedIndex = 0
        KryptonComboBox3.SelectedIndex = 0
        KryptonComboBox4.SelectedIndex = 0
        KryptonComboBox5.SelectedIndex = 0
        KryptonComboBox6.SelectedIndex = 0
        KryptonComboBox7.SelectedIndex = 0
    End Sub



    Private Sub SurvyTXT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadComboBox()


    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        'project.AddPointTopo("1", 25, 3, 3, 3, 1)
        'MsgBox(project.ListPointTopo.Item(0).X.ToString())
        LoadPointTXT()

    End Sub

    Private Sub KryptonComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonComboBox8.SelectedIndexChanged




        Select Case KryptonComboBox8.SelectedIndex
            Case 0
                ComboBoxClear()
                For i = 1 To 5
                    KryptonComboBox9.Items.Add(i)
                    KryptonComboBox10.Items.Add(i)
                    KryptonComboBox11.Items.Add(i)
                    KryptonComboBox12.Items.Add(i)
                    KryptonComboBox13.Items.Add(i)
                Next
                KryptonComboBox9.SelectedIndex = 0
                KryptonComboBox10.SelectedIndex = 1
                KryptonComboBox11.SelectedIndex = 2
                KryptonComboBox12.SelectedIndex = 3
                KryptonComboBox13.SelectedIndex = 4
            Case 1
                ComboBoxClear()
                For i = 1 To 4
                    KryptonComboBox10.Items.Add(i)

                    KryptonComboBox11.Items.Add(i)

                    KryptonComboBox12.Items.Add(i)

                    KryptonComboBox13.Items.Add(i)
                Next
                KryptonComboBox10.SelectedIndex = 0
                KryptonComboBox11.SelectedIndex = 1
                KryptonComboBox12.SelectedIndex = 2
                KryptonComboBox13.SelectedIndex = 3
                KryptonComboBox9.Enabled = False
            Case 2
                ComboBoxClear()
                For i = 1 To 4
                    KryptonComboBox9.Items.Add(i)
                    KryptonComboBox10.Items.Add(i)
                    KryptonComboBox11.Items.Add(i)
                    KryptonComboBox12.Items.Add(i)
                Next
                KryptonComboBox9.SelectedIndex = 0
                KryptonComboBox10.SelectedIndex = 1
                KryptonComboBox11.SelectedIndex = 2
                KryptonComboBox12.SelectedIndex = 3
                KryptonComboBox13.Enabled = False
            Case 3
                ComboBoxClear()
                For i = 1 To 3
                    KryptonComboBox10.Items.Add(i)
                    KryptonComboBox11.Items.Add(i)
                    KryptonComboBox12.Items.Add(i)
                Next
                KryptonComboBox10.SelectedIndex = 0
                KryptonComboBox11.SelectedIndex = 1
                KryptonComboBox12.SelectedIndex = 2
                KryptonComboBox9.Enabled = False
                KryptonComboBox13.Enabled = False
        End Select
    End Sub

    Sub ComboBoxClear()
        KryptonComboBox9.Items.Clear()
        KryptonComboBox10.Items.Clear()
        KryptonComboBox11.Items.Clear()
        KryptonComboBox12.Items.Clear()
        KryptonComboBox13.Items.Clear()

        KryptonComboBox9.ResetText()
        KryptonComboBox10.ResetText()
        KryptonComboBox11.ResetText()
        KryptonComboBox12.ResetText()
        KryptonComboBox13.ResetText()
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        Me.Dispose()

    End Sub


End Class
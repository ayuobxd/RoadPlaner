Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports RoadLib
Public Class MainW


    Dim Zoom As Integer


    Private Sub MainW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WriteText()

    End Sub



    Private Sub WriteText()
        Dim StrList() As String
        Dim LangF As New RoadLib.Language
        StrList = LangF.Lang(LanguageSettingGet())
        KryptonRibbon1.RibbonAppButton.AppButtonText() = StrList(0)
        KryptonRibbonTab1.Text = StrList(1)
        KryptonRibbonTab2.Text = StrList(2)
        KryptonRibbonTab3.Text = StrList(3)
        KryptonRibbonTab4.Text = StrList(4)
        KryptonRibbonTab5.Text = StrList(5)
        KryptonRibbonTab6.Text = StrList(6)
        KryptonRibbonTab7.Text = StrList(7)
        KryptonRibbonGroupButton1.TextLine1 = StrList(8)
        KryptonRibbonGroupButton2.TextLine1 = StrList(9)
        KryptonRibbonGroupButton3.TextLine1 = StrList(10)
        KryptonRibbonGroupButton4.TextLine1 = StrList(11)
        KryptonRibbonGroupButton5.TextLine1 = StrList(12)
        KryptonRibbonGroupButton6.TextLine1 = StrList(13)
        KryptonRibbonGroupButton10.TextLine1 = StrList(14)
        KryptonRibbonGroupButton12.TextLine1 = StrList(15)
        KryptonRibbonGroupButton13.TextLine1 = StrList(16)
        KryptonRibbonGroupButton7.TextLine1 = StrList(17)
        KryptonRibbonGroupButton8.TextLine1 = StrList(18)
        KryptonRibbonGroupButton9.TextLine1 = StrList(19)
        KryptonRibbonGroupButton11.TextLine1 = StrList(20)
        KryptonRibbonGroupButton14.TextLine1 = StrList(21)
        KryptonRibbonGroupButton16.TextLine1 = StrList(22)
        KryptonRibbonGroupButton18.TextLine1 = StrList(23)


    End Sub



    Private Sub SettingsQ_Click(sender As Object, e As EventArgs) Handles SettingsQ.Click
        Dim Frm As New Settings

        Frm.ShowDialog()

        Frm.Dispose()
    End Sub



    Private Sub MainW_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        WriteText()
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If e.Delta > 0 Then
            Zoom += 1

        Else
            Zoom -= 1

        End If
    End Sub

    Private Sub KryptonRibbonGroupButton3_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton3.Click

    End Sub
End Class

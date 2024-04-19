Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports RoadLib
Imports RoadLib.Project
Imports RoadLib.PointTopo
Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.Devices
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography

Public Class MainW
    Dim OffsetZoom As Point
    Public OffsetPan As Point
    Dim _Scale As Single = 1
    Dim ScaleBy As Single
    Dim MousePos As Point
    Dim Pan As Point

    Public StrList() As String



    Private Sub MainW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WriteText()


    End Sub
    Private Sub WriteText()


        StrList = Lang.Lang(LanguageSettingGet())

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



    Private Sub KryptonRibbonGroupButton19_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton19.Click
        Dim Frm As New SurvyTXT

        Frm.ShowDialog()

        Frm.Dispose()
    End Sub

    Private Sub KryptonRibbonGroupButton20_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton20.Click
        project.pointW()
    End Sub

    Private Sub KryptonRibbonGroupButton46_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton46.Click
        If KryptonRibbonGroupButton46.Checked Then
            KryptonRibbonGroupButton46.ImageLarge = Image.FromFile(Application.StartupPath & "\Data\on.png")
            KryptonRibbonGroupButton46.ImageSmall = Image.FromFile(Application.StartupPath & "\Data\on.png")
        Else
            KryptonRibbonGroupButton46.ImageLarge = Image.FromFile(Application.StartupPath & "\Data\off.png")
            KryptonRibbonGroupButton46.ImageSmall = Image.FromFile(Application.StartupPath & "\Data\off.png")
        End If
    End Sub





    Function After(value As String, a As String) As String
        Dim posA As Integer = value.LastIndexOf(a)

        Return value.Substring(posA + 1)
    End Function





    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Black)


        Dim DrawMatrix As New Matrix()

        DrawMatrix.Translate(-(OffsetZoom.X), -(OffsetZoom.Y))
        DrawMatrix.Scale(Math.Round(_Scale, 1), Math.Round(_Scale, 1))

        g.MultiplyTransform(DrawMatrix)



        Dim pen1 As New Pen(Color.Blue, 1 / _Scale)

        g.TranslateTransform(OffsetPan.X, OffsetPan.Y)

        g.DrawLine(pen1, 100, 100, 200, 200)


        For Each c As PointTopo In project.ListPointTopo

            Dim i = CInt(After(c.Name, ","))

            If i > 1 Then

                Dim rect As Rectangle = New Rectangle(CSng(c.X), CSng(c.Y), 3 / _Scale, 3 / _Scale)


                g.FillRectangle(Brushes.White, rect)

            End If

        Next










    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        MousePos = e.Location
        If e.Delta > 0 And _Scale < 100 Then

            _Scale += 0.1

            ScaleBy = 0.1

            OffsetZoom.X += CDbl(ScaleBy) * CDbl(ScreenToWorld(MousePos).X)
            OffsetZoom.Y += CDbl(ScaleBy) * CDbl(ScreenToWorld(MousePos).Y)
            PictureBox1.Invalidate()


        ElseIf _Scale > 0.2 Then
            _Scale -= 0.1

            ScaleBy = -0.1

            OffsetZoom.X += CDbl(ScaleBy) * CDbl(ScreenToWorld(MousePos).X)
            OffsetZoom.Y += CDbl(ScaleBy) * CDbl(ScreenToWorld(MousePos).Y)
            PictureBox1.Invalidate()
        End If
        Label2.Text = (Math.Round(_Scale, 1)).ToString
        Label1.Text = ScreenToWorld(MousePos).ToString
        Label5.Text = MousePos.ToString




    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        'middle mouse
        If e.Button = 4194304 Then
            Pan.X = e.Location.X
            Pan.Y = e.Location.Y
        End If



    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = 4194304 Then
            OffsetPan.X += (e.Location.X - Pan.X) / _Scale
            OffsetPan.Y += (e.Location.Y - Pan.Y) / _Scale
            Pan.X = e.Location.X
            Pan.Y = e.Location.Y

            PictureBox1.Invalidate()
        End If
        MousePos = e.Location
        Label1.Text = ScreenToWorld(MousePos).ToString
        Label5.Text = MousePos.ToString

    End Sub

    Function ScreenToWorld(ScrPos As Point) As Point
        Dim World As Point
        World.X = (ScrPos.X + OffsetZoom.X) / _Scale - OffsetPan.X
        World.Y = (ScrPos.Y + OffsetZoom.Y) / _Scale - OffsetPan.Y
        Return World
    End Function
    'gg

End Class
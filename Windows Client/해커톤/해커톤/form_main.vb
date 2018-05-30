Public Class form_main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_menu()

        'Dim panels = New UserControl1
        'Controls.Add(panels)
    End Sub



    Sub get_menu()
        Try
            Dim winhttp As New WinHttp.WinHttpRequest

            winhttp.Open("get", "https://www.dimigo.hs.kr/index.php?mid=school_cafeteria")
            winhttp.Send()

            Dim a() = Split(winhttp.ResponseText, """>" + Convert.ToInt32(Now.Month).ToString + "월 " + Convert.ToInt32(Now.Day).ToString + "일 식단입니다")
            Dim b() = Split(a(0), "href=""")
            Dim url = b(b.Length - 1)

            winhttp.Open("get", url)
            winhttp.Send()

            Dim c() = Split(winhttp.ResponseText, "조식 : ")
            Dim d() = Split(c(1), """ /")

            a = Split(d(0), "중식 : ")
            Label_Breakfast_Text.Text = a(0)

            b = Split(a(1), "석식 : ")
            Label_Lunch_Text.Text = b(0)
            Label_Dinner_Text.Text = b(1)


            If Now.Hour < 9 Then
                Label_Breakfast.ForeColor = Color.Tomato
                Label_Breakfast_Text.ForeColor = Color.Black
            ElseIf Now.Hour < 14 Then
                Label_Lunch.ForeColor = Color.Tomato
                Label_Lunch_Text.ForeColor = Color.Black
            Else
                Label_Dinner.ForeColor = Color.Tomato
                Label_Dinner_Text.ForeColor = Color.Black
            End If
        Catch ex As Exception
            '수정 해야 할 것
            '
            MsgBox("인터넷 연결 확인")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picture_Exit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles Picture_Exit.MouseHover
        'Picture_Exit.Image = My.Resources._Exit
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Picture_Exit.MouseLeave
        ' Picture_Exit.Image = My.Resources.Exit_Gray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        form_Study.ShowDialog()
    End Sub


    Dim skin As New Point
    Dim X, Y As Integer

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        form_Attend.ShowDialog()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            skin = Control.MousePosition
            skin.X -= (X)
            skin.Y -= (Y)
            Location = skin
        End If
    End Sub
End Class

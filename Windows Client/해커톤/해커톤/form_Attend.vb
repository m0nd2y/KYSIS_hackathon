Imports System.Threading

Public Class form_Attend

    Private Sub form_Attend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = form_main.Top
        Me.Left = form_main.Left
    End Sub

    Private Sub Picture_Exit_Click(sender As Object, e As EventArgs) Handles Picture_Exit.Click
        Me.Close()
    End Sub

    Dim skin As New Point
    Dim X, Y As Integer

    Private Sub form_Attend_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Dim trd As Thread
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        trd = New Thread(AddressOf check)
        trd.IsBackground = True
        trd.Start()
        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub form_Attend_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            skin = Control.MousePosition
            skin.X -= (X)
            skin.Y -= (Y)
            Location = skin
            form_main.Top = Me.Top
            form_main.Left = Me.Left
        End If
    End Sub

    Sub check()
        Dim winhttp As New WinHttp.WinHttpRequest
        winhttp.Open("get", "http://192.168.30.176:9990/student." + Split(ComboBox1.Text, "월")(0) + "." + ComboBox2.Text)
        winhttp.Send()
        winhttp.WaitForResponse()

        Dim Data() = Split(winhttp.ResponseText, " ")

        Try
            label_month_1.Text = con(Data(0))
            label_month_2.Text = con(Data(1))
            label_month_3.Text = con(Data(2))
            label_month_4.Text = con(Data(3))
            label_month_5.Text = con(Data(4))
            label_month_6.Text = con(Data(5))
            label_month_7.Text = con(Data(6))
            label_month_8.Text = con(Data(7))
            label_month_9.Text = con(Data(8))
            label_month_10.Text = con(Data(9))
            label_month_11.Text = con(Data(10))
            label_month_12.Text = con(Data(11))
            label_month_13.Text = con(Data(12))
            label_month_14.Text = con(Data(13))
            label_month_15.Text = con(Data(14))
            label_month_16.Text = con(Data(15))
            label_month_17.Text = con(Data(16))
            label_month_18.Text = con(Data(17))
            label_month_19.Text = con(Data(18))
            label_month_20.Text = con(Data(19))
            label_month_21.Text = con(Data(20))
            label_month_22.Text = con(Data(21))
            label_month_23.Text = con(Data(22))
            label_month_24.Text = con(Data(23))
            label_month_25.Text = con(Data(24))
            label_month_26.Text = con(Data(25))
            label_month_27.Text = con(Data(26))
            label_month_28.Text = con(Data(27))
            label_month_29.Text = con(Data(28))
            label_month_30.Text = con(Data(29))
            label_month_31.Text = con(Data(30))
        Catch ex As Exception

        End Try
        trd.Abort()
    End Sub

    Function con(ByVal text As String)
        Select Case text
            Case "0"
                Return "정보 없음"
            Case "1"
                Return "정상"
            Case "2"
                Return "조퇴"
            Case "3"
                Return "인정 지각"
            Case "4"
                Return "인정 결석"
            Case "5"
                Return "무단 결석"
            Case "6"
                Return "무단 지각"
            Case "7"
                Return "병결 결석"
            Case "8"
                Return "병결 지각"
            Case Else
                Return "오류"
        End Select
    End Function
End Class
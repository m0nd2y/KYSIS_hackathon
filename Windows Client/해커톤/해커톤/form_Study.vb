Public Class form_Study
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub form_Study_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = form_main.Top
        Me.Left = form_main.Left
        'Chart1.ChartAreas(0).AxisX.Minimum = 0D
        'Chart1.ChartAreas(0).AxisX.Maximum = 10D
    End Sub

    Private Sub Picture_Exit_Click(sender As Object, e As EventArgs) Handles Picture_Exit.Click
        Me.Close()
    End Sub

    Dim skin As New Point
    Dim X, Y As Integer

    Private Sub form_Study_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub form_Study_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            skin = Control.MousePosition
            skin.X -= (X)
            skin.Y -= (Y)
            Location = skin
            form_main.Top = Me.Top
            form_main.Left = Me.Left
        End If
    End Sub
End Class
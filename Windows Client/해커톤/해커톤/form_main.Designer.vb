<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Dinner_Text = New System.Windows.Forms.Label()
        Me.Label_Lunch_Text = New System.Windows.Forms.Label()
        Me.Label_Breakfast_Text = New System.Windows.Forms.Label()
        Me.Label_Lunch = New System.Windows.Forms.Label()
        Me.Label_Dinner = New System.Windows.Forms.Label()
        Me.Label_Breakfast = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Picture_Exit = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(-168, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "데이터"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(-172, -66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 55)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "로고"
        '
        'Label_Dinner_Text
        '
        Me.Label_Dinner_Text.AutoSize = True
        Me.Label_Dinner_Text.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Dinner_Text.ForeColor = System.Drawing.Color.Silver
        Me.Label_Dinner_Text.Location = New System.Drawing.Point(554, 320)
        Me.Label_Dinner_Text.Name = "Label_Dinner_Text"
        Me.Label_Dinner_Text.Size = New System.Drawing.Size(102, 28)
        Me.Label_Dinner_Text.TabIndex = 26
        Me.Label_Dinner_Text.Text = "석식 텍스트"
        '
        'Label_Lunch_Text
        '
        Me.Label_Lunch_Text.AutoSize = True
        Me.Label_Lunch_Text.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Lunch_Text.ForeColor = System.Drawing.Color.Silver
        Me.Label_Lunch_Text.Location = New System.Drawing.Point(554, 250)
        Me.Label_Lunch_Text.Name = "Label_Lunch_Text"
        Me.Label_Lunch_Text.Size = New System.Drawing.Size(102, 28)
        Me.Label_Lunch_Text.TabIndex = 25
        Me.Label_Lunch_Text.Text = "중식 텍스트"
        '
        'Label_Breakfast_Text
        '
        Me.Label_Breakfast_Text.AutoSize = True
        Me.Label_Breakfast_Text.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Breakfast_Text.ForeColor = System.Drawing.Color.Silver
        Me.Label_Breakfast_Text.Location = New System.Drawing.Point(554, 177)
        Me.Label_Breakfast_Text.Name = "Label_Breakfast_Text"
        Me.Label_Breakfast_Text.Size = New System.Drawing.Size(102, 28)
        Me.Label_Breakfast_Text.TabIndex = 24
        Me.Label_Breakfast_Text.Text = "조식 텍스트"
        '
        'Label_Lunch
        '
        Me.Label_Lunch.AutoSize = True
        Me.Label_Lunch.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Lunch.ForeColor = System.Drawing.Color.Silver
        Me.Label_Lunch.Location = New System.Drawing.Point(553, 219)
        Me.Label_Lunch.Name = "Label_Lunch"
        Me.Label_Lunch.Size = New System.Drawing.Size(52, 31)
        Me.Label_Lunch.TabIndex = 22
        Me.Label_Lunch.Text = "중식"
        '
        'Label_Dinner
        '
        Me.Label_Dinner.AutoSize = True
        Me.Label_Dinner.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Dinner.ForeColor = System.Drawing.Color.Silver
        Me.Label_Dinner.Location = New System.Drawing.Point(553, 289)
        Me.Label_Dinner.Name = "Label_Dinner"
        Me.Label_Dinner.Size = New System.Drawing.Size(52, 31)
        Me.Label_Dinner.TabIndex = 21
        Me.Label_Dinner.Text = "석식"
        '
        'Label_Breakfast
        '
        Me.Label_Breakfast.AutoSize = True
        Me.Label_Breakfast.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label_Breakfast.ForeColor = System.Drawing.Color.Silver
        Me.Label_Breakfast.Location = New System.Drawing.Point(553, 146)
        Me.Label_Breakfast.Name = "Label_Breakfast"
        Me.Label_Breakfast.Size = New System.Drawing.Size(52, 31)
        Me.Label_Breakfast.TabIndex = 20
        Me.Label_Breakfast.Text = "조식"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 20.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(591, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 41)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "오늘의 메뉴"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 20.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 41)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "학사 일정"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Sans CJK KR Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 55)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "디미림 인트라넷"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.해커톤.My.Resources.Resources.plan
        Me.PictureBox4.Location = New System.Drawing.Point(12, 146)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(531, 394)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.해커톤.My.Resources.Resources.Attend
        Me.PictureBox1.Location = New System.Drawing.Point(559, 367)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.해커톤.My.Resources.Resources.logo_Main
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Picture_Exit
        '
        Me.Picture_Exit.Image = Global.해커톤.My.Resources.Resources._Exit
        Me.Picture_Exit.Location = New System.Drawing.Point(1239, 14)
        Me.Picture_Exit.Name = "Picture_Exit"
        Me.Picture_Exit.Size = New System.Drawing.Size(50, 50)
        Me.Picture_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture_Exit.TabIndex = 27
        Me.Picture_Exit.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.해커톤.My.Resources.Resources.Menu
        Me.PictureBox2.Location = New System.Drawing.Point(541, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1301, 582)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Picture_Exit)
        Me.Controls.Add(Me.Label_Dinner_Text)
        Me.Controls.Add(Me.Label_Lunch_Text)
        Me.Controls.Add(Me.Label_Breakfast_Text)
        Me.Controls.Add(Me.Label_Lunch)
        Me.Controls.Add(Me.Label_Dinner)
        Me.Controls.Add(Me.Label_Breakfast)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "디미림 인트라넷"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Dinner_Text As Label
    Friend WithEvents Label_Lunch_Text As Label
    Friend WithEvents Label_Breakfast_Text As Label
    Friend WithEvents Label_Lunch As Label
    Friend WithEvents Label_Dinner As Label
    Friend WithEvents Label_Breakfast As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Picture_Exit As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class

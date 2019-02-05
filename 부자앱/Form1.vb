Public Class Form1
    Dim loc As Point
    Dim topmst = 0
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove_1(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub
    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        Panel5.BackgroundImage = My.Resources._2
    End Sub
    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        Panel5.BackgroundImage = My.Resources._1
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.name = Nothing Then
        Else
            Label2.Text = My.Settings.name + "의 보석"
            Panel6.Visible = False
            LinkLabel1.Visible = True
        End If
        FadeIn()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fadeout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            Label3.Text = "이름을 입력하세요."
            Label3.Visible = True
            Timer1.Start()
        ElseIf TextBox1.Text = "맨처음상태" Then
            My.Settings.name = Nothing
            Label3.Text = "너는 개발자입니다."
            Label3.Visible = True
            Timer1.Start()
            Dim msg = MsgBox("프로그램을 종료하시겠습니까? 이유는 '너'가 알고 있습니다.", vbYesNo + MsgBoxStyle.Question)
            If msg = vbYes Then
                Me.Close()
            End If
        ElseIf My.Settings.name = TextBox1.Text Then
            My.Settings.name = TextBox1.Text
            Label3.Text = "변경 사항이 없습니다."
            Label3.Visible = True
            Timer1.Start()
            Panel6.Visible = False
            LinkLabel1.Visible = True
        Else
            My.Settings.name = TextBox1.Text
            Label3.Text = "성공적으로 등록되었습니다."
            Label3.Visible = True
            Timer1.Start()
            Panel6.Visible = False
            Label2.Text = My.Settings.name + "의 보석"
            LinkLabel1.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel6.Visible = True
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        If topmst = 0 Then
            Me.TopMost = True
            topmst = 1
        Else
            Me.TopMost = False
            topmst = 0
        End If

        If TopMost = 0 Then
            Panel7.BackgroundImage = My.Resources.t_01
            Label3.Text = "보통 위치에 둡니다"
            Label3.Visible = True
            Timer1.Start()
        Else
            Panel7.BackgroundImage = My.Resources.t_11
            Label3.Text = "항상 위에 둡니다"
            Label3.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Panel7_MouseEnter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter
        If topmst = 0 Then
            Panel7.BackgroundImage = My.Resources.t_01
        Else
            Panel7.BackgroundImage = My.Resources.t_11
        End If
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave
        If topmst = 0 Then
            Panel7.BackgroundImage = My.Resources.t_0
        Else
            Panel7.BackgroundImage = My.Resources.t_1
        End If
    End Sub
End Class

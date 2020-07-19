Public Class Form1
    Private Sub Label2_Cl()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Label2.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "Nitima"
        Label1.Text = FirstName
        FirstName = "khuadsalee"
        Label2.Text = FirstName
        FirstName = "first"
        Label3.Text = FirstName

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, Fullname As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        Fullname = InputBox(Prompt)
        Label1.Text = Fullname
        Prompt = "กรุณาป้อนชื่อเล่น"
        Fullname = InputBox(Prompt)
        Label3.Text = Fullname
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, Fullname As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        Fullname = InputBox(Prompt)
        MsgBox(Fullname, , "ชื่อและนาทสกุลของคุณ")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

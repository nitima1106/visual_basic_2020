Public Class Form1
    Dim firstNum, SecondNum, SecondNum1, Result, Result1 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        firstNum = TextBox1.Text
        SecondNum = TextBox2.Text
        SecondNum1 = TextBox4.Text
        Result = firstNum * SecondNum
        Result1 = SecondNum1 - Result
        Label7.Text = Result
        Label8.Text = Result1

    End Sub
End Class

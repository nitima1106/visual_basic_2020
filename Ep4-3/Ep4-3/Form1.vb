Public Class Form1
    Dim Num1, Num2, Resulf As Double
    Dim Resulf1 As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Resulf = Num1 * Num2
        Resulf1 = Resulf / 50
        Label5.Text = Resulf
        Label6.Text = Resulf1
    End Sub
End Class

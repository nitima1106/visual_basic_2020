Public Class Form1
    Dim Username As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Userneme As String
        Userneme = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาใส่รหัสผ่านของคุณ")
        If Userneme = "เฟิร์ส" And Password = "123" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nitima khuadsalee\All_Images\photo05.jpg")
        ElseIf Userneme = "น้องแป้ง" And Password = "456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nitima khuadsalee\All_Images\photo07.jpg")
        ElseIf Userneme = "พี่ส้ม" And Password = "789" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\nitima khuadsalee\All_Images\user_nooknet.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If

    End Sub
End Class

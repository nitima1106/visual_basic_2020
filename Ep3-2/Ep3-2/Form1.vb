Public Class Form1
    Dim Birds As Short
    Dim Insects As Integer
    Dim WorlbPop As Long
    Dim Price As String
    Dim fullName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("Long")
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("FullName")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label3.Text = Birds
            Case 1
                Insects = 37500000
                Label3.Text = Insects
            Case 2
                WorlbPop = 253.99
                Label3.Text = WorlbPop
            Case 3
                Price = "first"
                Label3.Text = Price
            Case 4
                fullName = "นิธิมา ขวดสาลี่"
                Label3.Text = fullName
        End Select
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

Public Class Form1
    Public Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim h, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        ' TextBox3.Text = Format(BMI(h, w), "0.00")
        TextBox3.Text = Math.Round(BMI(h, w), 2)
    End Sub
End Class

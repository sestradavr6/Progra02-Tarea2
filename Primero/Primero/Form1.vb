Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frijol As Double, azuc As Double, arroz As Double
        Dim pago1 As Double, iva As Double, pago2 As Double
        Dim descaniv As Double, pagototal As Double

        frijol = TextBox1.Text
        azuc = TextBox2.Text
        arroz = TextBox3.Text

        pago1 = (frijol * 2.0 + azuc * 1.75 + arroz * 2.5)
        iva = pago1 * 0.12
        pago2 = pago1 + iva
        descaniv = "-" & pago2 * 0.05
        pagototal = pago2 + descaniv

        Label10.Text = pago1
        Label11.Text = iva
        Label12.Text = pago2
        Label13.Text = descaniv
        Label14.Text = pagototal


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label10.Text = "0"
        Label11.Text = "0"
        Label12.Text = "0"
        Label13.Text = "0"
        Label14.Text = "0"

    End Sub
End Class

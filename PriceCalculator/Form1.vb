Public Class Form1
    Private Sub btnClaculate_Click(sender As Object, e As EventArgs) Handles btnClaculate.Click
        Dim dPrice As Decimal
        Dim iQuantity As Integer
        Dim Total As Decimal

        dPrice = txtPrice.Text
        iQuantity = txtQuantity.Text

        Total = (dPrice * iQuantity)

        MessageBox.Show("The total cost is " & Total)

    End Sub
End Class

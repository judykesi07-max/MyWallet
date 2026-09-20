Public Class FormDeposit
    Public currentUser As String
    Private Sub btnSaveDeposit_Click(sender As Object, e As EventArgs) Handles btnSaveDeposit.Click

        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) Then
            MessageBox.Show("Enter a valid amount.")
            Exit Sub
        End If


        If amount <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Exit Sub
        End If


        Dim service As New TransactionService()


        If service.AddDeposit(currentUser, amount, "Deposit") Then

            MessageBox.Show("Deposit successful!")

            Me.Close()

        Else

            MessageBox.Show("Deposit failed.")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
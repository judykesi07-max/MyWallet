Public Class FormWithdraw
    Public currentUser As String

    Private Sub btnSaveWithdraw_Click(sender As Object, e As EventArgs) Handles btnSaveWithdraw.Click

        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) Then
            MessageBox.Show("Enter a valid amount.")
            Exit Sub
        End If


        If amount <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Exit Sub
        End If


        Dim category As String = cmbCategory.Text

        If category = "" Then
            MessageBox.Show("Select a category.")
            Exit Sub
        End If


        Dim service As New TransactionService()

        If service.AddWithdrawal(currentUser, amount, category) Then

            MessageBox.Show("Withdrawal successful!")

            Me.Close()

        Else

            MessageBox.Show("Insufficient balance.")

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
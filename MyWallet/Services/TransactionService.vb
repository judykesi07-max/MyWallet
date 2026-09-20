Imports Microsoft.Data.SqlClient

Public Class TransactionService

    Public Function AddDeposit(username As String,
                               amount As Decimal,
                               category As String) As Boolean

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim balance As Decimal = 0

            'Get current balance
            Dim balanceQuery As String =
            "SELECT Balance FROM Wallet WHERE Username=@Username"

            Using balCmd As New SqlCommand(balanceQuery, conn)

                balCmd.Parameters.AddWithValue("@Username", username)

                Dim result = balCmd.ExecuteScalar()

                If result IsNot Nothing Then
                    balance = Convert.ToDecimal(result)
                End If

            End Using


            Dim newBalance As Decimal = balance + amount


            'Update wallet
            Dim updateQuery As String =
            "UPDATE Wallet SET Balance=@Balance WHERE Username=@Username"

            Using updateCmd As New SqlCommand(updateQuery, conn)

                updateCmd.Parameters.AddWithValue("@Balance", newBalance)
                updateCmd.Parameters.AddWithValue("@Username", username)

                updateCmd.ExecuteNonQuery()

            End Using


            'Save transaction
            Dim query As String =
            "INSERT INTO Transactions
            (Username, TransactionType, Category, Amount, BalanceAfter, TransactionDate)
            VALUES
            (@Username,'Deposit',@Category,@Amount,@Balance,@Date)"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Category", category)
                cmd.Parameters.AddWithValue("@Amount", amount)
                cmd.Parameters.AddWithValue("@Balance", newBalance)
                cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                cmd.ExecuteNonQuery()

            End Using

        End Using

        Return True

    End Function
    Public Function AddWithdrawal(username As String,
                              amount As Decimal,
                              category As String) As Boolean

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim balance As Decimal = 0


            'Get current balance
            Dim balanceQuery As String =
            "SELECT Balance FROM Wallet WHERE Username=@Username"


            Using balCmd As New SqlCommand(balanceQuery, conn)

                balCmd.Parameters.AddWithValue("@Username", username)

                Dim result = balCmd.ExecuteScalar()

                If result IsNot Nothing Then
                    balance = Convert.ToDecimal(result)
                End If

            End Using


            'Check balance
            If amount > balance Then
                Return False
            End If


            Dim newBalance As Decimal = balance - amount


            'Update wallet
            Dim updateQuery As String =
            "UPDATE Wallet SET Balance=@Balance WHERE Username=@Username"


            Using updateCmd As New SqlCommand(updateQuery, conn)

                updateCmd.Parameters.AddWithValue("@Balance", newBalance)
                updateCmd.Parameters.AddWithValue("@Username", username)

                updateCmd.ExecuteNonQuery()

            End Using


            'Save transaction
            Dim query As String =
            "INSERT INTO Transactions
        (Username, TransactionType, Category, Amount, BalanceAfter, TransactionDate)
        VALUES
        (@Username,'Withdrawal',@Category,@Amount,@Balance,@Date)"


            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Category", category)
                cmd.Parameters.AddWithValue("@Amount", amount)
                cmd.Parameters.AddWithValue("@Balance", newBalance)
                cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                cmd.ExecuteNonQuery()

            End Using


        End Using


        Return True

    End Function
    Public Function GetTransactions(username As String) As DataTable

        Dim table As New DataTable()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT TransactionType, Category, Amount, BalanceAfter, TransactionDate
         FROM Transactions
         WHERE Username=@Username
         ORDER BY TransactionDate DESC"


            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                Using adapter As New SqlDataAdapter(cmd)

                    adapter.Fill(table)

                End Using

            End Using

        End Using


        Return table

    End Function
    Public Function GetTodaySpent(username As String) As Decimal

        Dim total As Decimal = 0

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT ISNULL(SUM(Amount),0)
         FROM Transactions
         WHERE Username=@Username
         AND TransactionType='Withdrawal'
         AND CAST(TransactionDate AS DATE)=CAST(GETDATE() AS DATE)"


            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                total = Convert.ToDecimal(cmd.ExecuteScalar())

            End Using

        End Using


        Return total

    End Function
    Public Function GetTopCategory(username As String) As String

        Dim category As String = "No data yet"

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT TOP 1 Category
         FROM Transactions
         WHERE Username=@Username
         AND TransactionType='Withdrawal'
         GROUP BY Category
         ORDER BY SUM(Amount) DESC"


            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    category = result.ToString()
                End If

            End Using

        End Using


        Return category

    End Function
    Public Function SearchTransactions(username As String, keyword As String) As DataTable

        Dim table As New DataTable()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT TransactionType, Category, Amount, BalanceAfter, TransactionDate
         FROM Transactions
         WHERE Username=@Username
         AND (TransactionType LIKE @Keyword OR Category LIKE @Keyword)
         ORDER BY TransactionDate DESC"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using

            End Using

        End Using

        Return table

    End Function

End Class

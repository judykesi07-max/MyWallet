Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class ReportService

    Public Function GetSpendingByCategory(username As String) As DataTable

        Dim table As New DataTable()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT Category,
                    SUM(Amount) AS TotalSpent
             FROM Transactions
             WHERE Username=@Username
             AND TransactionType='Withdrawal'
             GROUP BY Category
             ORDER BY TotalSpent DESC"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using

            End Using

        End Using

        Return table

    End Function

End Class

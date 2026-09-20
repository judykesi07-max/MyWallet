Imports Microsoft.Data.SqlClient

Public Class WalletService


    Public Function GetBalance(username As String) As Decimal

        Dim balance As Decimal = 0

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT Balance FROM Wallet WHERE Username=@Username"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    balance = Convert.ToDecimal(result)
                End If

            End Using

        End Using


        Return balance

    End Function


End Class
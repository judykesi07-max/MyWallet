Imports System.Data
Imports Microsoft.Data.SqlClient
Public Class SavingsGoalService

    Public Sub CreateGoal(username As String,
                          goalName As String,
                          targetAmount As Decimal)

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
                "INSERT INTO SavingsGoals " &
                "(Username, GoalName, TargetAmount, SavedAmount) " &
                "VALUES (@Username, @GoalName, @TargetAmount, 0)"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@GoalName", goalName)
                cmd.Parameters.AddWithValue("@TargetAmount", targetAmount)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub
    Public Function GetGoals(username As String) As DataTable

        Dim table As New DataTable()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT GoalID,
                GoalName,
                TargetAmount,
                SavedAmount,
                (TargetAmount - SavedAmount) AS Remaining
         FROM SavingsGoals
         WHERE Username=@Username"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", username)

                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using

            End Using

        End Using

        Return table

    End Function
    Public Sub AddMoney(goalID As Integer, amount As Decimal)

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "UPDATE SavingsGoals
         SET SavedAmount = SavedAmount + @Amount
         WHERE GoalID=@GoalID"


            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Amount", amount)
                cmd.Parameters.AddWithValue("@GoalID", goalID)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub
    Public Function GetSavingsSummary(username As String) As DataTable

        Dim table As New DataTable()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
            "SELECT 
            COUNT(*) AS TotalGoals,
            SUM(SavedAmount) AS TotalSaved,
            SUM(CASE 
                    WHEN SavedAmount >= TargetAmount 
                    THEN 1 
                    ELSE 0 
                END) AS CompletedGoals
         FROM SavingsGoals
         WHERE Username=@Username"


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
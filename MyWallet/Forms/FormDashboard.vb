Imports Microsoft.Data.SqlClient
Imports System.Data
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.WinForms
Public Class FormDashboard
    Public currentUser As String

    Public Balance As Decimal = 0
    Dim avgDailySpend As Decimal = 0
    Dim daysRemaining As Integer = 0


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCategory.Items.Clear()

        cmbCategory.Items.Add("Food")
        cmbCategory.Items.Add("Transport")


        cmbCategory.Items.Add("Shopping")
        cmbCategory.Items.Add("Entertainment")
        cmbCategory.Items.Add("Education")



        cmbCategory.SelectedIndex = 0


        lblUser.Text = "Logged in user: " & currentUser
        lblWelcome.Text = "Welcome, " & currentUser


        LoadBalance()
        LoadTransactions()
        LoadCategories()
        LoadTotalSpent()
        LoadTopCategory()
        LoadMonthlySummary()
        LoadSavingsSummary()

    End Sub
    Private Sub LoadBalance()

        Try

            Dim walletService As New WalletService()

            Balance = walletService.GetBalance(currentUser)

            lblBalance.Text = "KSh " & Balance.ToString("N2")


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

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


        Dim service As New TransactionService()


        If service.AddDeposit(currentUser, amount, category) Then

            MessageBox.Show("Deposit successful!")

            LoadBalance()
            LoadTransactions()
            LoadTotalSpent()
            LoadTopCategory()
            CheckWarnings()

            txtAmount.Clear()

        End If


    End Sub
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        Dim amount As Decimal

        If Not Decimal.TryParse(txtWithdraw.Text.Trim(), amount) Then
            MessageBox.Show("Enter a valid amount.")
            Exit Sub
        End If


        If amount <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Exit Sub
        End If


        Dim category As String = cmbCategory.Text


        Dim service As New TransactionService()


        If service.AddWithdrawal(currentUser, amount, category) Then

            MessageBox.Show("Withdrawal successful!")

            LoadBalance()
            LoadTransactions()
            LoadTotalSpent()
            LoadTopCategory()
            CheckWarnings()

            txtWithdraw.Clear()

        Else

            MessageBox.Show("Insufficient balance.")

        End If


    End Sub
    Private Sub LoadTransactions()

    End Sub
    Private Sub LoadCategories()

        cmbCategory.Items.Clear()

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim cmd As New SqlCommand("SELECT CategoryName FROM Categories", conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    cmbCategory.Items.Add(reader("CategoryName").ToString())
                End While

            End Using

        End Using

    End Sub

    Private Sub LoadTotalSpent()

        Dim totalSpent As Decimal = 0
        Dim avgDailySpend As Decimal = 0

        Using conn As SqlConnection = DatabaseManager.GetConnection()
            conn.Open()

            '========================
            ' 1. TOTAL SPENT
            '========================
            Dim cmd As New SqlCommand(
            "SELECT SUM(Amount) FROM Transactions WHERE TransactionType='Withdraw'",
            conn)

            Dim totalResult = cmd.ExecuteScalar()

            If totalResult IsNot Nothing AndAlso totalResult IsNot DBNull.Value Then
                totalSpent = Convert.ToDecimal(totalResult)
            End If

            '========================
            ' 2. AVERAGE DAILY SPEND
            '========================
            Dim cmd2 As New SqlCommand("
            SELECT AVG(DailyTotal)
            FROM (
                SELECT CAST(TransactionDate AS DATE) AS Day,
                       SUM(Amount) AS DailyTotal
                FROM Transactions
                WHERE TransactionType='Withdraw'
                GROUP BY CAST(TransactionDate AS DATE)
            ) AS DailyTable", conn)

            Dim avgResult = cmd2.ExecuteScalar()

            If avgResult IsNot Nothing AndAlso avgResult IsNot DBNull.Value Then
                avgDailySpend = Convert.ToDecimal(avgResult)
            End If
            If avgDailySpend > 0 Then
                daysRemaining = Balance / avgDailySpend
                lblPrediction.Text = $"Your money may last about {daysRemaining} days"
            Else
                lblPrediction.Text = "Not enough data to predict spending"
            End If

        End Using

        '========================
        ' DISPLAY (example labels)
        '========================
        lblTotalSpent.Text = "Total Spent: KSh " & totalSpent.ToString("N2")
        lblAvgDaily.Text = "Avg Daily Spend: KSh " & avgDailySpend.ToString("N2")


    End Sub
    Private Function GetTodaySpent() As Decimal

        Dim service As New TransactionService()

        Return service.GetTodaySpent(currentUser)

    End Function
    Private Sub CheckWarnings()

        Dim balance As Decimal = 0
        Dim spentToday As Decimal = GetTodaySpent()

        Using conn As SqlConnection = DatabaseManager.GetConnection()
            conn.Open()

            Dim query As String = "SELECT Balance FROM Wallet WHERE Username=@Username"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", currentUser)

                balance = Convert.ToDecimal(cmd.ExecuteScalar())

            End Using

        End Using

        lblWarning.Text = ""

        If balance <= 500 Then
            lblWarning.Text &= "⚠ Low balance (KSh " & balance.ToString("N2") & "). "
        End If

        If spentToday >= 1000 Then
            lblWarning.Text &= "⚠ You have spent KSh " & spentToday.ToString("N2") & " today. "
        End If

        If lblWarning.Text = "" Then
            lblWarning.Text = "✓ Your account is in good standing."
        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)

        Dim result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim login As New FormLogin
            login.Show()

            Close()

        End If

    End Sub
    Private Sub LoadTopCategory()

        Dim service As New TransactionService()

        lblTopCategory.Text =
        "Most spent on: " & service.GetTopCategory(currentUser)

    End Sub

    Private Sub LoadMonthlySummary()

        Try

            Using conn As SqlConnection = DatabaseManager.GetConnection()
                conn.Open()

                'Total Deposits
                Dim depositQuery As String =
            "SELECT ISNULL(SUM(Amount),0)
             FROM Transactions
             WHERE Username=@Username
             AND TransactionType='Deposit'
             AND YEAR(TransactionDate)=YEAR(GETDATE())
             AND MONTH(TransactionDate)=MONTH(GETDATE())"

                Dim totalDeposits As Decimal

                Using cmd As New SqlCommand(depositQuery, conn)

                    cmd.Parameters.AddWithValue("@Username", currentUser)
                    totalDeposits = Convert.ToDecimal(cmd.ExecuteScalar())

                End Using


                'Total Withdrawals
                Dim withdrawalQuery As String =
            "SELECT ISNULL(SUM(Amount),0)
             FROM Transactions
             WHERE Username=@Username
             AND TransactionType='Withdrawal'
             AND YEAR(TransactionDate)=YEAR(GETDATE())
             AND MONTH(TransactionDate)=MONTH(GETDATE())"

                Dim totalWithdrawals As Decimal

                Using cmd As New SqlCommand(withdrawalQuery, conn)

                    cmd.Parameters.AddWithValue("@Username", currentUser)
                    totalWithdrawals = Convert.ToDecimal(cmd.ExecuteScalar())

                End Using


                'Display
                lblMonthlyDeposits.Text = "Monthly Deposits: KSh " & totalDeposits.ToString("N2")
                lblMonthlyWithdrawals.Text = "Monthly Withdrawals: KSh " & totalWithdrawals.ToString("N2")
                lblNetSavings.Text = "Net Savings: KSh " & (totalDeposits - totalWithdrawals).ToString("N2")

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSaveBudget_Click(sender As Object, e As EventArgs) Handles btnSaveBudget.Click

        Dim budget As Decimal

        If Not Decimal.TryParse(txtMonthlyBudget.Text, budget) Then
            MessageBox.Show("Enter a valid budget.")
            Exit Sub
        End If

        Using conn As SqlConnection = DatabaseManager.GetConnection()

            conn.Open()

            Dim query As String =
        "IF EXISTS(SELECT 1 FROM Budget WHERE Username=@Username)
            UPDATE Budget SET MonthlyBudget=@Budget WHERE Username=@Username
         ELSE
            INSERT INTO Budget(Username, MonthlyBudget)
            VALUES(@Username,@Budget)"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Username", currentUser)
                cmd.Parameters.AddWithValue("@Budget", budget)

                cmd.ExecuteNonQuery()

            End Using

        End Using

        MessageBox.Show("Budget saved successfully.")

    End Sub

    Private Sub btnSavingsGoals_Click(sender As Object, e As EventArgs) Handles btnSavingsGoals.Click

        Dim frm As New FormSavingsGoals()

        frm.currentUser = currentUser

        frm.ShowDialog()

    End Sub
    Private Sub LoadSavingsSummary()

        Try

            Dim service As New SavingsGoalService()

            Dim table As DataTable =
                service.GetSavingsSummary(currentUser)


            If table.Rows.Count > 0 Then

                lblTotalGoals.Text =
                    "Total Goals: " &
                    table.Rows(0)("TotalGoals").ToString()


                lblTotalSaved.Text =
                    "Total Saved: " &
                    Convert.ToDecimal(table.Rows(0)("TotalSaved")).ToString("N2")


                lblCompletedGoals.Text =
                    "Completed Goals: " &
                    table.Rows(0)("CompletedGoals").ToString()

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
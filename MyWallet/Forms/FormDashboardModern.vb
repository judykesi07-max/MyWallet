Imports Microsoft.Data.SqlClient
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Public Class FormDashboardModern

    Private Sub DrawSilverBorder(panel As Panel, e As PaintEventArgs)
        Using borderPen As New Pen(Color.FromArgb(210, 210, 210), 1)
            e.Graphics.DrawRectangle(
            borderPen,
            0,
            0,
            panel.ClientSize.Width - 1,
            panel.ClientSize.Height - 1
        )
        End Using
    End Sub

    Private Sub btnDeposit_Paint(sender As Object, e As PaintEventArgs) Handles btnDeposit.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = 12

        Using path As New Drawing2D.GraphicsPath()
            Dim rect As New Rectangle(0, 0, btnDeposit.Width - 1, btnDeposit.Height - 1)

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            btnDeposit.Region = New Region(path)
        End Using
    End Sub

    Private Sub btnWithdraw_Paint(sender As Object, e As PaintEventArgs) Handles btnWithdraw.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim radius As Integer = 12

        Using path As New Drawing2D.GraphicsPath()
            Dim rect As New Rectangle(0, 0, btnWithdraw.Width - 1, btnWithdraw.Height - 1)

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            btnWithdraw.Region = New Region(path)
        End Using
    End Sub

    Private Sub RoundPanel(panel As Panel, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(panel.Width - radius,
                panel.Height - radius,
                radius, radius, 0, 90)
        path.AddArc(0,
                panel.Height - radius,
                radius, radius, 90, 90)

        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub
    Public currentUser As String
    Private balanceCard As SummaryCard
    Private incomeCard As SummaryCard
    Private spentCard As SummaryCard
    Private transactionCard As SummaryCard

    Private Sub FormDashboardModern_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWelcome.Text = "Welcome, " & currentUser

        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.FlatAppearance.BorderSize = 0

        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.FlatAppearance.BorderSize = 0

        RoundPanel(pnlDepositIcon, 10)
        RoundPanel(pnlWithdrawIcon, 10)

        'Connect card variables to controls
        balanceCard = SummaryCard1
        incomeCard = SummaryCard2
        spentCard = SummaryCard3
        transactionCard = SummaryCard4


        'Card titles
        balanceCard.CardTitle = "Current Balance"
        incomeCard.CardTitle = "Total Income"
        spentCard.CardTitle = "Total Spent"
        transactionCard.CardTitle = "Transactions"

        SummaryCard1.CardBackColor = Color.FromArgb(239, 246, 255)   'Blue
        SummaryCard2.CardBackColor = Color.FromArgb(236, 253, 245)   'Green
        SummaryCard3.CardBackColor = Color.FromArgb(254, 242, 242)   'Red
        SummaryCard4.CardBackColor = Color.FromArgb(255, 247, 237)   'Orange


#Disable Warning CA1416

        SummaryCard1.CardIcon = Image.FromFile(Application.StartupPath & "\Images\money.png")
        SummaryCard2.CardIcon = Image.FromFile(Application.StartupPath & "\Images\income.png")
        SummaryCard3.CardIcon = Image.FromFile(Application.StartupPath & "\Images\expense.png")
        SummaryCard4.CardIcon = Image.FromFile(Application.StartupPath & "\Images\receipt.png")

#Enable Warning CA1416
        'Card default values
        balanceCard.CardValue = "KES 0.00"
        incomeCard.CardValue = "KES 0.00"
        spentCard.CardValue = "KES 0.00"
        transactionCard.CardValue = "0"


        SummaryCard1.CardSubtitle = "Available Balance"
        SummaryCard2.CardSubtitle = "This Month"
        SummaryCard3.CardSubtitle = "This Month"
        SummaryCard4.CardSubtitle = "This Month"


        SummaryCard1.IconBackColor = Color.FromArgb(191, 219, 254)
        SummaryCard2.IconBackColor = Color.FromArgb(167, 243, 208)
        SummaryCard3.IconBackColor = Color.FromArgb(254, 202, 202)
        SummaryCard4.IconBackColor = Color.FromArgb(254, 215, 170)


        'Load dashboard data
        LoadDashboardData()
        LoadSpendingChart()


        SummaryCard1.ValueColor = Color.FromArgb(30, 64, 175)
        SummaryCard2.ValueColor = Color.FromArgb(22, 101, 52)
        SummaryCard3.ValueColor = Color.FromArgb(185, 28, 28)
        SummaryCard4.ValueColor = Color.FromArgb(194, 65, 12)

        'Load transactions
        Dim service As New TransactionService()

        dgvTransactions.DataSource = service.GetTransactions(currentUser)

        With dgvTransactions
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .GridColor = Color.Gainsboro

            'Modern look
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 35

            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.SelectionBackColor = Color.AliceBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowTemplate.Height = 35
        End With
        AddHandler Panel9.Paint, AddressOf Panel9_Paint
        AddHandler Panel10.Paint, AddressOf Panel10_Paint
    End Sub

    Private Sub LoadSpendingChart()

        PieChart1.Series = New ISeries() {
        New PieSeries(Of Double) With {
            .Name = "Food",
            .Values = New Double() {40}
        },
        New PieSeries(Of Double) With {
            .Name = "Transport",
            .Values = New Double() {25}
        },
        New PieSeries(Of Double) With {
            .Name = "Airtime",
            .Values = New Double() {20}
        },
        New PieSeries(Of Double) With {
            .Name = "Other",
            .Values = New Double() {15}
        }
    }

    End Sub
    Private Sub LoadDashboardData()

        Try
            Using conn As SqlConnection = DatabaseManager.GetConnection()

                conn.Open()

                'Current Balance
                Dim balanceQuery As String =
                "SELECT TOP 1 BalanceAfter 
                 FROM Transactions 
                 WHERE Username=@Username
                 ORDER BY TransactionID DESC"

                Using cmd As New SqlCommand(balanceQuery, conn)
                    cmd.Parameters.AddWithValue("@Username", currentUser)

                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        balanceCard.CardValue = "KES " & Convert.ToDecimal(result).ToString("N2")
                    Else
                        balanceCard.CardValue = "KES 0.00"
                    End If
                End Using


                'Total Income
                Dim incomeQuery As String =
                "SELECT ISNULL(SUM(Amount),0)
                 FROM Transactions
                 WHERE Username=@Username
                 AND TransactionType='Deposit'"

                Using cmd As New SqlCommand(incomeQuery, conn)
                    cmd.Parameters.AddWithValue("@Username", currentUser)

                    Dim income = Convert.ToDecimal(cmd.ExecuteScalar())

                    incomeCard.CardValue = "KES " & income.ToString("N2")
                End Using


                'Total Spent
                Dim spentQuery As String =
                "SELECT ISNULL(SUM(Amount),0)
                 FROM Transactions
                 WHERE Username=@Username
                 AND TransactionType='Withdrawal'"

                Using cmd As New SqlCommand(spentQuery, conn)
                    cmd.Parameters.AddWithValue("@Username", currentUser)

                    Dim spent = Convert.ToDecimal(cmd.ExecuteScalar())

                    spentCard.CardValue = "KES " & spent.ToString("N2")
                End Using


                'Number of Transactions
                Dim transactionQuery As String =
                "SELECT COUNT(*)
                 FROM Transactions
                 WHERE Username=@Username"

                Using cmd As New SqlCommand(transactionQuery, conn)
                    cmd.Parameters.AddWithValue("@Username", currentUser)

                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                    transactionCard.CardValue = count.ToString()
                End Using

            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try

            Dim service As New TransactionService

            If txtSearch.Text.Trim = "" Then
                dgvTransactions.DataSource = service.GetTransactions(currentUser)
            Else
                dgvTransactions.DataSource =
                service.SearchTransactions(currentUser, txtSearch.Text.Trim)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim depositForm As New FormDeposit()

        depositForm.currentUser = currentUser

        depositForm.ShowDialog()

        LoadDashboardData()

        dgvTransactions.DataSource =
        New TransactionService().GetTransactions(currentUser)

    End Sub
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.FlatAppearance.BorderSize = 0
        btnWithdraw.BackColor = Color.FromArgb(220, 38, 38)
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnWithdraw.Cursor = Cursors.Hand
        btnWithdraw.Text = "Withdraw"

        Dim withdraw As New FormWithdraw

        withdraw.currentUser = currentUser

        withdraw.ShowDialog()

        LoadDashboardData()

        dgvTransactions.DataSource =
    New TransactionService().GetTransactions(currentUser)
    End Sub
    Private Sub MakeRoundedButton(btn As Button, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub
    Private Sub DrawPanelBorder(panel As Panel, e As PaintEventArgs)
        Using pen As New Pen(Color.FromArgb(220, 220, 220), 1)
            e.Graphics.DrawRectangle(
                pen,
                0,
                0,
                panel.ClientSize.Width - 1,
                panel.ClientSize.Height - 1
            )
        End Using
    End Sub
    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs)
        DrawSilverBorder(Panel9, e)
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)
        DrawSilverBorder(Panel10, e)
    End Sub


End Class
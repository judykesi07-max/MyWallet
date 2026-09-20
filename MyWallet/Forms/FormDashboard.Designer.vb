<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SkDefaultLegend1 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Dim Padding1 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Dim SkDefaultTooltip1 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip()
        Dim Padding2 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        lblUser = New Label()
        lblBalance = New Label()
        txtAmount = New TextBox()
        btnDeposit = New Button()
        txtWithdraw = New TextBox()
        btnWithdraw = New Button()
        cmbCategory = New ComboBox()
        lblTotalSpent = New Label()
        lblWelcome = New Label()
        lblTopCategory = New Label()
        lblAvgDaily = New Label()
        lblPrediction = New Label()
        lblWarning = New Label()
        btnLogout = New Button()
        lblMonthlyDeposits = New Label()
        lblMonthlyWithdrawals = New Label()
        lblNetSavings = New Label()
        MonthlyBudget = New Label()
        txtMonthlyBudget = New TextBox()
        btnSaveBudget = New Button()
        budgetStatus = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        PieChart1 = New LiveChartsCore.SkiaSharpView.WinForms.PieChart()
        btnSavingsGoals = New Button()
        lblTotalGoals = New Label()
        lblTotalSaved = New Label()
        lblCompletedGoals = New Label()
        grpSavingsSummary = New GroupBox()
        pnlSidebar = New Panel()
        btnReports = New Button()
        btnCategories = New Button()
        Button1 = New Button()
        picLogo = New PictureBox()
        btnDashboard = New Button()
        Label2 = New Label()
        lblAppName = New Label()
        pnlMain = New Panel()
        pnlCards = New Panel()
        Panel2 = New Panel()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        Panel3 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        Label13 = New Label()
        lblIncome = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        pnlIncome = New Label()
        pnlBalance = New Panel()
        Label4 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        pnlHeader = New Panel()
        lblDate = New PictureBox()
        Label3 = New Label()
        grpSavingsSummary.SuspendLayout()
        pnlSidebar.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlCards.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        lblIncome.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlBalance.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        CType(lblDate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(807, 8)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(115, 20)
        lblUser.TabIndex = 1
        lblUser.Text = "Logged in user:"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBalance.Location = New Point(120, 29)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(63, 20)
        lblBalance.TabIndex = 2
        lblBalance.Text = "Balance"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(749, 35)
        txtAmount.Name = "txtAmount"
        txtAmount.PlaceholderText = """Enter amount"""
        txtAmount.Size = New Size(100, 23)
        txtAmount.TabIndex = 3
        ' 
        ' btnDeposit
        ' 
        btnDeposit.FlatStyle = FlatStyle.Flat
        btnDeposit.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeposit.Location = New Point(12, 124)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(200, 40)
        btnDeposit.TabIndex = 4
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' txtWithdraw
        ' 
        txtWithdraw.Location = New Point(736, 8)
        txtWithdraw.Name = "txtWithdraw"
        txtWithdraw.PlaceholderText = """Enter amount"""
        txtWithdraw.Size = New Size(100, 23)
        txtWithdraw.TabIndex = 5
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdraw.Location = New Point(12, 170)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(200, 40)
        btnWithdraw.TabIndex = 6
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Food", "Transport", "Airtime", "Rent", "Shopping", "Entertainment", "Education", "Health", "Other"})
        cmbCategory.Location = New Point(441, 371)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(121, 23)
        cmbCategory.TabIndex = 8
        ' 
        ' lblTotalSpent
        ' 
        lblTotalSpent.AutoSize = True
        lblTotalSpent.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSpent.ImageAlign = ContentAlignment.MiddleLeft
        lblTotalSpent.Location = New Point(720, 63)
        lblTotalSpent.Name = "lblTotalSpent"
        lblTotalSpent.Size = New Size(116, 17)
        lblTotalSpent.TabIndex = 9
        lblTotalSpent.Text = "Total Spent:KSh 0"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(20, 15)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(136, 37)
        lblWelcome.TabIndex = 10
        lblWelcome.Text = "Welcome"
        ' 
        ' lblTopCategory
        ' 
        lblTopCategory.AutoSize = True
        lblTopCategory.Location = New Point(515, 256)
        lblTopCategory.Name = "lblTopCategory"
        lblTopCategory.Size = New Size(0, 15)
        lblTopCategory.TabIndex = 11
        ' 
        ' lblAvgDaily
        ' 
        lblAvgDaily.AutoSize = True
        lblAvgDaily.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvgDaily.Location = New Point(203, 36)
        lblAvgDaily.Name = "lblAvgDaily"
        lblAvgDaily.Size = New Size(47, 17)
        lblAvgDaily.TabIndex = 12
        lblAvgDaily.Text = "Empty"
        ' 
        ' lblPrediction
        ' 
        lblPrediction.AutoSize = True
        lblPrediction.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrediction.Location = New Point(871, 262)
        lblPrediction.Name = "lblPrediction"
        lblPrediction.Size = New Size(64, 15)
        lblPrediction.TabIndex = 13
        lblPrediction.Text = "Prediction"
        ' 
        ' lblWarning
        ' 
        lblWarning.AutoSize = True
        lblWarning.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWarning.ForeColor = Color.Red
        lblWarning.Location = New Point(855, 31)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(47, 17)
        lblWarning.TabIndex = 14
        lblWarning.Text = "Empty"
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(12, 446)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(200, 40)
        btnLogout.TabIndex = 15
        btnLogout.Text = "LogOut"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblMonthlyDeposits
        ' 
        lblMonthlyDeposits.AutoSize = True
        lblMonthlyDeposits.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthlyDeposits.Location = New Point(719, 341)
        lblMonthlyDeposits.Name = "lblMonthlyDeposits"
        lblMonthlyDeposits.Size = New Size(46, 17)
        lblMonthlyDeposits.TabIndex = 16
        lblMonthlyDeposits.Text = "Label2"
        ' 
        ' lblMonthlyWithdrawals
        ' 
        lblMonthlyWithdrawals.AutoSize = True
        lblMonthlyWithdrawals.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthlyWithdrawals.Location = New Point(839, 377)
        lblMonthlyWithdrawals.Name = "lblMonthlyWithdrawals"
        lblMonthlyWithdrawals.Size = New Size(46, 17)
        lblMonthlyWithdrawals.TabIndex = 17
        lblMonthlyWithdrawals.Text = "Label2"
        ' 
        ' lblNetSavings
        ' 
        lblNetSavings.AutoSize = True
        lblNetSavings.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNetSavings.Location = New Point(667, 341)
        lblNetSavings.Name = "lblNetSavings"
        lblNetSavings.Size = New Size(46, 17)
        lblNetSavings.TabIndex = 18
        lblNetSavings.Text = "Label2"
        ' 
        ' MonthlyBudget
        ' 
        MonthlyBudget.AutoSize = True
        MonthlyBudget.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MonthlyBudget.Location = New Point(66, 357)
        MonthlyBudget.Name = "MonthlyBudget"
        MonthlyBudget.Size = New Size(124, 20)
        MonthlyBudget.TabIndex = 19
        MonthlyBudget.Text = "Monthly Budget:"
        ' 
        ' txtMonthlyBudget
        ' 
        txtMonthlyBudget.Location = New Point(293, 417)
        txtMonthlyBudget.Name = "txtMonthlyBudget"
        txtMonthlyBudget.Size = New Size(100, 23)
        txtMonthlyBudget.TabIndex = 20
        ' 
        ' btnSaveBudget
        ' 
        btnSaveBudget.FlatStyle = FlatStyle.Flat
        btnSaveBudget.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSaveBudget.Location = New Point(12, 400)
        btnSaveBudget.Name = "btnSaveBudget"
        btnSaveBudget.Size = New Size(200, 40)
        btnSaveBudget.TabIndex = 21
        btnSaveBudget.Text = "Save Buget"
        btnSaveBudget.UseVisualStyleBackColor = True
        ' 
        ' budgetStatus
        ' 
        budgetStatus.AutoSize = True
        budgetStatus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        budgetStatus.Location = New Point(194, 379)
        budgetStatus.Name = "budgetStatus"
        budgetStatus.Size = New Size(81, 15)
        budgetStatus.TabIndex = 22
        budgetStatus.Text = "Budget Status"
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(855, 60)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 23
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(895, 15)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 24
        ' 
        ' PieChart1
        ' 
        PieChart1.AutoUpdateEnabled = True
        PieChart1.ChartTheme = Nothing
        SkDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultLegend1.Content = Nothing
        SkDefaultLegend1.IsValid = False
        SkDefaultLegend1.Opacity = 1F
        Padding1.Bottom = 0F
        Padding1.Left = 0F
        Padding1.Right = 0F
        Padding1.Top = 0F
        SkDefaultLegend1.Padding = Padding1
        SkDefaultLegend1.RemoveOnCompleted = False
        SkDefaultLegend1.RotateTransform = 0F
        SkDefaultLegend1.X = 0F
        SkDefaultLegend1.Y = 0F
        PieChart1.Legend = SkDefaultLegend1
        PieChart1.Location = New Point(882, 227)
        PieChart1.Name = "PieChart1"
        PieChart1.Size = New Size(150, 150)
        PieChart1.TabIndex = 25
        SkDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultTooltip1.Content = Nothing
        SkDefaultTooltip1.IsValid = False
        SkDefaultTooltip1.Opacity = 1F
        Padding2.Bottom = 0F
        Padding2.Left = 0F
        Padding2.Right = 0F
        Padding2.Top = 0F
        SkDefaultTooltip1.Padding = Padding2
        SkDefaultTooltip1.RemoveOnCompleted = False
        SkDefaultTooltip1.RotateTransform = 0F
        SkDefaultTooltip1.Wedge = 10
        SkDefaultTooltip1.X = 0F
        SkDefaultTooltip1.Y = 0F
        PieChart1.Tooltip = SkDefaultTooltip1
        PieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000")
        ' 
        ' btnSavingsGoals
        ' 
        btnSavingsGoals.FlatStyle = FlatStyle.Flat
        btnSavingsGoals.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSavingsGoals.Location = New Point(12, 354)
        btnSavingsGoals.Name = "btnSavingsGoals"
        btnSavingsGoals.Size = New Size(200, 40)
        btnSavingsGoals.TabIndex = 26
        btnSavingsGoals.Text = "Savings Goals"
        btnSavingsGoals.UseVisualStyleBackColor = True
        ' 
        ' lblTotalGoals
        ' 
        lblTotalGoals.AutoSize = True
        lblTotalGoals.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalGoals.Location = New Point(0, 19)
        lblTotalGoals.Name = "lblTotalGoals"
        lblTotalGoals.Size = New Size(94, 17)
        lblTotalGoals.TabIndex = 27
        lblTotalGoals.Text = "Totals Goals: 0"
        ' 
        ' lblTotalSaved
        ' 
        lblTotalSaved.AutoSize = True
        lblTotalSaved.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSaved.Location = New Point(0, 43)
        lblTotalSaved.Name = "lblTotalSaved"
        lblTotalSaved.Size = New Size(91, 17)
        lblTotalSaved.TabIndex = 28
        lblTotalSaved.Text = "Total Saved: 0"
        ' 
        ' lblCompletedGoals
        ' 
        lblCompletedGoals.AutoSize = True
        lblCompletedGoals.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompletedGoals.Location = New Point(0, 70)
        lblCompletedGoals.Name = "lblCompletedGoals"
        lblCompletedGoals.Size = New Size(125, 17)
        lblCompletedGoals.TabIndex = 29
        lblCompletedGoals.Text = "Completed Goals: 0"
        ' 
        ' grpSavingsSummary
        ' 
        grpSavingsSummary.Controls.Add(lblTotalGoals)
        grpSavingsSummary.Controls.Add(lblCompletedGoals)
        grpSavingsSummary.Controls.Add(lblTotalSaved)
        grpSavingsSummary.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSavingsSummary.Location = New Point(667, 277)
        grpSavingsSummary.Name = "grpSavingsSummary"
        grpSavingsSummary.Size = New Size(200, 100)
        grpSavingsSummary.TabIndex = 30
        grpSavingsSummary.TabStop = False
        grpSavingsSummary.Text = "Savings Summary"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.AliceBlue
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnCategories)
        pnlSidebar.Controls.Add(Button1)
        pnlSidebar.Controls.Add(picLogo)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(lblAvgDaily)
        pnlSidebar.Controls.Add(btnSaveBudget)
        pnlSidebar.Controls.Add(Label2)
        pnlSidebar.Controls.Add(lblAppName)
        pnlSidebar.Controls.Add(btnDeposit)
        pnlSidebar.Controls.Add(btnWithdraw)
        pnlSidebar.Controls.Add(btnSavingsGoals)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(250, 520)
        pnlSidebar.TabIndex = 31
        ' 
        ' btnReports
        ' 
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReports.Location = New Point(12, 308)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(200, 40)
        btnReports.TabIndex = 31
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnCategories
        ' 
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCategories.Location = New Point(12, 262)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(200, 40)
        btnCategories.TabIndex = 31
        btnCategories.Text = "Categories"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 216)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 40)
        Button1.TabIndex = 31
        Button1.Text = "Transactions"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(12, 5)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(70, 70)
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.Location = New Point(12, 78)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(200, 40)
        btnDashboard.TabIndex = 31
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(85, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 17)
        Label2.TabIndex = 0
        Label2.Text = "AI Financial Assistant"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppName.ForeColor = Color.RoyalBlue
        lblAppName.Location = New Point(81, 5)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(141, 37)
        lblAppName.TabIndex = 0
        lblAppName.Text = "MyWallet"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.WhiteSmoke
        pnlMain.Controls.Add(lblNetSavings)
        pnlMain.Controls.Add(pnlCards)
        pnlMain.Controls.Add(lblMonthlyWithdrawals)
        pnlMain.Controls.Add(txtMonthlyBudget)
        pnlMain.Controls.Add(budgetStatus)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Controls.Add(grpSavingsSummary)
        pnlMain.Controls.Add(MonthlyBudget)
        pnlMain.Controls.Add(PieChart1)
        pnlMain.Controls.Add(lblMonthlyDeposits)
        pnlMain.Controls.Add(lblPrediction)
        pnlMain.Controls.Add(cmbCategory)
        pnlMain.Location = New Point(250, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1035, 520)
        pnlMain.TabIndex = 32
        ' 
        ' pnlCards
        ' 
        pnlCards.Controls.Add(Panel2)
        pnlCards.Controls.Add(Panel3)
        pnlCards.Controls.Add(lblIncome)
        pnlCards.Controls.Add(pnlBalance)
        pnlCards.Dock = DockStyle.Top
        pnlCards.Location = New Point(0, 83)
        pnlCards.Name = "pnlCards"
        pnlCards.Size = New Size(1035, 127)
        pnlCards.TabIndex = 32
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MistyRose
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label10)
        Panel2.Location = New Point(518, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 120)
        Panel2.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(108, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 15)
        Label8.TabIndex = 4
        Label8.Text = "Available Balance"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(94, 49)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 28)
        Label9.TabIndex = 3
        Label9.Text = "Ksh 0.00"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(3, 29)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(85, 48)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(120, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 2
        Label10.Text = "Total Spent"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Moccasin
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(774, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 120)
        Panel3.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.Gray
        Label11.Location = New Point(108, 83)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 15)
        Label11.TabIndex = 4
        Label11.Text = "Available Balance"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Orange
        Label12.Location = New Point(94, 49)
        Label12.Name = "Label12"
        Label12.Size = New Size(113, 28)
        Label12.TabIndex = 3
        Label12.Text = "Ksh 0.00"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(3, 29)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(85, 48)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(120, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(97, 20)
        Label13.TabIndex = 2
        Label13.Text = "Transactions"
        ' 
        ' lblIncome
        ' 
        lblIncome.BackColor = Color.PaleGreen
        lblIncome.BorderStyle = BorderStyle.FixedSingle
        lblIncome.Controls.Add(Label5)
        lblIncome.Controls.Add(Label6)
        lblIncome.Controls.Add(PictureBox2)
        lblIncome.Controls.Add(pnlIncome)
        lblIncome.Location = New Point(262, 3)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(250, 120)
        lblIncome.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(108, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 4
        Label5.Text = "Available Balance"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Green
        Label6.Location = New Point(94, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 28)
        Label6.TabIndex = 3
        Label6.Text = "Ksh 0.00"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(3, 29)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(85, 48)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' pnlIncome
        ' 
        pnlIncome.AutoSize = True
        pnlIncome.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlIncome.Location = New Point(120, 29)
        pnlIncome.Name = "pnlIncome"
        pnlIncome.Size = New Size(100, 20)
        pnlIncome.TabIndex = 2
        pnlIncome.Text = "Total Income"
        ' 
        ' pnlBalance
        ' 
        pnlBalance.BackColor = Color.AliceBlue
        pnlBalance.BorderStyle = BorderStyle.FixedSingle
        pnlBalance.Controls.Add(Label4)
        pnlBalance.Controls.Add(Label1)
        pnlBalance.Controls.Add(PictureBox1)
        pnlBalance.Controls.Add(lblBalance)
        pnlBalance.Location = New Point(6, 3)
        pnlBalance.Name = "pnlBalance"
        pnlBalance.Size = New Size(250, 120)
        pnlBalance.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(108, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 15)
        Label4.TabIndex = 4
        Label4.Text = "Available Balance"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(94, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 28)
        Label1.TabIndex = 3
        Label1.Text = "Ksh 0.00"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 48)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.AutoScroll = True
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblDate)
        pnlHeader.Controls.Add(txtSearch)
        pnlHeader.Controls.Add(Label3)
        pnlHeader.Controls.Add(lblUser)
        pnlHeader.Controls.Add(lblWelcome)
        pnlHeader.Controls.Add(lblWarning)
        pnlHeader.Controls.Add(lblTotalSpent)
        pnlHeader.Controls.Add(txtWithdraw)
        pnlHeader.Controls.Add(btnSearch)
        pnlHeader.Controls.Add(txtAmount)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1035, 83)
        pnlHeader.TabIndex = 31
        ' 
        ' lblDate
        ' 
        lblDate.Location = New Point(580, 13)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(100, 50)
        lblDate.TabIndex = 12
        lblDate.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 17)
        Label3.TabIndex = 11
        Label3.Text = "Here's your financial overview"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1277, 520)
        Controls.Add(lblTopCategory)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlMain)
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MyWallet"
        WindowState = FormWindowState.Maximized
        grpSavingsSummary.ResumeLayout(False)
        grpSavingsSummary.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlCards.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        lblIncome.ResumeLayout(False)
        lblIncome.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlBalance.ResumeLayout(False)
        pnlBalance.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(lblDate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblMonthlyDeposits As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMonthlyDeposits.Click

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents txtWithdraw As TextBox
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblTotalSpent As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTopCategory As Label
    Friend WithEvents lblAvgDaily As Label
    Friend WithEvents lblPrediction As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblMonthlyWithdrawals As Label
    Friend WithEvents lblNetSavings As Label
    Friend WithEvents MonthlyBudget As Label
    Friend WithEvents txtMonthlyBudget As TextBox
    Friend WithEvents btnSaveBudget As Button
    Friend WithEvents budgetStatus As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PieChart1 As LiveChartsCore.SkiaSharpView.WinForms.PieChart
    Friend WithEvents btnSavingsGoals As Button
    Friend WithEvents lblTotalGoals As Label
    Friend WithEvents lblTotalSaved As Label
    Friend WithEvents lblCompletedGoals As Label
    Friend WithEvents grpSavingsSummary As GroupBox
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlCards As Panel
    Friend WithEvents lblDate As PictureBox
    Friend WithEvents pnlBalance As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblIncome As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlIncome As Label
End Class

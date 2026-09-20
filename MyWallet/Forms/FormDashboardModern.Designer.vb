<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardModern
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboardModern))
        Dim Padding1 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Dim SkDefaultTooltip1 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip()
        Dim Padding2 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Panel1 = New Panel()
        Panel5 = New Panel()
        pnlLogout = New Panel()
        Label10 = New Label()
        pnlSettings = New Panel()
        Label9 = New Label()
        Panel7 = New Panel()
        pnlBudgets = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        pnlReports = New Panel()
        Label6 = New Label()
        pnlCategories = New Panel()
        Label5 = New Label()
        pnlTransactions = New Panel()
        Label4 = New Label()
        pnlWithdraw = New Panel()
        Label3 = New Label()
        pnlDeposit = New Panel()
        Label2 = New Label()
        pnlDashboard = New Panel()
        lblDashboard = New Label()
        picDasboard = New PictureBox()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Label1 = New Label()
        lblTitle = New Label()
        picLogo = New PictureBox()
        Panel2 = New Panel()
        pnlMain = New Panel()
        Panel8 = New Panel()
        Label15 = New Label()
        PieChart1 = New LiveChartsCore.SkiaSharpView.WinForms.PieChart()
        pnlActions = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel10 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        pnlWithdrawIcon = New Panel()
        btnWithdraw = New Button()
        Panel9 = New Panel()
        Label12 = New Label()
        Label11 = New Label()
        pnlDepositIcon = New Panel()
        btnDeposit = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvTransactions = New DataGridView()
        lblRecentTitle = New Label()
        tblCards = New TableLayoutPanel()
        SummaryCard1 = New SummaryCard()
        SummaryCard2 = New SummaryCard()
        SummaryCard3 = New SummaryCard()
        SummaryCard4 = New SummaryCard()
        pnlHeader = New Panel()
        lblDate = New Label()
        lblOverview = New Label()
        lblWelcome = New Label()
        Label16 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        pnlLogout.SuspendLayout()
        pnlSettings.SuspendLayout()
        Panel7.SuspendLayout()
        pnlBudgets.SuspendLayout()
        pnlReports.SuspendLayout()
        pnlCategories.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlWithdraw.SuspendLayout()
        pnlDeposit.SuspendLayout()
        pnlDashboard.SuspendLayout()
        CType(picDasboard, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        Panel8.SuspendLayout()
        pnlActions.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        tblCards.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 749)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(pnlLogout)
        Panel5.Controls.Add(pnlSettings)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(pnlReports)
        Panel5.Controls.Add(pnlCategories)
        Panel5.Controls.Add(pnlTransactions)
        Panel5.Controls.Add(pnlWithdraw)
        Panel5.Controls.Add(pnlDeposit)
        Panel5.Controls.Add(pnlDashboard)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(0, 96)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(260, 563)
        Panel5.TabIndex = 2
        ' 
        ' pnlLogout
        ' 
        pnlLogout.Controls.Add(Label10)
        pnlLogout.Cursor = Cursors.Hand
        pnlLogout.Dock = DockStyle.Top
        pnlLogout.Location = New Point(0, 288)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(260, 36)
        pnlLogout.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(60, 3)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 20)
        Label10.TabIndex = 2
        Label10.Text = "Log Out"
        ' 
        ' pnlSettings
        ' 
        pnlSettings.Controls.Add(Label9)
        pnlSettings.Cursor = Cursors.Hand
        pnlSettings.Dock = DockStyle.Top
        pnlSettings.Location = New Point(0, 252)
        pnlSettings.Name = "pnlSettings"
        pnlSettings.Size = New Size(260, 36)
        pnlSettings.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(60, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 20)
        Label9.TabIndex = 2
        Label9.Text = "Settings"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(pnlBudgets)
        Panel7.Controls.Add(Label7)
        Panel7.Cursor = Cursors.Hand
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 216)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(260, 36)
        Panel7.TabIndex = 8
        ' 
        ' pnlBudgets
        ' 
        pnlBudgets.Controls.Add(Label8)
        pnlBudgets.Cursor = Cursors.Hand
        pnlBudgets.Dock = DockStyle.Top
        pnlBudgets.Location = New Point(0, 0)
        pnlBudgets.Name = "pnlBudgets"
        pnlBudgets.Size = New Size(260, 36)
        pnlBudgets.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(60, 3)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 20)
        Label8.TabIndex = 2
        Label8.Text = "Budgets"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(60, 17)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 20)
        Label7.TabIndex = 2
        Label7.Text = "Dashboard"
        ' 
        ' pnlReports
        ' 
        pnlReports.Controls.Add(Label6)
        pnlReports.Cursor = Cursors.Hand
        pnlReports.Dock = DockStyle.Top
        pnlReports.Location = New Point(0, 180)
        pnlReports.Name = "pnlReports"
        pnlReports.Size = New Size(260, 36)
        pnlReports.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(60, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 2
        Label6.Text = "Reports"
        ' 
        ' pnlCategories
        ' 
        pnlCategories.Controls.Add(Label5)
        pnlCategories.Cursor = Cursors.Hand
        pnlCategories.Dock = DockStyle.Top
        pnlCategories.Location = New Point(0, 144)
        pnlCategories.Name = "pnlCategories"
        pnlCategories.Size = New Size(260, 36)
        pnlCategories.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(60, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 2
        Label5.Text = "Categories"
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.Controls.Add(Label4)
        pnlTransactions.Cursor = Cursors.Hand
        pnlTransactions.Dock = DockStyle.Top
        pnlTransactions.Location = New Point(0, 108)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(260, 36)
        pnlTransactions.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(60, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 2
        Label4.Text = "Transactions"
        ' 
        ' pnlWithdraw
        ' 
        pnlWithdraw.Controls.Add(Label3)
        pnlWithdraw.Cursor = Cursors.Hand
        pnlWithdraw.Dock = DockStyle.Top
        pnlWithdraw.Location = New Point(0, 72)
        pnlWithdraw.Name = "pnlWithdraw"
        pnlWithdraw.Size = New Size(260, 36)
        pnlWithdraw.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(60, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 2
        Label3.Text = "Withdraw"
        ' 
        ' pnlDeposit
        ' 
        pnlDeposit.Controls.Add(Label2)
        pnlDeposit.Cursor = Cursors.Hand
        pnlDeposit.Dock = DockStyle.Top
        pnlDeposit.Location = New Point(0, 36)
        pnlDeposit.Name = "pnlDeposit"
        pnlDeposit.Size = New Size(260, 36)
        pnlDeposit.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 2
        Label2.Text = "Deposit"
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.AliceBlue
        pnlDashboard.Controls.Add(lblDashboard)
        pnlDashboard.Controls.Add(picDasboard)
        pnlDashboard.Cursor = Cursors.Hand
        pnlDashboard.Dock = DockStyle.Top
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(260, 36)
        pnlDashboard.TabIndex = 2
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboard.Location = New Point(60, 3)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(85, 20)
        lblDashboard.TabIndex = 2
        lblDashboard.Text = "Dashboard"
        ' 
        ' picDasboard
        ' 
        picDasboard.Location = New Point(20, 9)
        picDasboard.Name = "picDasboard"
        picDasboard.Size = New Size(24, 24)
        picDasboard.SizeMode = PictureBoxSizeMode.Zoom
        picDasboard.TabIndex = 2
        picDasboard.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 659)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(260, 90)
        Panel4.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(lblTitle)
        Panel3.Controls.Add(picLogo)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(260, 96)
        Panel3.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.RoyalBlue
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 96)
        Panel6.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(93, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 17)
        Label1.TabIndex = 2
        Label1.Text = "AI Financial Assistant"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.RoyalBlue
        lblTitle.Location = New Point(90, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(148, 40)
        lblTitle.TabIndex = 2
        lblTitle.Text = "MyWallet"
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(20, 25)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(60, 60)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 2
        picLogo.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(1260, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1, 749)
        Panel2.TabIndex = 1
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.WhiteSmoke
        pnlMain.Controls.Add(Panel8)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(260, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1000, 749)
        pnlMain.TabIndex = 2
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(PieChart1)
        Panel8.Controls.Add(pnlActions)
        Panel8.Controls.Add(txtSearch)
        Panel8.Controls.Add(btnSearch)
        Panel8.Controls.Add(dgvTransactions)
        Panel8.Controls.Add(lblRecentTitle)
        Panel8.Controls.Add(tblCards)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 96)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(15)
        Panel8.Size = New Size(1000, 653)
        Panel8.TabIndex = 2
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(18, 190)
        Label15.Name = "Label15"
        Label15.Size = New Size(128, 17)
        Label15.TabIndex = 8
        Label15.Text = "Spending Overview"
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
        PieChart1.Location = New Point(12, 183)
        PieChart1.Name = "PieChart1"
        PieChart1.Size = New Size(190, 200)
        PieChart1.TabIndex = 7
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
        ' pnlActions
        ' 
        pnlActions.Controls.Add(TableLayoutPanel1)
        pnlActions.Location = New Point(12, 98)
        pnlActions.Margin = New Padding(0, 10, 0, 10)
        pnlActions.Name = "pnlActions"
        pnlActions.Padding = New Padding(10)
        pnlActions.Size = New Size(973, 82)
        pnlActions.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.8458366F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.1541634F))
        TableLayoutPanel1.Controls.Add(Panel10, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel9, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(973, 82)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Label14)
        Panel10.Controls.Add(Label13)
        Panel10.Controls.Add(pnlWithdrawIcon)
        Panel10.Controls.Add(btnWithdraw)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(491, 6)
        Panel10.Margin = New Padding(6)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(6)
        Panel10.Size = New Size(476, 70)
        Panel10.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(70, 40)
        Label14.Name = "Label14"
        Label14.Size = New Size(148, 15)
        Label14.TabIndex = 4
        Label14.Text = "Withdraw from your wallet"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Red
        Label13.Location = New Point(70, 11)
        Label13.Name = "Label13"
        Label13.Size = New Size(114, 17)
        Label13.TabIndex = 3
        Label13.Text = "Withdraw Money"
        ' 
        ' pnlWithdrawIcon
        ' 
        pnlWithdrawIcon.BackColor = Color.Red
        pnlWithdrawIcon.Location = New Point(15, 11)
        pnlWithdrawIcon.Name = "pnlWithdrawIcon"
        pnlWithdrawIcon.Size = New Size(45, 45)
        pnlWithdrawIcon.TabIndex = 2
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.Red
        btnWithdraw.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Location = New Point(290, 7)
        btnWithdraw.Margin = New Padding(0)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(180, 50)
        btnWithdraw.TabIndex = 1
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Label12)
        Panel9.Controls.Add(Label11)
        Panel9.Controls.Add(pnlDepositIcon)
        Panel9.Controls.Add(btnDeposit)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(6, 6)
        Panel9.Margin = New Padding(6)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(10)
        Panel9.Size = New Size(473, 70)
        Panel9.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(73, 32)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 15)
        Label12.TabIndex = 3
        Label12.Text = "Add money to your wallet"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Green
        Label11.Location = New Point(73, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(102, 17)
        Label11.TabIndex = 2
        Label11.Text = "Deposit Money"
        ' 
        ' pnlDepositIcon
        ' 
        pnlDepositIcon.BackColor = Color.Green
        pnlDepositIcon.Location = New Point(13, 10)
        pnlDepositIcon.Name = "pnlDepositIcon"
        pnlDepositIcon.Size = New Size(45, 45)
        pnlDepositIcon.TabIndex = 1
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeposit.BackColor = Color.Green
        btnDeposit.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeposit.ForeColor = Color.White
        btnDeposit.ImageAlign = ContentAlignment.MiddleLeft
        btnDeposit.Location = New Point(286, 11)
        btnDeposit.Margin = New Padding(0)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Padding = New Padding(12)
        btnDeposit.Size = New Size(180, 50)
        btnDeposit.TabIndex = 0
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(372, 404)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(291, 403)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AllowUserToDeleteRows = False
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(3, 429)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.RowHeadersVisible = False
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(700, 193)
        dgvTransactions.TabIndex = 1
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.Location = New Point(6, 386)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(290, 40)
        lblRecentTitle.TabIndex = 0
        lblRecentTitle.Text = "Recent Transactions"
        ' 
        ' tblCards
        ' 
        tblCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tblCards.BackColor = Color.Transparent
        tblCards.ColumnCount = 4
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tblCards.Controls.Add(SummaryCard1, 0, 0)
        tblCards.Controls.Add(SummaryCard2, 1, 0)
        tblCards.Controls.Add(SummaryCard3, 2, 0)
        tblCards.Controls.Add(SummaryCard4, 3, 0)
        tblCards.Location = New Point(12, 0)
        tblCards.Name = "tblCards"
        tblCards.RowCount = 1
        tblCards.RowStyles.Add(New RowStyle(SizeType.Absolute, 110F))
        tblCards.Size = New Size(973, 101)
        tblCards.TabIndex = 6
        ' 
        ' SummaryCard1
        ' 
        SummaryCard1.BackColor = Color.FromArgb(CByte(234), CByte(244), CByte(253))
        SummaryCard1.CardBackColor = Color.FromArgb(CByte(234), CByte(244), CByte(253))
        SummaryCard1.CardIcon = Nothing
        SummaryCard1.CardSubtitle = ""
        SummaryCard1.CardTitle = "Current Balance"
        SummaryCard1.CardValue = "KES 0.00"
        SummaryCard1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SummaryCard1.IconBackColor = Color.FromArgb(CByte(91), CByte(192), CByte(222))
        SummaryCard1.Location = New Point(8, 8)
        SummaryCard1.Margin = New Padding(8, 8, 8, 15)
        SummaryCard1.Name = "SummaryCard1"
        SummaryCard1.Size = New Size(227, 87)
        SummaryCard1.TabIndex = 0
        SummaryCard1.ValueColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        ' 
        ' SummaryCard2
        ' 
        SummaryCard2.BackColor = Color.FromArgb(CByte(232), CByte(248), CByte(240))
        SummaryCard2.CardBackColor = Color.FromArgb(CByte(233), CByte(248), CByte(240))
        SummaryCard2.CardIcon = Nothing
        SummaryCard2.CardSubtitle = ""
        SummaryCard2.CardTitle = "Total Income"
        SummaryCard2.CardValue = "KES 0.00"
        SummaryCard2.Dock = DockStyle.Fill
        SummaryCard2.IconBackColor = Color.FromArgb(CByte(46), CByte(204), CByte(154))
        SummaryCard2.Location = New Point(251, 8)
        SummaryCard2.Margin = New Padding(8, 8, 8, 15)
        SummaryCard2.Name = "SummaryCard2"
        SummaryCard2.Size = New Size(227, 87)
        SummaryCard2.TabIndex = 1
        SummaryCard2.ValueColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        ' 
        ' SummaryCard3
        ' 
        SummaryCard3.BackColor = Color.FromArgb(CByte(253), CByte(236), CByte(236))
        SummaryCard3.CardBackColor = Color.FromArgb(CByte(253), CByte(236), CByte(236))
        SummaryCard3.CardIcon = Nothing
        SummaryCard3.CardSubtitle = ""
        SummaryCard3.CardTitle = "Total Spent"
        SummaryCard3.CardValue = "KES 0.00"
        SummaryCard3.Dock = DockStyle.Fill
        SummaryCard3.IconBackColor = Color.FromArgb(CByte(240), CByte(106), CByte(140))
        SummaryCard3.Location = New Point(494, 8)
        SummaryCard3.Margin = New Padding(8, 8, 8, 15)
        SummaryCard3.Name = "SummaryCard3"
        SummaryCard3.Size = New Size(227, 87)
        SummaryCard3.TabIndex = 2
        SummaryCard3.ValueColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        ' 
        ' SummaryCard4
        ' 
        SummaryCard4.BackColor = Color.FromArgb(CByte(254), CByte(243), CByte(229))
        SummaryCard4.CardBackColor = Color.FromArgb(CByte(254), CByte(243), CByte(229))
        SummaryCard4.CardIcon = Nothing
        SummaryCard4.CardSubtitle = ""
        SummaryCard4.CardTitle = "Transactions"
        SummaryCard4.CardValue = "0"
        SummaryCard4.Dock = DockStyle.Fill
        SummaryCard4.IconBackColor = Color.FromArgb(CByte(245), CByte(168), CByte(85))
        SummaryCard4.Location = New Point(737, 8)
        SummaryCard4.Margin = New Padding(8, 8, 8, 15)
        SummaryCard4.Name = "SummaryCard4"
        SummaryCard4.Size = New Size(228, 87)
        SummaryCard4.TabIndex = 3
        SummaryCard4.ValueColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblDate)
        pnlHeader.Controls.Add(lblOverview)
        pnlHeader.Controls.Add(lblWelcome)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1000, 96)
        pnlHeader.TabIndex = 0
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.ForeColor = Color.Gray
        lblDate.Location = New Point(818, 25)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(47, 15)
        lblDate.TabIndex = 2
        lblDate.Text = "Label11"
        ' 
        ' lblOverview
        ' 
        lblOverview.AutoSize = True
        lblOverview.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOverview.ForeColor = Color.Black
        lblOverview.Location = New Point(20, 65)
        lblOverview.Name = "lblOverview"
        lblOverview.Size = New Size(215, 20)
        lblOverview.TabIndex = 1
        lblOverview.Text = "Here's your financial overview"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(19, 21)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(158, 45)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(233, 194)
        Label16.Name = "Label16"
        Label16.Size = New Size(47, 15)
        Label16.TabIndex = 9
        Label16.Text = "Label16"
        ' 
        ' FormDashboardModern
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1261, 749)
        Controls.Add(pnlMain)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormDashboardModern"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MyWallet"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        pnlLogout.ResumeLayout(False)
        pnlLogout.PerformLayout()
        pnlSettings.ResumeLayout(False)
        pnlSettings.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        pnlBudgets.ResumeLayout(False)
        pnlBudgets.PerformLayout()
        pnlReports.ResumeLayout(False)
        pnlReports.PerformLayout()
        pnlCategories.ResumeLayout(False)
        pnlCategories.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        pnlWithdraw.ResumeLayout(False)
        pnlWithdraw.PerformLayout()
        pnlDeposit.ResumeLayout(False)
        pnlDeposit.PerformLayout()
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        CType(picDasboard, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        pnlActions.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        tblCards.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents picDasboard As PictureBox
    Friend WithEvents lblDashboard As Label
    Friend WithEvents pnlCategories As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlWithdraw As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlDeposit As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pnlBudgets As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlReports As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlLogout As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblOverview As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents tblCards As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnDeposit As Button
    Friend WithEvents SummaryCard1 As SummaryCard
    Friend WithEvents SummaryCard2 As SummaryCard
    Friend WithEvents SummaryCard3 As SummaryCard
    Friend WithEvents SummaryCard4 As SummaryCard
    Friend WithEvents pnlDepositIcon As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pnlWithdrawIcon As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PieChart1 As LiveChartsCore.SkiaSharpView.WinForms.PieChart
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label

End Class

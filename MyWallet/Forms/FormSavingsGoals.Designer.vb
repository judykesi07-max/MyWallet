<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSavingsGoals
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
        Label1 = New Label()
        txtGoalName = New TextBox()
        Label2 = New Label()
        txtTargetAmount = New TextBox()
        btnSaveGoal = New Button()
        Label3 = New Label()
        dgvGoals = New DataGridView()
        txtContributionAmount = New TextBox()
        btnAddMoney = New Button()
        ProgressGoal = New ProgressBar()
        lblProgress = New Label()
        CType(dgvGoals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(166, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 17)
        Label1.TabIndex = 0
        Label1.Text = "Goal Name:"
        ' 
        ' txtGoalName
        ' 
        txtGoalName.Location = New Point(250, 50)
        txtGoalName.Name = "txtGoalName"
        txtGoalName.Size = New Size(100, 23)
        txtGoalName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(141, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 17)
        Label2.TabIndex = 2
        Label2.Text = "Target Amount:"
        ' 
        ' txtTargetAmount
        ' 
        txtTargetAmount.Location = New Point(250, 86)
        txtTargetAmount.Name = "txtTargetAmount"
        txtTargetAmount.Size = New Size(100, 23)
        txtTargetAmount.TabIndex = 3
        ' 
        ' btnSaveGoal
        ' 
        btnSaveGoal.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveGoal.Location = New Point(299, 146)
        btnSaveGoal.Name = "btnSaveGoal"
        btnSaveGoal.Size = New Size(105, 36)
        btnSaveGoal.TabIndex = 4
        btnSaveGoal.Text = "Save Goal"
        btnSaveGoal.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(358, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 5
        Label3.Text = "Saving Goals"
        ' 
        ' dgvGoals
        ' 
        dgvGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGoals.Location = New Point(75, 278)
        dgvGoals.Name = "dgvGoals"
        dgvGoals.Size = New Size(558, 100)
        dgvGoals.TabIndex = 6
        ' 
        ' txtContributionAmount
        ' 
        txtContributionAmount.Location = New Point(415, 50)
        txtContributionAmount.Name = "txtContributionAmount"
        txtContributionAmount.Size = New Size(100, 23)
        txtContributionAmount.TabIndex = 7
        ' 
        ' btnAddMoney
        ' 
        btnAddMoney.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddMoney.Location = New Point(521, 49)
        btnAddMoney.Name = "btnAddMoney"
        btnAddMoney.Size = New Size(112, 31)
        btnAddMoney.TabIndex = 8
        btnAddMoney.Text = "Add Money"
        btnAddMoney.UseVisualStyleBackColor = True
        ' 
        ' ProgressGoal
        ' 
        ProgressGoal.Location = New Point(12, 32)
        ProgressGoal.Name = "ProgressGoal"
        ProgressGoal.Size = New Size(100, 59)
        ProgressGoal.TabIndex = 9
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.Location = New Point(12, 12)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(86, 17)
        lblProgress.TabIndex = 10
        lblProgress.Text = "Progress: 0%"
        ' 
        ' FormSavingsGoals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblProgress)
        Controls.Add(ProgressGoal)
        Controls.Add(btnAddMoney)
        Controls.Add(txtContributionAmount)
        Controls.Add(dgvGoals)
        Controls.Add(Label3)
        Controls.Add(btnSaveGoal)
        Controls.Add(txtTargetAmount)
        Controls.Add(Label2)
        Controls.Add(txtGoalName)
        Controls.Add(Label1)
        Name = "FormSavingsGoals"
        Text = "FormSavingsGoals"
        CType(dgvGoals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGoalName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTargetAmount As TextBox
    Friend WithEvents btnSaveGoal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvGoals As DataGridView
    Friend WithEvents txtContributionAmount As TextBox
    Friend WithEvents btnAddMoney As Button
    Friend WithEvents ProgressGoal As ProgressBar
    Friend WithEvents lblProgress As Label
End Class
